using System;
using SampSharp.Entities;
using SampSharp.Entities.SAMP;
using SampSharp.Entities.SAMP.Commands;

namespace SampSharp.Template.Entities
{
    public class System1 : ISystem
    {
        [Event]
        public void OnGameModeInit(IServerService serverService)
        {
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine(" Blank game mode by your name here");
            Console.WriteLine("----------------------------------\n");

            serverService.AddPlayerClass(8, new Vector3(0, 0, 7), 0);
            serverService.SetGameModeText("Blank game mode");
        }

        [PlayerCommand("hello")]
        public void HelloCommand(Player player)
        {
            player.SendClientMessage($"Hello, {player.Name}!");
        }
    }
}