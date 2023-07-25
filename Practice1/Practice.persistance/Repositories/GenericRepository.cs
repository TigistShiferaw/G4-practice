using Practice.Application.Contract;
using Practice.Application.Contrat;
using Practice.Domain;
using Practice.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Practice.persistance.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly PracticeDbContext _practiceDbContext;

        public GenericRepository(PracticeDbContext practiceDbContext)
        {
            _practiceDbContext = practiceDbContext;
        }
        public async Task<T> Add(T entity)
        {
            await _practiceDbContext.AddAsync(entity);
            await _practiceDbContext.SaveChangesAsync();
            return entity;
        }
    }
}
