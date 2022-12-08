using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorCurrencyConverter.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]

        public string FullName { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        // Checks if the user has entered a name.
        // It will display a message accordingly to the users input.
        public void OnPost()
        {
            if (String.IsNullOrWhiteSpace(FullName))
            {
                ViewData["Message"] = "Please enter your name!";
            }
            else
            {
                ViewData["Message"] = FullName + " registered successfully!";
            }
        }
    }
}
