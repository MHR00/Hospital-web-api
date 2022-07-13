namespace Hospital.Entities
{
    public class Patient
    {
        public long Id { get; set; }    
        public string Name { get; set; }
        public string Lastname { get; set; }

        public long NationalCode { get; set; }    

        public long Mobile { get; set; }

        public List<Doctor> Doctors { get; set; }

        public long DoctersId { get; set; }
    }
}
