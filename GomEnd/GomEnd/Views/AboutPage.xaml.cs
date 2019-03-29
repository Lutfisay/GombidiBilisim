using GomEnd.Models;
using Plugin.LocalNotifications;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Acr.UserDialogs;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GomEnd.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AboutPage : ContentPage
	{
        List<ViewSlider> slider = new List<ViewSlider>();
        public AboutPage ()
		{
			InitializeComponent ();
            CV.ItemsSource = slider;
            GenerateSampleData();
		    var customActionSheet = new ActionSheetConfig();
		    customActionSheet.Add("Resimleri sağa ve sola kaydırınız..", null);
		    customActionSheet.SetCancel("TAMAM");
            UserDialogs.Instance.ActionSheet(customActionSheet);
            //UserDialogs.Instance.AlertAsync("Internet Connection Required", "Please establish an internet connection and try again!", "Okay");
            CrossLocalNotifications.Current.Show("Gombidi Bilişim", "Hoşgeldiniz..",100,DateTime.Now.AddSeconds(3));
        }
        

        private void GenerateSampleData()
        {
                //await Task.Delay(2000);
                for (int i = 1; i <= 3; i++)
                {
                    slider.Add(new ViewSlider
                    {
                        Url = string.Format("http://www.lutficansay.com/res/res{0}.jpg", i)

                    });

                }   
        }
        void Handle_ValueChanged(object sender, SegmentedControl.FormsPlugin.Abstractions.ValueChangedEventArgs e)
        {
            switch (e.NewValue)
            {
                case 0:
                    SegContent.Children.Clear();
                    SegContent.Children.Add(new Label()
                    {
                        FontSize = 15,
                        Text = "Gombidi Bilişim olarak, bilişim sektöründe hayallerini kolaylıkla gerçekleştirebilen, ticari, toplumsal yada kişisel bir çok ihtiyaca sektörel çözümler getirebilen bir firma olma hedefindeyiz. Bu hedefimize tam anlamı ile ulaşabilmemizin maddi güçten daha çok takım çalışması ile olacağını farkındayız. Bu yüzden öğrendiğimiz ve geliştirdiğimiz tüm birikimimizi sektördeki yeni beyinlere aktarmakta vizyonumuzun bir parçasıdır. Kısacası firma ismimizi büyütmekten daha çok istediğimiz tek şey bilginin paylaşılabilirliğini arttırarak, yeni nesile daha erişilebilir bilgi çağı sunmak."
                        
                    });
                    break;
                case 1:
                    SegContent.Children.Clear();
                    SegContent.Children.Add(new Label()
                    {
                        FontSize = 15,
                        Text = "Hedeflerimiz doğrultusunda açtığımız firmamız ile şu anda birden fazla sektöre farklı çözümler sunmaktayız. Mobil, Web, Masaüstü, Sunucu Tabanlı bir çok platformda farklı dillerde yazılım geliştirmekteyiz. Bu gelişimi, daha önce yanımızda eğitim görüp şu anda bize sektörel çözümlerde destek olan takım arkadaşlarımıza borçluyuz.Aktif olarak 2015’den bugüne “Hayalleri, Sanallaştıran Fikirler” sloganımız ile hedefimize giden yolda tam gaz ilerlemeye devam ediyoruz. "

                    });
                    break;
                case 2:
                    SegContent.Children.Clear();
                    SegContent.Children.Add(new Label()
                    {
                        FontSize = 15,
                        Text = "Kuruluşumuz, elde ettiği maddi kazancın büyük bir kısmını yine vizyon sermayesine harcamakta. Bu aşamada sağlanacak istihdam, bilgi birikimi, reklam ve benzeri kavramlar uzun vadede kendini çeviren bir çark sistemi oluşturacak. Bu sayede firmanın büyümesi için farklı sektörlere ve amaçlara ihtiyacı kalmayacak.Bilişim sektöründe maliyetin büyük bir kısmı bilgi hazinesine gitmektedir. Diğer sektörlerde harcanan sermaye masrafları düşünüldüğünde sürekli geliştiribilen bir beyne yatırım yapmak kesinlikle kayıp değildir."
                    });
                    break;
            }
        }
        
        private void ReferansGesture_Tapped(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushModalAsync(new ReferencePage());
        }
    }
}