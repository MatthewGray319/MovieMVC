namespace eTickets.Models
{
    public class Actors_Movies
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }    
        public string ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
