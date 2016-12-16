using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MessageMVVM
{
    class MainWindowViewModel
    {
        RelayCommand openWindowCommand;

        public ICommand OpenWindowCommand
        {
            get
            {
                if (openWindowCommand == null)
                    openWindowCommand = new RelayCommand(OpenWindowCommandExecute);
                return openWindowCommand;
            }
        }

        private void OpenWindowCommandExecute(object obj)
        {
            Messenger.Default.Send<Message, string>(Message.ShowNewWindow, "Супер секретные данные =)");
        }
    }
}
