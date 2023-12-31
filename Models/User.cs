using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PandoraCaseTest.Models
{
    public class User
    {
        [BindNever]
        public int? UserID { get; set; }
        [Required(ErrorMessage = "Proszę podać login.")]
        public string? Login { get; set; }
        [Required(ErrorMessage = "Proszę podać hasło.")]
        public string? Pass { get; set; }
        [Required(ErrorMessage = "Proszę podać mail.")]
        public string? Mail { get; set; }
    }
}
