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
    public partial class chanllenge : Form
    {

        int time = 10;//每次给5秒时间



        public int i=0;
        public List<Hanzi> list;

        public chanllenge()
        {
            InitializeComponent();
            list = HanziIO.ReadAll();
            this.hanziPictureBox1.Hanzi = list[i];
            timer1.Start();


            

        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.resttime.Width = this.resttime.Width-(50/time);
            if (this.resttime.Width <= 0)//时间用尽失败
            {
                timer1.Stop();
                end Aend = new end("挑战失败");
                Aend.Show();
                this.Close();
            }
        }

        private void hanziPictureBox1_Completed(object sender, HanziEventArgs e)
        {
            this.next.Visible = true;
            timer1.Stop();
            this.label1.Text = "挑战成功！可以进入下一个";
        }

        private void next_Click(object sender, EventArgs e)
        {
            try
            {
                if (i + 1 >= list.Count())
                    throw new UserException("当前字库已完结！");
                this.hanziPictureBox1.Hanzi = list[++i];
            }
            catch (UserException E)
            {
                wrong Awrong = new wrong(E.Message);
                Awrong.Show();
            }
            this.resttime.Width = 500;
            timer1.Start();
            this.label1.Text = "加油！";
            this.next.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
