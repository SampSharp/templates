using System;
using SampSharp.GameMode;

namespace SampSharp.Template.GameMode
{
    public class GameMode : BaseMode
    {
        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);

            Console.WriteLine("\n----------------------------------");
            Console.WriteLine(" Blank game mode by your name here");
            Console.WriteLine("----------------------------------\n");

            // TODO: Put logic to initialize your game mode here
            SetGameModeText("Bank game mode");
        }
    }
}