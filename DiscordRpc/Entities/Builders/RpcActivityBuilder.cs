namespace DiscordRpc.Entities.Builders
{
	public class RpcActivityBuilder
	{
		private RpcActivity activity;

		public RpcActivityBuilder()
		{
			activity = new RpcActivity();
		}

		public RpcActivityBuilder(RpcActivityType? type = RpcActivityType.Playing) : this()
		{
			activity.Type = type;
		}

		public RpcActivityBuilder WithType(RpcActivityType? type = RpcActivityType.Playing)
		{
			activity.Type = type;
			return this;
		}

		public RpcActivityBuilder WithState(string state)
		{
			activity.State = state;
			return this;
		}

		public RpcActivityBuilder WithDetails(string details)
		{
			activity.Details = details;
			return this;
		}

		public RpcActivityBuilder WithTimestamp(RpcActivityTimestamp timestamp = null)
		{
			activity.Timestamps = timestamp;
			return this;
		}

		public RpcActivityBuilder WithAssets(RpcActivityAssets assets = null)
		{
			activity.Assets = assets;
			return this;
		}

		public RpcActivityBuilder WithParty(RpcActivityParty party = null)
		{
			activity.Party = party;
			return this;
		}

		public RpcActivityBuilder WithSecrets(RpcActivitySecrets secrets = null)
		{
			activity.Secrets = secrets;
			return this;
		}

		public RpcActivityBuilder WithInstance(bool instance = true)
		{
			activity.Instance = instance;
			return this;
		}

		public RpcActivity Build()
			=> activity;

		public static implicit operator RpcActivity(RpcActivityBuilder builder)
			=> builder.Build();
	}
}