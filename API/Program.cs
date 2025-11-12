using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Storage.Application.Automapper;
using Storage.Application.DTOs.Validation;
using Storage.Application.Services;
using Storage.Application.Services.Interfaces;
using Storage.Domain.Interfaces.Repositories;
using Storage.Infrastructure.Context;
using Storage.Infrastructure.Repositories;
using Swashbuckle.AspNetCore.SwaggerGen;

var builder = WebApplication.CreateBuilder(args);

// DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("SupabaseConnection")));

// AutoMapper
builder.Services.AddAutoMapper(typeof(Mapping));

// FluentValidation
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddFluentValidationClientsideAdapters();
builder.Services.AddValidatorsFromAssemblyContaining<CadastrarVoluntarioValidationDto>();
builder.Services.AddValidatorsFromAssemblyContaining<AtualizarVoluntarioValidationDto>();

// Repositories
builder.Services.AddScoped<IVoluntarioRepository, VoluntarioRepository>();
builder.Services.AddScoped<IChavesRepository, ChavesRepository>();

// Services
builder.Services.AddScoped<IVoluntarioService, VoluntarioService>();
builder.Services.AddScoped<IChavesService, ChavesService>();

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