using System;
using System.Collections.Generic;
using System.Text;

namespace DiscordRpc.EventArgs
{
	public delegate void ClientErroredEventHandler(ClientErroredEventArgs e);

	/// <summary>
	/// Represents class that contain cause of error on client.
	/// </summary>
    public class ClientErroredEventArgs : System.EventArgs
    {
		/// <summary>
		/// Rpc Client that fired event.
		/// </summary>
		public RpcClient Client { get; }

		/// <summary>
		/// Cause of client error.
		/// </summary>
		public Exception Exception { get; }

		public ClientErroredEventArgs(RpcClient client, Exception exception)
		{
			this.Client = client;
			this.Exception = exception;
		}
    }
}
