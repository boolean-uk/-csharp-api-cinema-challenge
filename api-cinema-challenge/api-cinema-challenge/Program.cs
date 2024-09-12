using api_cinema_challenge.Data;
using api_cinema_challenge.Endpoints;
using api_cinema_challenge.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CinemaContext>();
builder.Services.AddScoped<IRepository, Repository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.PurgeCinemaDbTables();
app.SeedCinemaApi();

app.ConfigureCustomerApi();
app.ConfigureMovieApi();

app.Run();
