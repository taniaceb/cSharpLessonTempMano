using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10.GUI
{
    class Frame: GuiObject
    {
        private char _renderChar;
        public Frame(int x, int y, int width, int height, char renderChar) : base(x, y, width, height)
        {
            _renderChar = renderChar;
        }

        public void Render()
        {

        }
    }
}
