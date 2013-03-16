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
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            learn Learn = new learn();
            Learn.Show();
        }

        private void information_Click(object sender, EventArgs e)
        {
            achievement Achievement = new achievement();
            Achievement.Show();
        }
    }
}
