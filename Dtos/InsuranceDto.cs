namespace Hospital.Dtos
{
    public class InsuranceDto
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public long Discount { get; set; }

        public long DiscountCeiling { get; set; }
    }

    public class CreateInsuranceDto
    {
        public string Name { get; set; }

        public long Discount { get; set; }

        public long DiscountCeiling { get; set; }
    }

    public class UpdateInsuranceDto
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public long Discount { get; set; }

        public long DiscountCeiling { get; set; }
    }
}
