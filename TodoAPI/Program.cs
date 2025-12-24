using Microsoft.Extensions.Options;
using TodoAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Adding dependency injection
builder.Services.AddSingleton<ITodoRepository, TodoRepository>();
  
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular", policy =>
        policy.WithOrigins("*") // Angular app URL from any port
              .AllowAnyMethod()
              .AllowAnyHeader());
});

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors("AllowAngular");

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
