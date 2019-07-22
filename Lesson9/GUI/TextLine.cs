using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9.GUI
{
    class TextLine :GuiObject
    {
        //private string _data;

        public string Label { get; set; }

        public TextLine(int x, int y, int width, string data) : base(x, y, width)
        {
            Label = data;
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
