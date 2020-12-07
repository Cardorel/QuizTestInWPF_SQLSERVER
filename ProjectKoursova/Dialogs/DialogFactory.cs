using ProjectKoursova.ViewModels;
using ProjectKoursova.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectKoursova.Dialogs
{
    static class DialogFactory
    {
        public static void ShowAdminDialog(AdminViewModel a)
        {
            var v = new AdminView() { DataContext = a };
            v.ShowDialog();
        }
    }
}
