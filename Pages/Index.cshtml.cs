using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FizzBuzzWeb.Models;

namespace FizzBuzzWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public FizzBuzzModel FizzBuzz { get; set; }
        [BindProperty(SupportsGet = true)]
        public string Name { get; set; }
        public string Result { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }


        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                Name = "Mateusz";
            }

        }
        public IActionResult OnPost()
        {
            Name = "Mateusz";
            if (!ModelState.IsValid)
            {
                if (FizzBuzz.Number % 3 == 0)
                {
                    Result = "Fizz";
                }
                else if (FizzBuzz.Number % 5 == 0)
                {
                    Result = "Buzz";
                }
                else if (FizzBuzz.Number % 15 == 0)
                {
                    Result = "FizzBuzz";
                }
                else
                {
                    Result = $"Liczba: {FizzBuzz.Number} nie spełnia kryteriów FizzBuzz";
                }

            }

            return Page();

        }

    }
}