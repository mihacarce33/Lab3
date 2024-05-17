﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3.Models
{
    public class PatientDoctors
    {
        public PatientDoctors() {
            patients = new List<Patient>();
        }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public Doctor doctor { get; set; }
        public List<Patient> patients { get; set; }
    }
}