using HotelHub.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace HotelHub.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Account/Register
        public IActionResult Register()
        {
            return View();
        }

        // POST: Account/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(User user)
        {
            if (ModelState.IsValid)
            {
                // Hash the password (use a library like BCrypt in production)
                user.PasswordHash = user.PasswordHash; // Placeholder for hashing logic
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            return View(user);
        }

        // GET: Account/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string username, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == username);
            if (user != null && user.PasswordHash == password) // Replace with hashed password check
            {
                // Set session or authentication logic here
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "Invalid login attempt.");
            return View();
        }

        // GET: Account/Logout
        public IActionResult Logout()
        {
            // Clear session or authentication logic here
            return RedirectToAction("Index", "Home");
        }
    }
}