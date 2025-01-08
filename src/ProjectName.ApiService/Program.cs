using ProjectName.Core.Application.Interfaces.IRepositories;
using ProjectName.Core.Application.Interfaces.IServices;
using ProjectName.Core.Application.Services;
using ProjectName.Core.Application.UnitOfWork;
using ProjectName.DataAccess;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

// Add services to the container.
// Repositories and Unit of Work
// Register Unit of Work and Generic Repositories
builder.Services.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));  // Register UnitOfWork for DI
builder.Services.AddScoped(typeof(IRepository<>), typeof(GenericService<>));  // Generic Repository
builder.Services.AddScoped(typeof(IService<>), typeof(GenericService<>));  // Generic Service

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

app.MapDefaultEndpoints();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
