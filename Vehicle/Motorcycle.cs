using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    public class Motorcycle : Program.Vehicle
    {
        int EngineVolume { get; set; }

        public Motorcycle(string brand, double speed, int engineVolume) : base(brand, speed)
        {
            EngineVolume = engineVolume;
        }
        public void Move(string brand, double speed, int engineVolume)
        {
            Console.WriteLine($"{Brand} имеет объем двигателя {engineVolume} литр и движется со скоростью {Speed} км/час");
        }
    }
}
