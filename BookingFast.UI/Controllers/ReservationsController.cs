using BookingFast.Application.Dtos;
using BookingFast.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookingFast.UI.Controllers;

[ApiController]
[Route("[controller]")]
public class ReservationsController : Controller
{
    private readonly ReservationsService _reservationsService;

    public ReservationsController(ReservationsService reservationsService)
    {
        _reservationsService = reservationsService;
    }

    [HttpGet]
    public async Task<ActionResult<ReservationResponse>> FindAllReservations()
    {
        var reservations = await _reservationsService.FindAllReservations();
        return Ok(reservations);
    }

    [HttpPost]
    public async Task<IActionResult> CreateNewReservation([FromBody] ReservationDto reservation)
    {
        await _reservationsService.CreateNewReservation(reservation);
        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateReservationStatus(string status, Guid id)
    {
        await _reservationsService.UpdateReservationStatus(status, id);
        return Ok();
    }
}