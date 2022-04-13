using System.ComponentModel.DataAnnotations;

namespace movies_website_asp.net_mvc_application.Models
{
    public class Users
    {
        public int Id { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is Required")]
        [StringLength(200,MinimumLength = 3,ErrorMessage = "Name should be between Range 200 and 3 chars")]
        public string Name { get; set; }
        [EmailAddress]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Emaial is Requied")]
        public string Email { get; set; }
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password is Required")]
        [MinLength(8,ErrorMessage = "Password should be more than 8 chars")]
        public string Password { get; set; }

        //Relatioships
        public List<Users_Movies> Users_Movies { get; set; }
    }
}
