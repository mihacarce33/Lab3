using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab3.Models
{
    public class Patient
    {
        public Patient() {
            doctors = new List<Doctor>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(9999,100000)]
        public int PatientCode { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public virtual ICollection<Doctor> doctors { get; set; }

    }
}