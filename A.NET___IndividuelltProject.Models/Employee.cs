using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace A.NET___IndividuelltProject.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Birth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public DateTime ContractStart { get; set; }
        public int ProjectID { get; set; }
        public Project Project { get; set; }
        public ICollection<HourRapport> HourRapports { get; set; }
    }
}
