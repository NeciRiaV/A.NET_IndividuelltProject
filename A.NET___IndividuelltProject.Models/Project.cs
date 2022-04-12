using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace A.NET___IndividuelltProject.Models
{
    public class Project
    {
        [Key]
        public int ProjectID { get; set; }
        [Required]
        public string ProjectName { get; set; }
        public string Description { get; set; }
        [Required]
        public DateTime InitiationDate { get; set; }
        [Required]
        public DateTime FinishDate { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
