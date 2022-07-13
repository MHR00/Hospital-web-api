using AutoMapper;
using Hospital.Dtos;
using Hospital.Entities;

namespace Hospital.Helper
{
    public class ApplicationMapper:Profile
    {
        public ApplicationMapper()
        {
            // Patient
            CreateMap<Patient, PatientDto>();
            CreateMap<Patient, CreatePatientDto>();

            //Doctor
            CreateMap<Doctor , DoctorDto>();
            CreateMap<Doctor , CreateDoctorDto>();

            //Insurance
            CreateMap<Insurance, InsuranceDto>();
            CreateMap<Insurance, CreateInsuranceDto>();

            //Test
            CreateMap<Test, TestDto>();
            CreateMap<Test, CreateTestDto>();



        }
    }
}
