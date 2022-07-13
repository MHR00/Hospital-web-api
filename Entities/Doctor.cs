namespace Hospital.Entities
{
    public class Doctor
    {
        public long Id { get; set; }    
        public long SutySystemCode { get; set; }    
        public string Name { get; set; }    
        public string Lastname { get; set; }

        public List<Patient> Patients { get; set; }

        public long PatientsId { get; set; }

    }
}
