using BookingFast.Application.Dtos;

namespace BookingFast.Application.Services;

public interface IReservationsService
{
    Task<List<ReservationDto>> FindAllReservations();
    Task CreateNewReservation(ReservationDto reservation);
    Task UpdateReservationStatus(string status, Guid id);
}