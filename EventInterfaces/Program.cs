using System;
using System.Runtime.InteropServices;

namespace EventInterfaces
{
    public interface INumberOfPlayers // interface to print # of players
    {
        void printPlayers();
    }

    public interface INumberOfGames // interface to print # of games
    {
        void printGames();
    }

    public class TournamentInfo // tournament info class
    {
        int players;
        int games;

        public TournamentInfo(int newPlayers) // constructor
        {
            players = newPlayers;
        }

        public int Players // Property for players
        {
            get { return players; }
            set { players = value; }
        }

        public int Games // property for games
        {
            get { return games; }
            set { games = value; }
        }
    }

    public class Tournament : INumberOfPlayers, INumberOfGames // tournament class
    {
        private TournamentInfo theTournament; // initialize tournament info

        public Tournament(int newPlayers)
        {
            theTournament = new TournamentInfo(newPlayers);
        }

        void INumberOfPlayers.printPlayers() // implement interface player method
        {
            Console.WriteLine("Number of Players: " + theTournament.Players);
        }

        void INumberOfGames.printGames() // implement interface games method
        {
            theTournament.Games = (theTournament.Players - 1);
            Console.WriteLine("Number of Games: " + theTournament.Games);
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Make a Tournament");
            Console.WriteLine("----------------------\n");
            Console.WriteLine("Enter the # of players for a single elimination tournament");
            int players = Convert.ToInt32(Console.ReadLine());
            Tournament tournament = new Tournament(players);
            INumberOfPlayers numPlayers = tournament;
            INumberOfGames numGames = tournament;

            numPlayers.printPlayers();
            numGames.printGames();
        }
    }
}