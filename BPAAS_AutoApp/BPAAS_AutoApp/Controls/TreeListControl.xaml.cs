using BPAAS_AutoApp.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace BPAAS_AutoApp.Controls
{
    public partial class TreeListControl : ContentView
    {
        public TreeListControl()
        {
            InitializeComponent();

            onInitialized();
        }

        private void onInitialized()
        {
            AddParent("Testing", false);
            AddChild("Testing", false);
            AddChild("Testing", false);
            AddParent("Testing", false);
            AddChild("Testing", false);
            AddChild("Testing", false);
            AddChild("Testing", false);
            AddChild("Testing", false);
            AddParent("Testing", false);
            AddChild("Testing", false);

            //ObservableCollection<TreeModel> items = new ObservableCollection<TreeModel>();
            //ObservableCollection<SubTreeModel> subitems = new ObservableCollection<SubTreeModel>();
            //subitems.Add(new SubTreeModel() { Title = "Testing", Checked = false });
            //subitems.Add(new SubTreeModel() { Title = "Testing", Checked = false });
            //subitems.Add(new SubTreeModel() { Title = "Testing", Checked = false });
            //ItemList.ItemsSource = items;

            //items.Add(new TreeModel() { Name = "Testing", Checked = false, Items = subitems });
            //items.Add(new TreeModel() { Name = "Testing", Checked = false, Items = subitems });
            //items.Add(new TreeModel() { Name = "Testing", Checked = false, Items = subitems });
        }

        public string SwimLaneTitleText
        {
            get { return SwimLaneTitle.Text; }
            set { SwimLaneTitle.Text = value; }
        }

        //public string DataSource
        //{
        //    set { ItemList.ItemsSource = value; }
        //}

        private void AddParent(string text, bool check)
        {
            Grid parent = new Grid
            {
                BackgroundColor = Color.White,
                HeightRequest = 30,
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(25, GridUnitType.Absolute) },
                    new ColumnDefinition { Width = new GridLength(40, GridUnitType.Absolute) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                }
            };

            parent.Children.Add(
                new Label
                {
                    Text = "\uf067",
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                    TextColor = Color.Black,
                    FontSize = 14,
                    FontFamily = "/Assets/Fonts/fontawesome-webfont.ttf#fontawesome-webfont"
                } ,0, 0
            );

            parent.Children.Add(
                new Label
                {
                    Text = text,
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Start,
                    TextColor = Color.Black,
                    FontSize = 14,
                    FontFamily = "/Assets/Fonts/MetricWeb-Medium.ttf#Metric Web"
                }, 2, 0
            );

            StackLayout block = new StackLayout
            {
                Padding = 2,
                Children = {
                    parent
                }
            };

            Content.Children.Add(block);
        }

        private void AddChild(string text, bool check)
        {
            Grid parent = new Grid
            {
                BackgroundColor = Color.White,
                Margin = new Thickness(25,0,10,0),
                HeightRequest = 30,
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(40, GridUnitType.Absolute) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                }
            };

            parent.Children.Add(
                new Label
                {
                    Text = text,
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Start,
                    TextColor = Color.Black,
                    FontSize = 13,
                    FontFamily = "/Assets/Fonts/MetricWeb-Medium.ttf#Metric Web"
                }, 1, 0
            );

            StackLayout block = new StackLayout
            {
                Padding = 0,
                Children = {
                    parent
                }
            };

            Content.Children.Add(block);
        }
    }
}
