using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9.GUI
{
    class Button: GuiObject
    {
        protected Frame activeFrame;
        protected bool isActive = false;
        protected Frame notActiveFrame;
        protected TextLine textLine;

        public Button(int x, int y, int width, int height, string buttonText) : base (x, y, width, height)
        {
            
            textLine = buttonText;

        }

        public void Render()
        {

        }

        public void SetActive()
        {

        }
    }
}
