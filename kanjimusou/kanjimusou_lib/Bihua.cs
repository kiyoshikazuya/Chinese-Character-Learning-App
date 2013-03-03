using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Kanjimusou.Lib
{
    class Bihua
    {
        public static const int Resolution = 500 ;

        private readonly List<Point> gjdian;

        public List<Point> Gjdian
        {
            get { return gjdian; }
        }

        public Bihua( List<Point> gjdian )
        {
            this.gjdian = gjdian;
        }

    }
}
