using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace GomEnd.Views
{
    public class MapPage : ContentPage
    {
        public MapPage()
        {
            CreateMap();
        }
        void CreateMap()
        {
            Map currentMap = new Map
            {
                HasScrollEnabled = true,
                HasZoomEnabled = true,
                MapType = MapType.Street,
            };
            Pin gomPin = new Pin
            {
                Type = PinType.Place,
                Address = "Gombidi Bilişim",
                Label = "Entegrasyon,Yazılım,E-Ticaret",
                Position = new Position(36.9095713, 30.6793193),
            };
            currentMap.Pins.Add(gomPin);
            currentMap.MoveToRegion(MapSpan.FromCenterAndRadius(
                new Position(36.9095713, 30.6793193), Distance.FromMeters(100)));
            Content = currentMap;
        }
    }
}
