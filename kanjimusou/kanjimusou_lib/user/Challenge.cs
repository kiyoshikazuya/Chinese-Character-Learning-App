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
        private List<Hanzi> hzlist;
        private const double maxTime = 32;
        private int nowLevel = 0;
        private double nowTime = 0;
        private double nowMaxTime = 0;

        private Hanzi nowZi = null;
        System.Timers.Timer t;

        public event Action<int> FinishLevel;
        public event Action<int> Lose;

        public int NowLevel
        {
            get { return nowLevel; }
        }

        public double NowTime
        {
            get { return nowTime; }
        }
        
        public Hanzi NowZi
        {
            get { return nowZi; }
        }

        public double NowMaxTime
        {
            get { return nowMaxTime; }
        }
        
        public Challenge( User user )
        {
            this.user = user;
            this.hzlist = HanziIO.ReadAll();
        }

        public void NextLevel()
        {
            nowLevel++; 
            Random ra = new Random();
            nowZi = hzlist.ElementAt(ra.Next(hzlist.Count));
            nowMaxTime = ( maxTime - nowLevel >= 5 ? maxTime-nowLevel : 5 );
            nowTime = nowMaxTime;
            t = new System.Timers.Timer();
            t.Interval = 25;
            t.Elapsed += NowTimeChange;
            t.AutoReset = true;
            t.Enabled = true;
        }

        public void NowTimeChange(object source, System.Timers.ElapsedEventArgs e)
        {
            nowTime = nowTime - 0.025;
            if (nowTime <= 0)
            {
                nowLevel--;
                t.Close();
                Reset();
                Lose(nowLevel);
            }
        }

        public void Reset()
        {
            nowLevel = 0;
            nowTime = 0;
            nowZi = null;
        }

        public void OnFinishHanzi(Object sender, HanziEventArgs e)
        {
            if (nowTime > 0)
            {
                t.Close();
                if (nowLevel > user.MaxReachedLevel)
                    user.MaxReachedLevel = nowLevel;
                FinishLevel(nowLevel);
            }
        }

    }
}
