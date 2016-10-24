using BPAAS_AutoApp.Models;
using BPAAS_AutoApp.Views;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace BPAAS_AutoApp.Controls
{
    public partial class NavigationPaneControl : ContentView
    {
        public NavigationPaneControl()
        {
            InitializeComponent();

            onInitialized();
        }

        private void onInitialized()
        {
            ObservableCollection<MenuModel> items = new ObservableCollection<MenuModel>();
            TopMenu.ItemsSource = items;
            items.Add(new MenuModel() { Title = "Shop", Icon = "\uf0ad", TargetType = typeof(LoginPage) });
            items.Add(new MenuModel() { Title = "Utilities", Icon = "\uf0ad", TargetType = typeof(LoginPage) });
            items.Add(new MenuModel() { Title = "Settings", Icon = "\uf0ad", TargetType = typeof(LoginPage) });
        }

        public string TopMenuDataSource
        {
            set { TopMenu.ItemsSource = value; }
        }

        public void OnMenuClicked(object sender, EventArgs e)
        {
            if (NavigationMenu.WidthRequest == 48)
            {
                NavigationMenu.Animate(
                    name: "OpenPanel",
                    animation: new Animation(callback: d => NavigationMenu.WidthRequest = d,
                    start: 48,
                    end: 255,
                    easing: Easing.CubicOut
                    )
                    );
            }
            else
            {
                NavigationMenu.Animate(
                    name: "ClosePanel",
                    animation: new Animation(callback: d => NavigationMenu.WidthRequest = d,
                    start: 255,
                    end: 48,
                    easing: Easing.CubicIn
                    )
                    );
            }
        }
    }
}
