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
    /// <summary>
    /// 用于显示汉字并响应用户鼠标事件完成笔画绘制与识别的类
    /// </summary>
    public class HanziPictureBox : PictureBox, IComponent
    {
        public const int DrawSensitive = 10;
        public const int DetectSensitive = 50;
        public const double LengthSensitive = 0.2;

        private Stack<Image> drawStack = new Stack<Image>();
        private Image drawTmp;
        private double drawLength;
        private Point lastPoint;
        private Hanzi hanzi;
        private Color drawColor = Color.Black;
        private int penWidth = 30;
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
            stage = drawStack.Count;

            this.Refresh();
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
            stage = 0;
            step = 0;

            this.Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            foreach (Image draw in drawStack)
            {
                g.DrawImage(draw, 0, 0);
            }
            if (drawTmp != null) g.DrawImage(drawTmp, 0, 0, Width, Height);
            /// <debug>
            if (hanzi != null && stage < hanzi.BihuaBiao.Count)
            {
                for (int i = 0; i < hanzi.BihuaBiao[stage].Gjdian.Count; i++)
                {
                    Pen pen = null;
                    if (i < step) pen = new Pen(Color.Silver);
                    else if (i == step) pen = new Pen(Color.Blue);
                    else if (i > step) pen = new Pen(Color.Red);
                    g.DrawArc(pen,
                            hanzi.BihuaBiao[stage].Gjdian[i].X - DetectSensitive / 2, hanzi.BihuaBiao[stage].Gjdian[i].Y - DetectSensitive / 2,
                            DetectSensitive, DetectSensitive, 0, 360);
                }
            }
            /// </debug>
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (stage >= hanzi.BihuaBiao.Count) return;

            if (e.Button == MouseButtons.Left)
            {
                lastPoint = e.Location;
            }
            drawTmp = new Bitmap(this.Width, this.Height);

            step = 0;
            drawLength = 0;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (stage >= hanzi.BihuaBiao.Count) return;

            if (e.Button == MouseButtons.Left)
            {
                if (Math.Sqrt(Math.Pow(e.X - lastPoint.X, 2) + Math.Pow(e.Y - lastPoint.Y, 2)) > DrawSensitive)
                {
                    Graphics g = Graphics.FromImage(drawTmp);
                    Pen p = new Pen(drawColor, penWidth);
                    p.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
                    g.DrawLine(p, lastPoint, e.Location);
                    drawLength += Math.Sqrt(Math.Pow(e.X - lastPoint.X, 2) + Math.Pow(e.Y - lastPoint.Y, 2));

                    lastPoint = e.Location;
                    this.Refresh();
                }
                if (stage < hanzi.BihuaBiao.Count && step < hanzi.BihuaBiao[stage].Gjdian.Count
                    && Math.Sqrt(Math.Pow(e.X - hanzi.BihuaBiao[stage].Gjdian[step].X, 2)
                    + Math.Pow(e.Y - hanzi.BihuaBiao[stage].Gjdian[step].Y, 2)) < DetectSensitive)
                {
                    step++;
                }
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (stage >= hanzi.BihuaBiao.Count) return;

            if (e.Button == MouseButtons.Left)
            {
                drawStack.Push(drawTmp);
            }
            drawTmp = null;

            //校验笔画长度
            double bihuaLength = 0;
            bool flag = false;
            Point lastPt = new Point();
            foreach (Point pt in hanzi.BihuaBiao[stage].Gjdian)
            {
                if (flag)
                {
                    bihuaLength += Math.Sqrt(Math.Pow(pt.X - lastPt.X, 2) + Math.Pow(pt.Y - lastPt.Y, 2));
                }
                flag = true;
                lastPt = pt;
            }

            stage++;

            if (step >= hanzi.BihuaBiao[stage-1].Gjdian.Count && drawLength > bihuaLength * (1 - LengthSensitive)
                    && drawLength < bihuaLength * (1 + LengthSensitive))
            {
                if (stage >= hanzi.BihuaBiao.Count)
                {
                    if (Completed != null) Completed(this, new HanziEventArgs(stage));
                }
                else
                {
                    if (CorrectDrew != null) CorrectDrew(this, new HanziEventArgs(stage));
                }
            }
            else
            {
                UndoDraw();
                if (WrongDrew != null) WrongDrew(this, new HanziEventArgs(stage));
            }
            step = 0;
            this.Refresh();
        }
    }

    public delegate void BihuaHandler(Object sender, HanziEventArgs e);

    /// <summary>
    /// 用于封装笔画书写事件参数的类
    /// </summary>
    public class HanziEventArgs : EventArgs
    {
        private int bihuashu;

        /// <summary>
        /// 获得当前已正确完成的笔画数
        /// </summary>
        public int Bihuashu
        {
            get { return bihuashu; }
        }

        public HanziEventArgs(int Bihuashu)
        {
            bihuashu = Bihuashu;
        }
    }
}
