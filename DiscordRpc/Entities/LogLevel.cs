using System;
using System.Collections.Generic;
using System.Text;

namespace DiscordRpc.Entities
{
	public enum LogLevel
	{
		Debug = 1 << 0,
		Info = 1 << 2,
		Warn = 1 << 3,
		Error = 1 << 4,
		Fatal = 1 << 5,
	}
}
