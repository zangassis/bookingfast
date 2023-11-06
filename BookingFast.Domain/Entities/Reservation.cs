namespace BookingFast.Domain.Entities;

public class Reservation
{
    public Guid Id { get; set; }
    public string? GuestName { get; set; }
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
    public string? Status { get; set; }
}