using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Kanjimusou.Lib
{
    public delegate void BihuaHandler(Object sender, BihuaEventArgs e);

    /// <summary>
    /// 用于封装笔画书写事件参数的类
    /// </summary>
    public class BihuaEventArgs : EventArgs
    {
        private int bihuashu;

        public int Bihuashu
        {
            get { return bihuashu; }
        }

        public BihuaEventArgs(int Bihuashu)
        {
            bihuashu = Bihuashu;
        }
    }

    /// <summary>
    /// 用于显示汉字并响应用户鼠标事件完成笔画绘制与识别的类
    /// </summary>
    public class HanziPictureBox : PictureBox, IComponent
    {
        public const int DrawSensitive = 10;
        public const int DetectSensitive = 30;

        private Stack<Image> drawStack = new Stack<Image>();
        private Image drawTmp;
        private Point lastPoint;
        private Hanzi hanzi;
        private int penWidth = 10;
        private int stage;
        private int step;

        /// <summary>
        /// 获得或设置画板显示的汉字，设置新汉字后会清空并刷新画板
        /// </summary>
        public Hanzi Hanzi
        {
            get { return hanzi; }
            set
            {
                hanzi = value;
                if (hanzi != null) Image = hanzi.Picture;
                ClearDraw();
            }
        }

        /// <summary>
        /// 获得在画板上所画出的图像
        /// </summary>
        public Image DrawImage
        {
            get
            {
                Image draw = new Bitmap(this.Width, this.Height);
                Graphics g = Graphics.FromImage(draw);
                foreach (Image d in drawStack) g.DrawImage(d, 0, 0);
                return draw;
            }
        }

        /// <summary>
        /// 当用户正确的绘制了一个笔画时产生的事件
        /// </summary>
        public event BihuaHandler CorrectDrew;

        /// <summary>
        /// 当用户没有正确完成一个笔画时产生的事件
        /// </summary>
        public event BihuaHandler WrongDrew;

        /// <summary>
        /// 当用户完成了整个汉字时产生的事件，此时不会再产生CorrectDrew事件
        /// </summary>
        public event BihuaHandler Completed;

        public HanziPictureBox()
        {
        }

        public HanziPictureBox(Hanzi hanzi)
        {
            Hanzi = hanzi;
        }

        /// <summary>
        /// 撤销上一笔画，此操作会刷新画板
        /// </summary>
        public void UndoDraw()
        {
            if (drawStack.Count != 0) drawStack.Pop();
            this.Refresh();

            stage--;
        }

        /// <summary>
        /// 清空所有已绘制的笔画，此操作会刷新画板
        /// </summary>
        public void ClearDraw()
        {
            foreach (Image draw in drawStack)
            {
                draw.Dispose();
            }
            drawStack.Clear();
            this.Refresh();

            stage = 0;
            step = 0;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            foreach (Image draw in drawStack)
            {
                g.DrawImage(draw, 0, 0);
            }
            if (drawTmp != null) g.DrawImage(drawTmp, 0, 0);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lastPoint = e.Location;
            }
            drawTmp = new Bitmap(this.Width, this.Height);

            base.OnMouseDown(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Math.Sqrt(Math.Pow(e.X - lastPoint.X, 2) + Math.Pow(e.Y - lastPoint.Y, 2)) > DrawSensitive)
                {
                    Graphics g = Graphics.FromImage(drawTmp);
                    Pen p = new Pen(Color.Black, penWidth);
                    p.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
                    g.DrawLine(p, lastPoint, e.Location);
                    lastPoint = e.Location;
                    this.Refresh();
                }
                if (stage < hanzi.BihuaBiao.Count && step < hanzi.BihuaBiao[stage].Gjdian.Count
                    && Math.Sqrt(Math.Pow(e.X - hanzi.BihuaBiao[stage].Gjdian[step].X, 2)
                    + Math.Pow(e.Y - hanzi.BihuaBiao[stage].Gjdian[step].Y, 2)) > DetectSensitive)
                {
                    step++;
                }
            }

            base.OnMouseMove(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drawStack.Push(drawTmp);
            }
            drawTmp = null;
            this.Refresh();

            if (stage < hanzi.BihuaBiao.Count)
            {
                if (step >= hanzi.BihuaBiao[stage].Gjdian.Count)
                {
                    if (++stage >= hanzi.BihuaBiao.Count)
                    {
                        if (Completed != null) Completed(this, new BihuaEventArgs(stage));
                    }
                    else
                    {
                        if (CorrectDrew != null) CorrectDrew(this, new BihuaEventArgs(stage));
                    }
                }
                else if (WrongDrew != null) WrongDrew(this, new BihuaEventArgs(stage));
            }
            
            base.OnMouseUp(e);
        }
    }
}
