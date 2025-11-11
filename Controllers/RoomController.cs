using HotelHub.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace HotelHub.Controllers
{
    public class RoomController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RoomController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Room
        public IActionResult Index()
        {
            var rooms = _context.Rooms.ToList();
            return View(rooms);
        }

        // GET: Room/Details/5
        public IActionResult Details(int id)
        {
            var room = _context.Rooms.FirstOrDefault(r => r.Id == id);
            if (room == null)
            {
                return NotFound();
            }
            return View(room);
        }
    }
}