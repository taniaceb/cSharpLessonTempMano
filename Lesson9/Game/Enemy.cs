using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9.Game
{
    class Enemy:Unit
    {
        private int _id = 0;
        
        public Enemy(int id, int x, int y, string name) :base(x,y,name)
        {
           _id = id;
          
        }
         
        public void MoveDown()
        {
           
                Y ++;
           
        }

        /*public void PrintInfo()
        {
            Console.WriteLine("Enemy {0}  koordinates x = {1}  y = {2}", _id,_x, _y);
        }*/
        public int GetId()
        {
            return _id;
        }

    }
}
