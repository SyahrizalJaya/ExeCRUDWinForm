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

namespace ExeCRUDWinForm
{
    public partial class Form2 : Form
    {
        Panel panel1 = new Panel();
        public Form2()
        {
            InitializeComponent();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-SVN0V6C;Initial Catalog=ExeCRUDWinForm;User ID=sa;Password=123");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Mahasiswa values (@NIM,@Nama,@Kelas)",con);
            cmd.Parameters.AddWithValue("@NIM",int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Nama", textBox1.Text);
            cmd.Parameters.AddWithValue("@Kelas", textBox1.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Saved");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exeCRUDWinFormDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.exeCRUDWinFormDataSet.Mahasiswa);
        }



        private void Update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-SVN0V6C;Initial Catalog=ExeCRUDWinForm;User ID=sa;Password=123");
            con.Open();
            SqlCommand cmd = new SqlCommand("update Mahasiswa set NIM=@NIM,Nama=@Nama,Kelas=@Kelas", con);
            cmd.Parameters.AddWithValue("@NIM", textBox1.Text);
            cmd.Parameters.AddWithValue("@Nama", textBox1.Text);
            cmd.Parameters.AddWithValue("@Kelas", char.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Update");
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-SVN0V6C;Initial Catalog=ExeCRUDWinForm;User ID=sa;Password=123");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Mahasiswa where NIM=@NIM", con);
            cmd.Parameters.AddWithValue("@NIM", textBox1.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Delete");
        }
    }
}
