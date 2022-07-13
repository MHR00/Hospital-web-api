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
    public class InsurancesController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public InsurancesController(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<InsuranceDto>>> Get()
        {
            return Ok(await _context.Insurances.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Insurance>> GetById(long Id)
        {
            var insurance = await _context.Insurances.FindAsync(Id);
            if (insurance == null)
                return BadRequest("Docter not found");
            return Ok(_mapper.Map<InsuranceDto>(insurance));
        }

        [HttpPost]
        public async Task<ActionResult<List<CreateInsuranceDto>>> AddDoctor(CreateInsuranceDto createInsuranceDto)
        {
            var docter = new Insurance()
            {

                Name = createInsuranceDto.Name,
                Discount = createInsuranceDto.Discount,    
                DiscountCeiling = createInsuranceDto.DiscountCeiling,

            };


            _context.Insurances.Add(docter);
            await _context.SaveChangesAsync();
            return Ok(await _context.Insurances.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<UpdateInsuranceDto>>> Update(UpdateInsuranceDto request)
        {
            var insurance = await _context.Insurances.FindAsync(request.Id);
            if (insurance == null)
                return BadRequest("Insurance not found");
            insurance.Id = request.Id;
            insurance.Name = request.Name;
            insurance.Discount = request.Discount;
            insurance.DiscountCeiling = request.DiscountCeiling;


            await _context.SaveChangesAsync();
            return Ok(await _context.Insurances.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Insurance>>> Delete(long id)
        {
            var insurance = await _context.Insurances.FindAsync(id);
            if (insurance == null)
                return BadRequest("Insurance not found");

            _context.Insurances.Remove(insurance);
            await _context.SaveChangesAsync();

            return Ok(await _context.Insurances.ToListAsync());
        }
    }
}
