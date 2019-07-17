using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9_uzd_Child_Class.Transport
{
    class Vehicle : MovingObject
    {
        private int _wheelCount;
        public Vehicle (int movespeed, int wheelCount) :base (movespeed)
        {
            _wheelCount = wheelCount;
        }

        public void ChangeWheel(int wheel)
        {
            _wheelCount += wheel;
            Console.WriteLine($"Wheel count: {_wheelCount}");
        }
    }
}
