using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9.Game
{
    class Hero:Unit
    {
              
        public Hero(int x, int y, string name) : base(x, y, name)
        {
           // X = x;
           // Y = y;
           // Name = name;
        }

       
        public void MoveRight()
        {
           
                X++;
            
        }

        public void MoveLeft()
        {
           
                X --;
           
        }

        public int GetX()
        {
            return X;
        }


        //public void PrintInfo()
        //{
       //     Console.WriteLine("Hero koordinates x = {0}  y = {1}", X,Y);
      //  }



    }
}
