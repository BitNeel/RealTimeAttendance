using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RealTimeTrialONE.api.Dto
{
    public class EmployeeRoleDto
    {
        [Required]
        [MaxLength(50)]
        public string Role { get; set; }
    }
}
