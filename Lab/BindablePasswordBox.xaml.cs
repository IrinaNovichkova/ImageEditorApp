using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace Lab
{
    public partial class BindablePasswordBox : UserControl
    { 
        public BindablePasswordBox()
        {
            InitializeComponent();
        }

        static BindablePasswordBox()
        {
            FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault);
            SecurePasswordProperty = DependencyProperty.Register(
                "SecurePassword", typeof(SecureString), typeof(BindablePasswordBox), metadata);
        }

        public static readonly  DependencyProperty SecurePasswordProperty;

        public SecureString SecurePassword
        {
            get { return (SecureString)GetValue(SecurePasswordProperty); }
            set { SetValue(SecurePasswordProperty, value); } 
        }


        private void PasswordBox_OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            SecurePassword = ((PasswordBox) sender).SecurePassword;
        }

        //private static void SecurePasswordPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        //{
        //    ((BindablePasswordBox)d).SecurePasswordPropertyChanged((SecureString)e.NewValue);
        //}

        //private void SecurePasswordPropertyChanged(SecureString password)
        //{
        //    SecurePassword = password;
        //}
    }
}
