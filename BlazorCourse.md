# EditForm
EditForm in Blazor is a component that simplifies form handling, validation, and model binding. It works with a model class and automatically binds form inputs to properties of that model.
## Basic Example of EditForm
```razor
<EditForm Model="@user" OnValidSubmit="HandleValidSubmit">
    <DataAnnotationsValidator />

    <label>Username:</label>
    <InputText @bind-Value="user.Name" />
    
    <label>Age:</label>
    <InputNumber @bind-Value="user.Age" />

    <button type="submit">Submit</button>
</EditForm>

<p>@message</p>

@code {
    private User user = new();
    private string message;

    private void HandleValidSubmit()
    {
        message = $"Submitted: {user.Name}, Age: {user.Age}";
    }

    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
```
