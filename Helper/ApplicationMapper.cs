using AutoMapper;
using Hospital.Dtos;
using Hospital.Entities;

namespace Hospital.Helper
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            // Patient
            CreateMap<Patient, PatientDto>();


            //Doctor
            CreateMap<Doctor, ShowDoctorNameDto>();









            //CreateMap<Doctor, DoctorDto>().IncludeMembers(s => s.Patients);
            //CreateMap<Patient, DoctorDto>(MemberList.None);




            //Insurance
            CreateMap<Insurance, InsuranceDto>();
            CreateMap<Insurance, CreateInsuranceDto>();

            //Test
            CreateMap<Test, TestDto>();
            CreateMap<Test, CreateTestDto>();

            //Reception




            //var config = new MapperConfiguration(c =>
            //{
            //    c.CreateMap<Reception, ReceptionDto>();

            //    c.CreateMap<Test, TestDto>();
            //});

            //config.AssertConfigurationIsValid();

            //CreateMap<ReceptionDto, Reception>()
            //    .ForMember(re => re., re => re.MapFrom(te => te.Test.Id))
            //    .ForMember(re => re.Test, re => re.MapFrom(te => te.Test.Name))
            //    .ForMember(re => re.Test, re => re.MapFrom(te => te.Test.Price));






        }

    }
}
