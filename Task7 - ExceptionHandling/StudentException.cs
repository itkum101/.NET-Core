using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7___ExceptionHandling
{
    using System;

    public class StudentException : Exception
    {
        public StudentException() : base("Student is not enrolled.") { }

        public StudentException(string message) : base(message) { }

        public StudentException(string message, Exception innerException)
            : base(message, innerException) { }
    }

}
