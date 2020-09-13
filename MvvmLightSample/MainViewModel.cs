using CommonServiceLocator;
using GalaSoft.MvvmLight;
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
    public class MainViewModel : ViewModelBase
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { Set(ref title, value); }
        }

        public ICommand ChangeTitleCommand { get; set; }

        public ICommand GotoNextCommand { get; set; }

        public MainViewModel()
        {
            Title = "Hello World";
            ChangeTitleCommand = new RelayCommand(ChangeTitle);
            GotoNextCommand = new RelayCommand(GotoNext);
        }

        private void GotoNext()
        {
            var navigationService = ServiceLocator.Current.GetInstance<INavigationService>();
            navigationService.NavigateTo("PageTwo");
        }

        private void ChangeTitle()
        {
            Title = "Hello MvvmLight";
        }
    }
}
