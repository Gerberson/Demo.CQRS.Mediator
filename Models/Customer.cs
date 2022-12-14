namespace Demo.CQRS.Mediator.Models
{
    public class Customer
    {
        public Customer(string name, string email)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Email = email;
        }

        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
    }
}