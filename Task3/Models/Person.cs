using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Models
{
    internal class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }



        public Person(string name, int age)
        {
            Name = name;
            Age = age;

        }

        public void Introduce()
        {
            Console.WriteLine($"Hi My name is {Name} and my age is {Age}");

        }
    }
}
