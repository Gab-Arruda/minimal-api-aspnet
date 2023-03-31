using Flunt.Notifications;
using Flunt.Validations;

namespace MiniTodo.ViewModels
{
    public class CreateTodoViewModel : Notifiable<Notification>
    {
        public string Title { get; set; }

        public Todo MapTo()
        {
            var contract = new Contract<Notification>()
                .Requires()
                .IsNotNull(Title, "Type the task title")
                .IsGreaterThan(Title, 5, "");
            AddNotifications(contract);

            return new Todo(Guid.NewGuid(), Title, false);
        }
    }
}