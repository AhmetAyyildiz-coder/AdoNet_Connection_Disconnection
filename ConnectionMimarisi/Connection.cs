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
            
            connection = new SqlConnection("Server = DESKTOP-GJ4ARSC\\SQLEXPRESS;" +
                "Database=TelefonRehberi;User Id=sa;Password=1;");
            command = new SqlCommand();
            BaglantiAyarla();
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
                connection.Open();
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
                command.CommandText = "select * from Rehber";
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
                    string RehberIsim = sqlData["Isim"].ToString();
                    string RehberSoyisim = sqlData["Soyisim"].ToString();
                    string RehberTelefonNumarasi = sqlData["TelefonNumarasi"].ToString();
                    string RehberEmailAdress = sqlData["EmailAdress"].ToString();
                    listBoxRehber.Items.Add(string.Format("{0} {1} {2} {3}",
                        RehberIsim, RehberSoyisim,
                        RehberEmailAdress, RehberTelefonNumarasi));
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
                command = new SqlCommand("insert into Rehber (ID , Isim , Soyisim" +
                " , TelefonNumarasi , EmailAdress)" +
                " values " +
                "(@ID , @Isim , @Soyisim , @TelefonNumarasi , @EmailAdress)",
                connection);
                command.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = Guid.NewGuid();
                command.Parameters.Add("@Isim", SqlDbType.NVarChar).Value = textBoxIsim.Text;
                command.Parameters.Add("@Soyisim", SqlDbType.NVarChar).Value = textBoxSoyisim.Text;
                command.Parameters.Add("@TelefonNumarasi", SqlDbType.NVarChar).Value = textBoxTelefonNumarasi.Text;
                command.Parameters.Add("@EmailAdress", SqlDbType.NVarChar).Value = textBoxEmail.Text;
                BaglantiAyarla();
                int etkilenenSutunSayisi = command.ExecuteNonQuery(); // sorgu icin gerekli fonksiyon
                                                                      // bu fonksiyon geriye etkilenen satir sayisini int olarak dondurur.
        
            }
            catch (Exception ex)
            {

                
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
