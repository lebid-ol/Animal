using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Auto
{
    public class Car : Program.Vehicle
    {
        int NumberOfDoors { get; set; }

        public Car(string brand, double speed, int numberOfDoors) : base(brand, speed)
        {
            NumberOfDoors = numberOfDoors;

        }
        public void Move(string brand, double speed, int NumberOfDoors)
        {
            Console.WriteLine($"{Brand} имеет {NumberOfDoors} двери и движется со скоростью {Speed} км/час");
        }

    }
}
