using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GomEnd.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactPage : ContentPage
	{
		public ContactPage ()
		{
			InitializeComponent ();
		}
        private void WorkForward_Tap(object sender, EventArgs e)
        {
           Application.Current.MainPage.Navigation.PushModalAsync(new WorkPage());
            //Application.Current.MainPage.DisplayAlert("ssss", "aaaa", "aaaaa");
        }
        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushModalAsync(new MapPage());
        }
        private void TapCall_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("tel:05532631111"));
        }

	    private void Cell_OnTapped(object sender, EventArgs e)
	    {
	        Application.Current.MainPage.Navigation.PushModalAsync(new Internship());
        }
	}
}