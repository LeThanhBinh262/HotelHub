using HotelHub.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace HotelHub.Controllers
{
    public class BookingController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BookingController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Booking
        public IActionResult Index()
        {
            var bookings = _context.Bookings.ToList();
            return View(bookings);
        }

        // GET: Booking/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Booking/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Booking booking)
        {
            if (ModelState.IsValid)
            {
                _context.Bookings.Add(booking);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(booking);
        }
    }
}