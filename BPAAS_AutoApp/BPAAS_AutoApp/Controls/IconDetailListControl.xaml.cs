using BPAAS_AutoApp.Models;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace BPAAS_AutoApp.Controls
{
    public partial class IconDetailListControl : ContentView
    {
        public IconDetailListControl()
        {
            InitializeComponent();

            onInitialized();
        }

        private void onInitialized()
        {
            ObservableCollection<ListModel> items = new ObservableCollection<ListModel>();
            ItemList.ItemsSource = items;
            items.Add(new ListModel() { Title = "Break Maintenance", Description = "last change yesterday", Icon = "\uf0ad" });
            items.Add(new ListModel() { Title = "Engine Maintenance", Description = "last change last month", Icon = "\uf0ad" });
            items.Add(new ListModel() { Title = "Oil Change Due", Description = "last change today", Icon = "\uf0ad" });
            items.Add(new ListModel() { Title = "Break Maintenance", Description = "last change yesterday", Icon = "\uf0ad" });
            items.Add(new ListModel() { Title = "Engine Maintenance", Description = "last change last month", Icon = "\uf0ad" });
            items.Add(new ListModel() { Title = "Oil Change Due", Description = "last change today", Icon = "\uf0ad" });
            items.Add(new ListModel() { Title = "Break Maintenance", Description = "last change yesterday", Icon = "\uf0ad" });
            items.Add(new ListModel() { Title = "Engine Maintenance", Description = "last change last month", Icon = "\uf0ad" });
            items.Add(new ListModel() { Title = "Oil Change Due", Description = "last change today", Icon = "\uf0ad" });
        }

        public string SwimLaneTitleText
        {
            get { return SwimLaneTitle.Text; }
            set { SwimLaneTitle.Text = value; }
        }

        public string DataSource
        {
            set { ItemList.ItemsSource = value; }
        }
    }
}
