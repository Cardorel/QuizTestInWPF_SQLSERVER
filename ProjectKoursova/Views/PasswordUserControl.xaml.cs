﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjectKoursova.Views
{
    /// <summary>
    /// Interaction logic for PasswordUserControl.xaml
    /// </summary>
    public partial class PasswordUserControl : UserControl
    {
        public PasswordUserControl()
        {
            InitializeComponent();
            pwdBox.PasswordChanged += (sender, args) => {
                Password = ((PasswordBox)sender).SecurePassword;
            };
        }


        public SecureString Password
        {
            get { return (SecureString)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }
        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password", typeof(SecureString), typeof(PasswordUserControl),
                new PropertyMetadata(default(SecureString)));
    }
}
