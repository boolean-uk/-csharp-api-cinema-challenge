using api_cinema_challenge.Data;
using api_cinema_challenge.EndPoint;
using api_cinema_challenge.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<CinemaContext>();
builder.Services.AddScoped<IRepository, Repository>();
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

app.MapControllers();

app.ConfigureCinemaEndPoint();

app.SeedCinemaApi();

app.Run();
