using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lab
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        private MainPageModel _model = new MainPageModel();
        private List<IViewModel> _pageViewModels;
        private IViewModel _currentPageViewModel;
        private ICommand _changePageCommand;


        public MainPageViewModel()
        {
            PageViewModels.Add(new LogInViewModel(_model, this));
            PageViewModels.Add(new FeedViewModel());
            PageViewModels.Add(new UserPageViewModel());
            PageViewModels.Add(new PostViewModel());
            PageViewModels.Add(new EditPhotoViewModel());

            _currentPageViewModel = _pageViewModels[0];
        }

        public List<IViewModel> PageViewModels
        {
            get
            {
                if (_pageViewModels == null)
                    _pageViewModels = new List<IViewModel>();
                return _pageViewModels;

            }
        }

        public IViewModel CurrentPageViewModel
        {
            get { return _currentPageViewModel; }
            set
            {
                if (_currentPageViewModel != value)
                {
                    _currentPageViewModel = value;
                    OnPropertyChanged("CurrentPageViewModel");
                }
            }
        }

        public ICommand ChangePageCommand
        {
            get
            {
                if (_changePageCommand == null)
                {
                    _changePageCommand = new RelayCommand(
                        p => p is IViewModel,
                        p => ChangeViewModel((IViewModel)p));
                }

                return _changePageCommand;
            }
        }


        private void ChangeViewModel(IViewModel viewModel)
        {
            if (!_pageViewModels.Contains(viewModel))
                _pageViewModels.Add(viewModel);
            CurrentPageViewModel = PageViewModels.FirstOrDefault(vm => vm == viewModel);
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
