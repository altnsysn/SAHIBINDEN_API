using UserService.Service.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();



builder.Services.AddSingleton<IUserService,UserService.Service.Service.UserService>();
builder.Services.AddSingleton<UserService.Repository.Interface.IUserRepository, UserService.Repository.Repository.UserRepository>();




var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
