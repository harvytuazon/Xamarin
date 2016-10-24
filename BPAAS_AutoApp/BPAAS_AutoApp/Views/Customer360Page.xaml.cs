using Xamarin.Forms;

namespace BPAAS_AutoApp.Views
{
    public partial class Customer360Page : ContentPage
    {
        private double width = 0;
        private double height = 0;
        public Customer360Page()
        {
            InitializeComponent();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            if (width != this.width || height != this.height)
            {
                this.width = width;
                this.height = height;

                if (width < 1300)
                {
                    ScrollBase.Orientation = ScrollOrientation.Vertical;
                    StackBase.Orientation = StackOrientation.Vertical;

                }
                else
                {
                    ScrollBase.Orientation = ScrollOrientation.Horizontal;
                    StackBase.Orientation = StackOrientation.Horizontal;
                }
            }
        }
    }
}
