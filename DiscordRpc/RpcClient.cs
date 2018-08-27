using DiscordRpc.Entities;
using DiscordRpc.EventArgs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DiscordRpc
{
	public class RpcClient : IDisposable
	{
		#region Events

		private object evt_ready_key = new object();
		private object evt_connection_closed_key = new object();
		private object evt_client_errored_key = new object();
		private object evt_log_message_key = new object();
		private EventHandlerList handlers = new EventHandlerList();

		public event LogMessageEventHandler Log {
			add => handlers.AddHandler(evt_log_message_key, value);
			remove => handlers.RemoveHandler(evt_log_message_key, value);
		}

		/// <summary>
		/// Occurs when discord pipe is ready.
		/// </summary>
		public event ReadyEventHandler Ready {
			add => handlers.AddHandler(evt_ready_key, value);
			remove => handlers.RemoveHandler(evt_ready_key, value);
		}

		/// <summary>
		/// Occurs when pipe connection is closed.
		/// </summary>
		public event ConnectionClosedEventHandler ConnectionClosed {
			add => handlers.AddHandler(evt_connection_closed_key, value);
			remove => handlers.RemoveHandler(evt_connection_closed_key, value);
		}

		/// <summary>
		/// Occurs when client get some error.
		/// </summary>
		public event ClientErroredEventHandler ClientErrored {
			add => handlers.AddHandler(evt_client_errored_key, value);
			remove => handlers.RemoveHandler(evt_client_errored_key, value);
		}

		#endregion
		
		public RpcClientConfiguration Configuration { get; }
		public RpcUser CurrentUser { get; internal set; }

		public RpcClient(RpcClientConfiguration cfg)
		{
			this.Configuration = cfg;

			if (Configuration.RegisterApplication)
			{
				if (Environment.OSVersion.Platform != PlatformID.Win32NT)
					throw new PlatformNotSupportedException("App protocols are supported only in Windows.");
				else
				{
					if (!string.IsNullOrEmpty(Configuration.ExecutablePath))
						Utilities.RegisterAppWin(this, Configuration);
					else
						throw new ArgumentNullException(nameof(Configuration.ExecutablePath), "Application executable path is required to register as discord application!");
				}
			}
		}

		internal void RaiseLogEvent(object sender, LogLevel level, string message, DateTime? timestamp = null)
		{
			handlers[evt_log_message_key].DynamicInvoke(sender, new LogMessageEventArgs(message, level, timestamp));
		}

		public void Dispose()
		{

		}
	}

	public struct RpcClientConfiguration
	{
		public LogLevel Level { get; set; }
		public ulong ApplicationId { get; set; }
		public bool RegisterApplication { get; set; }
		public string ExecutablePath { get; set; }
	}
}