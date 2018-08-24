using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscordRpc.Entities
{
	public class RpcUser
	{
		/// <summary>
		/// User Id
		/// </summary>
		[JsonProperty("id")]
		public ulong Id { get; internal set; }

		/// <summary>
		/// Username
		/// </summary>
		[JsonProperty("username")]
		public string Username { get; internal set; }

		/// <summary>
		/// Discriminator
		/// </summary>
		[JsonProperty("discriminator")]
		public string Discriminator { get; internal set; }

		/// <summary>
		/// Avatar Hash
		/// </summary>
		[JsonProperty("avatar")]
		public string AvatarHash { get; internal set; }

		/// <summary>
		/// Avatar Url
		/// </summary>
		[JsonIgnore]
		public string AvatarUrl {
			get
			{
				if (string.IsNullOrEmpty(AvatarHash))
					return DefaultAvatarUrl;

				if (AvatarHash.StartsWith("a_"))
					return $"https://cdn.discordapp.com/avatars/{Id.ToString()}/{AvatarHash}.gif";

				return $"https://cdn.discordapp.com/avatars/{Id.ToString()}/{AvatarHash}.png";
			}
		}

		/// <summary>
		/// Default Avatar Url
		/// </summary>
		[JsonIgnore]
		public string DefaultAvatarUrl {
			get
			{
				return $"https://cdn.discordapp.com/embed/avatars/{(Convert.ToInt32(this.Discriminator) % 5).ToString()}.png";
			}
		}

		/// <summary>
		/// Is Bot User
		/// </summary>
		[JsonProperty("bot")]
		public bool IsBot { get; internal set; } = false;
	}
}