using SampSharp.Core;
using SampSharp.Entities;

namespace $safeprojectname$
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
