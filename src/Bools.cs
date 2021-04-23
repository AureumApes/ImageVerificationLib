using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageVericationLibrary
{
    public class Bools
    {
        public static bool CheckSize(Image image, int height, int with){
            if(height == image.Height && with == image.Width){
                return true;
            }
            return false;
        }

        public static bool CheckType(Image image, String type){
            if(type == "JPEG" && image.RawFormat.Equals(ImageFormat.Jpeg)) return true;
            if(type == "BMP" && image.RawFormat.Equals(ImageFormat.Bmp)) return true;
            if(type == "PNG" && image.RawFormat.Equals(ImageFormat.Png)) return true;
            return false;
        }

        public static bool CheckDepth(Image image, int depth){
            if(depth == Image.GetPixelFormatSize(image.PixelFormat)){
                return true;
            }
            return false;
        }
    }
}