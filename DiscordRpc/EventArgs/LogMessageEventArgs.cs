using DiscordRpc.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscordRpc.EventArgs
{
	public delegate void LogMessageEventHandler(object sender, LogMessageEventArgs e);

    public class LogMessageEventArgs : System.EventArgs
    {
		public LogLevel Level { get; }
		public DateTime Timestamp { get; }
		public string Message { get; }

		public LogMessageEventArgs(string message, LogLevel level = LogLevel.Info, DateTime? timestamp = null)
		{
			Message = message;
			Level = level;
			Timestamp = timestamp ?? DateTime.Now;
		}
    }
}
