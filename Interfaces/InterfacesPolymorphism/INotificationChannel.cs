using System;

namespace Interfaces
{
    public interface INotificationChannel
    {
        void Send(Message message);
    }
}
