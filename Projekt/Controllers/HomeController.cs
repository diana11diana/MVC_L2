using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Projekt.Models;
using Projekt.Data;

namespace Projekt.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public HomeController(
            UserManager<ApplicationUser> userManager,
            ApplicationDbContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        public IActionResult Index()
        {
            // Gość
            if (!User.Identity!.IsAuthenticated)
            {
                return View("GuestHome");
            }

            // Administrator
            if (User.IsInRole("Admin"))
            {
                DashboardViewModel model = new DashboardViewModel
                {
                    UsersCount = _context.Users.Count(),
                    ExercisesCount = _context.Exercises.Count(),
                    UserExercisesCount = _context.UserExercises.Count(),
                    CompletedExercisesCount = _context.UserExercises.Count(x => x.IsCompleted)
                };

                return View("AdminHome", model);
            }

            // Użytkownik
            string? userId = _userManager.GetUserId(User);

            DashboardViewModel userModel = new DashboardViewModel
            {
                ExercisesCount = _context.Exercises.Count(),
                UserExercisesCount = _context.UserExercises.Count(x => x.UserId == userId),
                CompletedExercisesCount = _context.UserExercises.Count(x =>
                    x.UserId == userId &&
                    x.IsCompleted)
            };

            return View("UserHome", userModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}