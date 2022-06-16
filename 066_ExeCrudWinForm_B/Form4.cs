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

namespace _066_ExeCrudWinForm_B
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-NNJOPBIC\\SQLEXPRESS;Initial Catalog=exercisepabd;User ID=sa;Password=***********");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string namaproduk = (textBox1.Text);
            string jenis = (textBox2.Text);
            string cc = (textBox3.Text);
            string stock = (textBox4.Text);
            con.Open();
            SqlCommand c = new SqlCommand("exec InsertProduk '" + namaproduk + "','" + jenis + "','" + cc + "','" + stock +);
            MessageBox.Show("Data Baru Berhasil DiUpdate")
        }
    }

    void GetProdukList()
    {

    }
}
