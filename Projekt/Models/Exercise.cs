using System.ComponentModel.DataAnnotations;

namespace Projekt.Models;

public class Exercise
{
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    [Required]
    public string Category { get; set; } = string.Empty;

    public int Duration { get; set; }

    public string? Description { get; set; }

    public string DifficultyLevel { get; set; } = "Średni";

    public int Sets { get; set; } = 3;

    public int Repetitions { get; set; } = 12;

    public int RestSeconds { get; set; } = 60;

    public string Equipment { get; set; } = "Brak sprzętu";

    public string? Instruction { get; set; }
}