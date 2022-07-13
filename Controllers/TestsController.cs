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
    public class TestsController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public TestsController(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<TestDto>>> Get()
        {
            return Ok(await _context.Tests.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Test>> GetById(long Id)
        {
            var test = await _context.Tests.FindAsync(Id);
            if (test == null)
                return BadRequest("Docter not found");
            return Ok(_mapper.Map<TestDto>(test));
        }

        [HttpPost]
        public async Task<ActionResult<List<CreateTestDto>>> AddDoctor(CreateTestDto createTestDto)
        {
            var docter = new Test()
            {

                Name = createTestDto.Name,
                Price = createTestDto.Price,
                

            };


            _context.Tests.Add(docter);
            await _context.SaveChangesAsync();
            return Ok(await _context.Tests.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<UpdateTestDto>>> Update(UpdateTestDto request)
        {
            var test = await _context.Tests.FindAsync(request.Id);
            if (test == null)
                return BadRequest("Test not found");
            test.Id = request.Id;
            test.Name = request.Name;
            test.Price = request.Price;
          


            await _context.SaveChangesAsync();
            return Ok(await _context.Tests.ToListAsync());
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Test>>> Delete(long id)
        {
            var test = await _context.Tests.FindAsync(id);
            if (test == null)
                return BadRequest("Test not found");

            _context.Tests.Remove(test);
            await _context.SaveChangesAsync();

            return Ok(await _context.Tests.ToListAsync());
        }

    }
}
