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
    class userService
    {
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
            }
            else
            {
                MessageBox.Show("LOGIN BERHASIL");
                Aplikasi open = new Aplikasi();
                open.Show();
                
                
            }
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
