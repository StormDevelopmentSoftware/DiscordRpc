using System;
using System.Collections.Generic;
using System.Text;

namespace DiscordRpc.EventArgs
{
	public delegate void ConnectionClosedEventHandler(ConnectionClosedEventArgs e);

	/// <summary>
	/// Represents class that contains disconnect event fields.
	/// </summary>
    public class ConnectionClosedEventArgs : System.EventArgs
    {
		/// <summary>
		/// Rpc Client that fired event.
		/// </summary>
		public RpcClient Client { get; }

		public ConnectionClosedEventArgs(RpcClient client)
		{
			this.Client = client;
		}
    }
}
