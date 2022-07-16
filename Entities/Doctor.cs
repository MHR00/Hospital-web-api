using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Hospital.Entities
{
    public class Doctor
    {
        public long Id { get; set; }    
        public long SutySystemCode { get; set; }    
        public string Name { get; set; }    
        public string Lastname { get; set; }
       
       public List<Patient> Patients { get; set; }  

      

    }
}
