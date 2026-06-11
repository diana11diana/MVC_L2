using Projekt.Models;

namespace Projekt.Data;

public static class ExerciseSeeder
{
    public static async Task SeedExercisesAsync(ApplicationDbContext context)
    {
        if (context.Exercises.Any())
        {
            return;
        }

        string[] names =
        {
            "Przysiady", "Pompki", "Plank", "Wykroki", "Burpees",
            "Mountain climbers", "Brzuszki", "Martwy ciąg", "Wyciskanie hantli", "Podciąganie",
            "Bieg w miejscu", "Skakanka", "Rowerek", "Russian twist", "Hip thrust",
            "Deska boczna", "Pajacyki", "Mostek", "Unoszenie nóg", "Sprint",
            "Wiosłowanie", "Przysiad bułgarski", "Kettlebell swing", "Face pull", "Rozciąganie pleców"
        };

        string[] categories =
        {
            "Siłowe", "Cardio", "Mobilność", "Core", "Nogi", "Ramiona", "Plecy", "Brzuch"
        };

        string[] levels =
        {
            "Łatwy", "Średni", "Trudny"
        };

        var exercises = new List<Exercise>();

        for (int i = 1; i <= 150; i++)
        {
            var baseName = names[(i - 1) % names.Length];
            var category = categories[(i - 1) % categories.Length];
            var level = levels[(i - 1) % levels.Length];

            exercises.Add(new Exercise
            {
                Name = $"{baseName} - wariant {i}",
                Category = category,
                Duration = 10 + (i % 50),
                DifficultyLevel = level,
                Description = $"Ćwiczenie typu {category.ToLower()} na poziomie {level.ToLower()}. Pomaga poprawić kondycję, siłę oraz ogólną sprawność fizyczną."
            });
        }

        context.Exercises.AddRange(exercises);
        await context.SaveChangesAsync();
    }
}