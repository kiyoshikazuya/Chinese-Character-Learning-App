using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kanjimusou.Lib;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("test", "test");
            Challenge cha = new Challenge(user);
            user.Achievement.setChallenge(cha);
            cha.NextLevel();
            System.Console.Read();
        }
    }
}
