using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Gender { get; set; }


        public static List<Person> GetAllPeople()
        {
           return  new List<Person>() {
            new Person { Id=1, Name ="Mukti Subedi", Gender = "Male"},
            new Person { Id=2, Name ="Anna Sharma", Gender = "Female"},
            new Person { Id=3, Name ="Sanjay Gupta", Gender = "MaLe"}, // MaLe instead of Male
            new Person { Id=4, Name ="Sirjana Poudel", Gender = "FemaLe"}, // FemaLe instead of Female
            };
        }

        public static void DisplayPersonDetails(Person person)
        {
            Console.WriteLine($"Id: {person.Id}");
            Console.WriteLine($"Name: {person.Name}"); 
            Console.WriteLine($"Gender: { person.Gender}");
        }

    }

}
