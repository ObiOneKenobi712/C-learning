using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyPolimorfizm
{
    public abstract class Car
    {
        public int WheelSize { get; set; }
        public int Length { get; set; }
        public int HorsePower { get; set; }

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

    public class SomeClass

    {
        public SomeClass() 
        {
            var mazda = new Mazda();
            
            Drive(mazda);
        }
        public void Drive(Mazda car)
        {
            System.Console.WriteLine($"You can reach your destination in {200 - car.HorsePower}");     
        }

    }
}
