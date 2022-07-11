namespace Hospital.Model
{
    public class Patient
    {
        public long Id { get; set; }    
        public string Name { get; set; }
        public string Lastname { get; set; }

        public string NationalCode { get; set; }    

        public string Mobile { get; set; }

        public List<Doctor> Doctors { get; set; }

        public long DocterId { get; set; }
    }
}
