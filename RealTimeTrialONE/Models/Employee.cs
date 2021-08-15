using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RealTimeTrialONE.api.Models
{
    public class Employee: MetadataModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required(ErrorMessage = "FirstName cannot be empty")]
        [MaxLength(100, ErrorMessage ="Name should not be more than 100 characters")]
        public string FirstName { get; set; }
        [MaxLength(100, ErrorMessage ="Middle Name should not be more than 100 characters")]
        public string MiddleName { get; set; }
        [Required(ErrorMessage = "LastName cannot be empty")]
        [MaxLength(100, ErrorMessage = "Last Name should not be more than 100 characters")]
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime Doj { get; set; }
    }
}
