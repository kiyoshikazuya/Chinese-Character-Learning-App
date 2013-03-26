using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;

namespace Kanjimusou.Lib
{
    public static class UserManager
    {
        public const String Path = "user/";
        //{0}: username
        public const String UserDirFormat = Path + "{0}/";
        public const String ProfilePathFormat = UserDirFormat + "{0}.profile";

        /// <summary>
        /// 以用户名和密码进行登录
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>用户存在且密码正确则返回对应的User对象</returns>
        /// <exception cref="UserException">若登录验证失败</exception>
        public static User Login(String username, String password)
        {
            if (!IsExisted(username)) throw new UserException("用户名不存在");
            User user = LoadFile(username);
            user.ResetHanziWeekFinished();
            if (user.Password == GetMD5(password)) return user;
            else throw new UserException("密码错误");
            /*
            try
            {
                User user = LoadFile(username);
                if (user.Password == GetMD5(password))
                    return true;
                else return false;
            }
            catch (FileNotFoundException)
            {
                return false;
            }
            */
        } 

        /// <summary>
        /// 以用户名和密码注册一个新的用户
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>构建的User对象，若用户名已存在则返回null</returns>
        public static User Register(String username, String password)
        {
            if (!IsExisted(username))
            {
                User user = new User(username, GetMD5(password));
                user.achievement = new Achievement(user);
                SaveFile(user);
                return user;
            }
            else throw new UserException ("用户名已存在");
            
            /*
            User user = new User(username, GetMD5(password));
            try {
                String filepath = path + "/" + username + ".xml";
                FileStream fs = new FileStream(filepath, FileMode.Open);
                fs.Close();
            }
            catch ( FileNotFoundException )
            {
                SaveFile(user);
                return true;
            }
            return false;
            */
        }

        /// <summary>
        /// 保存用户数据
        /// </summary>
        /// <param name="user">要保存的User对象</param>
        public static void SaveFile(User user)
        {
            if (!Directory.Exists(String.Format(UserDirFormat, user.Username)))
                Directory.CreateDirectory(Path + user.Username);
            String filepath = String.Format(ProfilePathFormat, user.Username);
            FileStream fs = new FileStream(filepath,FileMode.OpenOrCreate);
            BinaryFormatter bp = new BinaryFormatter();
            bp.Serialize(fs, user);
            fs.Close();
        }

        private static User LoadFile(String username)
        {
            String filepath = String.Format(ProfilePathFormat, username);
            FileStream fs = new FileStream(filepath, FileMode.Open);
            BinaryFormatter bp = new BinaryFormatter();
            User ret;
            ret = bp.Deserialize(fs) as User;
            fs.Close();
            return ret;
        }

        public static bool IsExisted(String username)
        {
            return File.Exists(String.Format(ProfilePathFormat, username));
            /*
            try
            {
                String filepath = path + "/" + username + ".xml";
                FileStream fs = new FileStream(filepath, FileMode.Open);
                fs.Close();
                return true;
            }
            catch ( FileNotFoundException )
            {
                return false;
            }
            */
        }

        public static void Delete( String username )
        {
            String filepath = String.Format(ProfilePathFormat, username);
            File.Delete(filepath);
        }

        public static String GetMD5(String source)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] ret = md5.ComputeHash(System.Text.Encoding.Default.GetBytes(source));
            return System.Text.Encoding.Default.GetString(ret);
        }
    }
}
