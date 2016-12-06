using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Common
{
    class NotificationMessageAction<TMessage>
    {
        public TMessage Message { get; private set; }
        public Action Action { get; private set; }

        public NotificationMessageAction(TMessage message, Action action)
        {
            Action = action;
            Message = message;
        }
    }

    class NotificationMessageAction<TMessage, TArg>
    {
        public TMessage Message { get; private set; }
        public Action<TArg> Action { get; private set; }

        public NotificationMessageAction(TMessage message, Action<TArg> action)
        {
            Action = action;
            Message = message;
        }
    }
}
