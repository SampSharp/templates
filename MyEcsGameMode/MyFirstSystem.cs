using System;
using SampSharp.Entities;
using SampSharp.Entities.SAMP;
using SampSharp.Entities.SAMP.Commands;

namespace MyEcsGameMode
{
	public class MyFirstSystem : ISystem
	{
		[Event]
		public void OnGameModeInit(IServerService serverService)
		{
			Console.WriteLine("My first ECS game mode is initializing.");

			serverService.AddPlayerClass(8, new Vector3(0, 0, 7), 0);
			serverService.SetGameModeText("My First Game Mode");
		}

		[PlayerCommand("hello")]
		public void MyFirstCommand(Player player)
		{
			player.SendClientMessage($"Hello, {player.Name}!");
		}
	}
}