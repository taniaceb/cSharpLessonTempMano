using Lesson9.Bank;
using Lesson9.Controller;
using Lesson9.Game;
using Lesson9.GUI;
using Lesson9.Test;
using System;
using System.Collections.Generic;

namespace Lesson9
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                GameController myGame = new GameController();
                myGame.StartGame();*/

                    
            Console.CursorVisible = false;

           // GameWindow gameWindow = new GameWindow();
           //gameWindow.Render();

            //CreditWindow creditWindow = new CreditWindow();
            //creditWindow.Render();

           GuiController newWindow = new GuiController();
           newWindow.ShowMenu();
            newWindow.ChooseMeniuButton();

            // jjj.Render();
            //jjj.creditWindow.Render();
            //jjj.gameWindow.Render();
            // Console.ReadKey(true);
            //Console.Clear();

            // while (Console.KeyAvailable)
            // {

            /* ConsoleKeyInfo pressedChar = Console.ReadKey();
            while (pressedChar.Key != ConsoleKey.Enter)
           {
                switch (pressedChar.Key)
                {
                    case ConsoleKey.Escape:
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("hhh");
                        //pressedChar = Console.ReadKey();
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("cccc");
                        //pressedChar = Console.ReadKey();
                        break;
                }
                pressedChar = Console.ReadKey();
            }*/

            //  }

            /*  var cc = Console.ReadKey(true);
              while (cc.Key != ConsoleKey.Enter)
              {
                  if (char.IsDigit(cc.KeyChar))
                  {
                      Console.Beep();
                      Console.WriteLine();
                  }
                  Console.Write(cc.KeyChar.ToString());
                  cc = Console.ReadKey(true);
              }*/


        }
    }
}