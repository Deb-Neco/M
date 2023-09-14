

using MiniChef.Domain.IRepository;
using MiniChef.Domain.IService;
using MiniChef.Repository;
using MiniChef.Service;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddTransient<IReceitasService, ReceitasService>();
//builder.Services.AddTransient<IReceitasRepository, ReceitasRepository>();
//builder.Services.AddTransient<IUserService, UserService>();
//builder.Services.AddTransient<IUserRepository, UserRepository>();

// Add services to the container.

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
