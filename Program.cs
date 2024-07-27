using CarServiceProject.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<CarServiceDbContext>(options =>
    {
        options.UseNpgsql(builder.Configuration["ConnectionStrings:CarServiceProjectDbContextConnectionPostgres"]);
    }
);

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IContactInfoRepository, ContactInfoRepository>();
builder.Services.AddScoped<ICustomerFeedbackRepository, CustomerFeedbackRepository>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IInventoryItemRepository, InventoryItemRepository>();
builder.Services.AddScoped<IServiceRepository, ServiceRepository>();
builder.Services.AddScoped<IBookingRepository, BookingRepository>();
builder.Services.AddScoped<IBookingManager, BookingManager>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

DbInitializer.Seed(app);
app.Run();
