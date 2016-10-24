using Prism.Unity;
using BPAAS_AutoApp.Views;

namespace BPAAS_AutoApp
{
    public partial class App : PrismApplication
    {
        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync("LoginPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<LoginPage>();
            Container.RegisterTypeForNavigation<SettingsPage>();
            Container.RegisterTypeForNavigation<Customer360Page>();
            Container.RegisterTypeForNavigation<SignInPage>();
        }
    }
}
