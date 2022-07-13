namespace Hospital.Dtos
{
    public class DoctorDto
    {
        public long Id { get; set; }
        public long SutySystemCode { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }

       
    }

    public class CreateDoctorDto
    {
     
        public long SutySystemCode { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
     
    }

    public class DeleteDoctoreDto
    {
        public long Id { get; set; }
    }

    public class UpdateDoctoreDto
    {
        public long Id { get; set; }
        public long SutySystemCode { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
    }
}
