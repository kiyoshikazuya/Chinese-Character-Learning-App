using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Drawing;

namespace Kanjimusou.Lib
{
    public class HanziIO
    {
        private XmlDocument xmldoc;
        private XmlNode xmlnode, root;
        private XmlElement xmlelem;

        public HanziIO()
        {
        } 

        public void OpenFile ( String filepath )
        {
            xmldoc = new XmlDocument();
            xmldoc.Load(filepath);
            root = xmldoc.SelectSingleNode("/Hanzis");
        }

        public List<Hanzi> ReadAll()
        {
            List<Hanzi> ret = new List<Hanzi>() ;
            List<Bihua> bihuabiao = new List<Bihua>();
            List<Point> pt;
            Hanzi zi;
            Bihua bi;
            Point po;
            String info = "", name = "", path = "";
            XmlNodeList hzlist = root.ChildNodes, bhlist = null, ptlist = null, tlist;

            foreach (XmlNode xn in hzlist)
            {
                bihuabiao = new List<Bihua>();
                name = xn.Attributes["zi"].Value;
                tlist = xn.ChildNodes;

                foreach (XmlNode xnn in tlist)
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
                zi = new Hanzi(name, bihuabiao, info, path);
                ret.Add(zi);
            }

            return ret;
        }
        
        public Hanzi Read(String zi)
        {
            Hanzi ret = null;
            XmlNodeList hzlist = root.ChildNodes;
            List<Bihua> bihuabiao = new List<Bihua>();
            List<Point> pt;
            Bihua bi;
            Point po;
            String info = "", name = "", path = "";
            XmlNodeList bhlist = null, ptlist = null, tlist;

            foreach (XmlNode xn in hzlist)
            {
                if (xn.Attributes["zi"].Value == zi)
                {
                    name = xn.Attributes["zi"].Value;
                    tlist = xn.ChildNodes;

                    foreach (XmlNode xnn in tlist)
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
                    ret = new Hanzi(name, bihuabiao, info, path);
                    break;
                }
            }


            return ret;    
        }

        public bool SaveFile(String filepath, List<Hanzi> hanziList)
        {

            return true;
        }

    }
}
