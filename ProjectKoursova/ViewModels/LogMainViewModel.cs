using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjectKoursova.ViewModels
{
    class LogMainViewModel : BindableBase
    {
        //    private BindableBase currentViewModal = new SignOutViewModel();
        //    private ICommand changeView;

        //    public LogMainViewModel()
        //    {

        //    }


        //    public BindableBase ViewModal
        //    {
        //        get => currentViewModal;
        //        private set => SetProperty(ref currentViewModal, value);
        //    }

        //    public ICommand ChangeViewModal
        //    {
        //        get => changeView ?? (changeView = new DelegateCommand(() =>
        //        {
        //            if (ViewModal is SignOutViewModel)
        //            {
        //                ViewModal = new RegistrationViewModel();
        //            }
        //            else
        //            {
        //                ViewModal = new SignOutViewModel();
        //            }
        //        }));
        //    }

        //    public ObservableCollection<RegistrationViewModel> registrationViews => new ObservableCollection<RegistrationViewModel>();

        //    public ObservableCollection<SignOutViewModel> signOutViews => new ObservableCollection<SignOutViewModel>();
        //}
    }
}
