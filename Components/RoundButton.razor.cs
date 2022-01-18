using Microsoft.AspNetCore.Components;

namespace BlazorApp.Components {
    public partial class RoundButton {
        [Parameter] public string Title {get; set;} = "";
        [Parameter] public string Styles {get; set;} = "";
        [Parameter] public EventCallback OnClick {get; set;}
    }
}