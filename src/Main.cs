using System;
using System.Drawing;

namespace ImageVericationLib
{
    public class Main
    {
        public static bool CheckImage(String path, String type, int height, int width, int depth){
            // ----------------------------------------------------------------------------------------------------
            Image img = Image.FromFile(path);
            // ----------------------------------------------------------------------------------------------------
            if(!Bools.CheckSize(img, height, width)){
                return false;
            }
            if(!Bools.CheckDepth(img, depth)){
                return false;
            }
            if(!Bools.CheckType(img, type)){
                return false;
            }
            return true;
        }
    }
}
