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

    public async Task<List<ReservationDto>> FindAllReservations()
    {
        var reservations = await _reservationsRepository.FindAllReservations();
        return reservations.Select(reservation => new ReservationDto(reservation)).ToList();
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