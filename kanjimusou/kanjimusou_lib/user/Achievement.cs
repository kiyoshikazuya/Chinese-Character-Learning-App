using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kanjimusou;

namespace Kanjimusou.Lib
{
    [Serializable]
    public class Achievement
    {
        private const String General = "达成了成就“{0}”！";

        private const String FirstWeekPlanFinishStr = "第一次完成周计划";
        private const String CompleteHanziStr = "完成了{0}个汉字";

        private bool firstWeekPlanFinish = false;
        private bool completeHanzi_10 = false;
        private bool completeHanzi_100 = false;
        private bool completeHanzi_1000 = false;

        public event Action<Object, String> AchievementReach;

        public Achievement(User user)
        {
            user.FinishHanzi += OnFinishHanzi;
        }

        public void OnFinishHanzi(Object sender, AchievementArgs args)
        {
            User user = sender as User;
            if (!firstWeekPlanFinish && user.IsHanziWeekPlanFinish)
            {
                firstWeekPlanFinish = true;
                if (AchievementReach != null) AchievementReach(this, String.Format(General, FirstWeekPlanFinishStr));
            }
            if (!completeHanzi_10 && user.HanziTotalFinished >= 10)
            {
                completeHanzi_10 = true;
                if (AchievementReach != null) AchievementReach(this, String.Format(General,
                        String.Format(CompleteHanziStr, 10)));
            }
            else if (!completeHanzi_100 && user.HanziTotalFinished >= 100)
            {
                completeHanzi_100 = true;
                if (AchievementReach != null) AchievementReach(this, String.Format(General,
                        String.Format(CompleteHanziStr, 100)));
            }
            else if (!completeHanzi_1000 && user.HanziTotalFinished >= 1000)
            {
                completeHanzi_1000 = true;
                if (AchievementReach != null) AchievementReach(this, String.Format(General,
                        String.Format(CompleteHanziStr, 1000)));
            }
            

        }
    }
}
