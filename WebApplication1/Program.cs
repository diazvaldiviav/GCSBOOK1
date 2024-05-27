using Microsoft.EntityFrameworkCore;
using System;
using WebApplication1.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<BookContext>(
    option => option.UseNpgsql(builder.Configuration.GetConnectionString("WebApiDatabase"))

    );


var app = builder.Build();

//var Configuration = builder.Configuration;
//builder.Services.AddDbContext<BookContext>(options =>
//        options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));

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
