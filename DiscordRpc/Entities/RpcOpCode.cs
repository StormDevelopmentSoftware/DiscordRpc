using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DiscordRpc.Entities
{
	public enum RpcOpCode
	{
		Handshake = 0,
		Frame,
		Close,
		Ping,
		Pong
	}
}