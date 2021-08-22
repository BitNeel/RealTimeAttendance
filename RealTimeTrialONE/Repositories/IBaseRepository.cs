using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealTimeTrialONE.api.Repositories
{
    public interface IBaseRepository<T> where T:class
    {
        IQueryable<T> GetAllRecords();
        Task AddNewRecordAsync(T entity);
        Task SaveChangesAsync();
    }
}
