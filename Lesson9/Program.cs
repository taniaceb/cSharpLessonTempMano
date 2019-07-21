using Lesson9.Bank;
using Lesson9.Game;
using Lesson9.GUI;
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

            GameWindow gameWindow = new GameWindow();
            gameWindow.Render();

            CreditWindow creditWindow = new CreditWindow();
            creditWindow.Render();

            Console.ReadKey();

        }
    }
}