namespace Demo.CQRS.Mediator.Models
{
    public class Product
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public double Price { get; private set; }

        public Product(string name, double price)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Price = price;
        }
    }
}