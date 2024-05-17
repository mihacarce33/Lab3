using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab3.Models
{
    public class Doctor
    {
        public Doctor() {
            patients = new List<Patient>();
        }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Hospital hospitalWork { get; set; }
        public virtual ICollection<Patient> patients { get; set; }

    }
}