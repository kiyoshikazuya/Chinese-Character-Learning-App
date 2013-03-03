using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Kanjimusou.Lib
{
    class HanziPanel : Panel
    {
        private Hanzi hanzi;

        public HanziPanel(Hanzi hanzi)
        {
            this.hanzi = hanzi;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black);
            
        }
    }
}
