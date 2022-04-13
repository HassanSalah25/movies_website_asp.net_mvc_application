using movies_website_asp.net_mvc_application.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace movies_website_asp.net_mvc_application.Models
{
    public class Movies
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Double Price { get; set; }
        public string ImageURL { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        public List<Movies_Actors> Movies_Actors { get; set; }
        public List<Users_Movies> Users_Movies { get; set; }
    }
}
