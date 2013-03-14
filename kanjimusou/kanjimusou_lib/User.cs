using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kanjimusou.Lib
{

    [Serializable]
    public class User
    {
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

        public User(String name, String pass)
        {
            this.username = name;
            this.password = pass;
        }

    }
}
