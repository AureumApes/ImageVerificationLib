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
            // Check if Image Size is right!
            if(!Bools.CheckSize(img, height, width)){
                return false;
            }
            // Check if ColorDepth is right!
            if(!Bools.CheckDepth(img, depth)){
                return false;
            }
            // Check if Image Type is right! (Without the Filename)
            if(!Bools.CheckType(img, type)){
                return false;
            }
            return true;
        }
    }
}
