<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kanjimusou.Lib
{
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

        private bool firstWeekPlanFinish = false;
        private bool completeHanzi_10 = false;
        private bool completeHanzi_100 = false;
        private bool completeHanzi_1000 = false;

        private List<AchievementElement> arcList;

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
    }
}
=======
﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kanjimusou.Lib
{
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

        private bool firstWeekPlanFinish = false;
        private bool completeHanzi_10 = false;
        private bool completeHanzi_100 = false;
        private bool completeHanzi_1000 = false;

        private List<AchievementElement> arcList;

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
    }
}
>>>>>>> UI
