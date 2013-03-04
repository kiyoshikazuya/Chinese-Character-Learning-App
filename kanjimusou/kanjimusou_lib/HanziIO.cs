using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Kanjimusou_lib
{
    class HanziIO
    {
        private XmlDocument xmldoc;
        private XmlNode xmlnode;
        private XmlElement xmlelem;

        public HanziIO()
        {
        } 

        public void OpenFile ( String filepath )
        {
            xmldoc = new XmlDocument();
            xmldoc.Load(filepath);


        }

        public bool SaveFile(String filepath, List<Hanzi> hanziList)
        {

            return true;
        }

    }
}
