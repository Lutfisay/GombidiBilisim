
using System;
using System.Threading.Tasks;
using Acr.UserDialogs;
using GomEnd.Models;
using GomEnd.Provider;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GomEnd.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WorkPage : ContentPage
	{
        
		public WorkPage ()
		{
			InitializeComponent ();
		}

	    private async void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
	    {
	        Company model = new Company
	        {
	            Name = ComName.Text,
	            Sector = ComSec.Text,
	            AuthorizedPerson = ComAuth.Text,
	            PhoneNumber = ComPhone.Text
	        };
            ServiceManager manager = new ServiceManager();
	        var result = await manager.InsertCompany(model);
	        UserDialogs.Instance.ShowLoading("Başvurunuz Gönderiliyor..");
            if (result == result)
            {
                await Task.Delay(5000);
                UserDialogs.Instance.HideLoading();
                DisplayAlert("Bilgilendirme", "Başvurunuz Alınmıştır.", "TAMAM");
	            Navigation.PopModalAsync();
	        }
	        else
	        {
	            DisplayAlert("Bilgilendirme", "Hatalı İşlem.", "TAMAM");
	        }
        }

	    //private async void FrameTapGestureRecognizer_OnTapped(object sender, EventArgs e)
	    //{
	    //   await Frm.ScaleTo(0.95, 100, Easing.BounceIn);
	    //   await Frm.ScaleTo(1, 50, Easing.CubicIn);
	    //   await Frm.ScaleTo(0.95, 100, Easing.CubicOut);
     //   }
	}
}