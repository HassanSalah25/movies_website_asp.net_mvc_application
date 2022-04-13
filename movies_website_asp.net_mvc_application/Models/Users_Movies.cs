namespace movies_website_asp.net_mvc_application.Models
{
    public class Users_Movies
    {
        public int MovieId { get; set; }
        public Movies Movies { get; set; }
        public int UserId { get; set; }
        public Users Users { get; set; }
    }
}
