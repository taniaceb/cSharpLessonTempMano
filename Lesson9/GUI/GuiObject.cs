using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9.GUI
{
    class GuiObject
    {
        protected int _height;
        protected int _width;
        protected int _x;
        protected int _y;

        public GuiObject (int x, int y, int height, int width)
        {
            _x = x;
            _y = y;
            _height = height;
            _width = width;

        }
    }
}
