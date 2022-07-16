using AutoMapper;
using Hospital.Data;
using Hospital.Dtos;
using Hospital.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Repository
{
    public class TestRepository : ITestRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public TestRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<long> AddTestAsync(CreateTestDto createTestDto)
        {
            var item = new Test()
            {
                Name = createTestDto.Name,
                Price = createTestDto.Price,
            };
            _context.Tests.Add(item);
            await _context.SaveChangesAsync();

            return item.Id;
        }

        public Task DeleteTestAsync(long testId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TestDto>> GetAllTestAsync()
        {
            var records = await _context.Tests.ToListAsync();
            return _mapper.Map<List<TestDto>>(records);
        }

        public async Task<TestDto> GetTestByIdAsync(long Id)
        {

            var result = await _context.Tests.Where(x => x.Id == Id).Select(x => new TestDto
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price
            }).FirstOrDefaultAsync();

            return result;



            //var result = _context.Tests.FindAsync(Id);
            //return _mapper.Map<TestDto>(result);

        }

        public Task UpadteTestAsync(long testId, TestDto testDto)
        {
            throw new NotImplementedException();
        }
    }
}
