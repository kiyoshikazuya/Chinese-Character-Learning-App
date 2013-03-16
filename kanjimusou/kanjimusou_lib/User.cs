using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Security.Cryptography;

namespace Kanjimusou.Lib
{
    /*
     * TODO:
     * 已学习的汉字，保存最近的几次所书写的汉字，每个汉字书写过的次数
     * 学习计划，学习进度
     * 统计信息
     * 
     */
    [Serializable]
    public class User
    {
        private Dictionary<String, HanziLearnLog> learnDic = new Dictionary<String, HanziLearnLog>();

        private String username;

        public String Username
        {
            get { return username; }
            set { username = value; }
        }

        private String password;

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public Dictionary<String, HanziLearnLog> LearnLog
        {
            get { return new Dictionary<string, HanziLearnLog>(learnDic); }
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
                log.pathList.RemoveAt(0);
            }
            DateTime now = DateTime.Now;
            String path = String.Format(UserManager.UserDirFormat + "{1}-{2}-{3}_{4}_{5}.bmp", username,
                    zi, now.ToShortDateString(), now.Hour, now.Minute, now.Second);
            image.Save(path);
            log.pathList.Add(path);
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
}
