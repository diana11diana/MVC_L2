namespace Projekt.Models;

public class AdminUserViewModel
{
    public string Id { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string? FullName { get; set; }

    public DateTime RegisteredAt { get; set; }

    public DateTime? LastLoginAt { get; set; }

    public DateTime? LastLogoutAt { get; set; }

    public string Roles { get; set; } = string.Empty;
}