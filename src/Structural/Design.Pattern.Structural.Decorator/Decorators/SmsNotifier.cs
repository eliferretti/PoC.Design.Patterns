using Design.Pattern.Estructural.Decorator.Components;

namespace Design.Pattern.Estructural.Decorator.Decorators
{
    public class SmsNotifier : NotifierDecorator
    {
        public SmsNotifier(INotifier notifier) : base(notifier)
        {
        }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"SMS Notification: {message}");
        }
    }
}
