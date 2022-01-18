using BlazorApp.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorApp.Pages {
    public partial class Todo {
        private List<TodoItem> todoLists = new List<TodoItem>() {
            new TodoItem() {
                title = "Test todo 1",
                tasks = new List<TaskItem>() {
                    new TaskItem {
                        title = "React",
                        isDone = true
                    },
                    new TaskItem {
                        title = "React Native",
                        isDone = false
                    },
                    new TaskItem {
                        title = "Redux",
                        isDone = true
                    },
                    new TaskItem {
                        title = "C#",
                        isDone = false
                    },
                    new TaskItem {
                        title = "Blazor",
                        isDone = true
                    },
                }
            },
            new TodoItem() {
                title = "Test todo 2",
                tasks = new List<TaskItem>() {
                    new TaskItem {
                        title = "React",
                        isDone = true
                    },
                    new TaskItem {
                        title = "React Native",
                        isDone = false
                    },
                    new TaskItem {
                        title = "Redux",
                        isDone = true
                    },
                    new TaskItem {
                        title = "C#",
                        isDone = false
                    },
                    new TaskItem {
                        title = "Blazor",
                        isDone = true
                    },
                }
            },
            new TodoItem() {
                title = "Test todo 3",
                tasks = new List<TaskItem>() {
                    new TaskItem {
                        title = "React",
                        isDone = true
                    },
                    new TaskItem {
                        title = "React Native",
                        isDone = false
                    },
                    new TaskItem {
                        title = "Redux",
                        isDone = true
                    },
                    new TaskItem {
                        title = "C#",
                        isDone = false
                    },
                    new TaskItem {
                        title = "Blazor",
                        isDone = true
                    },
                }
            },
            new TodoItem() {
            title = "Test todo 4",
            tasks = new List<TaskItem>() {
                new TaskItem {
                    title = "React",
                    isDone = true
                },
                new TaskItem {
                    title = "React Native",
                    isDone = false
                },
                new TaskItem {
                    title = "Redux",
                    isDone = true
                },
                new TaskItem {
                    title = "C#",
                    isDone = false
                },
                new TaskItem {
                    title = "Blazor",
                    isDone = true
                },
            }
        }
        };
        private string newTodolistTitle;
        private void AddTodolist() {
            if (!string.IsNullOrWhiteSpace(newTodolistTitle)) {
                todoLists.Add(new TodoItem { 
                    title = newTodolistTitle, 
                    tasks = new List<TaskItem>() 
                        });
                newTodolistTitle = string.Empty;
            }
        }
        private void RemoveTodolist(TodoItem removedItem) {
            todoLists.Remove(removedItem);
        }
    }
}