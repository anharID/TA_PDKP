using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TA_PDKP
{
    public partial class Beli : Form
    {
        public Beli()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string brt;
            float b, harga;

            brt = this.berat.Text;
            float.TryParse(brt, out b);

            if (this.comboKualitas.SelectedItem == "Biasa")
                harga = b * 10000;
            else
                harga = b * 15000;

            hargabeli.Text = harga.ToString();

        }
    }
}
