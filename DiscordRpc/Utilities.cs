using System;
using System.Collections.Generic;
using System.Text;

namespace DiscordRpc
{
	public static class Utilities
	{
		/// <summary>
		/// Converts <see cref="DateTime"/> to Unix timestamp.
		/// </summary>
		/// <param name="datetime"><see cref="DateTime"/> to convert</param>
		/// <returns>Unix timestamp converted</returns>
		public static long DateTimeToUnixTimestamp(DateTime datetime)
		{
			return (long)(TimeZoneInfo.ConvertTimeToUtc(datetime) -
				   new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
		}

		/// <summary>
		/// Converts Unix timestamp to <see cref="DateTime"/>
		/// </summary>
		/// <param name="timestamp">Unix timestamp</param>
		/// <returns><see cref="DateTime"/> converted</returns>
		public static DateTime UnixTimestampToDateTime(long timestamp)
		{
			return new DateTime(1970, 1, 1, 0, 0, 0)
				.AddSeconds(timestamp);
		}
	}
}