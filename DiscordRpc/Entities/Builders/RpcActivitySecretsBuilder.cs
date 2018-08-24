namespace DiscordRpc.Entities.Builders
{
	public class RpcActivitySecretsBuilder
	{
		RpcActivitySecrets secrets;

		public RpcActivitySecretsBuilder()
		{
			secrets = new RpcActivitySecrets();
		}

		public RpcActivitySecretsBuilder WithJoin(string join = null)
		{
			secrets.Join = join;
			return this;
		}

		public RpcActivitySecretsBuilder WithSpectate(string spectate = null)
		{
			secrets.Spectate = spectate;
			return this;
		}

		public RpcActivitySecretsBuilder WithMatch(string match = null)
		{
			secrets.Match = match;
			return this;
		}

		public RpcActivitySecrets Build()
			=> secrets;

		public static implicit operator RpcActivitySecrets(RpcActivitySecretsBuilder builder)
			=> builder.Build();
	}
}