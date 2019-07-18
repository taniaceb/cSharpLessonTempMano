using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10.GUI
{
    class TextLine: GuiObject
    {
        private string _data;
        public TextLine(int x, int y, int width, int height, string data) : base (x,y,width, height)
        {
            _data = data;
        }

        public void Render()
        {
            
        }
    }
}
