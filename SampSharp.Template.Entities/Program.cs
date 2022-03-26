using SampSharp.Core;
using SampSharp.Entities;

namespace SampSharp.Template.Entities
{
    public class Program
    {
        static void Main(string[] args)
        {
            new GameModeBuilder()
                .UseEcs<Startup>()
                .Run();
        }
    }
}
