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

namespace Personal_Budget_finance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RefreshListfromDatabase();
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RefreshListfromDatabase()
        {            
            SqlConnection connection = new SqlConnection("Data Source=(local)\\SQLEXPRESSROY;Database=Finance;User Id=sa;Pwd=123456");
            connection.Open();
            SqlCommand command = new SqlCommand(String.Format("SELECT Id, Tanggal, Tipe, Deskripsi, Jumlah FROM Finance"));
            command.Connection = connection;                        
            DataSet data = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            dataGridView1.DataSource = data.Tables[0];
            dataGridView1.Update();
            dataGridView1.Refresh();
            connection.Close();
        }
        private void Submit_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=(local)\\SQLEXPRESSROY;Database=Finance;User Id=sa;Pwd=123456");
            connection.Open();
            
            long inputjumlah = Convert.ToInt64(Jumlah.Value);
            string deskripsi = Deskripsi.Text;
            DateTime tanggal = DateTime.Now;
            if (Pemasukkan.Checked)
            {
                string formattanggal = string.Format("{0}-{1}-{2}", tanggal.Year, tanggal.Month, tanggal.Day);
                string tipe = Pemasukkan.Text;
                SqlCommand command = new SqlCommand(String.Format("INSERT INTO Finance Values (newid(),'{0}','{1}','{2}','{3}')", formattanggal, tipe, deskripsi, inputjumlah));
                command.Connection = connection;
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Data telah berhasil di simpan");
                RefreshListfromDatabase();
            }
            else if (Pengeluaran.Checked)
            {
                string formattanggal = string.Format("{0}-{1}-{2}", tanggal.Year, tanggal.Month, tanggal.Day);
                string tipe = Pengeluaran.Text;
                SqlCommand command = new SqlCommand(String.Format("INSERT INTO Finance Values (newid(),'{0}','{1}','{2}','{3}')", formattanggal, tipe, deskripsi, inputjumlah));
                command.Connection = connection;
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Data telah berhasil di simpan");
                RefreshListfromDatabase();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void Terapkan_Click(object sender, EventArgs e)
        {
            Selisih.Items.Clear();
            string tanggaldari = TanggalDari.Value.ToString("yyyy-MM-dd");
            string tanggalsampai = TanggalSampai.Value.ToString("yyyy-MM-dd");            
            SqlConnection connection = new SqlConnection("Data Source=(local)\\SQLEXPRESSROY;Database=Finance;User Id=sa;Pwd=123456");
            connection.Open();
            SqlCommand command = new SqlCommand(String.Format
            ("SELECT SUM(Jumlah) FROM Finance WHERE Tipe = 'Pengeluaran' AND Tanggal >= '{0}' AND Tanggal <= '{1}'", tanggaldari, tanggalsampai));
            command.Connection = connection;
            SqlDataReader reader = command.ExecuteReader();
            TotalPengeluaran.Items.Clear();
            while (reader.Read())
            {
                TotalPengeluaran.Items.Add(reader.GetValue(0));

            }
           
            connection.Close();
   
            connection.Open();
            SqlCommand command1 = new SqlCommand(String.Format
            ("SELECT SUM(Jumlah) FROM Finance WHERE Tipe = 'Pemasukkan' AND Tanggal >= '{0}' AND Tanggal <= '{1}'", tanggaldari, tanggalsampai));
            command1.Connection = connection;
            SqlDataReader reader1 = command1.ExecuteReader();
            TotalPemasukkan.Items.Clear();
            while (reader1.Read())
            {
                TotalPemasukkan.Items.Add(reader1.GetValue(0));               
            }            
            connection.Close();

            connection.Open();
            SqlCommand command2 = new SqlCommand(String.Format("SELECT (SELECT SUM(Jumlah) FROM Finance WHERE Tipe = 'Pemasukkan' AND Tanggal >= '{0}' AND Tanggal <= '{1}')" +
             " - (SELECT SUM(Jumlah) FROM Finance WHERE Tipe = 'Pengeluaran' AND Tanggal >= '{0}' AND Tanggal <= '{1}')", tanggaldari, tanggalsampai));
            command2.Connection = connection;
            SqlDataReader reader2 = command2.ExecuteReader();
            Selisih.Items.Clear();
            while (reader2.Read())
            {
                Selisih.Items.Add(reader2.GetValue(0));
            }
            connection.Close();



        }

        private void Hapus_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection row = dataGridView1.SelectedRows;
            SqlConnection connection = new SqlConnection("Data Source=(local)\\SQLEXPRESSROY;Database=Finance;User Id=sa;Pwd=123456");
            connection.Open();
            SqlCommand command = new SqlCommand(String.Format("DELETE FROM Finance WHERE Id = '{0}'", row[0].Cells[0].Value));
            command.Connection = connection;
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Data berhasil di hapus");
            RefreshListfromDatabase();

        }

        private void TotalPemasukkan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
