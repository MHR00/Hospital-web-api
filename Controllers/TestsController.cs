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
    public class TestsController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        private readonly ITestRepository _ItestRepository;
        public TestsController(DataContext context, IMapper mapper , ITestRepository testRepository)
        {
            _context = context;
            _mapper = mapper;
            _ItestRepository = testRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
           var result = await _ItestRepository.GetAllTestAsync();
            return Ok(result);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetById(long Id)
        {
            var result = await _ItestRepository.GetTestByIdAsync(Id);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateTestDto createTestDto)
        {
            var id = await _ItestRepository.AddTestAsync(createTestDto);
            return CreatedAtAction(nameof(GetById), new { Id = id, controller = "Tests" }, id);
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
