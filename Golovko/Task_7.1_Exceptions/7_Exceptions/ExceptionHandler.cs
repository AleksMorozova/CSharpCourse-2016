using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Exceptions
{
    static class ExceptionHandler
    {
        private static readonly List<Type> fatallExceptions;
        static ExceptionHandler()
        {
            fatallExceptions = new List<Type>
            {
                typeof(OutOfMemoryException),
                typeof(StackOverflowException)
            };
        }
        public static string FullMessage(this Exception e)
        {
            StringBuilder messageBuilder = new StringBuilder();
            while (e != null)
            {
                messageBuilder.AppendFormat("{0}\n", e);
                e = e.InnerException;
            }
            return messageBuilder.ToString();
        }
        public static void TryFilterCatch(Action action, Func<Exception, bool> isRecoverPossible, Action handlerAction)
        {
            try
            {
                action();
            }
            catch (Exception e)
            {
                if (!isRecoverPossible(e))
                {
                    throw;
                }
                handlerAction();
            }
        }
        public static void TryFilterCatch(Action action, Func<Exception, bool> isRecoverPossible, Action<Exception> handlerAction)
        {
            try
            {
                action();
            }
            catch (Exception e)
            {
                if (!isRecoverPossible(e))
                {
                    throw;
                }
                handlerAction(e);
            }
        }
        public static bool NotFatal(this Exception e)
        {
            return fatallExceptions.All(fatal => fatal != e.GetType());
        }
        public static bool IsFatal(this Exception e)
        {
            return !NotFatal(e);
        }
    }
}
