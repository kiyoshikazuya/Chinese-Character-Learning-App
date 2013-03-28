using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Security.Cryptography;
using System.IO;

namespace Kanjimusou.Lib
{
    /*
     * TODO:
     * +已学习的汉字，保存最近的几次所书写的汉字，每个汉字书写过的次数
     * +学习计划，学习进度
     * 统计信息
     * 
     */
    [Serializable]
    public class User
    {
        private Dictionary<String, HanziLearnLog> learnDic = new Dictionary<String, HanziLearnLog>();
        private String username;
        private String password;

        private int hanziWeekPlan;
        private int hanziWeekFinished;
        private int weekCount = 1;
        private int maxReachedLevel = 0;
        private DateTime planStartTime;

        internal Achievement achievement;

        public event AchievementHandler FinishHanzi;

        /// <summary>
        /// 取得和设置用户名
        /// </summary>
        public String Username
        {
            get { return username; }
            set { username = value; }
        }

        /// <summary>
        /// 设置密码
        /// </summary>
        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public int MaxReachedLevel
        {
            get { return maxReachedLevel; }
            set { maxReachedLevel = value; }
        }

        /// <summary>
        /// 取得学习记录
        /// </summary>
        public Dictionary<String, HanziLearnLog> LearnLog
        {
            get { return new Dictionary<string, HanziLearnLog>(learnDic); }
        }

        /// <summary>
        /// 取得和设置汉字周计划数量
        /// </summary>
        public int HanziWeekPlan
        {
            get { return hanziWeekPlan; }
            set { hanziWeekPlan = value; }
        }

        /// <summary>
        /// 取得本周已完成的汉字数
        /// </summary>
        public int HanziWeekFinished
        {
            get { return hanziWeekFinished; }
        }

        /// <summary>
        /// 取得本周待完成的汉字数
        /// </summary>
        public int HanziWeekPlanRest
        {
            get { return (hanziWeekPlan - hanziWeekFinished < 0? 0 : hanziWeekPlan - hanziWeekFinished); }
        }

        /// <summary>
        /// 检查是否已经完成周计划
        /// </summary>
        public bool IsHanziWeekPlanFinish
        {
            get { return (HanziWeekPlanRest == 0); }
        }

        /// <summary>
        /// 取得和设置计划开始时间
        /// </summary>
        public DateTime PlanStartTime
        {
            get { return planStartTime; }
            set { planStartTime = value; }
        }
        
        /// <summary>
        /// 取得完成的汉字的总数量
        /// </summary>
        public int HanziTotalFinished
        {
            get
            {
                int count = 0;
                foreach (HanziLearnLog log in learnDic.Values)
                {
                    count += log.Count;
                }
                return count;
            }
        }

        /// <summary>
        /// 取得成就对象
        /// </summary>
        public Achievement Achievement
        {
            get { return achievement; }
        }

        public User(String name, String pass)
        {
            this.username = name;
            this.password = pass;
        }

        /// <summary>
        /// 记录一次汉字书写
        /// </summary>
        /// <param name="zi">所写的字</param>
        /// <param name="image">所书写的图像，可以为null</param>
        public void addLearnLog(String zi, Image image)
        {
            hanziWeekFinished++;
            FinishHanzi(this, new AchievementArgs (zi));

            HanziLearnLog log;
            if (!learnDic.ContainsKey(zi))
            {
                log = new HanziLearnLog();
                learnDic.Add(zi, log);
            }
            else log = learnDic[zi];
            log.count++;
            if (image == null) return;
            if (log.pathList.Count >= 5)
            {
                File.Delete(log.pathList[0]);
                log.pathList.RemoveAt(0);
            }
            DateTime now = DateTime.Now;
            String path = String.Format(UserManager.UserDirFormat + "{1}-{2}-{3}-{4}-{5}_{6}_{7}.png", username,
                    zi, now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second);
            image.Save(path);
            log.pathList.Add(path);
        }

        /// <summary>
        /// 如果时间满一周，则重置用户每周完成的字数
        /// 如果不满，则不重置
        /// 登录时调用即可
        /// </summary>
        public void ResetHanziWeekFinished()
        {
            if ((((System.DateTime.Now.Ticks - planStartTime.Ticks) / 10000000) / 604800) > weekCount)
            {
                weekCount = (int)(((System.DateTime.Now.Ticks - planStartTime.Ticks) / 10000000) / 604800);
                hanziWeekFinished = 0;
            }
        }

    }

    [Serializable]
    public class HanziLearnLog
    {
        internal int count = 0;
        internal List<String> pathList = new List<String>();

        public int Count
        {
            get { return count; }
        }

        public List<Image> ImageList
        {
            get
            {
                List<Image> list = new List<Image>();
                foreach (String path in pathList)
                {
                    list.Add(Image.FromFile(path));
                }
                //让最近一次的记录排在最前
                list.Reverse();
                return list;
            }
        }
    }

    public delegate void AchievementHandler(Object sender, AchievementArgs e);

    public class AchievementArgs : EventArgs
    {
        private String zi;

        public String Zi
        {
            get { return zi; }
        }

        public AchievementArgs( String zi )
        {
            this.zi = zi;
        }

    }

}
