using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Vehicle_Branding;
using Vehicle_Branding.Data;
using Vehicle_Branding.DomainLL.Repository.IRepository;
using Vehicle_Branding.Repository;
using Vehicle_Branding.Services;
using Vehicle_Branding.Services.IVehicle;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("VehicelConnection")));
builder.Services.AddScoped<IVehicleRepository, Vehicle>();
builder.Services.AddScoped<IVehicleService, VehicleService>();

IMapper mapper = MapperConfig.RegisterMapper().CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
