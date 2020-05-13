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
            string sberat, gberat, sharga, gharga;
            float berat, harga;
            SetterGetter panggil = new SetterGetter();
            sberat = this.berat.Text;
            panggil.setBerat(sberat);
            gberat = panggil.getBerat();
            float.TryParse(gberat, out berat);

            if (comboKualitas.SelectedItem == "Biasa")
                harga = 10000 * berat;
            else
                harga = 15000 * berat;

            harga.ToString();

            sharga = harga.ToString();
            panggil.setHarga(sharga);
            gharga = panggil.getHarga();
            this.hargabeli.Text = gharga;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboKualitas.Text = "";
            berat.Text = "";
            hargabeli.Text = "";
        }
    }
}
