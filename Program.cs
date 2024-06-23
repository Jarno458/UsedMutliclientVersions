using Archipelago.MultiClient.Net;
using Archipelago.MultiClient.Net.Enums;
using static System.String;

namespace UsedMutliclientVersions
{
    class Program
    {
        static async Task<int> Main()
        {
            var session = ArchipelagoSessionFactory.CreateSession("Archipelago.gg");
            var roomInfo = await session.ConnectAsync();
            var loginResult = await session.LoginAsync("", "Player1493", ItemsHandlingFlags.NoItems, tags: new[] { "TextOnly", "HackedClient", "1337Hax0r3DIZ" });

            if (!loginResult.Successful)
            {
                Console.WriteLine(Join(", ", ((LoginFailure)loginResult).Errors));
                return -1;
            }

            Console.WriteLine("Connected");

            var usedVersions = await session.DataStorage[".NetUsedVersions"].GetAsync<Dictionary<string, bool>>();

            var gameInfos = new LookupDictionary<string, GameInfo>(g => g.Game);
            foreach (var usedVersion in usedVersions.Keys)
            {
                var parts = usedVersion.Split(':');

                var game = parts[0];
                var libVersion = parts[1];
                var netVersion = parts[2];

                if (game == Empty)
                    game = "Unknown";

                if (!gameInfos.TryGetValue(game, out GameInfo gameInfo))
                {
                    gameInfo = new GameInfo
                    {
                        Game = game,
                        UsedLibVersions = new HashSet<string>(),
                        UsedNetVersions = new HashSet<string>()
                    };

                    gameInfos.Add(gameInfo);
                }

                gameInfo.UsedLibVersions.Add(libVersion);
                gameInfo.UsedNetVersions.Add(netVersion);
            }

            Console.WriteLine("Used .Net Versions:");
            foreach (var gameInfo in gameInfos.OrderBy(g => g.Game))
            {
                Console.WriteLine($"{gameInfo.Game}: [{gameInfo.UsedNetVersions.Join(", ")}] ({gameInfo.UsedLibVersions.Join(", ")})");
            }
            
            while (true)
            {
                var cmd = Console.ReadLine();

                switch (cmd)
                {
                    case "exit":
                        return 0;
                }

                Thread.Sleep(100);
            }
        }
    }

    class GameInfo
    {
        public string Game { get; set; } = "Unknown";
        public HashSet<string> UsedLibVersions { get; set; } = new();
        public HashSet<string> UsedNetVersions { get; set; } = new();
    }
}