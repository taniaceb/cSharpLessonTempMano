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

           
                    
            Console.CursorVisible = false;

           GuiController newWindow = new GuiController();
           newWindow.ShowMenu();
           newWindow.ChooseMeniuButton();

                     
                    


        }
    }
}