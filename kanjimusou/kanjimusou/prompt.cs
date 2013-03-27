using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Kanjimusou.Lib;

namespace Kanjimusou
{
    public partial class prompt : Form
    {

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int mParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTTION = 0x0002;
        public Form Aform;
        public User Auser;


        public prompt()
        {
            InitializeComponent();
        }
        public prompt(Form A,User user): this()
        {
            Aform = A;
            Auser = user;

        }

        private void closeAll_Click(object sender, EventArgs e)
        {
            UserManager.SaveFile(Auser);
            DL.ADL.Close();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void doNotClose_Click(object sender, EventArgs e)
        {
            welcome Welcome = new welcome(Auser);
            Welcome.Show();
            Aform.Close();
            this.Close();
        }
        private void prompt_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTTION, 0);
        }
    }
}
