using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10.GUI
{
    class GuiObject
    {
        protected int _height;
        protected int _width;
        protected int _x;
        protected int _y;

        public GuiObject(int x, int y, int width, int height)
        {
            _x = x;
            _y = y;
            _height = height;
            _width = width;
        }


    }
}
