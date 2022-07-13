using AutoMapper;
using Hospital.Data;
using Hospital.Dtos;
using Hospital.Entities;
using Hospital.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatiensController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IPatientRepository _IpatientRepository;
        private readonly IMapper _mapper;


        public PatiensController(DataContext context, IPatientRepository IpatientRepository, IMapper mapper)
        {
            _context = context;
            _IpatientRepository = IpatientRepository;
            _mapper = mapper;

        }

        [HttpGet]
        public async Task<IActionResult> GetPatientAsync()
        {
            var patient = await _IpatientRepository.GetPatientAsync();
            return Ok(_mapper.Map<IEnumerable<PatientDto>>(patient));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPatientByIdAsync([FromRoute]long Id)
        {
            var patient = await _IpatientRepository.GetPatientByIdAsync(Id);
            if (patient == null)
            {
                return NotFound();
            }
            return Ok(patient);
        }

        [HttpPost]
        public async Task<ActionResult<List<CreatePatientDto>>> Addpatient(CreatePatientDto createpatientDto)
        {
            var patient = new Patient()
            {
                Name = createpatientDto.Name,
                Lastname = createpatientDto.Lastname,
                NationalCode = createpatientDto.NationalCode,
                Mobile = createpatientDto.Mobile,
            };


            _context.Patients.Add(patient);
            await _context.SaveChangesAsync();
            return Ok(await _context.Patients.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<UpdatePatientDto>>> Update(UpdatePatientDto request)
        {
            var patient = await _context.Patients.FindAsync(request.Id);
            if (patient == null)
                return BadRequest("patient not found");
            patient.Id = request.Id;
            patient.Name = request.Name;
            patient.Lastname = request.Lastname;
            patient.NationalCode = request.NationalCode;
            patient.Mobile = request.Mobile;


            await _context.SaveChangesAsync();
            return Ok(await _context.Patients.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Patient>>> Delete(long id)
        {
            var patient = await _context.Patients.FindAsync(id);
            if (patient == null)
                return BadRequest("patient not found");

            _context.Patients.Remove(patient);
            await _context.SaveChangesAsync();

            return Ok(await _context.Patients.ToListAsync());
        }



    }
}
