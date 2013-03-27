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
        private const int maxTime = 32;
        private int nowLevel = 0;
        private int nowTime = 0;
        private Hanzi nowZi = null;
        System.Timers.Timer t;

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
        
        public Hanzi NowZi
        {
            get { return nowZi; }
        }
        
        public Challenge( User user )
        {
            this.user = user;
            this.hzlist = HanziIO.ReadAll();
            this.user.FinishHanzi += OnFinishHanzi;
        }

        public void NextLevel()
        {
            nowLevel++; 
            Random ra = new Random();
            nowZi = hzlist.ElementAt(ra.Next(hzlist.Count));
            nowTime = ( maxTime - nowLevel >= 5 ? maxTime-nowLevel : 5 );
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += NowTimeChange;
            t.AutoReset = true;
            t.Enabled = true;
        }

        public void NowTimeChange(object source, System.Timers.ElapsedEventArgs e)
        {
            nowTime--;
            if (nowTime == 0)
            {
                nowLevel--;
                t.Close();
                Lose(nowLevel);
            }
        }

        public void Reset()
        {
            nowLevel = 0;
            nowTime = 0;
            nowZi = null;
        }

        public void OnFinishHanzi(Object sender, AchievementArgs args)
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
