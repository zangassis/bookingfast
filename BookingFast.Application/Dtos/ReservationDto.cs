using BookingFast.Domain.Entities;

namespace BookingFast.Application.Dtos;

public class ReservationDto
{
    public ReservationDto() { }

    public ReservationDto(Reservation reservation)
    {
        Id = reservation.Id;
        GuestName = reservation.GuestName;
        CheckInDate = reservation.CheckInDate;
        CheckOutDate = reservation.CheckOutDate;
        Status = reservation.Status;
    }

    public Guid Id { get; set; }
    public string? GuestName { get; set; }
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
    public string? Status { get; set; }
}