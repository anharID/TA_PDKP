using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA_PDKP
{
    class SetterGetter
    {
        private string berat;
        private string harga;

        public void setBerat(string Text)
        {
            this.berat = Text;
        }
        public string getBerat()
        {
            return berat;
        }
        public void setHarga(string Text)
        {
            this.harga = Text;
        }
        public string getHarga()
        {
            return harga;
        }

    }
}
