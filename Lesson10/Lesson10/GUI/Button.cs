using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10.GUI
{
    class Button: GuiObject
    {
        private Frame activeFrame ;
        private bool isActive  = false;
        private Frame nonActiveFrame;
        private TextLine textLine;

        public Button(int x, int y, int width , int height, string buttonName ) : base(x,y,width, height)
        {

        }
        public void Render()
        {

        }

        public void SetActive()
        { 
}
    }
}
