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
    public class HanziPictureBox : PictureBox, IComponent
    {
        public const int Sensitive = 10;

        private Stack<Image> drawStack = new Stack<Image>();
        private Image drawTmp;
        private Point lastPoint;

        private Hanzi hanzi;
        public Hanzi Hanzi
        {
            get { return hanzi; }
            set
            {
                hanzi = value;
                //Image = hanzi.Picture;
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

        public HanziPictureBox()
        {
        }

        public HanziPictureBox(Hanzi hanzi)
        {
            this.hanzi = hanzi;
        }

        public void UndoDraw()
        {
            if (drawStack.Count != 0) drawStack.Pop();
            this.Refresh();
        }

        public void ClearDraw()
        {
            foreach (Image draw in drawStack)
            {
                draw.Dispose();
            }
            drawStack.Clear();
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
                if (Math.Abs(e.X - lastPoint.X) + Math.Abs(e.Y - lastPoint.Y) > Sensitive)
                {
                    Graphics g = Graphics.FromImage(drawTmp);
                    Pen p = new Pen(Color.Black, 5);
                    p.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
                    g.DrawLine(p, lastPoint, e.Location);
                    lastPoint = e.Location;
                    this.Refresh();
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
            
            base.OnMouseUp(e);
        }
    }
}
