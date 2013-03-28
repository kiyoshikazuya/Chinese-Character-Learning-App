using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kanjimusou.Lib;

namespace Kanjimusou
{
    public partial class challenge : Form
    {

        private User user;
        private int maxTime;
        private Challenge cha;

        public challenge( User user )
        {
            InitializeComponent();
            this.user = user;
            this.cha = new Challenge(user);
            timer1.Interval = 25;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.resttime.Width = this.resttime.Width*(int)(cha.NowTime/cha.NowMaxTime);
        }

        private void next_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
