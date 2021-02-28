using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.LocalDatabase
{
    public interface ILocalDatabase
    {
        void AddGameResult(GameResult result);
        List<Player> GetPlayers();
        List<Player> GetTopPlayers(int number);
        List<GameResult> GetGameResults();
    }
}
