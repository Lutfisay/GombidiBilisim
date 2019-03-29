using GomEnd.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GomEnd
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            var page = new AboutPage();
            PlaceHolder.Content = page.Content;      // Home Page //

        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var page = new AboutPage();
            PlaceHolder.Content = page.Content;
        }
        private void TapGesture2(object sender, EventArgs e)
        {
            var page = new EmployeePage();
            PlaceHolder.Content = page.Content;
        }
        private void TapGesture3(object sender, EventArgs e)
        {
            var page = new ContactPage();
            PlaceHolder.Content = page.Content;
        }
    }
}
