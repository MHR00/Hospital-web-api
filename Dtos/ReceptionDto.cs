using Hospital.Entities;
using System.Collections;


namespace Hospital.Dtos
{
    public class ReceptionDto
    {
        public long Id { get; set; }
        public Patient Patient { get; set; }

        public string PatientName { get; set; }

        public Doctor Doctor { get; set; }

        public string DoctorName { get; set; }

        public List<Test> Tests { get; set; }


        public Insurance Insurance { get; set; }

        public string InsuranceName { get; set; }



        public class CreateReceptionDto
        {
            public string PatientName { get; set; }

            public string DoctorName { get; set; }

            public virtual Test Test { get; set; }
            public long TestId { get; set; }

            public string InsuranceName { get; set; }
        }

        public class UpdateReceptionDto
        {
            public long Id { get; set; }
            public string PatientName { get; set; }

            public string DoctorName { get; set; }

            public List<Test> Tests { get; set; }
            

            public string InsuranceName { get; set; }
        }


    }
}
