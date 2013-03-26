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
    public partial class learn : Form
    {

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int mParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTTION = 0x0002;
        string[] lists = { "中", "華", "华", "國", "国", "精", "诚", "誠", "愛", "爱", "民", "亲", "親" };
        static public User Auser;
        static public Hanzi Ahanzi;
        int i = 0;

        public static learn Ale;
        public learn()
        {
            InitializeComponent();
            Ale = this;
            Ahanzi = HanziIO.Read(lists[i]);
            this.picture.Image = Ahanzi.Picture;
        }
        public learn(User A):this()
        {
            Auser = A;
        }



        public learn(User A,Hanzi H)
        {
            Auser = A;
            Ahanzi = H;
        }


        private void learn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTTION, 0);

        }

        private void exercise_Click(object sender, EventArgs e)
        {
            exercise_form AnexerciseForm = new exercise_form(Ahanzi);
            AnexerciseForm.Show();
        }

        private void close_it_Click(object sender, EventArgs e)
        {
            prompt Prompt = new prompt(this);
            Prompt.Show();
        }

        private void next_Click(object sender, EventArgs e)
        {
            Ahanzi = HanziIO.Read(lists[++i]);
            this.picture.Image = Ahanzi.Picture;
        }



    }
}
