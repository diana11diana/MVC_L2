using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projekt.Data;
using Projekt.Models;

namespace Projekt.Controllers;

[Authorize]
public class PremiumController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly ApplicationDbContext _context;

    public PremiumController(
        UserManager<ApplicationUser> userManager,
        ApplicationDbContext context)
    {
        _userManager = userManager;
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var user = await _userManager.GetUserAsync(User);

        if (user != null && user.IsPremium)
        {
            var total = await _context.UserExercises
                .CountAsync(x => x.UserId == user.Id);

            var completed = await _context.UserExercises
                .CountAsync(x => x.UserId == user.Id && x.IsCompleted);

            var active = total - completed;

            var percent = total > 0 ? completed * 100 / total : 0;

            var totalMinutes = await _context.UserExercises
                .Where(x => x.UserId == user.Id && x.IsCompleted)
                .Include(x => x.Exercise)
                .SumAsync(x => x.Exercise != null ? x.Exercise.Duration : 0);

            var model = new DashboardViewModel
            {
                UserExercisesCount = total,
                CompletedExercisesCount = completed,
                ActiveExercisesCount = active,
                ProgressPercent = percent,
                TotalTrainingMinutes = totalMinutes
            };

            return View("PremiumPanel", model);
        }

        return View();
    }

    public IActionResult Payment()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> ConfirmPayment()
    {
        var user = await _userManager.GetUserAsync(User);

        if (user != null)
        {
            user.IsPremium = true;
            await _userManager.UpdateAsync(user);
        }

        return RedirectToAction(nameof(Index));
    }
}