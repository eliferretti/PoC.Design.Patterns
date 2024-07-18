using Design.Pattern.Estructural.Decorator.Components;
using Design.Pattern.Estructural.Decorator.Decorators;

INotifier notifier = new BasicNotifier();
INotifier emailNotifier = new EmailNotifier(notifier);
INotifier smsNotifier = new SmsNotifier(emailNotifier);

smsNotifier.Send("This is a test notification.");

// Output:
// Basic Notification: This is a test notification.
// Email Notification: This is a test notification.
// SMS Notification: This is a test notification.