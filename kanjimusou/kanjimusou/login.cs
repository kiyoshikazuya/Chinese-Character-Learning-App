using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kanjimusou
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

       

        

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void log_in_Click(object sender, EventArgs e)
        {
            if (name.Text == "root" && passwd.Text == "123456")
            {
                welcome Welcome = new welcome();
                Welcome.Show();
            }
            else
            {
                wrong Wrong = new wrong();
                Wrong.Show();
            }
        }

        private void log_on_Click(object sender, EventArgs e)
        {
            logon Logon = new logon();
            Logon.Show();
        }


     

        

        

        

        
    }
}
