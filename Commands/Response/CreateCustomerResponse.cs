namespace Demo.CQRS.Mediator.Commands.Response
{
    public class CreateCustomerResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
    }
}