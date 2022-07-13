using AutoMapper;
using Hospital.Data;
using Hospital.Dtos;
using Hospital.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public DoctorsController(DataContext context , IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<DoctorDto>>> Get()
        {
            return Ok(await _context.Doctors.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Doctor>> GetById (long Id)
        {
            var doctor = await _context.Doctors.FindAsync(Id);
            if (doctor == null)
                return BadRequest("Docter not found");
            return Ok(_mapper.Map<DoctorDto>(doctor));
        }

        [HttpPost]
        public async Task<ActionResult<List<CreateDoctorDto>>> AddDoctor(CreateDoctorDto createDoctorDto)
        {
            var docter = new Doctor()
            {
             
                Name = createDoctorDto.Name,
                Lastname = createDoctorDto.Lastname,
                SutySystemCode = createDoctorDto.SutySystemCode,
                
            };

      
            _context.Doctors.Add(docter);
            await _context.SaveChangesAsync();
            return Ok(await _context.Doctors.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<UpdateDoctoreDto>>> Update(UpdateDoctoreDto request)
        {
            var doctor = await _context.Doctors.FindAsync(request.Id);
            if (doctor == null)
                return BadRequest("Doctor not found");
            doctor.Id = request.Id;
            doctor.Name = request.Name;
            doctor.Lastname = request.Lastname;
            doctor.SutySystemCode = request.SutySystemCode;
            

            await _context.SaveChangesAsync();
            return Ok(await _context.Doctors.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Doctor>>> Delete(long id)
        {
            var doctor = await _context.Doctors.FindAsync(id);
            if (doctor == null)
                return BadRequest("Doctor not found");

            _context.Doctors.Remove(doctor);
            await _context.SaveChangesAsync();

            return Ok(await _context.Doctors.ToListAsync());
        }


    }
}
