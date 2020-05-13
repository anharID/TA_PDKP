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
    public partial class Jual : Form
    {
        public Jual()
        {
            InitializeComponent();
        }
        private void hideSubMenu()
        {
            if (panelSubMenu1.Visible == true)
                panelSubMenu1.Visible = false;
            if (panelSubMenu2.Visible == true)
                panelSubMenu2.Visible = false;
            if (panelSubMenu3.Visible == true)
                panelSubMenu3.Visible = false;
        }
        private void showSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hideSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            showSubMenu(panelSubMenu1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            showSubMenu(panelSubMenu2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            showSubMenu(panelSubMenu3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int harga1, jumlah1;
            string total1;
            total1 = jml1.Text;

            int.TryParse(total1, out jumlah1);
            harga1 = 5000 * jumlah1;

            bayar1.Text = harga1.ToString();

            MessageBox.Show("Hot Cokelat\n\nTerjual sebanyak :" + jml1.Text + "\nPenghasilan :" + bayar1.Text);
            jml1.Text = "";
            bayar1.Text = "";


        }

        private void button4_Click(object sender, EventArgs e)
        {
            int harga2, jumlah2;
            string total2;
            total2 = jml2.Text;

            int.TryParse(total2, out jumlah2);
            harga2 = 7000 * jumlah2;

            bayar2.Text = harga2.ToString();

            MessageBox.Show("Ice Cokelat\n\nTerjual sebanyak :" + jml2.Text + "\nPenghasilan :" + bayar2.Text);
            jml2.Text = "";
            bayar2.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int harga3, jumlah3;
            string total3;
            total3 = jml3.Text;

            int.TryParse(total3, out jumlah3);
            harga3 = 25000 * jumlah3;

            bayar3.Text = harga3.ToString();
            MessageBox.Show("Serbuk Cokelat\n\nTerjual sebanyak :" + jml3.Text + "\nPenghasilan :" + bayar3.Text);
            jml3.Text = "";
            bayar3.Text = "";
        }
    }
}
