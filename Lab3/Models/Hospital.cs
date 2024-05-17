using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3.Models
{
    public class Hospital
    {
        public Hospital() {
            doctors = new List<Doctor>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ImageURL { get; set; }
        public virtual ICollection<Doctor> doctors { get; set; }
    }
}