using System.Security.Cryptography.X509Certificates;

namespace Task1
{
    internal class Program
    {


        public static List<string> duplicateRemove(List<string> list)
        {
                var uniqueList = new List<string>();

            foreach (var item in list)
            {
                if(uniqueList.Contains(item) == false)
                {
                    uniqueList.Add(item);
                }
            }

            return uniqueList; 
            
             
        }

        static void Main(string[] args)
        {
            //List of integers

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            numbers.Add(11);
            numbers.Add(12); 
            numbers.Add(13);
            numbers.Add(14);
            numbers.Add(15);

            Console.WriteLine("Even Numbers are:"); 
            foreach (int i in numbers)
            {
                if (i % 2 == 0) { 
                    Console.Write($"{i} ");
                }
              
            }

            Console.WriteLine("");

            // To find maxiimum and minimum values in a list of integers

            int maxValue = int.MinValue;
            int minValue = int.MaxValue;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] >= maxValue)
                {
                    maxValue = numbers[i];
                }

                if (numbers[i] <= minValue)
                {
                    minValue = numbers[i];
                }
                
            }

            Console.WriteLine($"Max Value is {maxValue} ");
            Console.WriteLine($"Min Value is {minValue} ");


            List<string> itemWithDuplicateValue = new List<string>() {  "apple", "ball", "cat", "apple", "ball", "cat"};


            var finalListWithoutDuplication = Program.duplicateRemove(itemWithDuplicateValue);

            foreach(var value in finalListWithoutDuplication) { 
                Console.Write($"{value} ");
            }
            
           //  var finaListWithoutDuplication2 = duplicateRemove(finalListWithoutDuplication); //another way
        }
    }
}
