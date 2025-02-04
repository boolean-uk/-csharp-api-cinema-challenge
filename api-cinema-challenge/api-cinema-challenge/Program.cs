using api_cinema_challenge;
using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using exercise.cinemaapi.EndPoints;
using workshop.wwwapi.Repository; 

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddScoped<IRepository<Customer>, Repository<Customer>>();
builder.Services.AddScoped<IRepository<Movie>, Repository<Movie>>();
builder.Services.AddScoped<IRepository<Ticket>, Repository<Ticket>>();
builder.Services.AddScoped<IRepository<Screening>, Repository<Screening>>();
builder.Services.AddDbContext<DataContext>();
builder.Services.AddAutoMapper(typeof(Program));
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

app.ConfigureCinemaApi();

app.SeedDatabase();

app.Run();
