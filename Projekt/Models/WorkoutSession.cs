using System.ComponentModel.DataAnnotations;

namespace Projekt.Models;

public class WorkoutSession
{
    public int Id { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Range(0, 5000)]
    public int CaloriesBurned { get; set; }

    public int ExerciseId { get; set; }

    public Exercise? Exercise { get; set; }
}