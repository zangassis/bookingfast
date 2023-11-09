using BookingFast.Application.Dtos;
using BookingFast.Domain.Entities;
using BookingFast.Domain.Infra.Interfaces;

namespace BookingFast.Application.Services;

public class ReservationsService : IReservationsService
{
    private readonly IReservationsRepository _reservationsRepository;

    public ReservationsService(IReservationsRepository reservationsRepository)
    {
        _reservationsRepository = reservationsRepository;
    }

    public async Task<ReservationResponse> FindAllReservations()
    {
        var reservations = await _reservationsRepository.FindAllReservations();
        return new ReservationResponse(reservations);
    }

    public async Task CreateNewReservation(ReservationDto reservation)
    {
        var newReservation = new Reservation(reservation.Id, reservation.GuestName, reservation.CheckInDate, reservation.CheckOutDate, reservation.Status);
        await _reservationsRepository.InsertReservation(newReservation);
    }

    public async Task UpdateReservationStatus(string status, Guid id)
    {
        await _reservationsRepository.UpdateReservationStatus(status, id);
    }
}