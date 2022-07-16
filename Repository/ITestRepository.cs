using Hospital.Dtos;

namespace Hospital.Repository
{
    public interface ITestRepository
    {
        Task<List<TestDto>> GetAllTestAsync();
        Task<TestDto> GetTestByIdAsync(long Id);
        Task<long> AddTestAsync(CreateTestDto createTestDto);
        Task UpadteTestAsync(long testId, TestDto testDto);
        Task DeleteTestAsync(long testId);  
    }
}
