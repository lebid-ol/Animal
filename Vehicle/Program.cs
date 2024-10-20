namespace Auto
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vehicle MyVehicle = new Vehicle("Nissan", 90);
            MyVehicle.Move();

            Car MyCar = new Car("Mercedes", 240.5, 4);
            MyCar.Move("Mercedes", 120.5, 4);

            Motorcycle MyMoto = new Motorcycle("BMW", 220, 1);
            MyMoto.Move("BMW", 220, 1);

            Bicycle MyBicycle = new Bicycle("Aist", 20, 17);
            MyBicycle.Move("Aist", 20, 17);

        }
        public class Vehicle
        {
            public string Brand { get; set; }
            public double Speed { get; set; }

            public Vehicle(string brand, double speed)
            {
                Brand = brand;
                Speed = speed;
            }


            public void Move()
            {
                Console.WriteLine($"{Brand} движется со скоростью {Speed} км/час");
            }

        }

    }
}
