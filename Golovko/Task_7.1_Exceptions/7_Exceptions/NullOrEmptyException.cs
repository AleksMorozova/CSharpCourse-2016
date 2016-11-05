using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Exceptions
{
    class NullOrEmptyException : Exception
    {
        public NullOrEmptyException(string message) : base(message)
        {
            this.HelpLink = "https://social.msdn.microsoft.com/Forums/en-US/c1aad16e-b6ca-40d9-b0fb-72ee8b5eca42/stringisnullorempty-and-argumentexception?forum=vstscode";
            this.HResult = 10221;
        }
    }
}
