using Microsoft.EntityFrameworkCore;
using RealTimeTrialONE.api.Contexts;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RealTimeTrialONE.api.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T:class
    {
        private readonly HRMSDbContext _dbcontext;
        public BaseRepository(HRMSDbContext dbc)
        {
            _dbcontext = dbc;
        }
        public async Task AddNewRecordAsync(T entity)
        {
           await _dbcontext.AddAsync(entity);
        }

        public IQueryable<T> GetAllRecords()
        {
            return _dbcontext.Set<T>().AsQueryable();
        }

        public async Task SaveChangesAsync()
        {
            await _dbcontext.SaveChangesAsync();
        }
    }
}
