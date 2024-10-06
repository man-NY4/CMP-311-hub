using System;

namespace RefactorEvent
{
    public class Program
    {
        static void Main(string[] args)
        {
            OfflineTourney offline = new OfflineTourney(4032, "Gaming United", 16);
            ITournament tournament = offline;
            TournamentService tournamentService1 = new TournamentService(tournament);
            tournamentService1.printTournament("Inside Offline tournament\n");

            OnlineTourney online = new OnlineTourney(8021, "Online Frontier", 16);
            ITournament tournament2 = online;
            TournamentService tournamentService2 = new TournamentService(tournament2);
            tournamentService1.printTournament("Inside Online tournament");


            /*
            Console.WriteLine("Make a Tournament");
            Console.WriteLine("---------------------------------------\n");
            Console.WriteLine("Enter the # of players for an offline single elimination tournament");

            int offlineEntrees = Convert.ToInt32(Console.ReadLine());
            Tournament tournament = new Tournament(4032, "Big Games Tourney", offlineEntrees);

            INumberOfPlayers offlinePlayers = tournament;
            ITotalFees offlineFees = tournament;
            INumberOfGames offlineGames = tournament;
            IVersusType offlineVersus = tournament;
           
            TournamentService tournamentService = new TournamentService(offlinePlayers, offlineGames, offlineFees, offlineVersus);

            Console.WriteLine("Enter an offline discount code, [D], [E], [F], [L]:");
            tournamentService.playerCost(Console.ReadLine());
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Enter the # of players for an online single elimination tournament");

            int onlineEntrees = Convert.ToInt32(Console.ReadLine());
            OnlineTourney online = new OnlineTourney(8045, "Network Gamers", onlineEntrees);

            INumberOfPlayers onlinePlayers = online;
            ITotalFees onlineFees = online;
            INumberOfGames onlineGames = online;
            IVersusType onlineVersus = online;
            
            TournamentService onlineService = new TournamentService(onlinePlayers, onlineGames, onlineFees, onlineVersus);

            Console.WriteLine("Enter an online discount code, [D], [E], [F], [L]:");
            onlineService.playerCost(Console.ReadLine());
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Offline Tournament Stats");
            
            tournamentService.printPlayers();
            tournamentService.printGames();
            tournamentService.printVersusType("Team V.S.");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine("Online Tournament Stats");
            onlineService.printPlayers();
            onlineService.printGames();
            onlineService.printVersusType("One on one");
            Console.WriteLine("---------------------------------------");

            Console.WriteLine(tournament);
            Console.WriteLine(online);
            Console.WriteLine("---------------------------------------\n"); 
            */
        }
    }
}