using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyHermetyzacja
{
    public class Car
    {
        private int wheelSize; //pole
        public int WheelSize
        {
            get
            {
                return wheelSize;
            }

            set
            {
                if (value > 10 && value <= 30)
                {
                    wheelSize = value;
                }
                throw new Exception ("Wheel size was either too large ao too small");
            }

        }
        //properties
        protected int Length { get; set; }  //protected
        protected int HorsePower { get; set; }  //protected

    }

    public class SomeClass 
    { 
    public SomeClass() 
        { 
        var car = new Car();
        car.WheelSize = 15;   // -15? ===>  set
        // car.wheelSize = -15              validation omitting
        // var mazda = new Mazda ();
        // mazda.length                     encapsulation
        }
    }

    public class Mazda : Car
    {
        public Mazda()
        {
            WheelSize = 15;
            Length = 395;
            HorsePower = 146;
        }

    }

    public class Porshe : Car
    {
        public Porshe()
        {
            WheelSize = 14;
            Length = 429;
            HorsePower = 130;
        }
    }
}
