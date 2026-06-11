namespace Projekt.Models
{
    public class DashboardViewModel
    {
        // Admin dashboard
        public int UsersCount { get; set; }
        public int ExercisesCount { get; set; }
        public int UserExercisesCount { get; set; }
        public int CompletedExercisesCount { get; set; }

        // Old statistics (used by existing views)
        public int TotalExercises { get; set; }
        public int TotalSessions { get; set; }
        public int TotalCalories { get; set; }
        public double AverageDuration { get; set; }
    }
}