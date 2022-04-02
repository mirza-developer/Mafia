namespace Mafia.Pages
{
    public partial class AddRole
    {
        public string Name = string.Empty;
        public string Description = string.Empty;
        public bool IsMafia = false;

        public ElementReference Input { get; set; }
        [Inject] public NavigationManager NavigationManager { get; set; }

        public async Task ClickSavePlayer(MouseEventArgs e)
        {
            Tools.StorageHelper.Roles.Add(new()
            {
                Id = Tools.StorageHelper.Roles.Count + 1,
                Name = Name,
                Description = Description,
                IsMafia = IsMafia
            });

            Name = string.Empty;
            Description = string.Empty;
            IsMafia = false;

            await Input.FocusAsync();
        }

        public async Task ClickBack(MouseEventArgs e)
        {
            NavigationManager.NavigateTo("/");
        }
    }
}
