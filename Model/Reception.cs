namespace Hospital.Model
{
    public class Reception
    {
        public long Id { get; set; }    
        public virtual Patient Patient { get; set; }
        public long PatientId { get; set; }

        public virtual Doctor Doctor { get; set; }  
        public long DoctorId { get; set; }  

        public virtual Test Test { get; set; }  
        public long TestId { get; set; }    

        public virtual Insurance Insurance { get; set; }
        public long InsuranceId { get; set; }

    }
}
