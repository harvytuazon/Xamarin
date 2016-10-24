using BPAAS_AutoApp.Models;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace BPAAS_AutoApp.Controls
{
    public partial class ContactListControl : ContentView
    {
        public ContactListControl()
        {
            InitializeComponent();

            onInitialized();
        }

        private void onInitialized()
        {
            ObservableCollection<PersonModel> items = new ObservableCollection<PersonModel>();
            ItemList.ItemsSource = items;
            items.Add(new PersonModel() { Name = "Liza Soberano", PhoneNumber = "+63 9175434841", Timestamp = "15 days ago", Image = "https://s-media-cache-ak0.pinimg.com/736x/9e/d4/9d/9ed49d114fd99253e582ec9a3a6f4bf3.jpg" });
            items.Add(new PersonModel() { Name = "Jessy Mendiola", PhoneNumber = "+63 9175772364", Timestamp = "2 weeks ago", Image = "http://chisms.net/wp-content/uploads/2015/12/jessycake-loob.jpg" });
            items.Add(new PersonModel() { Name = "Coleen Garcia", PhoneNumber = "+63 9175434841", Timestamp = "3 months ago", Image = "http://chisms.net/wp-content/uploads/2015/09/coleen-school-use.jpg" });
            items.Add(new PersonModel() { Name = "Cristine Reyes", PhoneNumber = "+63 9175434841", Timestamp = "1 year ago", Image = "http://balitangviral.com/wp-content/uploads/2016/01/Cristine-Reyes.jpeg" });
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
