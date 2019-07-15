﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9.Game
{
    class Hero
    {
        private int _x = 0;
        private int _y = 0;
        private string _name;
       
        public Hero(int x, int y, string name)
        {
            _x = x;
            _y = y;
            _name = name;
        }

        public void MoveRight(int x)
        {
            if ((_x + x) <=60)
            {
                _x += x;
            }
              else
            {
                Console.WriteLine("Negalime judeti i desine");
            }

        }

        public void MoveLeft(int x)
        {
            if ((_x - x) >= 0)
            {
                _x -= x;
            }
            else
            {
                Console.WriteLine("Negalime judeti i kaire");
            }

        }

        public void PrintInfo()
        {
            Console.WriteLine("Hero koordinates x = {0}  y = {1}", _x,_y);
        }



    }
}