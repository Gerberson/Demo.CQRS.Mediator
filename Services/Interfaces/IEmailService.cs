namespace Demo.CQRS.Mediator.Services.Interfaces
{
    public interface IEmailService
    {
        void Send(string name, string email);
    }
}