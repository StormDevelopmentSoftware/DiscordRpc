using DiscordRpc.Entities;
using DiscordRpc.EventArgs;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;
using System.Threading;

namespace DiscordRpc.Net
{
	/// <summary>
	/// Represents Pipe Client for I/O operations. 
	/// </summary>
    public sealed class PipeClient
    {
		internal string name;
		internal NamedPipeClientStream stream;
		internal RpcClient rpc;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="pipeName">Pipe Name (like: discord-rpc-0)</param>
		/// <param name="client">Current <see cref="RpcClient"/> instance</param>
		public PipeClient(string pipeName, RpcClient client)
		{
			name = pipeName;
			rpc = client;
			stream = new NamedPipeClientStream(".", pipeName, PipeDirection.InOut);
		}

		/// <summary>
		/// Connect to Pipe Stream.
		/// </summary>
		public void Connect()
		{
			stream.Connect(5000);
		}

		/// <summary>
		/// Read next buffer from pipe stream.
		/// </summary>
		/// <returns></returns>
		public byte[] Read()
		{
			if (!stream.IsConnected)
				throw new InvalidOperationException("Pipe is not connected!");

			var buf = new byte[stream.InBufferSize];
			stream.Read(buf, 0, buf.Length);
			return buf;
		}

		/// <summary>
		/// Write <see cref="RpcPacket"/> to pipe stream.
		/// </summary>
		/// <param name="packet">Packet to write in.</param>
		public void Write(RpcPacket packet)
		{
			if (!stream.IsConnected)
				throw new InvalidOperationException("Pipe is not connected!");

			if (packet == null)
				throw new ArgumentNullException(nameof(packet), "Packet cannot be null!");

			var buf = packet.GetBytes();
			stream.Write(buf, 0, buf.Length);

			rpc.RaiseLogMessageReceivedEvent(this, new LogMessageEventArgs("Sent", LogLevel.Debug));
		}
    }
}
