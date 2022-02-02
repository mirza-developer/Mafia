using Mafia.Tools;

namespace Mafia.Pages
{
    public partial class Match
    {
        public bool IsShowRole = false;
        public string Playername = string.Empty;
        public string Rolename = string.Empty;
        public int PlayerRole = 0;

        [Inject] public NavigationManager NavigationManager { get; set; }

        public List<PlayerRole> Draw = new();

        protected override async Task OnInitializedAsync()
        {
            Redraw();

            await base.OnInitializedAsync();
        }

        void Redraw()
        {
            Draw.Clear();
            var roles = StorageHelper.Roles;
            var players = StorageHelper.Players;

            players = players.OrderBy(x => Guid.NewGuid()).ToList();

            for (int i = 0; i < roles.Count; i++)
            {
                Draw.Add(new()
                {
                    Id = Draw.Count + 1,
                    Player = players[i],
                    PlayerId = players[i].Id,
                    Role = roles[i],
                    RoleId = roles[i].Id
                });
            }
        }

        public async Task ShowRole(PlayerRole role)
        {
            Playername = role.Player.Name;
            Rolename = role.Role.Name;
            PlayerRole = role.Id;
            IsShowRole = true;
        }

        public async Task HideRole(MouseEventArgs e)
        {
            IsShowRole = false;
            Playername = string.Empty;
            Rolename = string.Empty;
            Draw.FirstOrDefault(p => p.Id == PlayerRole).IsShown = true;
            PlayerRole = 0;
        }

        public async Task ClickBack(MouseEventArgs e)
        {
            NavigationManager.NavigateTo("/");
        }
    }
}
