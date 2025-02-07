using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6___LINQ.Repositories
{
    public class NumberRepository : IRepository<int>
    {
        public List<int> GetAll()
        {
            return Enumerable.Range(1, 10).ToList();
        }
    }
}
