using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Application.Contrat
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Add(T entity);
    }
}
