using Microsoft.EntityFrameworkCore;
using StudentData.Entity.Models;
using StudentData.Repository.Contract;
using StudentData.Repository.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddDbContext<STDataDbContext>();
//builder.Services.AddScoped<IStudentBusiness, StudentBusiness>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();




//To use connectionString for Db connections (EF).
builder.Services.AddDbContext<StudentMasterContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("STDataConnectionStrings"));
});

//To use Automapper.
//builder.Services.AddAutoMapper(c =>
//{
//    c.AddExpressionMapping();
//}, typeof(AutoMapperProfiles).Assembly);

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
