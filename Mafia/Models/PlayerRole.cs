namespace Mafia.Models
{
    public class PlayerRole
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public Player Player { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }

        public bool IsShown { get; set; } = false;
    }
}
