using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RealTimeTrialONE.api.Models
{
    public class EmployeeRole: MetadataModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [MaxLength(20)]
        [Required]
        public string Role { get; set; }
        public string Description { get; set; }
    }
}
