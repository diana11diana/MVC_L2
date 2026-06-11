using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projekt.Data;
using Projekt.Models;

namespace Projekt.Controllers;

[Authorize]
public class UserExercisesController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;

    public UserExercisesController(
        ApplicationDbContext context,
        UserManager<ApplicationUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    public async Task<IActionResult> Available(string? difficulty, string? category)
    {
        var userId = _userManager.GetUserId(User);

        var activeExerciseIds = await _context.UserExercises
            .Where(x => x.UserId == userId && !x.IsCompleted)
            .Select(x => x.ExerciseId)
            .ToListAsync();

        ViewBag.ActiveExerciseIds = activeExerciseIds;
        ViewBag.CurrentDifficulty = difficulty;
        ViewBag.CurrentCategory = category;

        var exercises = _context.Exercises.AsQueryable();

        if (!string.IsNullOrWhiteSpace(difficulty))
        {
            exercises = exercises.Where(x => x.DifficultyLevel == difficulty);
        }

        if (!string.IsNullOrWhiteSpace(category))
        {
            exercises = exercises.Where(x => x.Category == category);
        }

        return View(await exercises
            .OrderBy(x => x.Name)
            .ToListAsync());
    }

    public async Task<IActionResult> MyExercises(string? status)
    {
        var userId = _userManager.GetUserId(User);

        var query = _context.UserExercises
            .Include(x => x.Exercise)
            .Where(x => x.UserId == userId);

        if (status == "completed")
        {
            query = query.Where(x => x.IsCompleted);
        }

        if (status == "active")
        {
            query = query.Where(x => !x.IsCompleted);
        }

        ViewBag.CurrentStatus = status;

        var myExercises = await query
            .OrderByDescending(x => x.AddedAt)
            .ToListAsync();

        return View(myExercises);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Add(int exerciseId)
    {
        var userId = _userManager.GetUserId(User);

        var alreadyActive = await _context.UserExercises
            .AnyAsync(x =>
                x.UserId == userId &&
                x.ExerciseId == exerciseId &&
                !x.IsCompleted);

        if (!alreadyActive)
        {
            var userExercise = new UserExercise
            {
                UserId = userId!,
                ExerciseId = exerciseId,
                IsCompleted = false,
                AddedAt = DateTime.Now
            };

            _context.UserExercises.Add(userExercise);
            await _context.SaveChangesAsync();
        }

        return RedirectToAction(nameof(Available));
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Complete(int id)
    {
        var userId = _userManager.GetUserId(User);

        var userExercise = await _context.UserExercises
            .FirstOrDefaultAsync(x => x.Id == id && x.UserId == userId);

        if (userExercise == null)
        {
            return NotFound();
        }

        userExercise.IsCompleted = true;
        userExercise.CompletedAt = DateTime.Now;

        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(MyExercises));
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Remove(int id)
    {
        var userId = _userManager.GetUserId(User);

        var userExercise = await _context.UserExercises
            .FirstOrDefaultAsync(x => x.Id == id && x.UserId == userId);

        if (userExercise == null)
        {
            return NotFound();
        }

        if (userExercise.IsCompleted)
        {
            return RedirectToAction(nameof(MyExercises));
        }

        _context.UserExercises.Remove(userExercise);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(MyExercises));
    }
}