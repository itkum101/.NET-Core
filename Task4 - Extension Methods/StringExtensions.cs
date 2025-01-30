using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4___Extension_Methods
{
    public static class StringExtensions
    {
        /// <summary>
        /// Reverses the given string.
        /// </summary>
        public static string ReverseString(this string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return s; 
            }
            StringBuilder reverseString = new StringBuilder(s.Length);
            //String reverseString = "";

            for (int i = s.Length - 1; i >= 0; i--)
            {
                reverseString.Append(s[i]);
                //reverseString += s[i]; //Create multiple string instance
            }

            return reverseString.ToString();
        }

        /// <summary>
        /// Converts the first letter of the string to uppercase.
        /// </summary>
        /// 
        public static string ToTitleCase(this string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return s;
            }


            return char.ToUpper(s[0]) + s.Substring(1);
        }

        /// <summary>
        /// Returns a list of unique vowels in the string.
        /// </summary>
        public static List<char> GetVowels(this string s)
        {



            if (string.IsNullOrEmpty(s))
            {
                return new List<char>();

            }

            SortedSet<char> vowels = new SortedSet<char>();
            foreach (char c in s)
            {
                char lowerchar = char.ToLower(c);
                if ("aeiou".Contains(lowerchar))
                {
                    vowels.Add(lowerchar);
                }
            }

            return vowels.ToList();
        }

        
      
    }
}
