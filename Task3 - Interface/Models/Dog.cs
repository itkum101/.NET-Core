using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.Interfaces;

namespace Task3.Models
{
    internal class Dog : IAnimal
    {
        const string catSound = "Bark Bark Bark !!!";
        const string speciesName = "Dog";
        public void MakeSound()
        {
            Console.WriteLine(catSound);
        }
        public string GetSpecies()
        {
            return speciesName;
        }

    }
}
