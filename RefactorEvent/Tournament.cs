using System;

namespace RefactorEvent
{
    public class Tournament : INumberOfPlayers, INumberOfGames, ITotalFees, IVersusType // tournament class
    {
        private TournamentInfo theTournament; // initialize tournament info

        public Tournament(int newId, string newTournamentName, int newPlayers)
        {
            theTournament = new TournamentInfo(newId, newTournamentName, newPlayers);
        }

        void INumberOfPlayers.printPlayers() // implement interface player method
        {
            Console.WriteLine("Number of Entrees: " + theTournament.Players);
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
        void IVersusType.printVersusType(string versusType)
        {
            theTournament.VersusType = versusType;
            Console.WriteLine("This offline tournament will be a " + theTournament.VersusType + " format.");
        }

        public override string ToString()
        {
            return theTournament.ToString();
        }
    }
}