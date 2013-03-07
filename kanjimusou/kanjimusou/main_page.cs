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
    public partial class main_page : Form
    {
        public main_page()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            learn Aform = new learn();
            Aform.Show();

        }

        private void calligraphy_Click(object sender, EventArgs e)
        {
            myCalligraphy ACalligraphy = new myCalligraphy();
            ACalligraphy.Show();
        }

     

        

        

        

        
    }
}
