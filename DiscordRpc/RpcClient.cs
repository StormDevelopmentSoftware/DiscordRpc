﻿using DiscordRpc.EventArgs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DiscordRpc
{
	public class RpcClient
	{
		private EventHandlerList handlers = new EventHandlerList();
		private object LogEventLocker = new object();
		private object ReadyEventLocker = new object();

		public event LogMessageEventHandler LogMessageReceived {
			add => handlers.AddHandler(LogEventLocker, value);
			remove => handlers.RemoveHandler(LogEventLocker, value);
		}

		internal void RaiseLogMessageReceivedEvent(object sender, LogMessageEventArgs e)
		{
			handlers[LogEventLocker].DynamicInvoke(sender ?? this, e);
		}
	}
}