using System;

namespace DiscordRpc.Attributes
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public sealed class CommandAttribute : Attribute
	{
		public string Name { get; }

		public CommandAttribute(string name)
			=> this.Name = name;
	}
}