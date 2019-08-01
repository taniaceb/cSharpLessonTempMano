using Lesson9.Game;
using Lesson9.GUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9.Controller
{
    class GuiController
    {
        private GameWindow gameWindow;
        private CreditWindow creditWindow;
        private GameController myGame;



        public GuiController()
        {
            gameWindow = new GameWindow();
            creditWindow = new CreditWindow();
            myGame = new GameController();

        }

        public void ShowMenu()
        {
            gameWindow.Render();

            
        }

        public void ChooseMeniuButton()
        {
           
            bool creditW = false;

            ConsoleKeyInfo pressedChar = Console.ReadKey();
            while (pressedChar.Key != ConsoleKey.End)
            {
                switch (pressedChar.Key)
                {
                    case ConsoleKey.Enter:

                        if (creditW)
                        {
                            creditW = false;
                            ShowMenu();

                        }

                        else
                        {

                            if (gameWindow.CheckActiveButton() == 0)
                            {
                                Console.Clear();
                                myGame.StartGame();
                            }
                            else if (gameWindow.CheckActiveButton() == 1)
                            {
                                Console.Clear();
                                creditWindow.Render();
                                creditW = true;
                            }
                            else if (gameWindow.CheckActiveButton() == 2)
                            {
                                Console.Clear();

                            }

                        }
                        break;


                    case ConsoleKey.RightArrow:

                        gameWindow.Direction = true;
                        gameWindow.MoveMeniuItem();

                        break;
                    case ConsoleKey.LeftArrow:
                        gameWindow.Direction = false;
                        gameWindow.MoveMeniuItem();

                        break;
                }
                pressedChar = Console.ReadKey();

            }
        }


    }
}
