using Hospital.Entities;


namespace Hospital.Dtos
{
    public class PatientDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }

        public long NationalCode { get; set; }

        public long Mobile { get; set; }
       
      


    }



    public class CreatePatientDto
    {
       
        public string Name { get; set; }
        public string Lastname { get; set; }

        public long NationalCode { get; set; }

        public long Mobile { get; set; }
      
    }

    public class UpdatePatientDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }

        public long NationalCode { get; set; }

        public long Mobile { get; set; }

    }


}
