using Prism.Commands;
using Prism.Mvvm;
using ProjectKoursova.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjectKoursova.ViewModels
{
    class AdminViewModel: BindableBase
    {
        private BindableBase currentViewModal = new StudentViewModel();
        private ICommand changeView;
        private ICommand javascriptView;
        private ICommand javaView;
        private ICommand cplusView;
        private ICommand csharpView;

        public BindableBase ViewModel
        {
            get => currentViewModal;
            private set => SetProperty(ref currentViewModal, value);
        }

        public Registration Username { get; set; }

        public bool IsTeacher { get; set; }


        public ICommand ChangeViewModal
        {
            get => changeView ?? (changeView = new DelegateCommand(() =>
            {
                if (ViewModel is StudentViewModel)
                {
                    if (IsTeacher)
                    {
                        ViewModel = new AdminAddQuestionViewModel();
                    }            
                }
                else
                {
                    ViewModel = new StudentViewModel();
                }
            }));
        }

        public ICommand JavaScriptViewModelCommand
        {
            get
            {
                return javascriptView ?? (javascriptView = new DelegateCommand(() =>
                {
                    ViewModel = new JavaScriptQuizViewModel();
                }));
            }
        }

        [Obsolete]
        public ICommand CSharpViewModelCommand
        {
            get
            {
                return csharpView ?? (csharpView = new DelegateCommand(() =>
                {
                    ViewModel = new CSharpQuizViewModel(Username);
                }));
            }
        }

        public ICommand CPlusViewModelCommand
        {
            get
            {
                return cplusView ?? (cplusView = new DelegateCommand(() =>
                {
                    ViewModel = new CPlusQuizViewModel();
                }));
            }
        }

        public ICommand JavaViewModelCommand
        {
            get
            {
                return javaView ?? (javaView = new DelegateCommand(() =>
                {
                    ViewModel = new JavaQuizViewModel();
                }));
            }
        }

    }
}
