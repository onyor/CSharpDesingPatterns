using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    // Concrete FlyWeight
    class Sergeant : Soldier
    {

        public Sergeant()
        {
            UnitName = "SWAT";
            Guns = "Sword";
            Health = "Good";
        }

        public override void MoveTo(int x, int y)
        {
            X = x;
            Y = y;

            Console.WriteLine("Çavuş ({0}:{1}) noktasına hareket etti", X, Y);
        }

    }
}
