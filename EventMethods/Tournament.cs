using System;

namespace EventMethods
{
    public interface INumberOfPlayers // interface to print # of players
    {
        void printPlayers();
    }

    public interface ITotalFees
    {
        double playerCost(string inp);
    }

    public interface INumberOfGames // interface to print # of games
    {
        void printGames();
    }

    public class TournamentInfo // tournament info class
    {
        int id;
        string tournamentName;
        int players;
        int games;
        double entranceFee;

        public TournamentInfo(int newId,string newTournamentName, int newPlayers) // constructor
        {
            id = newId;
            tournamentName = newTournamentName;
            players = newPlayers;
        }

        public int Id // property for id
        {
            get { return id; }
            set { id = value; }
        }

        public string TournamentName // property for tournament name
        {
            get { return tournamentName; }
            set { tournamentName = value; }
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

        public double EntranceFee // event cost property
        {
            get { return entranceFee; }
            set { entranceFee = value; }
        }

        public override string ToString()
        {
            return "ID: " + Id.ToString() + ", Name of Tournament: " + TournamentName + ", Number of Players: " + Players.ToString()
                + ", Number of Games: " + Games.ToString() + ", Total Entrance Fees: " + EntranceFee.ToString();
        }
    }

    public class Tournament : INumberOfPlayers, INumberOfGames, ITotalFees // tournament class
    {
        private TournamentInfo theTournament; // initialize tournament info

        public Tournament(int newId, string newTournamentName, int newPlayers)
        {
            theTournament = new TournamentInfo(newId, newTournamentName, newPlayers);
        }

        void INumberOfPlayers.printPlayers() // implement interface player method
        {
            Console.WriteLine("Number of Players: " + theTournament.Players);
        }
        
        double ITotalFees.playerCost(string inp) // calculates total entrance fees
        {
            inp = inp.ToUpper();
            double costPerPlayer = 10.00;
            theTournament.EntranceFee = costPerPlayer * theTournament.Players; //total entrance fees

            if (inp == "D") // ifs/else ifs to get other totals
            {
                theTournament.EntranceFee *= 0.9;
            } 
            else if (inp == "E")
            {
                theTournament.EntranceFee *= 0.75;
            } 
            else if (inp == "F")
            {
                theTournament.EntranceFee *= 0;
            } 
            else if (inp == "L")
            {
                theTournament.EntranceFee *= 1.1;   
            }
            return theTournament.EntranceFee;

        }

        void INumberOfGames.printGames() // implement interface games method
        {
            theTournament.Games = (theTournament.Players - 1);
            Console.WriteLine("Number of Games: " + theTournament.Games);
        }

        public override string ToString()
        {
            return theTournament.ToString();
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
            Tournament tournament = new Tournament(4032, "Big Games Tourney",players);
            
            INumberOfPlayers numPlayers = tournament;
            ITotalFees totalFees = tournament;
            INumberOfGames numGames = tournament;

            Console.WriteLine("Enter a discount code, [D], [E], [F], [L]:");
            totalFees.playerCost(Console.ReadLine());
            
            numPlayers.printPlayers();
            numGames.printGames();
            Console.WriteLine(tournament);
        }
    }
}