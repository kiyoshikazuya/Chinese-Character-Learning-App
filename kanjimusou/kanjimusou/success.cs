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
    public partial class success : Form
    {
        private bool showing = true;
        private bool doClose = true;
        private System.Windows.Forms.Timer Atimer = new System.Windows.Forms.Timer();

        public success( string result )
        {
            InitializeComponent();
            Atimer.Tick += Atimer_Tick;
            Atimer.Interval = 25;
            resultButton.Text = result;
        }

        private void Atimer_Tick(object sender, EventArgs e)
        {
            double d = 0.25;
            if (showing)
            {
                if (Opacity + d >= 0.9)
                {
                    Opacity = 0.85;
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
                    this.Close();
                }
                else
                {
                    Opacity -= d;
                }
            }
        }

        public void OnShow()
        {
            this.Show();
            showing = true;
            Opacity = 0.0;      //窗体透明度为0
            Atimer.Start(); //计时
            this.Enabled = true;
        }

        public void OnClose(bool doClose)
        {
            this.doClose = doClose;
            this.Enabled = false;
            showing = false;
            Atimer.Start();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.OnClose(true);
        }


    }
}
