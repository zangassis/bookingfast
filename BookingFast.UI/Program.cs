using BookingFast.Application.Services;
using BookingFast.Domain.Infra.Interfaces;
using BookingFast.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Configure<ReservationsDatabaseSettings>(builder.Configuration.GetSection("ReservationsDatabaseSettings"));
builder.Services.AddSingleton<IReservationsRepository, ReservationsRepository>();
builder.Services.AddScoped<IReservationsService, ReservationsService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
