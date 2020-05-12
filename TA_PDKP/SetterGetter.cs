using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA_PDKP
{
    class SetterGetter
    {
        class Beli_setget
        {
            private string Berat;
            private string Harga;

            public void setBerat (string val)
            {
                this.Berat = val;
            }
            public string getBerat()
            {
                return Berat;
            }
            public void setHarga (string val)
            {
                this.Harga = val;
            }
            public string getHarga()
            {
                return Harga;
            }


        }
        

    }
}
