using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9.GUI
{
    class Window:GuiObject
    {
        protected Frame border;
        public Window(int x, int y, int width, int height, Frame border) :base (x,y,width, height)
        {
            this.border = border;
        }
    }
}
