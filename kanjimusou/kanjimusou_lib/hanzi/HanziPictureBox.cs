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
        public const int DrawSensitive = 20;
        public const int DetectSensitive = 50;
        public const double LengthSensitive = 0.2;
        public const int AnimateRate = 20;
        public const int DrawingWidthMin = 10;
        public const int DrawingWidthMax = 20;

        private Stack<Image> drawStack = new Stack<Image>();
        private Image drawTmp;
        private double drawLength;
        private Point lastPoint;
        private Hanzi hanzi;
        private Color drawColor = Color.Black;
        private int penWidth = 40;
        private int stage;
        private int step;
        private bool drawing = false;
        private Point drawingPoint;
        private int drawingWidth;
        private bool inkMode = true;
        private bool showHelper = false;

        private Timer timer;
        private int animeStep;

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
        /// 指定是否显示提示动画
        /// </summary>
        public bool IsShowHelper
        {
            get { return showHelper; }
            set
            {
                showHelper = value;
                if (value)
                {
                    StartTimer();
                    ResetAnimation();
                }
                else
                {
                    StopTimer();
                }
            }
        }

        /// <summary>
        /// 指定是否启动墨水模式
        /// </summary>
        public bool IsInkMode
        {
            get { return inkMode; }
            set { inkMode = value; }
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

        public HanziPictureBox() : this(null)
        {
            Image = new Bitmap(1, 1);
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

            if (showHelper) ResetAnimation();

            this.Refresh();
        }

        private void StartTimer()
        {
            if (timer == null)
            {
                timer = new Timer();
                timer.Interval = 50;
                timer.Tick += OnTimerTick;
            }
            timer.Start();
        }

        private void StopTimer()
        {
            if (timer != null && !showHelper && !drawing) timer.Stop();
        }

        private void ResetAnimation()
        {
            animeStep = 0;
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            if (showHelper) animeStep++;
            if (drawing && drawingWidth <= DrawingWidthMax) drawingWidth++;
            Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            foreach (Image draw in drawStack)
            {
                g.DrawImage(draw, 0, 0);
            }
            if (drawTmp != null) g.DrawImage(drawTmp, 0, 0, Width, Height);

            if (drawing)
            {
                Graphics gDraw = Graphics.FromImage(drawTmp);
                gDraw.SmoothingMode = SmoothingMode.AntiAlias;
                gDraw.FillPie(new SolidBrush(drawColor), drawingPoint.X - drawingWidth, drawingPoint.Y - drawingWidth,
                    drawingWidth * 2, drawingWidth * 2, 0, 360);
            }

            //若未设置汉字引用则剩下的操作全部跳过
            if (hanzi == null) return;
#if DEBUG
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
#endif

            //绘制路径动画
            if (showHelper)
            {
                for (int i = 0; stage < hanzi.BihuaBiao.Count && i <= (animeStep / AnimateRate) % (hanzi.BihuaBiao[stage].Gjdian.Count - 1); i++)
                {
                    Pen pen = new Pen(Color.Red, 10);

                    if (i < (animeStep / AnimateRate) % (hanzi.BihuaBiao[stage].Gjdian.Count - 1))
                    {
                        pen.EndCap = LineCap.Round;
                        g.DrawLine(pen, hanzi.BihuaBiao[stage].Gjdian[i], hanzi.BihuaBiao[stage].Gjdian[i + 1]);
                    }
                    else
                    {
                        pen.EndCap = LineCap.ArrowAnchor;
                        g.DrawLine(pen, hanzi.BihuaBiao[stage].Gjdian[i],
                            new Point(hanzi.BihuaBiao[stage].Gjdian[i].X
                            + (hanzi.BihuaBiao[stage].Gjdian[i + 1].X - hanzi.BihuaBiao[stage].Gjdian[i].X) * ((animeStep % AnimateRate) + 1) / AnimateRate,
                            hanzi.BihuaBiao[stage].Gjdian[i].Y
                            + (hanzi.BihuaBiao[stage].Gjdian[i + 1].Y - hanzi.BihuaBiao[stage].Gjdian[i].Y) * ((animeStep % AnimateRate) + 1) / AnimateRate));
                    }
                }
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            Sound.PlaySE("se_write");
            base.OnMouseDown(e);
            if (e.Button != MouseButtons.Left) return;
            if (stage >= hanzi.BihuaBiao.Count) return;

            lastPoint = drawingPoint = e.Location;
            drawTmp = new Bitmap(this.Width, this.Height);

            step = 0;
            drawLength = 0;

            if (inkMode)
            {
                drawing = true;
                drawingWidth = penWidth / 2;
                StartTimer();
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (stage >= hanzi.BihuaBiao.Count) return;

            drawingPoint = e.Location;

            if (e.Button == MouseButtons.Left)
            {
                if (Math.Sqrt(Math.Pow(e.X - lastPoint.X, 2) + Math.Pow(e.Y - lastPoint.Y, 2)) > DrawSensitive)
                {
                    Graphics g = Graphics.FromImage(drawTmp);
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    Pen p = new Pen(drawColor, (inkMode? drawingWidth * 2: penWidth));
                    p.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
                    g.DrawLine(p, lastPoint, e.Location);
                    drawLength += Math.Sqrt(Math.Pow(e.X - lastPoint.X, 2) + Math.Pow(e.Y - lastPoint.Y, 2));

                    lastPoint = e.Location;
                    drawingWidth--;
                    if (drawingWidth < DrawingWidthMin) drawingWidth = DrawingWidthMin;
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
            if (e.Button != MouseButtons.Left) return;
            if (stage >= hanzi.BihuaBiao.Count) return;

            drawStack.Push(drawTmp);
            drawTmp = null;

            //校验笔画长度
            double bihuaLength = 0;
            for (int i = 1; i < hanzi.BihuaBiao[stage].Gjdian.Count; i++)
            {
                bihuaLength += Math.Sqrt(Math.Pow(hanzi.BihuaBiao[stage].Gjdian[i].X - hanzi.BihuaBiao[stage].Gjdian[i-1].X, 2)
                    + Math.Pow(hanzi.BihuaBiao[stage].Gjdian[i].Y - hanzi.BihuaBiao[stage].Gjdian[i-1].Y, 2));
            }
            bool checkLength = drawLength - bihuaLength * (1.0 + LengthSensitive) < 100;

            if (inkMode)
            {
                drawing = false;
                StopTimer();
            }
            if (showHelper) ResetAnimation();

            stage++;

            if (step >= hanzi.BihuaBiao[stage-1].Gjdian.Count && checkLength)
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
