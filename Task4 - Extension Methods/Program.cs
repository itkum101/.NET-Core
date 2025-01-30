namespace Task4___Extension_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime dob1 = new DateTime(2004, 1, 1);
            DateTime dob2 = new DateTime(2013, 2, 2);

            try
            {
                Console.WriteLine($"Age for DOB {dob1.ToShortDateString()}: {dob1.GetAge()}");
                Console.WriteLine($"Age for DOB {dob2.ToShortDateString()}: {dob2.GetAge()}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }


            string input = "nepal is a beautiful country.";

            Console.WriteLine($"Reverse: {input.ReverseString()}");
            Console.WriteLine($"Title Case: {input.ToTitleCase()}");
            Console.WriteLine($"Vowels: {string.Join(", ", input.GetVowels())}");
        }
    }
}
