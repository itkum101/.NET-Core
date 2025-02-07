using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6___LINQ.Repositories
{
    public class StudentRepository : IRepository<Student>
    {
        public List<Student> GetAll()
        {
            return new List<Student>
            {
                new Student { StudentId = 1, Name = "Ram Sharma", Gender = "Male", Age = 20 },
                new Student { StudentId = 2, Name = "Sita Bhattarai", Gender = "Female", Age = 21 },
                new Student { StudentId = 3, Name = "Ganesh Tamang", Gender = "Male", Age = 22 },
                new Student { StudentId = 4, Name = "Laxmi Gurung", Gender = "Female", Age = 19 },
                new Student { StudentId = 5, Name = "Bikash Maharjan", Gender = "Male", Age = 23 }
            };
        }
    }
}
