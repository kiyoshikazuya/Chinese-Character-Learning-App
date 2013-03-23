using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kanjimusou.Lib
{
    public class UserException: Exception
    {
        public UserException()
            : base()
        {
        }

        public UserException(String msg)
            : base(msg)
        {
        }

        public UserException(String msg, Exception ex)
            : base(msg, ex)
        {
        }
    }
}
