using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projekt.Data;
using Projekt.Models;

namespace Projekt.Controllers;

public class WorkoutSessionsController : Controller
{
    private readonly ApplicationDbContext _context;

    public WorkoutSessionsController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var sessions = await _context.WorkoutSessions
            .Include(s => s.Exercise)
            .OrderByDescending(s => s.Date)
            .ToListAsync();

        return View(sessions);
    }

    public IActionResult Create()
    {
        ViewData["ExerciseId"] = new SelectList(_context.Exercises, "Id", "Name");
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(WorkoutSession session)
    {
        if (ModelState.IsValid)
        {
            _context.WorkoutSessions.Add(session);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        ViewData["ExerciseId"] = new SelectList(_context.Exercises, "Id", "Name", session.ExerciseId);
        return View(session);
    }
}