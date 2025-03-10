
using api_filmes_senai.Repositories;
using api_filmes_senai1.Context;
using api_filmes_senai1.interfaces;
using api_filmes_senai1.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adiciona o contexto do banco de dados (exemplo com SQL Server)
builder.Services.AddDbContext<Filmes_Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


//Adicionar o repositorio e a interface ao container de dependencia 
builder.Services.AddScoped<IGeneroRepository, GeneroRepository>();

//Adicionar o servi�o de controllers
builder.Services.AddControllers();

var app = builder.Build();

//Adicionar o mapeamento dos controllers 
app.MapControllers();

app.Run();
