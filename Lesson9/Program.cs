using Lesson9.Bank;
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

            GameWindow gameWindow = new GameWindow();
            gameWindow.Render();

            CreditWindow creditWindow = new CreditWindow();
            creditWindow.Render();

            Console.ReadKey();

           /* TestClass testPerson = new TestClass();

            testPerson.Name = "testas1";
            string testas2 =testPerson.LastName;

            testPerson.City = "TestasCity";
            
            string street1 = testPerson.Street;*/
           

          
            
            // Console.WriteLine(testPerson.Name);


            /*Console.WriteLine($" Name {testPerson.Name}\r\n LastName {testPerson.LastName}\r\n City \r\n Street  {testPerson.Street}\r\n");

              testPerson.Name = "NewName";
             // testPerson.LastName = "NewLastName";
              testPerson.City = "Kaunas";
             // testPerson.Street = "Kauno";

              Console.WriteLine($" Name {testPerson.Name}\r\n LastName {testPerson.LastName}\r\n City {testPerson.City}\r\n Street  {testPerson.Street}\r\n"); */




        }
    }
}