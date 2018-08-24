namespace DiscordRpc.Entities.Builders
{

	public class RpcActivityAssetsBuilder
	{
		RpcActivityAssets assets;

		public RpcActivityAssetsBuilder()
		{
			assets = new RpcActivityAssets();
		}

		public RpcActivityAssetsBuilder WithLargeImage(string largeImage = null)
		{
			assets.LargeImage = largeImage;
			return this;
		}

		public RpcActivityAssetsBuilder WithLargeText(string largeText = null)
		{
			assets.LargeText = largeText;
			return this;
		}

		public RpcActivityAssetsBuilder WithSmallImage(string smallImage = null)
		{
			assets.SmallImage = smallImage;
			return this;
		}

		public RpcActivityAssetsBuilder WithSmallText(string smallText = null)
		{
			assets.SmallText = smallText;
			return this;
		}

		public RpcActivityAssets Build()
			=> assets;

		public static implicit operator RpcActivityAssets(RpcActivityAssetsBuilder builder)
			=> builder.Build();
	}
}