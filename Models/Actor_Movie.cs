namespace eTickets.Models
{
    public class Actor_Movie
    {
        public int MovieId { get; set; }
        public NewMovieVM Movie { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
