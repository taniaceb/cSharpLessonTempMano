﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10.GUI
{
    class Window : GuiObject
    {
        private Frame border;

        public Window(int x, int y, int width, int height, char borderChar) : base(x,y, width, height)
        {
            border = new Frame(x, y, width, height, borderChar);
        }

        public void Render()
        {

        }
    }
}
