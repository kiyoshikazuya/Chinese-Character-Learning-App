using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Kanjimusou.Lib
{
    /// <summary>
    /// 保存一个笔画的类
    /// </summary>
    public class Bihua
    {
        /// <summary>
        /// 表示该笔画的默认分辨率
        /// </summary>
        public static int Resolution = 500 ;
        /// <summary>
        /// 表示该笔画的关键点 由一个POINT表保存
        /// </summary>
        private readonly List<Point> gjdian;

        public List<Point> Gjdian
        {
            get { return gjdian; }
        }
        /// <summary>
        /// 构造函数，参数1个，为关键点的列表
        /// </summary>
        /// <param name="gjdian"></param>
        public Bihua( List<Point> gjdian )
        {
            this.gjdian = gjdian;
        }

    }
}
