using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SchoolRegister.Web.Areas.Identity.Pages.Account;

public class RegisterModel : PageModel
{
    public IActionResult OnGet()
    {
        // This method is called when the page is accessed via a GET request.
        // You can add any initialization logic here if needed.
        return NotFound();
    }
    public IActionResult OnPost()
    {
        // This method is called when the page is accessed via a POST request.
        // You can add any logic to handle form submissions here if needed.
        return NotFound();
    }
}