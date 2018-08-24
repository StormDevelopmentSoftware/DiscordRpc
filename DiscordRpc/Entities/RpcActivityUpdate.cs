using Newtonsoft.Json;

namespace DiscordRpc.Entities
{
	public class RpcActivityUpdate : RpcBaseActivityUpdate
	{
		[JsonProperty("activity", NullValueHandling = NullValueHandling.Ignore)]
		public RpcActivity Activity { get; set; }
	}
}