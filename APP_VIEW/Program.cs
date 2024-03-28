var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
<<<<<<< HEAD

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=BanHang}/{action=TaiQuay}/{id?}");
app.MapControllerRoute(
    name: "Areas",
    pattern: "{controller=Admin}/{action=GetAllSanPham}/{id?}"
);
=======
app.MapControllerRoute(
    name: "Areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

>>>>>>> 36ae7ba50f23e2488b5d74626f33607b2c556019

app.Run();
