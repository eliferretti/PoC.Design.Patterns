using Design.Pattern.Estructural.Decorator.Components;

namespace Design.Pattern.Estructural.Decorator.Decorators
{
    public class EmailNotifier : NotifierDecorator
    {
        public EmailNotifier(INotifier notifier) : base(notifier)
        {
        }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"Email Notification: {message}");
        }
    }
}
