using Microsoft.EntityFrameworkCore;
using ShoppingCartDataAccess.DataAccess;
using ShoppingCartDataAccess.DBEntities;
using ShoppingCartDataAccess.Repositories;
using ShoppingCartDataAccess.BuisnessLogic;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDbContext>(x=>x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConn")));
builder.Services.AddAutoMapper(typeof(Program).Assembly);
builder.Services.AddScoped<IProducts, ProductsBL>();
builder.Services.AddScoped<ICategory, CategoryBL>();

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
