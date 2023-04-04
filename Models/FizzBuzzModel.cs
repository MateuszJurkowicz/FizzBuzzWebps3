using System.ComponentModel.DataAnnotations;

namespace FizzBuzzWeb.Models
{
    public class FizzBuzzModel
    {
        [Display(Name = "Liczba:")]
        [Required, Range(1899, 2022, ErrorMessage = "Oczekiwana wartość liczby z zakresu {1} i {2}.")]
        public int? Number { get; set; }
        [Display(Name = "Imię:")]
        [StringLength(10, ErrorMessage = "Maksymalna długość pola {0} wynosi {1} znaków.")]
        public string? Name { get; set; }
        public string? Result { get; set; }
    }
}
