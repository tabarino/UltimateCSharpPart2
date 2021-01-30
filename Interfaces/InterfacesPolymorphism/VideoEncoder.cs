using System;
using System.Collections.Generic;

namespace Interfaces
{
    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationChannels;

        public VideoEncoder()
        {
            _notificationChannels = new List<INotificationChannel>();
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }

        public void Encode(Video video)
        {
            // Video Encode Logic
            // ...

            foreach (var channel in _notificationChannels)
            {
                // We implemented polymorphic behaviour here,
                // because the Send method is being called according to the object
                channel.Send(new Message());
            }
        }
    }
}
