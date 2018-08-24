using System;

namespace DiscordRpc.Entities.Builders
{
	public class RpcActivityTimestampBuilder
	{
		private RpcActivityTimestamp timestamp;

		public RpcActivityTimestampBuilder()
		{
			timestamp = new RpcActivityTimestamp();
		}

		public RpcActivityTimestampBuilder WithStartTime(DateTime? start = null)
		{
			timestamp.Start = start;
			return this;
		}

		public RpcActivityTimestampBuilder WithEndTimestamp(DateTime? end = null)
		{
			timestamp.End = end;
			return this;
		}

		public RpcActivityTimestamp Build()
			=> timestamp;

		public static implicit operator RpcActivityTimestamp(RpcActivityTimestampBuilder builder)
			=> builder.Build();
	}
}