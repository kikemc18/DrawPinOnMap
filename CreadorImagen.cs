using ImageMagick;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml.Media.Imaging;

namespace PinMapa
{
	public class CreadorImagen
	{
      
        

        public static byte[] ImagenFin( ) 
        {
            byte[] bytesArchivo;
            try
            {
                string plantilla = @"Assets\Plantilla.jpg";
                string pathPin = @"Assets\Pin.png";
                string path1 = @"Assets\Rojo.png";

                string pathFinal = Path.Combine(Path.GetTempPath(),"Pin.png");

                using (MagickImage combiaciondePin = new MagickImage(plantilla))
                {
                    MagickImage pin = new MagickImage(pathPin);
                    MagickImage p1 = new MagickImage(path1);
                    MagickImage p2 = new MagickImage(path1);
                    MagickImage p3 = new MagickImage(path1);
                    MagickImage p4 = new MagickImage(path1);

                    pin.Colorize(MagickColors.Pink, new Percentage(100)); // Cambiar de Color 
                    p1.Colorize(MagickColors.Blue, new Percentage(100));
                    p2.Colorize(MagickColors.Green, new Percentage(100));
                    p3.Colorize(MagickColors.BlueViolet, new Percentage(100));
                    p4.Colorize(MagickColors.Red, new Percentage(100));

                    combiaciondePin.Scale(new Percentage(110), new Percentage(110)); // cambiar la escala
                    p1.Scale(new Percentage(10), new Percentage(10));
                    p2.Scale(new Percentage(10), new Percentage(10));
                    p3.Scale(new Percentage(10), new Percentage(10));
                    p4.Scale(new Percentage(10), new Percentage(10));

                    combiaciondePin.Composite(pin, 350, 200); //Combinar Imagenes
                    combiaciondePin.Composite(p1, 210, 80);
                    combiaciondePin.Composite(p4, 410, 0);
                    combiaciondePin.Composite(p2, 610, 0);
                    combiaciondePin.Composite(p2, 810, 80);

                    var img = new MagickImage(combiaciondePin);
                    img.ColorFuzz = new Percentage(10);

                    img.Transparent(MagickColors.White); //Quita el fondo Blanco
                    img.Transparent(MagickColors.Black); // Quitra el fondo Negro
                    //img.Transparent(MagickColors.Gray); //Quita el gris

                   bytesArchivo = img.ToByteArray();
                   


                    img.Write(pathFinal); // Guardar
                }

            }
            catch (Exception)
            {
                bytesArchivo = null;

                throw;
            }

            return bytesArchivo;
        }

       // int a = 0;

        public async void PinImagen(bool P1, bool P2, bool P3, bool P4 , int a) 
        {      
            try
            {
                string plantilla = @"Assets\Plantilla.jpg";
                string pathPin = @"Assets\Pin.png";
                string path1 = @"Assets\Rojo.png";
                string pathFinal = Path.Combine(Path.GetTempPath(), "Pin" + a + ".png");

                using (MagickImage combiaciondePin = new MagickImage(plantilla))
                {
                    MagickImage pin = new MagickImage(pathPin); //Uso de MagickImage para poder usar 
                    MagickImage p1 = new MagickImage(path1);
                    MagickImage p2 = new MagickImage(path1);
                    MagickImage p3 = new MagickImage(path1);
                    MagickImage p4 = new MagickImage(path1);

                    pin.Colorize(MagickColors.Orange, new Percentage(100)); // Cambiar de Color 
                    p1.Colorize(MagickColors.Blue, new Percentage(100));
                    p2.Colorize(MagickColors.Green, new Percentage(100));
                    p3.Colorize(MagickColors.BlueViolet, new Percentage(100));
                    p4.Colorize(MagickColors.Red, new Percentage(100));               

                    combiaciondePin.Scale(new Percentage(110), new Percentage(110)); // cambiar la escala
                                                                                     // 
                    p1.Scale(new Percentage(10), new Percentage(10));
                    p2.Scale(new Percentage(10), new Percentage(10));
                    p3.Scale(new Percentage(10), new Percentage(10));
                    p4.Scale(new Percentage(10), new Percentage(10));

                    combiaciondePin.Composite(pin, 350, 200);

                    if (P1)
                    {
                        combiaciondePin.Composite(p1, 210, 80);
                    }
                    if (P2)
                    {
                        combiaciondePin.Composite(p2, 410, 0);
                    }
                    if (P3)
                    {
                        combiaciondePin.Composite(p3, 610, 0);
                    }

                    if (P4)
                    {
                        combiaciondePin.Composite(p4, 810, 80);
                    }

                    //combiaciondePin.Composite(pin, 350, 200); //Combinar Imagenes
                    //combiaciondePin.Composite(p1, 210, 80);
                    //combiaciondePin.Composite(p4, 410, 0);
                    //combiaciondePin.Composite(p2, 610, 0);
                   // combiaciondePin.Composite(p2, 810, 80);


                   
                    var img = new MagickImage(combiaciondePin);
                    img.ColorFuzz = new Percentage(10);
                    
                    img.Transparent(MagickColors.White); //Quita el fondo Blanco
                    img.Transparent(MagickColors.Black); // Quitra el fondo Negro
                                                         //img.Transparent(MagickColors.Gray); //Quita el gris                
                    a++;
                    img.Write(pathFinal); // Guardar
                }
            }
            catch (Exception)
            {

                throw;
            }


        }





    }
}
