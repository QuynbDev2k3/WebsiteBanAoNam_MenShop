//using APP_API.IServices;
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
using APP_API.IServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<MyDbContext>(options =>
{
    options.UseSqlServer("Data Source=LAPTOP-LK8MUMJ8\\SQLEXPRESS;Initial Catalog=MenShop;User ID=duhvph21775;Password=123456;Encrypt=False");
});

// Thêm dịch vụ DbContext đã đăng ký từ bên ngoài
//builder.Services.AddDbContext<MyDbContext>(options =>
//{
//    options.UseSqlServer("Server=QUY\\SQLEXPRESS;Database=MenShop;Trusted_Connection=True;TrustServerCertificate=True");
//});

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<INhanVienService, NhanVienService>();
builder.Services.AddScoped<IHangService, HangService>();
builder.Services.AddScoped<ISanPhamService, SanPhamService>();
builder.Services.AddScoped<ICTSanPhamService, CTSanPhamService>();
builder.Services.AddDbContext<MyDbContext>(options =>
{
    options.UseSqlServer("Data Source=DESKTOP-L9J8TJS\\SQLEXPRESS;Initial Catalog=MenShop;Integrated Security=True;Encrypt=False");
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
