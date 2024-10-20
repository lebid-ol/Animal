using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Inheritance.Program;

namespace Inheritance
{
    internal class Cat : Animal
    {

        internal Cat(string name, int age)
        {
            Name = name;
            Age = age;
        }


        internal void Meow()
        {
            Console.WriteLine($"{Name} возрастом {Age} года мяукает");
        }
    }
    }
