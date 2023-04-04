using FizzBuzzWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace FizzBuzzWeb.Controllers
{
    public class SavedInSessionModel : PageModel
    {
        [BindProperty]
        public List<FizzBuzzModel> UsersData { get; set; } = new List<FizzBuzzModel>();
        public FizzBuzzModel FizzBuzz { get; set; }
        public void OnGet()
        {
            var userData = HttpContext.Session.GetString("UserData");
            if (userData != null)
            {
                UsersData = JsonConvert.DeserializeObject<List<FizzBuzzModel>>(userData);
            }

            var data = HttpContext.Session.GetString("Data");
            if (data != null)
            {
                FizzBuzz = JsonConvert.DeserializeObject<FizzBuzzModel>(data);
                UsersData.Add(FizzBuzz);
                HttpContext.Session.SetString("UserData", JsonConvert.SerializeObject(UsersData));
            }
        }
    }
}
