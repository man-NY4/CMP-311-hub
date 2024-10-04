using System;

namespace RefactorEvent
{
    public class TournamentInfo // tournament info class
    {
        int id;
        string tournamentName;
        int players;
        int games;
        double entranceFee;
        string versusType;

        public TournamentInfo(int newId, string newTournamentName, int newPlayers) // constructor
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

        public string VersusType // property for versus type
        {
            get { return versusType; }
            set { versusType = value; }
        }

        public override string ToString()
        {
            return "ID: " + Id.ToString() + ", Name of Tournament: " + TournamentName + 
                ", Number of Entrees: " + Players.ToString()+ ", Number of Games: " + Games.ToString() 
                + ", Total Entrance Fees: " + EntranceFee.ToString() + ", \nin a " + VersusType.ToString() + " format";
        }
    }
}
