using System.Reflection;
using Demo.CQRS.Mediator.IoC.Extensions.DI;
using MediatR;
using Raven.Client.Documents;
using Raven.Client.Documents.Session;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

builder.Services
    .AddRespositoriesDI()
    .AddHandlersDI()
    .AddServicesDI();

var store = new DocumentStore
{
    Urls =  new[] { "http://localhost:8080" },
    Database = "cqrs",
};

store.Initialize();
builder.Services.AddSingleton<IDocumentStore>(store);
builder.Services.AddScoped<IAsyncDocumentSession>(serviceProvider =>
{
    return serviceProvider.GetService<IDocumentStore>().OpenAsyncSession();
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
