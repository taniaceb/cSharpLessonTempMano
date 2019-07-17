using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9.Game
{
    class Enemy
    {
        private int _id = 0;
        private int _x = 0;
        private int _y = 0;
        private string _name;
        public Enemy(int id, int x, int y, string name)
        {
            _id = id;
            _x = x;
            _y = y;
            _name = name;
        }
         
        public void MoveDown(int id)
        {
           
                _y ++;
           
        }

        public void PrintInfo()
        {
            Console.WriteLine("Enemy {0}  koordinates x = {1}  y = {2}", _id,_x, _y);
        }


    }
}
