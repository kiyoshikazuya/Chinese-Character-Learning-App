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


        List<Hanzi> Ahanzilist = new List<Hanzi>(HanziIO.ReadAll());



        static public User Auser;



        static public Hanzi Ahanzi;
        int i = 0;

        public static learn Ale;
        public learn()
        {
            InitializeComponent();
            Ale = this;
            Ahanzi = HanziIO.Read(Ahanzilist[i].Zi);
            this.picture.Image = Ahanzi.Picture;
            this.paraphrase.Text = Ahanzi.Info;
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
            prompt Prompt = new prompt(this,Auser);
            Prompt.Show();
        }

        private void next_Click(object sender, EventArgs e)
        {
            Auser.addLearnLog(Ahanzi.Zi, exercise_form.Zi);

            try
            {
                if (i+1 >= Ahanzilist.Count())
                    throw new UserException("已学完当前所有课程！");
                Ahanzi = HanziIO.Read(Ahanzilist[++i].Zi);
                this.picture.Image = Ahanzi.Picture;

                this.paraphrase.Text = Ahanzi.Info;
            }

            catch (UserException A)
            {
                wrong Awrong = new wrong(A.Message);
                Awrong.Show();
            }
            
        }

        private void sound_Click(object sender, EventArgs e)
        {

        }

        private void more_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string link = "http://zh.wikipedia.org/wiki/" + Ahanzi.Zi;
            System.Diagnostics.Process.Start("iexplore.exe", link); 
        }

        private void write_Click(object sender, EventArgs e)
        {

        }




    }
}
