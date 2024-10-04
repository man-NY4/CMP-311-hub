using System;

namespace RefactorEvent
{
    public class OnlineTourney : INumberOfPlayers, INumberOfGames, ITotalFees, IVersusType // tournament class
    {
        private TournamentInfo onlineTournament; // initialize tournament info

        public OnlineTourney(int newId, string newTournamentName, int newPlayers)
        {
            onlineTournament = new TournamentInfo(newId, newTournamentName, newPlayers);
        }

        void INumberOfPlayers.printPlayers() // implement interface player method
        {
            Console.WriteLine("Number of Entrees: " + onlineTournament.Players);
        }

        double ITotalFees.playerCost(string inp) // calculates total entrance fees
        {
            inp = inp.ToUpper();
            double costPerPlayer = 5.00;
            onlineTournament.EntranceFee = costPerPlayer * onlineTournament.Players; //total entrance fees

            if (inp == "D") // ifs/else ifs to get other totals
            {
                onlineTournament.EntranceFee *= 0.9;
            }
            else if (inp == "E")
            {
                onlineTournament.EntranceFee *= 0.75;
            }
            else if (inp == "F")
            {
                onlineTournament.EntranceFee *= 0;
            }
            else if (inp == "L")
            {
                onlineTournament.EntranceFee *= 1.1;
            }
            return onlineTournament.EntranceFee;

        }

        void INumberOfGames.printGames() // implement interface games method
        {
            onlineTournament.Games = (onlineTournament.Players - 1);
            Console.WriteLine("Number of Games: " + onlineTournament.Games);
        }

        void IVersusType.printVersusType(string versusType)
        {
            onlineTournament.VersusType = versusType;
            Console.WriteLine("This online tournament will be a " + onlineTournament.VersusType + " format.");
        }

        public override string ToString()
        {
            return onlineTournament.ToString();
        }
    }
}