using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson9_uzd_Child_Class.Transport
{
    class Flyer: Vehicle
    {
        public int Altitude;
        public Flyer(int movespeed, int wheelCount, int altitude) : base (movespeed, wheelCount)
        {
            this.Altitude = altitude;
        }

        public void PichUp(int altitude)
        {
            Altitude += altitude;

        }
    }
}
