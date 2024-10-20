namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            myAnimal.Name = "Животное";
            myAnimal.Age = 7;
            myAnimal.MakeSound();

            Dog myDog = new Dog("Собака", 3);
            myDog.Bark(); 
            myDog.MakeSound();//объект создан с наследуемого класса, но метод вызван с базового


            Cat myCat = new Cat("Кошка", 4);
            myCat.Meow();

            Bird myBird = new Bird("Воробей", 2);
            myBird.Sing();
        }

        internal class Animal
        {
            internal string Name { get; set; }
            internal int Age { get; set; }


        internal void MakeSound()
            {
                Console.WriteLine($"{Name} возрастом {Age} лет издает звук");
            }


        }

      

       
      
    }
}
