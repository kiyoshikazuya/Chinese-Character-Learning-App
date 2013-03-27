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
    public partial class end : Form
    {
        public end()
        {
            InitializeComponent();
            
        }
        public end(string s)
            : this()
        {
            this.label1.Text = s;
        }
    }
}
