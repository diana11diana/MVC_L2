using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projekt.Data;
using Projekt.Models;

namespace Projekt.Controllers;

[Authorize(Roles = "Admin")]
public class ExercisesController : Controller
{
    private readonly ApplicationDbContext _context;

    public ExercisesController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index(string? searchString)
    {
        var exercises = _context.Exercises.AsQueryable();

        if (!string.IsNullOrWhiteSpace(searchString))
        {
            exercises = exercises.Where(e =>
                e.Name.Contains(searchString) ||
                e.Category.Contains(searchString));
        }

        ViewData["CurrentFilter"] = searchString;

        return View(await exercises.ToListAsync());
    }

    public async Task<IActionResult> Details(int? id)
    {
        if (id == null) return NotFound();

        var exercise = await _context.Exercises
            .FirstOrDefaultAsync(e => e.Id == id);

        if (exercise == null) return NotFound();

        return View(exercise);
    }

    public IActionResult Create()
    {
        return View(new Exercise());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Exercise exercise)
    {
        if (!ModelState.IsValid)
        {
            return View(exercise);
        }

        _context.Exercises.Add(exercise);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null) return NotFound();

        var exercise = await _context.Exercises.FindAsync(id);

        if (exercise == null) return NotFound();

        return View(exercise);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, Exercise exercise)
    {
        if (id != exercise.Id) return NotFound();

        if (!ModelState.IsValid)
        {
            return View(exercise);
        }

        _context.Exercises.Update(exercise);
        await _context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null) return NotFound();

        var exercise = await _context.Exercises
            .FirstOrDefaultAsync(e => e.Id == id);

        if (exercise == null) return NotFound();

        return View(exercise);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var exercise = await _context.Exercises.FindAsync(id);

        if (exercise != null)
        {
            _context.Exercises.Remove(exercise);
            await _context.SaveChangesAsync();
        }

        return RedirectToAction(nameof(Index));
    }
}