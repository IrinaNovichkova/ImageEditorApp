using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class LogInModel : INotifyPropertyChanged
    {
        private MainPageModel _parentModel;
        public LogInModel(MainPageModel parentModel)
        {
            _parentModel = parentModel;
        }

        #region auth
        private EAuthenticationStatus _status;
        public EAuthenticationStatus Status
        {
            get { return _status;}
            private set
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }


        public void Authenticate(string login, SecureString password)
        {
            Status = _parentModel.LabService.Authenticate(login, password);
        }
        #endregion

        public void Register(string login, SecureString password)
        {
            Status = _parentModel.RegistrationService.Register(login, password);
        }


        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
#endregion

    }
}
