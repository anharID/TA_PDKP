using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace TA_PDKP
{
    class userService
    {
        Thread th;
        private string[,] data;
        private string user, password, roles = "";

        public userService(string users, string passwords)
        {
            user = users;
            password = passwords;
            data = new string[2, 3] {
                {"admin", "12345", "superadmin" },
                {"anhar", "12345", "user"  }
            };
        }

        public void login()
        {
            var (status, role) = checkCredentials();
            if (status == false)
            {
                MessageBox.Show("LOGIN GAGAL");
                th = new Thread(opennewform2);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();


            }
            else
            {
                MessageBox.Show("LOGIN BERHASIL");

                th = new Thread(opennewform);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();


            }
        }

        private void opennewform2()
        {
            Application.Restart();
        }

        private void opennewform()
        {
            Application.Run(new Aplikasi());
        }

        private (bool, string) checkCredentials()
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (data[i, 0] == user && data[i, 1] == password)
                {
                    roles = data[i, 2];
                    return (true, roles);
                }
            }
            return (false, roles);
        }
    }
}
