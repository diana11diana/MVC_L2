using System.ComponentModel.DataAnnotations;

namespace Projekt.Models;

public class Exercise
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    [Required]
    public string Category { get; set; } = string.Empty;

    [Range(1, 300)]
    public int Duration { get; set; }

    public string? Description { get; set; }

    public string DifficultyLevel { get; set; } = "Średni";
}