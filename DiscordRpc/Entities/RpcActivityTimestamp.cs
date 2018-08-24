using Newtonsoft.Json;
using System;

namespace DiscordRpc.Entities
{
	public class RpcActivityTimestamp
	{
		[JsonProperty("start", NullValueHandling = NullValueHandling.Ignore)]
		internal long? _start { get; set; } = null;

		[JsonProperty("end", NullValueHandling = NullValueHandling.Ignore)]
		internal long? _end { get; set; } = null;

		/// <summary>
		/// Unix Start Timestamp
		/// </summary>
		[JsonIgnore]
		public DateTime? Start {
			get
			{
				if (_start.HasValue)
					return Utilities.UnixTimestampToDateTime(_start.Value);
				return null;
			}
			set
			{
				if (value.HasValue)
					_start = Utilities.DateTimeToUnixTimestamp(value.Value);
				else
					_start = null;
			}
		}

		/// <summary>
		/// Unix End Timestamp
		/// </summary>
		[JsonIgnore]
		public DateTime? End {
			get
			{
				if (_end.HasValue)
					return Utilities.UnixTimestampToDateTime(_end.Value);
				return null;
			}
			set
			{
				if (value.HasValue)
					_end = Utilities.DateTimeToUnixTimestamp(value.Value);
				else
					_end = null;
			}
		}
	}
}