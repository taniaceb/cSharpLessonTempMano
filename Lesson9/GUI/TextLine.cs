using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9.GUI
{
    class TextLine :GuiObject
    {
        //private string _label;

        public string Label {get; set; }
        

        public TextLine(int x, int y, int width, string label) : base(x, y, width)
        {
            Label = label;
        }

        public void Render()
        {
            Console.SetCursorPosition(X, Y);
            if (Width > Label.Length)
            {
                int offset = (Width - Label.Length) / 2;
                for (int i = 0; i < offset; i++)
                {
                    Console.Write(' ');
                }
            }

            Console.Write(Label);
        }
    }
}
