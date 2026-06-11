using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projekt.Data;
using Projekt.Models;

namespace Projekt.Controllers;

[Authorize]
public class UserDashboardController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;

    public UserDashboardController(
        ApplicationDbContext context,
        UserManager<ApplicationUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    public async Task<IActionResult> Index()
    {
        var userId = _userManager.GetUserId(User);

        var model = new UserDashboardViewModel
        {
            AllExercisesCount = await _context.Exercises.CountAsync(),

            MyExercisesCount = await _context.UserExercises
                .CountAsync(x => x.UserId == userId),

            CompletedExercisesCount = await _context.UserExercises
                .CountAsync(x => x.UserId == userId && x.IsCompleted),

            NotCompletedExercisesCount = await _context.UserExercises
                .CountAsync(x => x.UserId == userId && !x.IsCompleted)
        };

        return View(model);
    }
}