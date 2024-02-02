using api_cinema_challenge.Data;
using api_cinema_challenge.Endpoints;
using api_cinema_challenge.Repository;
using api_cinema_challenge.Repository.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CinemaContext>();
builder.Services.AddScoped<ICustomerRepository,CustomerRepository>();
builder.Services.AddScoped<IMovieRepository,MovieRepository>();
builder.Services.AddScoped<ITicketRepository,TicketRepository>();
builder.Services.AddScoped<IScreeningRepository,ScreeningRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.ConfigureCustomerEndpoints();
app.ConfigureMoviesEndpoints();
app.ConfigureScreeningEndpoints();
app.ConfigureTicketsEndpoints();
app.Run();
