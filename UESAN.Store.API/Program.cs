                                    // son las librerias para la conexion
using Microsoft.EntityFrameworkCore;
using UESAN.Store.INFRAESTRUCTURE.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
                                            // esttos pasos se modifican
var _config = builder.Configuration;
var _cnx = _config.GetConnectionString("DevConnection");
builder.Services
    .AddDbContext<StoreDbContext>
    (options =>options.UseSqlServer(_cnx));
                                            // hasta aca :V
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
