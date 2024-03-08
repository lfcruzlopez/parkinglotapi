using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using ParkingLotApi.Contracts;
using ParkingLotApi.Data.Context;
using ParkingLotApi.Models;
using ParkingLotApi.Repositories;
using ParkingLotApi.Services;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Set up the connection string.
string? connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Add DbContext
builder.Services.AddDbContext<ParkingLotDataContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",b => b
        .AllowAnyHeader()
        .AllowAnyOrigin()
        .AllowAnyMethod());
});
 
builder.Services.AddControllers()
    .AddJsonOptions(options => { options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()); });

builder.Host.UseSerilog( (context, loggerConf)  => 
    loggerConf.WriteTo.Console()
        .ReadFrom.Configuration(context.Configuration)
);

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<ParkingLotRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ParkingLotService>();
//Create the app
var app = builder.Build();

// Configure middleware.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSerilogRequestLogging();

//app.UseHttpsRedirection();

app.UseCors("AllowAll");

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    if (endpoints != null)
    {
        endpoints.MapGet("/api/parkinglot/pagenumber={pageNumber}&pageSize={pageSize}",
            (async (ParkingLotService parkingService, int pageNumber, int pageSize) =>
            {
                var result = await parkingService.GetParkingLotAsync(pageNumber, pageSize);
                return result;
            }));
        
        endpoints.MapGet("/api/user/pagenumber={pageNumber}&pageSize={pageSize}",
            (async (IUserService userService, int pageNumber, int pageSize) =>
            {
                var result = await userService.GetUsersPaginatedAsync(pageNumber, pageSize);
                return result;
            }));
        endpoints.MapGet("/api/user/Id/{id}",
            (async (IUserService userService, Guid id ) =>
            {
                var result = await userService.GetUserById(id);
                return result;
            }));
        endpoints.MapGet("/api/user/number/{userNumber}",
            (async (IUserService userService, int userNumber ) =>
            {
                var result = await userService.GetUserByNumberAsync(userNumber);
                return result;
            }));
        endpoints.MapGet("/api/user/{userName}",
            (async (IUserService userService, string userName ) =>
            {
                var result = await userService.GetUserByUsernameAsync(userName);
                return result;
            }));
        
    }
});

 
app.Run();

[JsonSerializable(typeof(List<ParkingLotResponse>))]
[JsonSerializable(typeof(List<UserModel>))]
[JsonSerializable(typeof(UserModel))]
internal partial class AppJsonSerializerContext : JsonSerializerContext
{
}