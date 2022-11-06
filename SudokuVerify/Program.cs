using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using SudokuVerify.Application.Interfaces;
using SudokuVerify.Application.Services;
using SudokuVerify.Domain.Interfaces.Repositories;
using SudokuVerify.Domain.Interfaces.Services;
using SudokuVerify.Domain.Services;
using SudokuVerify.Infra.Data.Context;
using SudokuVerify.Infra.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ISudokuCheckedRepository, SudokuCheckedRepository>();
builder.Services.AddScoped<ISudokuCheckedService, SudokuCheckedService>();
builder.Services.AddScoped<ISudokuCheckedAppService, SudokuCheckedAppService>();

builder.Services.AddDbContext<BaseContext>(options => options.UseInMemoryDatabase(databaseName: "MockDB"));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSwagger(x => x.SerializeAsV2 = true);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
