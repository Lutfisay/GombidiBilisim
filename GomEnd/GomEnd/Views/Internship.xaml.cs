using Acr.UserDialogs;
using GomEnd.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GomEnd.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GomEnd.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Internship : ContentPage
	{
		public Internship ()
		{
			InitializeComponent ();
		}

	    private async void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
	    {
	        Intern model = new Intern
	        {
	            NameSurname = InName.Text,
	            School = InSc.Text,
	            Chapter = InCha.Text,
	            PhoneNumber = InPhoneN.Text
	        };
	        ServiceManager manager = new ServiceManager();
	        var result = await manager.InsertIntern(model);
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
	}
}