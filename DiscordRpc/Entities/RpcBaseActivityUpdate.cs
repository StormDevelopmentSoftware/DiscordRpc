using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscordRpc.Entities
{
	public class RpcBaseActivityUpdate
	{
		/// <summary>
		/// Current Process Id
		/// </summary>
		[JsonProperty("pid")]
		public int ProcessId { get; internal set; }

		public string ToJson()
			=> JsonConvert.SerializeObject(this);
	}
}