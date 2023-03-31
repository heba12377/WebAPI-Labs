using Day2.DAL.Context;
using Day2.DAL.Repos.TicketsRepo;
using Day2.BL.Managers;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DB Connection
var connectionString = builder.Configuration.GetConnectionString("TicketDb");
builder.Services.AddDbContext<TicketContext>(options =>
    options.UseSqlServer(connectionString));

// Repos

builder.Services.AddScoped<ITicketsRepo, TicketsRepo>();

// Managers


builder.Services.AddScoped<ITicketsManager, TicketsManager>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
