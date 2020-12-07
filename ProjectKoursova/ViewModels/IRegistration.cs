using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectKoursova.Models;

namespace ProjectKoursova.ViewModels
{
    interface IRegistration
    {
        ObservableCollection<Registration> Registrations { get; }
    }
}
