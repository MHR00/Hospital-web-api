using AutoMapper;
using Hospital.Data;
using Hospital.Dtos;
using Hospital.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static Hospital.Dtos.ReceptionDto;

namespace Hospital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceptionsController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public ReceptionsController(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<Reception>>> Get()
        {
            var result = await _context.Receptions
                .Include(c => c.Tests)
                .Include(c=>c.Insurance)
                .Include(c=>c.Doctor)
                .Include(c=>c.Patient)
                .ToListAsync();

            return Ok(result);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<ReceptionDto>> GetById(long Id)
        {
            var reception = await _context.Receptions
                .Where(c => c.Id == Id)
                .Include(c => c.Tests)
                .Include(c => c.Insurance)
                .Include(c => c.Doctor)
                .Include(c => c.Patient)
                .ToListAsync();

            if (reception == null)
                return BadRequest("Reception not found");

            //return Ok(_mapper.Map<ReceptionDto>(reception));
            return Ok(reception);

        }

        //[HttpPost]
        //public async Task<ActionResult<List<CreateReceptionDto>>> AddDoctor(CreateReceptionDto createReceptionDto)
        //{
        //    var item = new Reception()
        //    {

        //        PatientName = createReceptionDto.PatientName,
        //        DoctorName = createReceptionDto.DoctorName,
        //        InsuranceName = createReceptionDto.InsuranceName,


        //    };


        //    _context.Receptions.Add(item);
        //    await _context.SaveChangesAsync();
        //    return Ok(await _context.Receptions.ToListAsync());
        //}

        //[HttpPut]
        //public async Task<ActionResult<List<UpdateReceptionDto>>> Update(UpdateReceptionDto request)
        //{
        //    var reception = await _context.Receptions.FindAsync(request.Id);
        //    if (reception == null)
        //        return BadRequest("Reception not found");
        //    reception.Id = request.Id;
        //    reception.PatientName = request.PatientName;
        //    reception.DoctorName = request.DoctorName;
        //    reception.Tests = request.Tests;



        //    await _context.SaveChangesAsync();
        //    return Ok(await _context.Receptions.ToListAsync());
        //}

        //[HttpDelete("{id}")]
        //public async Task<ActionResult<List<Reception>>> Delete(long id)
        //{
        //    var reception = await _context.Receptions.FindAsync(id);
        //    if (reception == null)
        //        return BadRequest("Reception not found");

        //    _context.Receptions.Remove(reception);
        //    await _context.SaveChangesAsync();

        //    return Ok(await _context.Receptions.ToListAsync());
        //}
    }
}
