using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9.GUI
{
    abstract class GuiObject
    {
        // private int _height;
        //private int _width;
        // private int _x;
        //private int _y;


        /* public int Height
         {
             get { return _height; }
             set { _height = value; }
         }*/

        /* public int Width
   {
       get { return _width; }
       set { _width = value; }
   }*/

        /*  public int X
          {
              get { return _x; }
              set { _x = value; }
          }

          public int Y
          {
              get { return _y; }
              set { _y = value; }
          }*/


        public int Height { get; set; }
        public int Width { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

               
        public GuiObject (int x, int y, int width, int height )
        {
                       
            X = x;
            Y = y;
            Height = height;
            Width = width;

        }
        public GuiObject(int x, int y, int width)
        {
            X = x;
            Y = y;
           Width = width;

        }

    }
}
