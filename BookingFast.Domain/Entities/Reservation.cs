namespace BookingFast.Domain.Entities;

public class Reservation
{
    public Reservation(Guid id, string guestName, DateTime checkInDate, DateTime checkOutDate, string status)
    {
        Id = id;
        GuestName = guestName;
        CheckInDate = checkInDate;
        CheckOutDate = checkOutDate;
        Status = status;
    }

    public Guid Id { get; set; }
    public string? GuestName { get; set; }
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
    public string? Status { get; set; }
}