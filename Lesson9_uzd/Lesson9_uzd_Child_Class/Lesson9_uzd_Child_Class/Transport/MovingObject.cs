using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9_uzd_Child_Class.Transport
{
    class MovingObject
    {
        private int _movespeed;

        public MovingObject(int movespeed)
        {
            _movespeed = movespeed;
        }

        public void Move()
        {
            _movespeed++;
            Console.WriteLine($"Speed: {_movespeed}");
        }
    }
}
