using Design.Pattern.Estructural.Decorator.Components;

namespace Design.Pattern.Estructural.Decorator.Decorators
{
    public abstract class NotifierDecorator : INotifier
    {
        protected INotifier _notifier;

        public NotifierDecorator(INotifier notifier)
        {
            _notifier = notifier;
        }

        public virtual void Send(string message)
        {
            _notifier.Send(message);
        }
    }
}
