using CleanArchitecture.Application.Features.Services;
using CleanArchitecture.Persistance.Context;
using CleanArchitecture.Persistance.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

#region Dependency Injection Interface and Implement Class
builder.Services.AddScoped<ICarService, CarService>();
#endregion

#region Dependency Injection for AutoMapper
builder.Services.AddAutoMapper(typeof
    (CleanArchitecture.Persistance.AssemblyRefence).Assembly);
#endregion

#region SqlConnection
string connectionString = builder.Configuration.GetConnectionString("SqlServer");
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));
#endregion

builder.Services.AddControllers()
    .AddApplicationPart(typeof(CleanArchitecture.Presentation.AssemblyReference).Assembly);

#region MediatR Assembly service registration
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof
(CleanArchitecture.Application.AssemblyReference).Assembly));
#endregion

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
