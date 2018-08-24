using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscordRpc.Entities
{
	public class RpcDispatch
	{
		/// <summary>
		/// Command Type.
		/// </summary>
		[JsonProperty("cmd")]
		public string Command { get; set; }

		/// <summary>
		/// Arguments.
		/// </summary>
		[JsonProperty("args", NullValueHandling = NullValueHandling.Ignore)]
		public object Arguments { get; set; }

		/// <summary>
		/// Unique Id used once for replies from the server.
		/// </summary>
		[JsonProperty("nonce")]
		public string Nonce { get; set; } = Guid.NewGuid().ToString();

		/// <summary>
		/// Dispatch Data.
		/// </summary>
		[JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
		public object Data { get; set; }

		/// <summary>
		/// Event Name.
		/// </summary>
		[JsonProperty("evt", NullValueHandling = NullValueHandling.Ignore)]
		public string Event { get; set; }

		/// <summary>
		/// Convert dispatch to json.
		/// </summary>
		/// <returns></returns>
		public string ToJson()
			=> JsonConvert.SerializeObject(this, Formatting.None);
	}
}