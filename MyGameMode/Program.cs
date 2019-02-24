using SampSharp.Core;

namespace MyGameMode
{
	public class Program
	{
		public static void Main(string[] args)
		{
			new GameModeBuilder()
				.Use<GameMode>()
				.Run();
		}
	}
}
