using APP_API.IServices;
using APP_API.Services;
using APP_DATA.Context;
using APP_DATA.IRepositories;
using APP_DATA.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MyDbContext>(options =>
{
    options.UseSqlServer("Server=LAPTOP-B9NKF2E2\\SQLEXPRESS;Database=MenShop;Trusted_Connection=True;TrustServerCertificate=True");
});
//builder.Services.AddScoped<IGioHangRepository, GioHangRepository>();
//builder.Services.AddScoped<IGioHangService, GioHangService>();

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
