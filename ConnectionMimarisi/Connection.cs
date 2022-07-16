using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace AdoNetGirisv2
{
    public partial class Connection : Form
    {
        SqlConnection connection;
        SqlCommand command;
        public Connection()
        {
            InitializeComponent();
            
            connection = new SqlConnection("Server =(LocalDb)\\MSSQLLocalDB;" +
                "Database=PhoneGuide;Trusted_Connection=True;");
            command = new SqlCommand();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
        }
        /// <summary>
        /// Eger baglanti yoksa baglantiyi ac. Baglanti acik ise baglantiyi kapat
        /// </summary>
        public void BaglantiAyarla()
        {
            if (connection.State == ConnectionState.Closed)
            {
                //eger baglanti yoksa baglantiyi ac
                try
                {
                    connection.Open();
                }
                catch (System.Data.SqlClient.SqlException ext)
                {

                    string a = ext.Message;
                    MessageBox.Show("Basarisiz Database Bağlantısı => " + a);
                }
               
            }
            else
            {
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                command.CommandText = "select * from Guide";
                command.Connection = connection;
                SqlDataReader sqlData = command.ExecuteReader();
                int toplamSatir = sqlData.FieldCount;
                //simdi datamizi cekmeyi gorduk bunu okumayi bulalim
                if (listBoxRehber.Items.Count> 0)
                {
                    listBoxRehber.Items.Clear();
                }
                while (sqlData.Read())
                {
                    string Name = sqlData["Name"].ToString();
                    string Surname = sqlData["Surname"].ToString();
                    string PhoneNumber = sqlData["PhoneNumber"].ToString();
                    string EmailAdress = sqlData["EmailAdress"].ToString();
                    listBoxRehber.Items.Add(string.Format("{0} {1} {2} {3}",
                        Name, Surname,
                        PhoneNumber, EmailAdress));
                }

            }
            catch (Exception)
            {


            }
            finally
            {
                BaglantiAyarla();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                command = new SqlCommand("insert into Guide (ID , Name , Surname" +
                " , PhoneNumber , EmailAdress)" +
                " values " +
                "(@ID , @Name , @Surname , @PhoneNumber , @EmailAdress)",
                connection);
                command.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = Guid.NewGuid();
                command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = textBoxIsim.Text;
                command.Parameters.Add("@Surname", SqlDbType.NVarChar).Value = textBoxSoyisim.Text;
                command.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = textBoxTelefonNumarasi.Text;
                command.Parameters.Add("@EmailAdress", SqlDbType.NVarChar).Value = textBoxEmail.Text;
                BaglantiAyarla();
                int etkilenenSutunSayisi = command.ExecuteNonQuery(); // sorgu icin gerekli fonksiyon
                                                                      // bu fonksiyon geriye etkilenen satir sayisini int olarak dondurur.
                if (etkilenenSutunSayisi == 1)
                {
                    MessageBox.Show("Tebrikler Kayıt eklenildi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            finally
            {
                textBoxEmail.Text = string.Empty;
                textBoxIsim.Text = string.Empty;

                textBoxSoyisim.Text = string.Empty;
                textBoxTelefonNumarasi.Text = string.Empty;

                BaglantiAyarla();
            }
        }
    }
}
