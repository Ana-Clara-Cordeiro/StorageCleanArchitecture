using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Storage.Application.Automapper;
using Storage.Application.Services;
using Storage.Application.Services.Interfaces;
using Storage.Domain.Interfaces.Repositories;
using Storage.Infrastructure.Context;
using Storage.Infrastructure.Repositories;
using Swashbuckle.AspNetCore.SwaggerGen;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("SupabaseConnection")));

// AutoMapper
builder.Services.AddAutoMapper(typeof(Mapping));

// Repositories
builder.Services.AddScoped<IVoluntarioRepository, VoluntarioRepository>();

// Services
builder.Services.AddScoped<IVoluntarioService, VoluntarioService>();

// Controllers
builder.Services.AddControllers();
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