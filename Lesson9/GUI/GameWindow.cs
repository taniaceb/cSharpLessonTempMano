using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9.GUI
{
    class GameWindow :Window
    {
        private Button _startButton;
        private Button _creditsButton;
        private Button _quitButton;
        private TextBlock _titleTextBlock;
        public List<Button> _buttonMenu = new List<Button>();
        public bool Direction = true;

        public GameWindow() : base(0, 0, 120, 30, '%')
        {
            _titleTextBlock = new TextBlock(10, 5, 100, new List<String> { "Super duper zaidimas", "Vardas Pavardaitis kuryba!", "Made in Vilnius Coding School!" });

            _startButton = new Button(20, 13, 18, 5, "Start");
            //_startButton.SetActive();

            _creditsButton = new Button(50, 13, 18, 5, "Credits");

            _quitButton = new Button(80, 13, 18, 5, "Quit");

            _buttonMenu.Add(_startButton);
            _buttonMenu.Add(_creditsButton);
            _buttonMenu.Add(_quitButton);
            _buttonMenu[0].SetActive();
            
        }

        public override void Render()
        {
            base.Render();

            _titleTextBlock.Render();

          //  _startButton.Render();
         //   _creditsButton.Render();
        //    _quitButton.Render();
            
            for (int i=0; i<_buttonMenu.Count;i++)
            {
                _buttonMenu[i].Render();
            }

            Console.SetCursorPosition(0, 0);
        }

        public int CheckActiveButton()
        {
            int buttonIndex=0;
            foreach (Button value in _buttonMenu)
            {
                if (value.IsActive == true)
                {
                    buttonIndex = _buttonMenu.IndexOf(value);
                }
            }
            return buttonIndex;
        }

        public void MoveMeniuItem()
        {

            int index = CheckActiveButton();
            if (Direction)
            {
                if (index == 0)
                {
                    _buttonMenu[1].SetActive();
                    _buttonMenu[0].SetNotActive();
                }
                else if (index == 1)
                {
                    _buttonMenu[1].SetNotActive();
                    _buttonMenu[2].SetActive();
                }

                Render();
            }
            else
            {
                
                if (index == 2)
                {
                    _buttonMenu[1].SetActive();
                    _buttonMenu[2].SetNotActive();
                }
                else if (index == 1)
                {
                    _buttonMenu[1].SetNotActive();
                    _buttonMenu[0].SetActive();
                }

                Render();
            }

        }
    }
}
