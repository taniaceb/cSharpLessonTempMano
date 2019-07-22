using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9.GUI
{
    class Button: GuiObject
    {
        private Frame _activeFrame;
       // private bool _isActive = false;
        private Frame _notActiveFrame;
       // private TextLine _textLine;


        public bool IsActive { get; set; } = false;
        public TextLine Label { get; set; }

        public Button(int x, int y, int width, int height, string buttonText) : base (x, y, width, height)
        {

            _notActiveFrame = new Frame(x, y, width, height, '+');
            _activeFrame = new Frame(x, y, width, height, '#');
            Label = new TextLine(x + 1, y + 1 + ((height - 2) / 2), width - 2, buttonText);

        }

        public void Render()
        {
            if (IsActive)
            {
                _activeFrame.Render();
            }
            else
            {
                _notActiveFrame.Render();
            }

            _textLine.Render();
        }

        public void SetActive()
        {
            IsActive = true;
        }
    }
}
