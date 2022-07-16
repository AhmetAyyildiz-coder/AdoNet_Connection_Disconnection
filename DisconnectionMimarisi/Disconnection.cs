using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataCekmeV2
{
    public partial class Disconnection : Form
    {
        DataTable table = new DataTable();
        DataSet dataSet = new DataSet();
        SqlConnection connection;
        SqlCommand command;
        public Disconnection()
        {
            InitializeComponent();
            connection = new SqlConnection("Server = DESKTOP-GJ4ARSC\\SQLEXPRESS;" +
               "Database=TelefonRehberi;User Id=sa;Password=1;");
            command = new SqlCommand();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select  * from Rehber", connection);

                dataAdapter.Fill(table); // database'den cekilen tabloyu bir tablo nesnesine bastirdik.
                dataGridView1.DataSource = table;
               

            }
            catch (Exception)
            {

                
            }
            finally
            {
              
            }
        }

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

        private void buttonRehberGetir_Click(object sender, EventArgs e)
        {
            //sql data adapter nesnesinin olayi sudur ki baglanti ayarla adindaki metodu surekli surekli yazmak zorunda kalmayiz.
            //bu nesne sql baglantisini otomatik acip kapatir database islemleri sirasinda.
            //yani arka planda connection.open fonksiyonunu acip islemi yapip ardindan close fonksiyonu ile kapaticak ve geriye bir tablo donicek
           
            dataGridView1.Columns[1].Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //data grid viewda istenilen kolonlari kapatmak icin bir ozelligimiz var
        
          
            
            dataSet.Tables.Add(table);
            dataGridView1.DataSource = dataSet.Tables[0];
            dataGridView1.Columns[1].Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void dataGridView1_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
           
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

         
            var RowCellIndex = e.RowIndex;// Satir indexi aldik secilen degerin
            var datagridRowcount = dataGridView1.RowCount;
            var ColumnCellIndex = e.ColumnIndex; // kolon indexini aldik secilen degerin
            if (dataGridView1.RowCount-3 > RowCellIndex)
            {
                var columnName = table.Columns[ColumnCellIndex].ColumnName; // secilen indexin kolon indexine gore degerini aldik
                                                                            //yani nesnenin tablodaki property'sini aldik.

                var changedValueInCell = table.Rows[RowCellIndex].ItemArray[ColumnCellIndex]; //degisek degeri yakaladik. Satir indexinden 

                var ChangedValueID = table.Rows[RowCellIndex].ItemArray[0];

                command.CommandText = "update Rehber set Isim = @isim where ID = @id";
                var comtext = command.CommandText;
                command.Parameters.Add("@isim", SqlDbType.NVarChar).Value = changedValueInCell;
                command.Parameters.Add("@id", SqlDbType.UniqueIdentifier).Value = ChangedValueID;


                command.Connection = connection;
                BaglantiAyarla();
                var commandTextMessage = command.ExecuteNonQuery();
            }
            else
            {
                //dataGridView1.Rows.Add(1);
                //var changedValueInCell = table.Rows[RowCellIndex].ItemArray[ColumnCellIndex];
                //var columnName = table.Columns[ColumnCellIndex].ColumnName;
                //command.CommandText ="insert into Rehber @columnName values @changedValueInCell";
                //command.Parameters.Add("@columnName", SqlDbType.NVarChar).Value = columnName;
                //command.Parameters.Add("@changedValueInCell", SqlDbType.NVarChar).Value = changedValueInCell;
            }
            

           
        }
    }
}
