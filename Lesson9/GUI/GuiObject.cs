using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9.GUI
{
    class GuiObject
    {
        protected int Height;
        protected int Width;
        protected int X;
        protected int Y;

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
