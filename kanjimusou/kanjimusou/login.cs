using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Kanjimusou
{
    public partial class login : Form
    {


        public static int counts = 0;
        //计数判断窗体个数

        private bool showing = true;



        public login()
        {
            InitializeComponent();
             Opacity = 0.0;      //窗体透明度为0
            Atimer.Start(); //计时开始

        }

       

        


        private void log_in_Click(object sender, EventArgs e)
        {
            if (name.Text == "root" && passwd.Text == "123456")
            {
                welcome Welcome = new welcome();
                Welcome.Show(); counts++;
                //隐藏窗体
                if (counts == 0) this.Close();

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

        private void Atimer_Tick(object sender, EventArgs e)
        {
            double d = 0.30;
            if (showing)
            {
                if (Opacity + d >= 1.0)
                {
                    Opacity = 1.0;
                    Atimer.Stop();
                }
                else
                {
                    Opacity += d;
                }
            }
            else
            {
                
                if (Opacity - d <= 0.0)
                {
                    Opacity = 0.0;
                    Atimer.Stop();
                }
                else
                {
                    Opacity -= d;
                }
            }
        }


        

        

        

        
    }
}
