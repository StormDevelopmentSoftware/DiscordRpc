using Newtonsoft.Json;

namespace DiscordRpc.Entities
{
	public class RpcActivitySecrets
	{
		/// <summary>
		/// Join Secret
		/// </summary>
		[JsonProperty("join", NullValueHandling = NullValueHandling.Ignore)]
		public string Join { get; set; }

		/// <summary>
		/// Spectate Secret
		/// </summary>
		[JsonProperty("spectate", NullValueHandling = NullValueHandling.Ignore)]
		public string Spectate { get; set; }

		/// <summary>
		/// Match Secret
		/// </summary>
		[JsonProperty("match", NullValueHandling = NullValueHandling.Ignore)]
		public string Match { get; set; }
	}
}