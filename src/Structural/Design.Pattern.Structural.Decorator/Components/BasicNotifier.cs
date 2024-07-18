namespace Design.Pattern.Estructural.Decorator.Components
{
    public class BasicNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine($"Basic Notification: {message}");
        }
    }
}
