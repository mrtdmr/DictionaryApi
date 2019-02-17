using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DictionaryApi.Repository
{
    public interface IRepository<T> where T:class
    {
        IQueryable<T> getAll();
    }
}
