using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projekt.Data;
using Projekt.Models;

namespace Projekt.Controllers;

[Authorize(Roles = "Admin")]
public class AdminController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;

    public AdminController(
        ApplicationDbContext context,
        UserManager<ApplicationUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    public async Task<IActionResult> Index()
    {
        ViewBag.UsersCount = await _userManager.Users.CountAsync();
        ViewBag.ExercisesCount = await _context.Exercises.CountAsync();
        ViewBag.UserExercisesCount = await _context.UserExercises.CountAsync();
        ViewBag.CompletedExercisesCount = await _context.UserExercises.CountAsync(x => x.IsCompleted);

        return View();
    }
[Authorize(Roles = "Admin")]
public async Task<IActionResult> Users(string? searchString)
{
    var users = await _userManager.Users.ToListAsync();

    if (!string.IsNullOrWhiteSpace(searchString))
    {
        users = users
            .Where(u =>
                (u.Email != null && u.Email.Contains(searchString, StringComparison.OrdinalIgnoreCase)) ||
                (u.FullName != null && u.FullName.Contains(searchString, StringComparison.OrdinalIgnoreCase)))
            .ToList();
    }

    var model = new List<AdminUserViewModel>();

    foreach (var user in users)
    {
        var roles = await _userManager.GetRolesAsync(user);

        model.Add(new AdminUserViewModel
        {
            Email = user.Email ?? "-",
            FullName = string.IsNullOrWhiteSpace(user.FullName) ? "-" : user.FullName,
            Roles = string.Join(", ", roles),
            RegisteredAt = user.RegisteredAt,
            LastLoginAt = user.LastLoginAt,
            LastLogoutAt = user.LastLogoutAt
        });
    }

    ViewData["CurrentFilter"] = searchString;

    return View(model);
}
}