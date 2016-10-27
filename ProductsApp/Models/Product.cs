namespace ProductsApp.Models
{
    public interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
        string Category { get; set; }
        decimal Price { get; set; }
    }
    public class Product : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}