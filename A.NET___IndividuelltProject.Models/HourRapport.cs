using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace A.NET___IndividuelltProject.Models
{
    public class HourRapport
    {
        [Key]
        public int HourRapportID { get; set; }
        [Required]
        public int ProjectID { get; set; }
        [Required]
        public int EmployeeID { get; set; }
        public int WeekNumber { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Employee Employee { get; set; }

        public static void GetDate(DateTime S, DateTime E)
        {
            HourRapport hr = new HourRapport();
            S = hr.Start;
            E = hr.End;

            TimeSpan ts = E - S;
            Console.WriteLine(ts);
        }
    }
}
