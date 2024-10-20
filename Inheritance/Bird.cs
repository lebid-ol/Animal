using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Inheritance.Program;

namespace Inheritance
{
    internal class Bird : Animal
    {

        internal Bird(string name, int age)
        {
            Name = name;
            Age = age;
        }
        internal void Sing()
        {
            Console.WriteLine($"{Name} возрастом {Age} года чирикает");
        }
    }
}
