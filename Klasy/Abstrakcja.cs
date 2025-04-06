using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyAbstrakcja
{
    //anstract class
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

            var mazda = new Mazda();
            //not possible var car = new Car();
        }

    }

    public class Porshe : Car
    {
        public Porshe()
        {
            WheelSize = 14;
            Length = 429;
            HorsePower = 130;

            var porshe = new Porshe();
            //not possible var car = new Car();
        }
    }

    public abstract class Shape
    { 
    
    }

    public class Triangle : Shape 
    { 
    
    }

    public class Square : Shape 
    { 
    
    }
}