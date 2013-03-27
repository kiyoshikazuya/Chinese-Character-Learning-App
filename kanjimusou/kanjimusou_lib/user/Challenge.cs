using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kanjimusou.Lib
{

    [Serializable]
    public class Challenge
    {

        private User user;
       // private List<Hanzi> hzlist;
        private const int maxTime = 30;
        private int maxReachedLevel = 0;
        private int nowLevel = 0;
        private int nowTime = 0;
       // private Hanzi nowZi = null;

        public event Action<int> FinishLevel;
        public event Action<int> Lose;

        public int NowLevel
        {
            get { return nowLevel; }
        }

        public int NowTime
        {
            get { return nowTime; }
        }
        /*
        public Hanzi NowZi
        {
            get { return nowZi; }
        }
        */
        public int MaxReachedLevel
        {
            get { return maxReachedLevel; }
        }
        
        public Challenge( User user )
        {
            this.user = user;
        //    this.hzlist = HanziIO.ReadAll();
        }

        public void NextLevel()
        {
            nowLevel++;
            nowTime = ( maxTime - nowLevel + 1 >= 5 ? maxTime-nowLevel : 5 );
            Random ra = new Random();
            
        }

        public void Reset()
        {
        }

        public void ExitChallenge()
        {
        }

    }
}
