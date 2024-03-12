using Demo.Listings.Infrastructure.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddAutoMapper(typeof(Demo.Listings.Api.Mappers.MapperConfig), typeof(Demo.Listings.Infrastructure.Mappers.MapperConfig));
builder.Services.AddCustomServices();

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

// var db = app.Services.GetService<ListingsDbContext>();
// if (db.Database.EnsureCreated()) {
//     Demo.Listings.Infrastructure.SeedData.SeedDataToDb(db);
// }

var scopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();
using (var scope = scopeFactory.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ListingsDbContext>();
    if (db.Database.EnsureCreated()) {
        Demo.Listings.Infrastructure.SeedData.SeedDataToDb(db);
    }
}

app.Run();


