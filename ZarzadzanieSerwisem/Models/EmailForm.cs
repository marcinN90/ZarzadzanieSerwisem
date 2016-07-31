using System.ComponentModel.DataAnnotations;


namespace ZarzadzanieSerwisem.Models
{
    public class EmailForm
    {
        [Required(ErrorMessage = "Proszę podać swoje imie i nazwisko.")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Proszę podać adres email.")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Proszę podać poprawny adres Email.")]
        public string Email { get; set; }
       
        
        [Required(ErrorMessage ="Proszę wpisać treść wiadomości")]
        public string Message { get; set; }
            }
}