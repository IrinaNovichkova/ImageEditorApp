using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using Lab.Models;

namespace Lab
{
    internal class EditPhotoViewModel : INotifyPropertyChanged, IViewModel
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region IViewModel

        public string Name
        {
            get { return "Edit Photo"; }
        }

        #endregion

        private readonly EditPhotoModel _model = new EditPhotoModel(); 
        private BitmapImage _editedImage;
        private ICommand _readyCommand;

        public BitmapImage EditedImage
        {
            get { return _editedImage; }
            set
            {
                _editedImage = value;
                OnPropertyChanged("EditedImage");
            }
        }

        
        public ObservableCollection<BitmapImage> TemplateExamples
        {
            get { return _model.GetTemplates(); }
        }
    }
}
