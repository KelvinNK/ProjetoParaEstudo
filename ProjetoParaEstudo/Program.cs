using ProjetoParaEstudo.Domain.Data;
using ProjetoParaEstudo.Domain.Entity;
using ProjetoParaEstudo.Domain.Repositories;
using ProjetoParaEstudo.Domain.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<LolDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("LolDB")));
//Comando migrations, como o DataContext está em um projeto separado é necessário apontar para o csproj do projeto onde o appSettings se encontra, utilize -s.
//A partir da pasta ProjetoParaEstudo.Domain
//dotnet ef migrations add InitialCreation -s ..\ProjetoParaEstudo\ProjetoParaEstudo.csproj
//dotnet ef database update -s ..\ProjetoParaEstudo\ProjetoParaEstudo.csproj

builder.Services.AddMediatR(x => x.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.Load("ProjetoParaEstudo.Domain")));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.Load("ProjetoParaEstudo.Domain"));

builder.Services.AddScoped<IRepository<Personagem>, PersonagemRepository>();

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
