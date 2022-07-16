using System.Collections;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Hospital.Entities
{
    public class Reception
    {
        public long Id { get; set; }
        public Patient Patient { get; set; }

        public string PatientName { get; set; }

        public Doctor Doctor { get; set; }

        public string DoctorName { get; set; }
       
        public List<Test> Tests { get; set; }   
          

        public Insurance Insurance { get; set; }
        
        public string InsuranceName { get; set; }
    }
}
