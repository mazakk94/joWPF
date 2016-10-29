using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace UserInterface
{
    public class UIWindowDialogService : IUIWindowDialogService
    {
        public bool? ShowDialog(string title, object datacontext)
        {
            var win = new Windows.Editor.Dialogs.Create();
            win.Title = title;
            win.DataContext = datacontext;

            return win.ShowDialog();
        }

    }
}