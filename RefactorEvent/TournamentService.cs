using System;

namespace RefactorEvent
{
    public class TournamentService
    {
        private readonly INumberOfPlayers _players;
        private readonly INumberOfGames _games;
        private readonly ITotalFees _totalFees;
        private readonly IVersusType _versusType;

        public TournamentService(INumberOfPlayers players, INumberOfGames games, ITotalFees totalFees, IVersusType versusType)
        {
            _players = players;
            _games = games;
            _totalFees = totalFees;
            _versusType = versusType;
        }

        public void printPlayers()
        {
            _players.printPlayers();
        }

        public void printGames()
        {
            _games.printGames();
        }

        public void playerCost(string totalFees)
        {
            _totalFees.playerCost(totalFees);
        } 

        public void printVersusType(string versusType)
        {
            _versusType.printVersusType(versusType);
        }
    }
}