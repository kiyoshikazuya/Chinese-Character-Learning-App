﻿using System;
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
    public partial class DL : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int mParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTTION = 0x0002;

        public static User Auser;
        public static DL ADL;

        private bool showing = true;
        private bool doClose = true;

        public DL()
        {
            InitializeComponent();
            ADL = this;
            Atimer.Interval = 25;
            OnShow();
            
        }

        public void OnAchievementReach(Object sender, String info)
        {
            achievement_tips achTips = new achievement_tips(info);
            achTips.OnShow();
        }

        public void Clear()
        {
            this.name.Text = "";
            this.passwd.Text = "";
        }
        
        private void log_on_Click(object sender, EventArgs e)
        {
            Sound.PlaySE("se_buttonclick");
            ZC Logon = new ZC();
            Logon.Shown += BlockWindow;
            Logon.FormClosed += UnblockWindow;
            Logon.OnShow(); 
            
        }

        private void Atimer_Tick(object sender, EventArgs e)
        {
            double d = 0.02;
            if (showing)
            {
                if (Opacity + d >= 0.9)
                {
                    Opacity = 0.9;
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
                    if (doClose) this.Close();
                    else this.Visible = false;
                }
                else
                {
                    Opacity -= d;
                }
            }
        }

        private void closethis_Click(object sender, EventArgs e)
        {
            Sound.PlaySE("se_buttonclick");
            this.OnClose( true );
        }

        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTTION, 0);
        }

        private void dlu_Click(object sender, EventArgs e)
        {
            Sound.PlaySE("se_buttonclick");
            try
           {
              Auser=UserManager.Login(this.name.Text,this.passwd.Text);
              Auser.ResetHanziWeekFinished();
              welcome Awelcom = new welcome(Auser);

              this.OnClose(false);
              Auser.FinishHanzi += Auser.Achievement.OnFinishHanzi;
              Auser.Achievement.AchievementReach += OnAchievementReach;

              Awelcom.OnShow();
               
            }
            catch(UserException a)
            {
                wrong Awrong = new wrong(a.Message);
                Awrong.Shown += new EventHandler(BlockWindow);
                Awrong.FormClosed += new FormClosedEventHandler(UnblockWindow);
                Awrong.OnShow();
            }
        }

        void UnblockWindow(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }

        void BlockWindow(object sender, EventArgs e)
        {
            this.Enabled = false;
        }

        public void OnShow()
        {
            this.Show();
            showing = true;
            Opacity = 0.0;      //窗体透明度为0
            Atimer.Start(); //计时
            if ( ! Sound.IsPlayingBGM ) Sound.PlayBGM("bgm_opening");
            this.Enabled = true;
            Clear();
        }

        public void OnClose( bool doClose )
        {
            
            this.Opacity = 0.9;
            this.doClose = doClose;
            this.Enabled = false;
            showing = false;
            Atimer.Start();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            this.passwd.Text = "";
        }


        //如何返回此参数

        

        

        
    }
}
