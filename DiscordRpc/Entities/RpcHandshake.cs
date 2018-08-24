using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscordRpc.Entities
{
	public class RpcHandshake
	{
		/// <summary>
		/// Handshake Version
		/// </summary>
		[JsonProperty("v")]
		public int Version { get; } = 1;

		/// <summary>
		/// Discord Client Id
		/// </summary>
		[JsonProperty("client_id")]
		public string ClientId { get; set; }
	}
}