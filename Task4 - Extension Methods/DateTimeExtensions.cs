using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4___Extension_Methods
{
    public static class DateTimeExtensions
    {
        public static int GetAge(this DateTime dateOfBirth)
        {


            var today = DateTime.Today;

            if (dateOfBirth > today)
                throw new ArgumentException("Date of birth cannot be in the future.");


            var age = today.Year - dateOfBirth.Year;


            if (today.Month < dateOfBirth.Month || (today.Month == dateOfBirth.Month && today.Day < dateOfBirth.Day))
            {
                age--;
            }

            return age;
        }
    }
}
