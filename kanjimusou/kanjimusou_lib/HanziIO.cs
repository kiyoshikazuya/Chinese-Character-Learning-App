using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Drawing;

namespace Kanjimusou.Lib
{
    /// <summary>
    /// 该类使用XML处理汉字信息的I/O
    /// 首先实例化一个对象，然后调用OpenFile方法打开XML文件即可读取Hanzi对象
    /// </summary>
    public class HanziIO
    {
        private XmlDocument xmldoc;
        private XmlNode xmlnode, root;
        private XmlElement xmlelem;

        public HanziIO()
        {
        } 
        /// <summary>
        /// 该方法初始化一个XMLDOC对象，以读取文件内容，参数即为打开文件的路径
        /// </summary>
        /// <param name="filepath"></param>
        public void OpenFile ( String filepath )
        {
            xmldoc = new XmlDocument();
            xmldoc.Load(filepath);
            root = xmldoc.SelectSingleNode("/Hanzis");
        }
        /// <summary>
        /// 该方法返回文件中所有的Hanzi对象，返回值是一个Hanzi类型的LIST
        /// </summary>
        /// <returns></returns>
        public List<Hanzi> ReadAll()
        {
            List<Hanzi> ret = new List<Hanzi>() ; 
            List<Bihua> bihuabiao = new List<Bihua>();
            List<Point> pt;
            Hanzi zi;
            Bihua bi;
            Point po;
            String info = "", name = "", path = "", zitiname = "";
            XmlNodeList hzlist = root.ChildNodes, bhlist = null, ptlist = null, elelist;

            foreach (XmlNode xn in hzlist)
            {
                bihuabiao = new List<Bihua>();
                name = xn.Attributes["zi"].Value;
                zitiname = xn.Attributes["ziti"].Value;
                elelist = xn.ChildNodes;

                foreach (XmlNode xnn in elelist)
                {
                    if (xnn.Name == "bihualist") bhlist = xnn.ChildNodes;
                    if (xnn.Name == "info") info = xnn.InnerText;
                    if (xnn.Name == "path") path = xnn.InnerText;
                }
                foreach (XmlNode xnn in bhlist)
                {
                    ptlist = xnn.ChildNodes;
                    pt = new List<Point>();
                    foreach (XmlNode xnnn in ptlist)
                    {
                        po = new Point(int.Parse(xnnn.Attributes["x"].Value), int.Parse(xnnn.Attributes["y"].Value));
                        pt.Add(po);
                    }
                    bi = new Bihua(pt);
                    bihuabiao.Add(bi);
                }
                zi = new Hanzi(name, zitiname, bihuabiao, info, path);
                ret.Add(zi);
            }

            return ret;
        }
        /// <summary>
        /// 该方法是返回一个特定的Hanzi对象，参数2个，分别是指定返回的汉字名与字体
        /// </summary>
        /// <param name="zi"></param>
        /// <param name="ziti"></param>
        /// <returns></returns>
        public Hanzi Read(String zi, String ziti)
        {
            Hanzi ret = null;
            XmlNodeList hzlist = root.ChildNodes;
            List<Bihua> bihuabiao = new List<Bihua>();
            List<Point> pt;
            Bihua bi;
            Point po;
            String info = "", name = "", path = "", zitiname = "";
            XmlNodeList bhlist = null, ptlist = null, elelist;

            foreach (XmlNode xn in hzlist)
            {
                if (xn.Attributes["zi"].Value == zi && xn.Attributes["ziti"].Value == ziti)
                {
                    name = xn.Attributes["zi"].Value;
                    zitiname = xn.Attributes["ziti"].Value;
                    elelist = xn.ChildNodes;

                    foreach (XmlNode xnn in elelist)
                    {
                        if (xnn.Name == "bihualist") bhlist = xnn.ChildNodes;
                        if (xnn.Name == "info") info = xnn.InnerText;
                        if (xnn.Name == "path") path = xnn.InnerText;
                    }
                    foreach (XmlNode xnn in bhlist)
                    {
                        ptlist = xnn.ChildNodes;
                        pt = new List<Point>();
                        foreach (XmlNode xnnn in ptlist)
                        {
                            po = new Point(int.Parse(xnnn.Attributes["x"].Value), int.Parse(xnnn.Attributes["y"].Value));
                            pt.Add(po);
                        }
                        bi = new Bihua(pt);
                        bihuabiao.Add(bi);
                    }
                    ret = new Hanzi(name, zitiname, bihuabiao, info, path);
                    break;
                }
            }


            return ret;    
        }
        /// <summary>
        /// 该方法是返回一个特定的汉字对象，参数1个，为指定返回的汉字名，字体为默认
        /// </summary>
        /// <param name="zi"></param>
        /// <returns></returns>
        public Hanzi Read(String zi)
        {
            return Read(zi, "雅黑");
        }

        public bool SaveFile(String filepath, List<Hanzi> hanziList)
        {

            return true;
        }

    }
}
