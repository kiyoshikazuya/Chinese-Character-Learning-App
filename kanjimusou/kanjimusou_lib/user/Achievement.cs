
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kanjimusou.Lib
{

    [Serializable]
    public class AchievementElement
    {
        String arcName, arcInfo;
        bool finished = false;

        public AchievementElement( String arcName, String arcInfo, bool finished )
        {
            this.arcName = arcName;
            this.arcInfo = arcInfo;
            this.finished = finished;
        }
    }

    [Serializable]
    public class Achievement
    {
        private const String General = "达成了成就“{0}”！";

        private const String FirstWeekPlanFinishStr = "第一次完成周计划";
        private const String CompleteHanziStr = "完成了{0}个汉字";
        private const String FinishLevelStr = "突破{0}连战！";

        private bool firstWeekPlanFinish = false;
        private bool completeHanzi_10 = false;
        private bool completeHanzi_100 = false;
        private bool completeHanzi_1000 = false;
        private bool finishLevel_10 = false;
        private bool finishLevel_20 = false;
        private bool finishLevel_30 = false;
        private bool finishLevel_50 = false;
        private bool finishLevel_100 = false;

        private List<AchievementElement> arcList;

        /// <summary>
        /// 当成就达成时产生的事件
        /// </summary>
 
        public event Action<Object, String> AchievementReach;

        public List<AchievementElement> ArcList
        {
            get { return arcList; }
        }

        public Achievement(User user)
        {
            user.FinishHanzi += OnFinishHanzi;
            arcList = new List<AchievementElement>();
        }

        public void OnFinishHanzi(Object sender, AchievementArgs args)
        {
            User user = sender as User;
            AchievementElement arcEle;
            if (!firstWeekPlanFinish && user.IsHanziWeekPlanFinish)
            {
                firstWeekPlanFinish = true;
                arcEle = new AchievementElement("firstWeekPlanFinish", FirstWeekPlanFinishStr, true);
                if (!arcList.Contains(arcEle)) arcList.Add(arcEle);
                if (AchievementReach != null) AchievementReach(this, String.Format(General, FirstWeekPlanFinishStr));
            }
            if (!completeHanzi_10 && user.HanziTotalFinished >= 10)
            {
                completeHanzi_10 = true;
                arcEle = new AchievementElement("completeHanzi_10", String.Format(CompleteHanziStr, 10), true);
                if (!arcList.Contains(arcEle)) arcList.Add(arcEle);
                if (AchievementReach != null) AchievementReach(this, String.Format(General,
                        String.Format(CompleteHanziStr, 10)));
            }
            else if (!completeHanzi_100 && user.HanziTotalFinished >= 100)
            {
                completeHanzi_100 = true;
                arcEle = new AchievementElement("completeHanzi_100", String.Format(CompleteHanziStr, 100), true);
                if (!arcList.Contains(arcEle)) arcList.Add(arcEle);
                if (AchievementReach != null) AchievementReach(this, String.Format(General,
                        String.Format(CompleteHanziStr, 100)));
            }
            else if (!completeHanzi_1000 && user.HanziTotalFinished >= 1000)
            {
                completeHanzi_1000 = true;
                arcEle = new AchievementElement("completeHanzi_1000", String.Format(CompleteHanziStr, 1000), true);
                if (!arcList.Contains(arcEle)) arcList.Add(arcEle);
                if (AchievementReach != null) AchievementReach(this, String.Format(General,
                        String.Format(CompleteHanziStr, 1000)));
            }
        }

        public void OnFinishLevel(int nowLevel)
        {
            AchievementElement arcEle;
            if (!finishLevel_10 && nowLevel == 10)
            {
                finishLevel_10 = true;
                arcEle = new AchievementElement("finishLevel_10", String.Format(FinishLevelStr,10), true);
                if (!arcList.Contains(arcEle)) arcList.Add(arcEle);
                if (AchievementReach != null) AchievementReach(this, String.Format(General,
                        String.Format(FinishLevelStr, 10)));
            }
            if (!finishLevel_20 && nowLevel == 20)
            {
                finishLevel_20 = true;
                arcEle = new AchievementElement("finishLevel_20", String.Format(FinishLevelStr, 20), true);
                if (!arcList.Contains(arcEle)) arcList.Add(arcEle);
                if (AchievementReach != null) AchievementReach(this, String.Format(General,
                        String.Format(FinishLevelStr, 20)));
            }
            if (!finishLevel_30 && nowLevel == 30)
            {
                finishLevel_30 = true;
                arcEle = new AchievementElement("finishLevel_30", String.Format(FinishLevelStr, 30), true);
                if (!arcList.Contains(arcEle)) arcList.Add(arcEle);
                if (AchievementReach != null) AchievementReach(this, String.Format(General,
                        String.Format(FinishLevelStr, 30)));
            }
            if (!finishLevel_50 && nowLevel == 50)
            {
                finishLevel_50 = true;
                arcEle = new AchievementElement("finishLevel_50", String.Format(FinishLevelStr, 50), true);
                if (!arcList.Contains(arcEle)) arcList.Add(arcEle);
                if (AchievementReach != null) AchievementReach(this, String.Format(General,
                        String.Format(FinishLevelStr, 50)));
            }
            if (!finishLevel_100 && nowLevel == 100)
            {
                finishLevel_100 = true;
                arcEle = new AchievementElement("finishLevel_100", String.Format(FinishLevelStr, 100), true);
                if (!arcList.Contains(arcEle)) arcList.Add(arcEle);
                if (AchievementReach != null) AchievementReach(this, String.Format(General,
                        String.Format(FinishLevelStr, 100)));
            }
        }


    }
}
