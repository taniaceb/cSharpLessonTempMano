using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9.GUI
{
    class Frame : GuiObject
    {
        //private char _renderChar;

        public char RenderChar { get; set; }

        public Frame(int x, int y, int width, int height, char renderChar) : base(x, y, width, height)
        {
           RenderChar = renderChar;

        }

        public void Render()
        {
            for (int i = 0; i < Height; i++)
            {

                Console.SetCursorPosition(X, Y + i);
                if (i == 0 || i == Height - 1)
                {
                    for (int j = 0; j < Width; j++)
                    {
                        Console.Write(RenderChar);
                    }
                }
                else
                {
                    Console.Write(RenderChar);
                    for (int j = 0; j < Width - 2; j++)
                    {
                        Console.Write(' ');
                    }

                    Console.Write(RenderChar);
                }
            }
        }
    }
}
