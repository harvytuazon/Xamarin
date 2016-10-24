using BPAAS_AutoApp.Models;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace BPAAS_AutoApp.Controls
{
    public partial class ImageDetailListControl : ContentView
    {
        public ImageDetailListControl()
        {
            InitializeComponent();

            onInitialized();
        }

        private void onInitialized()
        {
            ObservableCollection<VehicleModel> vehicles = new ObservableCollection<VehicleModel>();
            ItemList.ItemsSource = vehicles;
            vehicles.Add(new VehicleModel() { Color = Color.FromHex("#614767"), Name = "Sentra SL", Model = "NSO-543233-2", Type = "Sedan", Image = "http://cdn.epictimes.com/boblong/wp-content/uploads/sites/7/2014/10/2014_nissan_sentra_012-960x590.jpg" });
            vehicles.Add(new VehicleModel() { Color = Color.FromHex("#FF8D6D"), Name = "Beetle A5", Model = "VSO5002321-1", Type = "Sub-compact Car", Image = "http://regmedia.co.uk/2012/10/29/volkswagen_beetle_7.jpg" });
            vehicles.Add(new VehicleModel() { Color = Color.FromHex("#2AD2C9"), Name = "Mercedez-Benz A45", Model = "NZ34563-22", Type = "SUV", Image = "http://resources.carsguide.com.au/dp/images/uploads/MercedesA45AMG-W.jpg" });
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
