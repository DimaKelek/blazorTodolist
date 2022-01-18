using BlazorApp.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorApp.Components {
    public partial class Todolist {
        [Parameter] public string Title {get; set;}
        [Parameter] public EventCallback RemoveTodoList {get; set;}
        [Parameter] public List<TaskItem> Tasks {get; set;}
        private string newTaskTitle;
        private void AddTask() {
            if (!string.IsNullOrWhiteSpace(newTaskTitle)) {
                Tasks.Add(new TaskItem { title = newTaskTitle, isDone = false });
                newTaskTitle = string.Empty;
            }
        }
        private void RemoveTask(TaskItem removedTask) {
            Tasks.Remove(removedTask);
        }
    }
}