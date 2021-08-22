using RealTimeTrialONE.api.Dto;
using RealTimeTrialONE.api.Models;
using RealTimeTrialONE.api.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealTimeTrialONE.api.Services
{
    public class EmployeeRoleService : IEmployeeRoleService
    {
        private readonly IBaseRepository<EmployeeRole> _repo;
        public EmployeeRoleService(IBaseRepository<EmployeeRole> repo)
        {
            _repo = repo;
        }
        public async Task AddNewEmployeeRole(EmployeeRoleDto newrole)
        {
            string creator = "Admin";
            DateTime todaysDate = DateTime.UtcNow;
            EmployeeRole newEmpRole = new() { Role = newrole.Role, 
                //CreatedBy = creator, 
                ModifiedBy = creator, 
                ModifiedOn = todaysDate, 
                CreatedOn = todaysDate };
            await _repo.AddNewRecordAsync(newEmpRole);
            await _repo.SaveChangesAsync();
        }
    }
}
