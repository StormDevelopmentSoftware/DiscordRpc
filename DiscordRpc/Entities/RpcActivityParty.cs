using Newtonsoft.Json;

namespace DiscordRpc.Entities
{
	public class RpcActivityParty
	{
		[JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
		public string Id { get; set; }

		[JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
		public int?[] Size { get; set; } = null;
	}
}