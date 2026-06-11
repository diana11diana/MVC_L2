using System.ComponentModel.DataAnnotations;

namespace Projekt.Models;

public class UserExercise
{
    public int Id { get; set; }

    [Required]
    public string UserId { get; set; } = string.Empty;

    public ApplicationUser? User { get; set; }

    [Required]
    public int ExerciseId { get; set; }

    public Exercise? Exercise { get; set; }

    public bool IsCompleted { get; set; } = false;

    public DateTime AddedAt { get; set; } = DateTime.Now;

    public DateTime? CompletedAt { get; set; }
}