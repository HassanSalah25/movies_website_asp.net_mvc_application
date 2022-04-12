namespace movies_website_asp.net_mvc_application.Models
{
    public class Movies_Actors
    {
        public int MovieId { get; set; }
        public Movies Movies { get; set; }
        public int ActorId { get; set; }
        public Actors Actors { get; set; }
    }
}
