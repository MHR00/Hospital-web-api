namespace Hospital.Entities
{
    public class Insurance
    {
        public long Id { get; set; }
        public string Name { get; set; }    

        public long Discount { get; set; }

        public long DiscountCeiling { get; set; }
    }
}
