namespace Hospital.Entities
{
    public class Test
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public long? ReceptionId { get; set; }
        public Reception Reception { get; set; }

    }
}
