using System;
using Xamarin.Forms;

namespace BPAAS_AutoApp.Controls
{
    public partial class ContactInfoControl : ContentView
    {
        public ContactInfoControl()
        {
            InitializeComponent();

            expandCollapseButton.Clicked += OnExpandCollapse;
        }

        public string SwimLaneTitleText
        {
            get { return SwimLaneTitle.Text; }
            set { SwimLaneTitle.Text = value; }
        }

        public bool Collapsed
        {
            get
            {
                return moreInfoBase.IsVisible;
            }
            set
            {
                ExpandCollapse(value);
            }
        }

        private void OnExpandCollapse(object sender, EventArgs e)
        {
            ExpandCollapse(moreInfoBase.IsVisible);
        }

        private async void ExpandCollapse(bool value)
        {
            if (value)
            {
                expandCollapseButton.Text = "\uf078";
                await moreInfoPanel.TranslateTo(0, -moreInfoPanel.Height, 250, Easing.CubicOut);
                moreInfoBase.IsVisible = false;
            }
            else
            {
                expandCollapseButton.Text = "\uf077";
                moreInfoBase.IsVisible = true;
                await moreInfoPanel.TranslateTo(0, 0, 250, Easing.CubicIn);
            }
        }
    }
}
