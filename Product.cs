namespace Product
{
    public class Product
    {
        private int Id { get; }
        public string? Brand { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public Product(int id,string? brand, string? name, decimal price)
        {
            Id = id;
            Brand = brand;
            Name = name;
            Price = price;
        }
    }
}
