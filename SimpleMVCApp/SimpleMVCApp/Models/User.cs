using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SimpleMVCApp.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Nume")]   
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [DisplayName("Adresa email")]
        public string Email { get; set; }
    }
}
