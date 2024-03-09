namespace TodoApp.Core;

public record TodoItem(
    string Text,
    bool IsDone,
    int Order);
