using DiscordRpc.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscordRpc.EventArgs
{
	public class RpcReadyEventArgs : System.EventArgs
	{
		[JsonProperty("v")]
		public int Version { get; internal set; }

		[JsonProperty("config")]
		public RpcConfig Config { get; internal set; }

		[JsonProperty("user")]
		public RpcUser User { get; internal set; }
	}
}