using CarServiceProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarServiceProject.Api;

public class BookingsController: ControllerBase
{
    private readonly IBookingManager _bookingManager;

    public BookingsController(IBookingManager bookingManager)
    {
        _bookingManager = bookingManager;
    }

    [HttpPost]
    [Route("/api/bookings")]
    public IActionResult CreateBooking([FromBody]  Booking booking)
    {
        if (booking==null)
        {
            
            return BadRequest("Request should not be empty");
        }
        _bookingManager.AddBooking(booking);
        return Ok();
    }
    
    [HttpGet]
    [Route("/api/bookings/{id}")]
    public ActionResult GetBookingById(int id)
    {
        // Retrieve booking from the database by ID
        Booking booking = _bookingManager.GetBookingById(id);

        if (booking == null)
        {
            return NotFound();
        }

        return new JsonResult(booking);
    }
    
    [HttpGet]
    [Route("/api/bookings")]
    public ActionResult GetAllBookings()
    { 
        return new JsonResult(_bookingManager.GetAllBookings());
    }
    
    [HttpPut]
    [Route("/api/bookings/{id}")]
    public IActionResult UpdateBooking(int id, [FromBody] Booking booking)
    {
        if (id != booking.Id)
        {
            return BadRequest("ID of the object and ID in the request are not matching");
        }
        
        _bookingManager.UpdateBooking(booking);
        return Ok();
    }
    
    [HttpDelete]
    [Route("/api/bookings/{id}")]
    public IActionResult DeleteBooking(int id)
    {
        Booking booking = _bookingManager.GetBookingById(id);
        
        if (booking == null)
        {
            return NotFound();
        }
        
        _bookingManager.DeleteBooking(booking);
        return NoContent();
    }
}