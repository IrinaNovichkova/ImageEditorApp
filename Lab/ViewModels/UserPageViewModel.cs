using System.ComponentModel;
using System.Runtime.CompilerServices;
using Lab.Models;

namespace Lab
{
    class UserPageViewModel : INotifyPropertyChanged, IViewModel
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region IViewModel

        public string Name
        {
            get { return "User Page"; }
        }

        #endregion

        private UserPageModel _model = new UserPageModel();

        //public ObservableCollection<CPost> Posts
        //{
        //    get { return _model.GetPosts(); }
        //}
    }
}
