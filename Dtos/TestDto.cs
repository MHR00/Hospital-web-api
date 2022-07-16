using Hospital.Entities;

namespace Hospital.Dtos
{
    public class TestDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public long? ReceptionId { get; set; }
        public Reception Reception { get; set; }
    }

    public class CreateTestDto
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }

    public class UpdateTestDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
