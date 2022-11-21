using API.Data;
using API.Data.Repositories;
using API.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<TesteDBContext>(
    options => options.UseSqlServer("name=ConnectionStrings:TesteDB"));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddRepositories();
builder.Services.AddServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

    using IServiceScope scope = app.Services.CreateScope();
    TesteDBContext db = scope.ServiceProvider.GetRequiredService<TesteDBContext>();
    db.Database.EnsureDeleted();
    db.Database.EnsureCreated();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
