using System;
using System.Drawing;

namespace ImageVericationLib
{
    public class Main
    {
        public static bool CheckImage(String path, String type, int height, int width, int depth){
            Image img = Image.FromFile(path);
            
            if(Bools.CheckSize(img, height, width) && Bools.CheckDepth(img, depth) && Bools.CheckType(img, type))
                return true;
            else
                return false;
        }
    }
}
