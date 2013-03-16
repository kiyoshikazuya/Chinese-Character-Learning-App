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
    public partial class exercise_form : Form
    {
        public exercise_form()
        {
            InitializeComponent();

            HanziIO hanzi = new HanziIO();
            hanzi.OpenFile("Hanzi.xml");
            hanziPictureBox1.Hanzi = hanzi.Read("中");
            hanziPictureBox1.CorrectDrew += new BihuaHandler(OnCorrectDrew);
            hanziPictureBox1.WrongDrew += new BihuaHandler(OnWrongDrew);
            hanziPictureBox1.Completed += new BihuaHandler(OnCompleted);
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

        private void backspace_Click(object sender, EventArgs e)
        {
            hanziPictureBox1.UndoDraw();
        }

        private void clean_Click(object sender, EventArgs e)
        {
            hanziPictureBox1.ClearDraw();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
