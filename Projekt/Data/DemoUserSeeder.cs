using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Projekt.Models;

namespace Projekt.Data;

public static class DemoUserSeeder
{
    public static async Task SeedDemoUsersAsync(
        ApplicationDbContext context,
        UserManager<ApplicationUser> userManager)
    {
        var exercises = await context.Exercises
            .OrderBy(x => x.Id)
            .ToListAsync();

        if (exercises.Count < 50)
        {
            return;
        }

        var demoUsers = new[]
        {
            new { Email = "user01@demo.com", Name = "Anna Kowalska", Added = 10, Completed = 5 },
            new { Email = "user02@demo.com", Name = "Jan Nowak", Added = 20, Completed = 7 },
            new { Email = "user03@demo.com", Name = "Katarzyna Zielińska", Added = 15, Completed = 15 },
            new { Email = "user04@demo.com", Name = "Piotr Wiśniewski", Added = 8, Completed = 3 },
            new { Email = "user05@demo.com", Name = "Marta Lewandowska", Added = 25, Completed = 12 },
            new { Email = "user06@demo.com", Name = "Tomasz Kamiński", Added = 18, Completed = 9 },
            new { Email = "user07@demo.com", Name = "Julia Wójcik", Added = 12, Completed = 4 },
            new { Email = "user08@demo.com", Name = "Michał Dąbrowski", Added = 30, Completed = 20 },
            new { Email = "user09@demo.com", Name = "Natalia Kozłowska", Added = 16, Completed = 6 },
            new { Email = "user10@demo.com", Name = "Adam Mazur", Added = 22, Completed = 11 },
            new { Email = "user11@demo.com", Name = "Oliwia Krawczyk", Added = 14, Completed = 14 },
            new { Email = "user12@demo.com", Name = "Paweł Piotrowski", Added = 9, Completed = 2 },
            new { Email = "user13@demo.com", Name = "Wiktoria Grabowska", Added = 28, Completed = 18 },
            new { Email = "user14@demo.com", Name = "Kamil Pawlak", Added = 11, Completed = 5 },
            new { Email = "user15@demo.com", Name = "Zofia Michalska", Added = 19, Completed = 10 },
            new { Email = "user16@demo.com", Name = "Filip Król", Added = 21, Completed = 8 },
            new { Email = "user17@demo.com", Name = "Laura Wieczorek", Added = 13, Completed = 6 },
            new { Email = "user18@demo.com", Name = "Mateusz Jankowski", Added = 26, Completed = 13 },
            new { Email = "user19@demo.com", Name = "Emilia Wróbel", Added = 17, Completed = 9 },
            new { Email = "user20@demo.com", Name = "Szymon Nowicki", Added = 24, Completed = 16 }
        };

        var password = "User123";

        for (int i = 0; i < demoUsers.Length; i++)
        {
            var demo = demoUsers[i];

            var user = await userManager.FindByEmailAsync(demo.Email);

            if (user == null)
            {
                user = new ApplicationUser
                {
                    UserName = demo.Email,
                    Email = demo.Email,
                    FullName = demo.Name,
                    RegisteredAt = DateTime.Now.AddDays(-(30 + i)),
                    LastLoginAt = DateTime.Now.AddDays(-i).AddHours(-2),
                    LastLogoutAt = DateTime.Now.AddDays(-i).AddHours(-1)
                };

                var result = await userManager.CreateAsync(user, password);

                if (!result.Succeeded)
                {
                    continue;
                }

                await userManager.AddToRoleAsync(user, "User");
            }

            var existingUserExercises = context.UserExercises
                .Where(x => x.UserId == user.Id);

            context.UserExercises.RemoveRange(existingUserExercises);
            await context.SaveChangesAsync();

            var selectedExercises = exercises
                .Skip(i * 5)
                .Take(demo.Added)
                .ToList();

            for (int j = 0; j < selectedExercises.Count; j++)
            {
                var isCompleted = j < demo.Completed;

                context.UserExercises.Add(new UserExercise
                {
                    UserId = user.Id,
                    ExerciseId = selectedExercises[j].Id,
                    AddedAt = DateTime.Now.AddDays(-(demo.Added - j)),
                    IsCompleted = isCompleted,
                    CompletedAt = isCompleted
                        ? DateTime.Now.AddDays(-(demo.Completed - j)).AddHours(-3)
                        : null
                });
            }

            await context.SaveChangesAsync();
        }
    }
}