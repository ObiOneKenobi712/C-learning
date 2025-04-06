using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyKompozycja
{
    public class Car
    {
        public int WheelSize { get; set; }
        public int Length { get; set; }
        public int HorsePower { get; set; }

    }

    //public class Mazda : Car
    public class Mazda
    {
        public Car Car { get; set; }
        public Mazda()
        {
            Car.WheelSize = 15;
            Car.Length = 395;
            Car.HorsePower = 146;
        }

    }

    //public class Porshe : Car
    public class Porshe
    {
        public Car Car{ get; set; }
        public Porshe()
        {
            Car.WheelSize = 14;
            Car.Length = 429;
            Car.HorsePower = 130;
        }
    }
}
