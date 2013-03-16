using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
using System.Security.Cryptography;

namespace Kanjimusou.Lib
{
    public class UserManager
    {

        private String path;

        public UserManager( String path )
        {
            this.path = path;
        }

        public bool Login(String username, String password)
        {
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
        } 

        /// <summary>
        /// 以用户名和密码注册一个新的用户
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>构建的User对象，若用户名已存在则返回null</returns>
        public User Register( String username, String password )
        {
            if (!IsExisted(username))
            {
                User user = new User(username, GetMD5(password));
                SaveFile(user);
                return user;
            }
            else return null;
            
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

        public void SaveFile( User user )
        {
            String filepath = path + "/" + user.Username + ".xml";
            FileStream fs = new FileStream(filepath,FileMode.OpenOrCreate);
            SoapFormatter sp = new SoapFormatter();
            sp.Serialize(fs, user);
            fs.Close();
        }

        public User LoadFile( String username )
        {
            String filepath = path + "/" + username + ".xml";
            FileStream fs = new FileStream(filepath, FileMode.Open);
            SoapFormatter sp = new SoapFormatter();
            User ret;
            ret = sp.Deserialize(fs) as User;
            fs.Close();
            return ret;
        }

        public bool IsExisted(String username)
        {
            return File.Exists(path + "/" + username + ".xml");
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

        public void Delete( String username )
        {
            String filepath = path + "/" + username + ".xml";
            File.Delete(filepath);
        }

        public String GetMD5(String source)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] ret = md5.ComputeHash(System.Text.Encoding.Default.GetBytes(source));
            return System.Text.Encoding.Default.GetString(ret);
        }

    }
}
