using LiteDB;
using Mafia.Tools;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;


namespace Mafia.Pages
{
    public partial class Index
    {
        [Inject] public NavigationManager NavigationManager { get; set; }

        public async Task ClickRemovePlayer(MouseEventArgs e, int player)
        {
            Tools.StorageHelper.Players.RemoveAll(p=>p.Id == player);
        }

        public async Task ClickRemoveRole(MouseEventArgs e, int player)
        {
            Tools.StorageHelper.Roles.RemoveAll(p=>p.Id == player);
        }

        public async Task ClickAddPlayer(MouseEventArgs e)
        {
            NavigationManager.NavigateTo("/AddPlayer");
        }
        public async Task ClickAddRole(MouseEventArgs e)
        {
            NavigationManager.NavigateTo("/AddRole");
        }

        public async Task ClickNewMatch(MouseEventArgs e)
        {
            NavigationManager.NavigateTo("/Match");
        }

        public async Task ClickRetry(MouseEventArgs e)
        {
            StorageHelper.Matches.Clear();
            StorageHelper.Roles.Clear();
            StorageHelper.PlayerRoles.Clear();
            StorageHelper.Players.Clear();
        }
    }
}
