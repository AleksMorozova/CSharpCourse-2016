using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {            
            ExceptionHandler.TryFilterCatch(
                TestMethod, 
                ExceptionHandler.NotFatal, 
                e => Log.Write(e.FullMessage()));
            
            Console.ReadKey();
        }
        static void TestMethod()
        {
            string p = string.Empty;
            if (string.IsNullOrEmpty(p))
            {
                throw new NullOrEmptyException("The value of argument is null or empty. Check the argumen value.");
            }
        }
    }
}
