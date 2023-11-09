using BookingFast.Application.Dtos;

namespace BookingFast.Application.Services;

public interface IReservationsService
{
    Task<ReservationResponse> FindAllReservations();
    Task CreateNewReservation(ReservationDto reservationResponse);
    Task UpdateReservationStatus(string status, Guid id);
}