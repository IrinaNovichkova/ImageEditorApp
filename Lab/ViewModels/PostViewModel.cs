using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Lab.Models;

namespace Lab
{
    class PostViewModel : INotifyPropertyChanged, IViewModel
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region IViewModel

        public string Name
        {
            get { return "Post"; }
        }

        #endregion

        private PostModel _model = new PostModel();
        public BitmapImage Image { get;}

        //public ObservableCollection<CComment> Comments
        //{
        //    get { return _model.GetComments(); }
        //}
    }
}
