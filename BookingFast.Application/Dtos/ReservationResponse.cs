using BookingFast.Domain.Entities;

namespace BookingFast.Application.Dtos;

public class ReservationResponse
{
    public IEnumerable<ReservationDto> ReservationsDto { get; set; }
    public ReservationDto ReservationDto { get; set; }

    public ReservationResponse(Reservation reservation)
    {
        ReservationDto = ReservationsDto != null ? new ReservationDto(reservation) : null;
    }

    public ReservationResponse(IEnumerable<Reservation> reservations)
    {
        ReservationsDto = reservations.Select(r => new ReservationDto(r));
    }
}