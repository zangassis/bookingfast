using BookingFast.Domain.Entities;
using BookingFast.Domain.Infra.Interfaces;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace BookingFast.Infrastructure.Repositories;

public class ReservationsRepository : IReservationsRepository
{
    private readonly IMongoCollection<Reservation> _reservations;

    public ReservationsRepository(IOptions<ReservationsDatabaseSettings> options)
    {
        var mongoClient = new MongoClient(options.Value.ConnectionString);

        _reservations = mongoClient
            .GetDatabase(options.Value.DatabaseName)
            .GetCollection<Reservation>(options.Value.CollectionName);
    }

    public async Task<IEnumerable<Reservation>> FindAllReservations()
    {
        if (_reservations == null)
            return Enumerable.Empty<Reservation>();

        return await _reservations.Find(_ => true).ToListAsync();
    }

    public async Task InsertReservation(Reservation reservation)
    {
        await _reservations.InsertOneAsync(reservation);
    }

    public async Task UpdateReservationStatus(string status, Guid id)
    {
        var reservation = await _reservations.Find(a => a.Id == id).SingleOrDefaultAsync();
        reservation.Status = status;
        await _reservations.ReplaceOneAsync(a => a.Id == id, reservation);
    }
}