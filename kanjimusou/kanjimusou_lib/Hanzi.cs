using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Kanjimusou.Lib
{
    public class Hanzi
    {
        private readonly List<Bihua> bihuaBiao;

        public List<Bihua> BihuaBiao
        {
            get { return bihuaBiao; }
        } 

        private readonly String zi;

        public String Zi
        {
            get { return zi; }
        }

        private readonly String path;

        public String Path
        {
            get { return path; }
        }

        private Image picture = null;

        public Image Picture
        {
            get {
                if (picture == null) picture = Image.FromFile ( path );

                return picture; 
            }
        } 

        private readonly String info;

        public String Info
        {
            get { return info; }
        }

        public int Bihuashu
        {
            get { return bihuaBiao.Count; }
        }

        public Hanzi( String zi, List<Bihua> bihuabiao, String info, String path )
        {
            this.zi = zi;
            this.bihuaBiao = bihuabiao;
            this.info = info;
            this.path = path;
        }



    }
}
