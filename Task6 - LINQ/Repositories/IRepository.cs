using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6___LINQ.Repositories
{
    public interface IRepository<T>
    {
        List<T> GetAll();
    }
}
