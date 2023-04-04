using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FizzBuzzWeb.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using FizzBuzzWeb.Controllers;

namespace FizzBuzzWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public FizzBuzzModel FizzBuzz { get; set; } = new FizzBuzzModel();



        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();

            }
            if ((FizzBuzz.Number % 4 == 0) && (FizzBuzz.Number != 1900))
            {
                FizzBuzz.Result = "był";
            }
            else
            {
                FizzBuzz.Result = "nie był";
            }
            HttpContext.Session.SetString("Data", JsonConvert.SerializeObject(FizzBuzz));

            return RedirectToPage("./SavedInSession");


        }

    }
}