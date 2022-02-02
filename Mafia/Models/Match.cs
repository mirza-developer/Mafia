namespace Mafia.Models
{
    public class Match
    {
        public int Id { get; set; }
        public DateTime PlayTime { get; set; } = DateTime.Now;
        public List<PlayerRole> PlayerRoles { get; set;}
    }
}
