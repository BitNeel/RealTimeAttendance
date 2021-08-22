using RealTimeTrialONE.api.Dto;
using System.Threading.Tasks;

namespace RealTimeTrialONE.api.Services
{
    public interface IEmployeeRoleService
    {
        Task AddNewEmployeeRole(EmployeeRoleDto newrole);
    }
}
