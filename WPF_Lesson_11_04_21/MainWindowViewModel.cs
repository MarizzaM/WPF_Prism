using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WPF_Lesson_11_04_21
{

    public class MainWindowViewModel
    {
        bool flag = true;
        public DelegateCommand DelegateCommand1 { get; set; }
        public DelegateCommand DelegateCommand2 { get; set; }

        public MainWindowViewModel()
        {

            DelegateCommand1 = new DelegateCommand(
            () => DelegateCommand2.RaiseCanExecuteChanged());

            DelegateCommand2 = new DelegateCommand(
                () => MessageBox.Show("delegate command"),
                () =>
                {
                    flag = !flag;
                    return flag;
                });

        }


    }
}
