using Microsoft.AspNetCore.Components;

namespace BlazorApp.Components {
    public partial class IconButton {
        [Parameter] public string Icon {get; set;}
        [Parameter] public EventCallback OnClick {get; set;}
        [Parameter] public string Styles {get; set;}
    }
}