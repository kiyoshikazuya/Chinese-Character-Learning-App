using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using Kanjimusou.Lib;
using System.Runtime.InteropServices;

namespace Kanjimusou
{
    public partial class learn : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int mParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTTION = 0x0002;






        public learn()
        {
            InitializeComponent();
            HanziIO hanzi = new HanziIO();
            hanzi.OpenFile("Hanzi.xml");
            hanziPictureBox1.Hanzi = hanzi.Read("中");
            hanziPictureBox1.CorrectDrew += new BihuaHandler(OnCorrectDrew);
            hanziPictureBox1.WrongDrew += new BihuaHandler(OnWrongDrew);
            hanziPictureBox1.Completed += new BihuaHandler(OnCompleted);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void learn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTTION, 0);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void backspace_Click(object sender, EventArgs e)
        {
            hanziPictureBox1.UndoDraw();
        }

        private void clean_Click(object sender, EventArgs e)
        {
            hanziPictureBox1.ClearDraw();
        }
        public void OnCorrectDrew(Object sender, HanziEventArgs e)
        {
            tips.Text = String.Format("成功画了一笔，已画了{0}画", e.Bihuashu);
        }

        public void OnWrongDrew(Object sender, HanziEventArgs e)
        {
            tips.Text = String.Format("错误的一笔，已画了{0}画", e.Bihuashu);
        }

        public void OnCompleted(Object sender, HanziEventArgs e)
        {
            tips.Text = String.Format("已完成整个汉字");
        }
        

        
    }
}
