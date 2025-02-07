using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6___LINQ.Repositories
{

        public class EmployeeRepository : IRepository<Employee>
        {
            public List<Employee> GetAll()
            {
                return new List<Employee>
                {
                    new Employee { EmployeeId = 1, Name = "Ram Sharma", Gender = "Male", Age = 30 },
                    new Employee { EmployeeId = 2, Name = "Sita Bhattarai", Gender = "Female", Age = 28 },
                    new Employee { EmployeeId = 3, Name = "Ganesh Tamang", Gender = "Male", Age = 35 },
                    new Employee { EmployeeId = 4, Name = "Laxmi Gurung", Gender = "Female", Age = 32 },
                    new Employee { EmployeeId = 5, Name = "Bikash Maharjan", Gender = "Male", Age = 27 }
                };
            }
        }

}
