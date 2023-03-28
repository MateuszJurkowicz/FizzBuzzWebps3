using System.ComponentModel.DataAnnotations;

namespace FizzBuzzWeb.Models
{
    public class FizzBuzzModel
    {
        [Display(Name = "Liczba:")]
        [Required, Range(1, 1000, ErrorMessage = "Oczekiwana wartość liczby z zakresu {1} i {2}.")]
        public int? Number { get; set; }
    }
}
