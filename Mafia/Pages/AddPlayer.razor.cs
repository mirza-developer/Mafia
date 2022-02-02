using Microsoft.AspNetCore.Components.Web;

namespace Mafia.Pages
{
    public partial class AddPlayer
    {
        public string Name = string.Empty;
        public ElementReference Input { get; set; }
        [Inject] public NavigationManager NavigationManager { get; set; }

        public async Task ClickSavePlayer(MouseEventArgs e)
        {
            Tools.StorageHelper.Players.Add(new()
            {
                Id = Tools.StorageHelper.Players.Count + 1,
                Name = Name
            });
            
            Name = string.Empty;

            await Input.FocusAsync();
        }

        public async Task ClickBack(MouseEventArgs e)
        {
            NavigationManager.NavigateTo("/");
        }
    }
}
