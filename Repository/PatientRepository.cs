using AutoMapper;
using Hospital.Data;
using Hospital.Dtos;
using Hospital.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Repository
{
    public class PatientRepository: IPatientRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public PatientRepository(DataContext context , IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<long> AddPatientAsync(CreatePatientDto createPatientDto)
        {
            //var patient = new Patient()
            //{
            //    Id = createPatientDto.Id,
            //    Name = createPatientDto.Name,
            //    Lastname = createPatientDto.Lastname,
            //    Mobile = createPatientDto.Mobile,
            //    NationalCode = createPatientDto.NationalCode,
            //    DoctersId = createPatientDto.DoctersId,
            //};
            //_context.Add(patient);
            //await _context.SaveChangesAsync();

            //return patient.Id;

            _context.Add(createPatientDto);
            return await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Patient>> GetPatientAsync()
        {
            return await Task.FromResult(_context.Patients);
        }

        public async Task<PatientDto> GetPatientByIdAsync(long Id)
        {
            //var patient = _context.Patients.Where(p => p.Id == Id).SingleOrDefault();
            //return await Task.FromResult(patient);
            var patient = await _context.Patients.FindAsync(Id);

            return _mapper.Map<PatientDto>(patient);
        }
    }
}
