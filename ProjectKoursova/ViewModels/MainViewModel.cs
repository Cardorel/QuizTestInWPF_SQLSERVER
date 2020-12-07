using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjectKoursova.ViewModels
{
    class MainViewModel
    {
        private IRegistration registration;

        public MainViewModel(IRegistration r)
        {
            registration = r;
        }

        public IRegistration Registration => registration;
    }
}
