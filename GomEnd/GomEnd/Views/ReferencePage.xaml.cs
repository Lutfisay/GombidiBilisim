using Acr.UserDialogs;
using GomEnd.Models;
using Plugin.LocalNotifications;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GomEnd.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ReferencePage : ContentPage
	{
        List<Referenceİmage> referencestart= new List<Referenceİmage>();
        List<Referenceİmage> referenceend = new List<Referenceİmage>();
        public ReferencePage ()
		{
			InitializeComponent ();
            ReferenceİmageStart();
            ReferenceİmageEnd();
            ReferenceOne.ItemsSource = referencestart;
            ReferenceTwo.ItemsSource = referenceend;
		    var customActionSheet = new ActionSheetConfig();
		    customActionSheet.Add("Resimleri sağa ve sola kaydırınız..", null);
		    customActionSheet.SetCancel("TAMAM");
            UserDialogs.Instance.ActionSheet(customActionSheet);
            CrossLocalNotifications.Current.Show("BİLGİLENDİRME", "Resimleri sağa ve sola kaydırarak görüntüleyiniz.", 100, DateTime.Now.AddSeconds(3));

        }
        private void ReferenceİmageStart()
        {
            for (int i = 1; i <= 7; i++)
            {
                referencestart.Add(new Referenceİmage
                {
                    RefURLStart = string.Format("http://www.lutficansay.com/ref2/ref{0}.png", i)

                });

            }
        }
        private void ReferenceİmageEnd()
        {
            for (int i = 1; i <= 4; i++)
            {
                referenceend.Add(new Referenceİmage
                {
                    RefURLEnd = string.Format("http://www.lutficansay.com/ref1/ref{0}.jpg", i)

                });

            }
        }

        
    }
}