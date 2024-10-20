using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    internal class Bicycle : Program.Vehicle
    {
       int WheelSize { get; set; }

        public Bicycle(string brand, double speed, int wheelsize) : base(brand, speed)
        {
            WheelSize = wheelsize;
        }
        public void Move(string brand, double speed, int wheelsize)
        {
            Console.WriteLine($"{Brand} имеет диаметр колес {wheelsize} и движется со скоростью {Speed} км/час");
        }

    }
}
