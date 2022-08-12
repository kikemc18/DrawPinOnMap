using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Devices.Geolocation;
using Windows.UI.Xaml.Controls.Maps;
using System.Collections.ObjectModel;
using Windows.Storage.Streams;
using System.Drawing;
using ImageMagick;
using Image = System.Drawing.Image;
using Windows.UI.Xaml.Media.Imaging;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PinMapa
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        MapElementsLayer myLayer1;
        IList<MapLayer> myLayers = new ObservableCollection<MapLayer>();
        public MainPage()
        {
            this.InitializeComponent();
           
        }

        private void myMap_Loaded(object sender, RoutedEventArgs e)
        {         
            myMap.Center = MainPage.SeattleGeopoint;
            myMap.ZoomLevel = 12;      
            AddLayer1();
            
            myMap.Layers = this.myLayers;          
        }

        private void AddLayer1()
        {
            this.myLayer1 = new MapElementsLayer();
            this.myLayer1.MapElements = CreateCityBuildingsCollection();
            this.myLayers.Add(this.myLayer1);         
        }
     
        public static readonly Geopoint SeattleGeopoint = new Geopoint(new BasicGeoposition() { Latitude = 19.018567, Longitude = -98.265844 });
        public static List<MapElement> CreateCityBuildingsCollection()
        {
            string Estado = "Disponible";
            string ColorPin = "Rojo";
            string ImageName = "";
            bool FueraDeZona,FueraHorario,SinSenal, SinReporteUbicacion;

            FueraDeZona = true;
            FueraHorario = true;
            SinSenal = false;
            SinReporteUbicacion = false;

            if (Estado == "Disponible") ColorPin = "Rojo";
            else if (Estado == "Alerta Asignada") ColorPin = "Verde";

            ImageName = ColorPin + "_";
            ImageName += (FueraDeZona) ? "S" : "N";
            ImageName += FueraHorario ? "S" : "N";
            ImageName += (SinSenal) ? "S" : "N";
            ImageName += (SinReporteUbicacion) ? "S" : "N";

            RandomAccessStreamReference PinMap = RandomAccessStreamReference.CreateFromUri(new Uri("ms-appx:///Assets/"+ImageName+".png")); 

            //RandomAccessStreamReference Pin2 = RandomAccessStreamReference.CreateFromUri(new Uri("ms-appx:///Assets/Azul.png")); 



            //  //ms-appdata:///temp/Pin5.png
            //  byte[] PIN;

            //  PIN = CreadorImagen.ImagenFin();

            //RandomAccessStreamReference Pin1 =RandomAccessStreamReference.CreateFromUri(new Uri("ms-appdata:///temp/Pin5.png"));



            //  Stream memstr = new MemoryStream(PIN);




            //  RandomAccessStreamReference Randon = RandomAccessStreamReference.CreateFromStream(memstr.AsRandomAccessStream());




            /// RandomAccessStreamReference Pin = RandomAccessStreamReference.CreateFromStream(nose);



            Geopoint ubicacion = new Geopoint(new BasicGeoposition() { Latitude = 19.018587, Longitude = -98.265848 });
        
            return new List<MapElement>
            {
                 new MapIcon { Location = ubicacion, NormalizedAnchorPoint = new Windows.Foundation.Point(0.5, 0.1), Image = PinMap,ZIndex = 0,Title="PIN"}
            };
            
        }

        private void findAtCenterButton_Click(object sender, RoutedEventArgs e)
        {


            CreadorImagen n = new CreadorImagen();

            //for (int a=0; a < 100; a++) {
              
               n.PinImagen(true, false, false, false, 5);
               n.PinImagen(true, true, false, false, 6);
               n.PinImagen(true, true, true, false, 7);
               n.PinImagen(true, true, true, true, 8);


            //}
        }
    }
}
