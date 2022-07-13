using Hospital.Dtos;
using Hospital.Entities;

namespace Hospital.Repository
{
    public interface IPatientRepository
    {
        Task<IEnumerable<Patient>> GetPatientAsync();
        Task<PatientDto> GetPatientByIdAsync(long Id);
        Task<long> AddPatientAsync (CreatePatientDto createPatientDto);
    }
}
