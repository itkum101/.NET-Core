using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Task2
{
    internal class Program
    {
        internal static void Distinguish(List<Person> personList)
        {
            
           List<Person> malePerson = new List<Person>();
           List<Person> femalePerson= new List<Person>();


            foreach (Person person in personList)
            {
                if (person.Gender.Equals("Male", StringComparison.OrdinalIgnoreCase))
                {
                    malePerson.Add(person);
                }
                else
                {
                    femalePerson.Add(person);
                }
            }

            Console.WriteLine("Male List ");
            foreach (Person person in malePerson) 
                {
                Person.DisplayPersonDetails(person);
                }
            Console.WriteLine("Female List");
            foreach(Person person in femalePerson)
            {
                Person.DisplayPersonDetails(person);
            }



        }
        //Defining Method of a Delegate
        public delegate void PersonDelegate(Person person);
        static void Main(string[] args)
        {
            //List of a person: 
            List<Person> personList = Person.GetAllPeople();



            Distinguish(personList);
            //Output
            //Male List
            //Id: 1
            //Name: Mukti Subedi
            //Gender: Male
            //Id: 3
            //Name: Sanjay Gupta
            //Gender: MaLe
            //Female List
            //Id: 2
            //Name: Anna Sharma
            //Gender: Female
            //Id: 4
            //Name: Sirjana Poudel
            //Gender: Female





        }
    }
}
