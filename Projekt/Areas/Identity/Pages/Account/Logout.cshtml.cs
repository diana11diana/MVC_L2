using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Projekt.Models;

namespace Projekt.Areas.Identity.Pages.Account;

public class LogoutModel : PageModel
{
    private readonly SignInManager<ApplicationUser> _signInManager;
    private readonly UserManager<ApplicationUser> _userManager;

    public LogoutModel(
        SignInManager<ApplicationUser> signInManager,
        UserManager<ApplicationUser> userManager)
    {
        _signInManager = signInManager;
        _userManager = userManager;
    }

    public async Task<IActionResult> OnPostAsync(string? returnUrl = null)
    {
        var user = await _userManager.GetUserAsync(User);

        if (user != null)
        {
            user.LastLogoutAt = DateTime.Now;
            await _userManager.UpdateAsync(user);
        }

        await _signInManager.SignOutAsync();

        return RedirectToAction("Index", "Home");
    }
}