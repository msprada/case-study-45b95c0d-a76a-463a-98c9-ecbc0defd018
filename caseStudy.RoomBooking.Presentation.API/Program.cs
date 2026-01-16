using System.Reflection.Metadata;

var builder = WebApplication.CreateBuilder(args);

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
