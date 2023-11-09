using BookingFast.Domain.Entities;

namespace BookingFast.Domain.Infra.Interfaces;

public interface IReservationsRepository
{
    Task<IEnumerable<Reservation>> FindAllReservations();
    Task InsertReservation(Reservation reservation);
    Task UpdateReservationStatus(string status, Guid id);
}