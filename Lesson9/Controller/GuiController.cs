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



        public GuiController()
        {
            gameWindow = new GameWindow();
            creditWindow = new CreditWindow();


        }

        public void ShowMenu()
        {
            gameWindow.Render();

            //Console.WriteLine(gameWindow.CheckActiveButton());
        }

        public void ChooseMeniuButton()
        {
            // while (Console.KeyAvailable)
            // {

           
            ConsoleKeyInfo pressedChar = Console.ReadKey();
            while (pressedChar.Key != ConsoleKey.End)
            {
                switch (pressedChar.Key)
                {
                    case ConsoleKey.Enter:
                        break;
                    case ConsoleKey.RightArrow:

                        gameWindow.Direction = true;
                        gameWindow.MoveMeniuItem();
                        /* int index = gameWindow.CheckActiveButton();
                        if (index == 0)
                        {
                            gameWindow._buttonMenu[1].SetActive();
                            gameWindow._buttonMenu[0].SetNotActive();
                        }
                        else if (index == 1)
                        {
                            gameWindow._buttonMenu[1].SetNotActive();
                            gameWindow._buttonMenu[2].SetActive();
                        }

                        gameWindow.Render();*/

                        break;
                    case ConsoleKey.LeftArrow:
                        gameWindow.Direction = false;
                        gameWindow.MoveMeniuItem();

                        /*  int index1 = gameWindow.CheckActiveButton();
                          if (index1 == 2)
                          {
                              gameWindow._buttonMenu[1].SetActive();
                              gameWindow._buttonMenu[2].SetNotActive();
                          }
                          else if (index1 == 1)
                          {
                              gameWindow._buttonMenu[1].SetNotActive();
                              gameWindow._buttonMenu[0].SetActive();
                          }

                          gameWindow.Render();*/
                        break;
                }
                pressedChar = Console.ReadKey();

            }
        }





        /* public void KeyPress()
         {

             ConsoleKeyInfo pressedChar = Console.ReadKey();
             while (pressedChar.Key != ConsoleKey.Pause)
             {
                 switch (pressedChar.Key)
                 {
                     case ConsoleKey.Escape:
                         break;
                     case ConsoleKey.RightArrow:
                         //gameWindow._buttonMenu[0].IsActive = true;

                         Console.WriteLine("hhh");
                         //pressedChar = Console.ReadKey();
                         break;
                     case ConsoleKey.LeftArrow:
                         Console.WriteLine("cccc");
                         //pressedChar = Console.ReadKey();
                         break;
                 }
                 pressedChar = Console.ReadKey();
             }



         }*/


    }
}
