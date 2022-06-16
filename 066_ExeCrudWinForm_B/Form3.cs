using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _066_ExeCrudWinForm_B
{
    public partial class Produk : Form
    {
        public Produk()
        {
            InitializeComponent();
        }

        private void Produk_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exercisepabdDataSet.ProdukReadyStock' table. You can move, or remove it, as needed.
            this.produkReadyStockTableAdapter.Fill(this.exercisepabdDataSet.ProdukReadyStock);

        }
    }
}
