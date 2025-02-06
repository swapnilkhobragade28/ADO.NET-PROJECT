using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creative_Hearts
{
    public class UsernameNotValidException : Exception
    {
        public UsernameNotValidException(string msg):base(msg) { }
    }


}
