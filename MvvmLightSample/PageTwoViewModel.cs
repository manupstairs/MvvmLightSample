using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MvvmLightSample
{
    public class PageTwoViewModel
    {
        private INavigationService _navigationService;

        public ICommand GoBackCommand { get; set; }

        public PageTwoViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            GoBackCommand = new RelayCommand(() => { _navigationService.GoBack(); });
        }
    }
}
