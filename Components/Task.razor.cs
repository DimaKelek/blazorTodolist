using BlazorApp.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorApp.Components {
    public partial class Task {
        [Parameter] public TaskItem TaskData {get; set;}
        [Parameter] public EventCallback RemoveTask {get; set;}
    }
}