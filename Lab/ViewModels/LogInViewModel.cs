using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Windows.Input;
using Lab.Models;

namespace Lab
{
    class LogInViewModel : INotifyPropertyChanged, IViewModel
    {
        #region IViewModel

        public string Name
        {
            get { return "Log In"; }
        }

        #endregion

        private MainPageViewModel _parentViewModel;
        private readonly LogInModel _model;
        private String _login;
        private SecureString _password;
        private EAuthenticationStatus _authenticationStatus;
        private ICommand _registerCommand;
        private ICommand _logInCommand;

        public LogInViewModel(MainPageModel parentModel, MainPageViewModel parentViewModel)
        {
            _model = new LogInModel(parentModel);
            _parentViewModel = parentViewModel;
            _model.PropertyChanged += (s, e) => OnPropertyChanged(e.PropertyName);
        }

        public String Login
        {
            set
            {
                _login = value;
            }
        }

        public SecureString Password
        {
            set { _password = value; }
        }

        public EAuthenticationStatus LoggedIn
        {
            get { return _authenticationStatus; }
        }

        public ICommand RegisterCommand
        {
            get
            {
                if (_registerCommand == null)
                {
                    _registerCommand = new RelayCommand(
                        obj => CanLogIn(),
                        obj => _model.Register(_login, _password)
                        );
                }
                return _registerCommand;
            }
        }
  
        public ICommand LogInCommand
        {
            get
            {
                if (_logInCommand == null)
                {
                    _logInCommand = new RelayCommand(
                        obj => CanLogIn(),
                        obj => _model.Authenticate(_login, _password)
                    );
                }

                return _logInCommand;
            }
        }

        private Boolean CanLogIn()
        {
            return SValidator.HasCredentials(_login, _password);
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
