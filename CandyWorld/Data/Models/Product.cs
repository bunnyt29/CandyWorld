namespace CandyWorld.Data.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public int Availability { get; set; }

        public string Flavour { get; set; }

        public double Price { get; set; }

        public int ProductCategoryId { get; set; }

        public ProductCategory ProductCategory { get; set; }

        public int CandyEmployeeId { get; set; }

        public CandyEmployee Chef { get; set; }

        public ICollection<Bill> Bills { get; set; } = new HashSet<Bill>();



    }
}
