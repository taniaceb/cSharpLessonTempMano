using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson10.GUI
{
    class TextBlock: GuiObject
    {
        private List<TextLine> textBlocks = new List<TextLine>();
            
        
        public TextBlock(int x, int y, int width, int height , List<string> textBlocks) : base(x,y, width, height )
        {
            

        }

        public void Render()
        {

        }

        
    }
}
