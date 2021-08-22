using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RealTimeTrialONE.api.Models
{
    public class MetadataModel
    {
        [Required]
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        [DefaultValue(true)]
        public bool IsActive { get; set; }
    }
}
