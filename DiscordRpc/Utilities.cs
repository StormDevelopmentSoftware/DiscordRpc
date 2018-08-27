using DiscordRpc.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;
using System.ComponentModel;

#if !NETCOREAPP2_0
using Microsoft.Win32;
#endif

namespace DiscordRpc
{
	/// <summary>
	/// Represents an utility class.
	/// </summary>
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

		public static RpcCommand? GetCommand(string name)
		{
			foreach(RpcCommand cmd in Enum.GetValues(typeof(RpcCommand)))
			{
				var attr = (DescriptionAttribute)cmd.GetType()
					.GetCustomAttributes(typeof(DescriptionAttribute), false)
					.FirstOrDefault();

				if (attr != null && attr.Description == name)
					return cmd;
			}
			return null;
		}

		public static string GetCommandName(this RpcCommand command)
		{
			var attr = (DescriptionAttribute)command.GetType()
				.GetCustomAttributes(typeof(DescriptionAttribute), false)
				.FirstOrDefault();

			if (attr != null)
				return attr.Description;

			return null;
		}

		public static RpcEvent? GetEvent(string name)
		{
			foreach (RpcEvent evt in Enum.GetValues(typeof(RpcCommand)))
			{
				var attr = (DescriptionAttribute)evt.GetType()
					.GetCustomAttributes(typeof(DescriptionAttribute), false)
					.FirstOrDefault();

				if (attr != null && attr.Description == name)
					return evt;
			}
			return null;
		}

		public static string GetEventName(this RpcEvent evt)
		{
			var attr = (DescriptionAttribute)evt.GetType()
				.GetCustomAttributes(typeof(DescriptionAttribute), false)
				.FirstOrDefault();

			if (attr != null)
				return attr.Description;

			return null;
		}

		public static void RegisterAppWin(RpcClient client, RpcClientConfiguration cfg)
		{
#if NETCOREAPP2_0 || NETSTANDARD2_0
			throw new PlatformNotSupportedException(".NET Core does not have support to Mincrosoft Windows Registry.");
#else
			var key = Registry.ClassesRoot.OpenSubKey($"discord-{cfg.ApplicationId}");
			
			if(key != null)
				Registry.ClassesRoot.DeleteSubKeyTree($"discord-{cfg.ApplicationId}");

			key = Registry.ClassesRoot.CreateSubKey($"discord-{cfg.ApplicationId}");
			key.SetValue(string.Empty, $"URL: Run Game {cfg.ApplicationId} Protocol");
			key.SetValue("URL Protocol", string.Empty);

			var command = key.CreateSubKey(@"shell\open\command");
			command.SetValue(string.Empty, cfg.ExecutablePath);

			var icon = key.CreateSubKey("DefaultIcon");
			icon.SetValue(string.Empty, cfg.ExecutablePath);

			icon.Close();
			command.Close();
			key.Close();

			client.RaiseLogEvent(client, LogLevel.Info, "Registered registry key for this app.");
#endif
		}
	}
}