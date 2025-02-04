using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4___StringBuilder
{
    internal class StringBuilderDemo
    {

        static void Main()
        {
            List<string> words = ["Nepal", "is", "a", "beautiful", "country"];
            List<string> famousNames = ["Ram", "Sita", "Gautam Buddha", "Prithvi Narayan Shah"];

            string sentence = CreateSentence(words);
            Console.WriteLine("Sentence: " + sentence);


            string namesString = CommaSeparatedString(famousNames);
            Console.WriteLine("Famous Names: " + namesString);
        }

        static string CreateSentence(List<string> words)
        {
            if (words == null || words.Count == 0)
            {
                return string.Empty;
            }

            StringBuilder sb = new StringBuilder();
            foreach (var word in words)
            {
                sb.Append(word);
                sb.Append(" ");
            }
            return sb.Append('.').ToString();
        }

        static string CommaSeparatedString(List<string> names)
        {
            if (names == null || names.Count == 0)
            {
                return string.Empty;
            }


            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < names.Count; i++)
            {
                sb.Append(names[i]);
                if (i < names.Count - 1)
                {
                    sb.Append(", ");
                }

            }
            return sb.ToString();
        }
    }
}
