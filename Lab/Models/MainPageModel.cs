using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.LabServiceReference;
using Lab.Models;

namespace Lab
{
    class MainPageModel : INotifyPropertyChanged
    {
        public CRegistrationServiceConnection RegistrationService { get; }
        public CLabServiceConnection LabService { get; }

        public MainPageModel()
        {
            RegistrationService = new CRegistrationServiceConnection();
            LabService = new CLabServiceConnection();
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
