using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeCRUDWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="admin" && textBox2.Text=="admin")
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password salah!!!, Silahkan coba lagi");
                textBox1.Clear();
                textBox2.Clear();

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
