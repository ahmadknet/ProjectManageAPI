using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using ProjectManageAPI.Models;
using ProjectManageAPI.Data;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);


var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<PMDbContext>(option => option.UseSqlServer(connectionString));

builder.Services.AddControllers();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
