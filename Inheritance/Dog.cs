using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Inheritance.Program;

namespace Inheritance
{
    internal class Dog : Animal
    {

        internal Dog(string name, int age)
        {
            Name = name;
            Age = age;
        }
            internal void Bark()
        {
            Console.WriteLine($"{Name} возрастом {Age} года гавкает");
        }
    }
}
