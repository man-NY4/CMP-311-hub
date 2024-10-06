using System;

namespace RefactorEvent
{
    public class TournamentService
    {
        private readonly ITournament _tournament;

        public TournamentService(ITournament tournament)
        {
            _tournament = tournament;
        }

        public void printTournament(string message)
        {
            _tournament.printTournament(message);
        }

        /*
        public void printPlayers()
        {
            _players.printPlayers();
        }

        public void printGames()
        {
            _games.printGames();
        }

        public void playerCost(string tournament)
        {
            _totalFees.playerCost(tournament);
        } 

        public void printVersusType(string tournament)
        {
            _versusType.printVersusType(tournament);
        }
        */
    }
}