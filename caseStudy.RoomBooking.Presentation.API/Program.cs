using caseStudy.RoomBooking.Domain.Entities;
using caseStudy.RoomBooking.Domain.Repositories;
using caseStudy.RoomBooking.Infrastructure.Persistence;
using caseStudy.RoomBooking.Infrastructure;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructure(builder.Configuration);

// Register repositories
builder.Services.AddScoped<IRepository<User>, EFRepository<User>>();

// Add services to the container.
builder.Services.AddControllers();  // Enable MVC controllers

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapControllers();  // Map controller routes

app.Run();
