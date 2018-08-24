using Newtonsoft.Json;

namespace DiscordRpc.Entities
{
	public class RpcActivity
	{
		[JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
		public RpcActivityType? Type { get; set; } = null;

		[JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
		public string State { get; set; }

		[JsonProperty("details", NullValueHandling = NullValueHandling.Ignore)]
		public string Details { get; set; }

		[JsonProperty("timestamps", NullValueHandling = NullValueHandling.Ignore)]
		public RpcActivityTimestamp Timestamps { get; set; }

		[JsonProperty("assets", NullValueHandling = NullValueHandling.Ignore)]
		public RpcActivityAssets Assets { get; set; }

		[JsonProperty("party", NullValueHandling = NullValueHandling.Ignore)]
		public RpcActivityParty Party { get; set; }

		[JsonProperty("secrets", NullValueHandling = NullValueHandling.Ignore)]
		public RpcActivitySecrets Secrets { get; set; }

		[JsonProperty("instance", NullValueHandling = NullValueHandling.Ignore)]
		public bool Instance { get; set; } = true;
	}
}