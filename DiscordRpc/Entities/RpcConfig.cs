using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscordRpc.Entities
{
    public class RpcConfig
    {
		/// <summary>
		/// Discord CDN Host
		/// </summary>
		[JsonProperty("cdn_host")]
		public string CdnHost { get; internal set; }

		/// <summary>
		/// Discord Api Endpoint
		/// </summary>
		[JsonProperty("api_endpoint")]
		public string ApiEndpoint { get; internal set; }
		
		/// <summary>
		/// Discord environment
		/// </summary>
		[JsonProperty("environment")]
		public string Environment { get; internal set; }
    }
}
