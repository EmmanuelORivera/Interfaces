using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
	internal class VideoEncoder
	{
		private readonly List<INotificationChannel> _notificationChannels;
		public VideoEncoder()
		{
			_notificationChannels = new List<INotificationChannel>();
		}

		public void Encode(Video video)
		{
			// Video encoding logic ...

			foreach (var channel in _notificationChannels)
			{
				channel.Send(new Message());
			}

		}

		public void RegisterNotificationChannel(INotificationChannel channel)
		{
			_notificationChannels.Add(channel);
		}
	}
}
