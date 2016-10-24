using BPAAS_AutoApp.Models;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace BPAAS_AutoApp.Controls
{
    public partial class AltImageDetailListControl : ContentView
    {
        public AltImageDetailListControl()
        {
            InitializeComponent();

            onInitialized();
        }

        private void onInitialized()
        {
            ObservableCollection<AlternateListModel> vehicles = new ObservableCollection<AlternateListModel>();
            ItemList.ItemsSource = vehicles;
            vehicles.Add(new AlternateListModel() { Title = "Sentra SL", Description = "2013.3", Date = "12 July 2016", Image = "http://cdn.epictimes.com/boblong/wp-content/uploads/sites/7/2014/10/2014_nissan_sentra_012-960x590.jpg" });
            vehicles.Add(new AlternateListModel() { Title = "Beetle A5", Description = "173.9", Date = "15 August 2015", Image = "http://regmedia.co.uk/2012/10/29/volkswagen_beetle_7.jpg" });
            vehicles.Add(new AlternateListModel() { Title = "Mercedez-Benz A45", Description = "2578.1", Date = "9 Dec 2014", Image = "http://resources.carsguide.com.au/dp/images/uploads/MercedesA45AMG-W.jpg" });
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
