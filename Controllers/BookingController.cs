using Microsoft.AspNetCore.Mvc;
using CarServiceProject.Models;

namespace CarServiceProject.Controllers
{
    public class BookingController : Controller
    {
        private readonly IBookingManager _bookingManager;

        public BookingController(IBookingManager bookingManager)
        {
            _bookingManager = bookingManager;
        }

        [HttpPost]
        public IActionResult AddBooking(Booking booking)
        {
            _bookingManager.AddBooking(booking);
            return RedirectToAction("Index", "Home");
        }
    }
}

