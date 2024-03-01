using APP_API.IServices;
using APP_API.Services;
using APP_DATA.Context;
using APP_DATA.IRepositories;
using APP_DATA.Models;
using APP_DATA.Repositories;
using Microsoft.EntityFrameworkCore;
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
// Thêm dịch vụ DbContext đã đăng ký từ bên ngoài
// builder.Services.AddDbContext<MyDbContext>(options =>
// {
//     options.UseSqlServer("Server=QUY\\SQLEXPRESS;Database=MenShop;Trusted_Connection=True;TrustServerCertificate=True");
// });

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<INhanVienService, NhanVienService>();
builder.Services.AddScoped<IHangService, HangService>();
builder.Services.AddScoped<ISanPhamService, SanPhamService>();
builder.Services.AddScoped<ICTSanPhamService, CTSanPhamService>();
// builder.Services.AddDbContext<MyDbContext>(options =>
// {
//     options.UseSqlServer("Server=LAPTOP-B9NKF2E2\\SQLEXPRESS;Database=MenShop;Trusted_Connection=True;TrustServerCertificate=True");
// });
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
