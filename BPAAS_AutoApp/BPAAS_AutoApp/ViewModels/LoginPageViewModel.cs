using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Navigation;

namespace BPAAS_AutoApp.ViewModels
{
    public class LoginPageViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;
        public DelegateCommand SettingsCommand { get; private set; }
        public DelegateCommand OnlineCommand { get; private set; }
        public DelegateCommand OfflineCommand { get; private set; }
        public LoginPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            SettingsCommand = new DelegateCommand(onSettingsButtonClick);
            OnlineCommand = new DelegateCommand(onOnlineButtonClick);
            OfflineCommand = new DelegateCommand(onOfflineButtonClick);
        }

        private void onSettingsButtonClick()
        {
            _navigationService.NavigateAsync("SettingsPage");
        }

        private void onOnlineButtonClick()
        {
            _navigationService.NavigateAsync("Customer360Page");
        }

        private void onOfflineButtonClick()
        {
            _navigationService.NavigateAsync("Customer360Page");
        }
    }
}
