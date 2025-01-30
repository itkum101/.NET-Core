using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Models
{
    internal class Cat
    {
        const string catSound = "Meow Meow Meow !!!";
        const string speciesName = "Cat";
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
