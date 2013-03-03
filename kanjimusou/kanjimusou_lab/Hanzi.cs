using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kanjimusou_lib
{
    class Hanzi
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

        private readonly String info;

        public String Info
        {
            get { return info; }
        }

        public int Bihuashu
        {
            get { return bihuaBiao.Count; }
        }

        public Hanzi( String zi, List<Bihua> bihuabiao, String info )
        {
            this.zi = zi;
            this.bihuaBiao = bihuabiao;
            this.info = info;
        }



    }
}
