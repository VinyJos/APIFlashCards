global using APIEnglishFlashCards;
using APIEnglishFlashCards.DataBase;
using APIEnglishFlashCards.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// injeção de dependência para entity framework
builder.Services.AddDbContext<APIEnglishFlashCardsContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("APIFlashCards"))
    );

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
