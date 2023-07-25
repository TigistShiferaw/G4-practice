using Practice.Application.Contract;
using Practice.Domain;
using Practice.Persistence;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.persistance.Repositories
{
    public class CinemaRepository : GenericRepository<CinemaEntity>, ICinemaRepository
    {
        private readonly PracticeDbContext _dbContext;
        public CinemaRepository(PracticeDbContext practiceDbContext) : base(practiceDbContext)
        {
            _dbContext = practiceDbContext;
        }
    }
}
