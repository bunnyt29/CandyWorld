namespace CandyWorld.Data.Models
{
    public class ProductCategory
    {
        public int ProductCategoryId { get; set; }

        public string Name { get; set; }

        public ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}
