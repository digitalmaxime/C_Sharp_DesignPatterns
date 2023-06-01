

var notificationServiceProvider = new NotificationServiceProvider();
var shippingService = new ShippingService(notificationServiceProvider);
shippingService.ShipItem();

interface IUserNotifier
{
    void NotifyUser(int id);
}

class EmailUserNotifier : IUserNotifier
{
    public void NotifyUser(int id)
    {
        System.Console.WriteLine($"Notified user {id} by email!");
    }
}

class DebugUserNotifier : IUserNotifier
{
    public void NotifyUser(int id)
    {
        System.Console.WriteLine($"Notified user {id} for debug testing!");
    }
}

class NotificationServiceProvider
{
    public IUserNotifier GetUserNotifier()
    {
#if DEBUG
        return new DebugUserNotifier();
#else
        return new EmailUserNotifier();
#endif
    }
}

class ShippingService
{
    NotificationServiceProvider _notificationServiceProvider;

    public ShippingService(NotificationServiceProvider serviceProvider)
    {
        _notificationServiceProvider = serviceProvider;
    }

    public void ShipItem()
    {
        System.Console.WriteLine("Shipping item..");
        System.Threading.Thread.Sleep(2000);

        _notificationServiceProvider.GetUserNotifier().NotifyUser(1);
    }
}