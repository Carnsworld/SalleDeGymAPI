using Microsoft.EntityFrameworkCore;
using SalleDeGymAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure DbContext to use SQL Server
builder.Services.AddDbContext<SalleDeGymContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SalleDeGymConnection")));

var app = builder.Build();


