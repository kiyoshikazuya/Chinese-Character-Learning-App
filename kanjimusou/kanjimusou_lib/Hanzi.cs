using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Kanjimusou.Lib
{
    /// <summary>
    /// Hanzi类是用来表示一个汉字的类，实例即为汉字本体
    /// 属性有汉字名，笔画表，图片路径，汉字信息，字体
    /// </summary>
    public class Hanzi
    {
        /// <summary>
        /// 笔画表是一个笔画LIST，由笔画对象组成
        /// </summary>
        private readonly List<Bihua> bihuaBiao; 

        public List<Bihua> BihuaBiao
        {
            get { return bihuaBiao; }
        } 
        /// <summary>
        /// 汉字的字名
        /// </summary>
        private readonly String zi;

        public String Zi
        {
            get { return zi; }
        }
        /// <summary>
        /// 汉字的字体
        /// </summary>
        private readonly String ziti;

        public String Ziti
        {
            get { return ziti; }
        } 
        /// <summary>
        /// 汉字图片的存放路径
        /// </summary>
        private readonly String path;

        public String Path
        {
            get { return path; }
        }
        /// <summary>
        /// 构造汉字时将图片加载进对象中
        /// </summary>
        private Image picture = null;

        public Image Picture
        {
            get {
                if (picture == null) picture = Image.FromFile ( path );

                return picture; 
            }
        } 
        /// <summary>
        /// 汉字的信息
        /// </summary>
        private readonly String info;

        public String Info
        {
            get { return info; }
        }
        /// <summary>
        /// 该类的构造函数，参数有5个，分别是字名、字体、笔画表、信息、图片路径
        /// </summary>
        /// <param name="zi"></param>
        /// <param name="ziti"></param>
        /// <param name="bihuabiao"></param>
        /// <param name="info"></param>
        /// <param name="path"></param>
        public Hanzi( String zi, String ziti, List<Bihua> bihuabiao, String info, String path )
        {
            this.zi = zi;
            this.ziti = ziti;
            this.bihuaBiao = bihuabiao;
            this.info = info;
            this.path = path;
        }



    }
}
