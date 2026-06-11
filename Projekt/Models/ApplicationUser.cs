using Microsoft.AspNetCore.Identity;

namespace Projekt.Models;

public class ApplicationUser : IdentityUser
{
    public string? FullName { get; set; }

    public DateTime RegisteredAt { get; set; } = DateTime.Now;

    public DateTime? LastLoginAt { get; set; }

    public DateTime? LastLogoutAt { get; set; }
}