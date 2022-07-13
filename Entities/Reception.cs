namespace Hospital.Entities
{
    public class Reception
    {
        public long Id { get; set; }
        public string PatientName { get; set; }

        public string DoctorName { get; set; }

        public virtual Test Test { get; set; }
        public long TestId { get; set; }

        public string InsuranceName { get; set; }

    }
}
