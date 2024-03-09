using System.Collections.ObjectModel;
using TodoApp.Core;

namespace TodoApp;

public partial class MainPage : ContentPage
{
    public ObservableCollection<TodoItem> TodoItems { get; set; } = [];

    int count = 0;

    public MainPage()
    {
        InitializeComponent();

        TodoItems.Add(new TodoItem("This is my first todo item", false, 0));
        TodoItems.Add(new TodoItem("This is my second todo item", false, 1));
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}

