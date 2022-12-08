using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace RazorCurrencyConverter.Pages
{
    public class CurrencyConverterModel : PageModel
    {
        public const double POUND_TO_RON = 5.74;

        [BindProperty]
        public double InputPOUND { get; set; }
        [BindProperty]
        public double OutputRON { get; set; }

        // Checks if users input is a positive number or not.
        // It will display a message accordingly to the users input.
        public void OnPost()
        {
            if (double.IsNegative(InputPOUND))
            {
                ViewData["Message"] = "Please enter a positive number!";
            }
            else
            {
                OutputRON = InputPOUND * POUND_TO_RON;
                ViewData["Message"] = "Currency successfully converted!";
            }
        }
    }
}