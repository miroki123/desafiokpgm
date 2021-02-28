using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entity;
using System.Linq;

namespace Infrastructure.LocalDatabase
{
    public class LocalDatabase : ILocalDatabase
    {
        private List<GameResult> results;
        private List<Player> players;

        public LocalDatabase()
        {
            results = new List<GameResult>();
            players = new List<Player>();
        }

        public List<GameResult> GetGameResults()
        {
            return this.results;
        }

        public List<Player> GetPlayers()
        {
            return this.players;
        }

        public List<Player> GetTopPlayers(int number)
        {
            return players.OrderByDescending(p => p.Balance).Take(number).ToList();
        }

        public void AddGameResult(GameResult result)
        {
            this.results.Add(result);
            UpdatePlayer(result);
        }

        private void UpdatePlayer(GameResult result)
        {
            var player = this.players.FirstOrDefault(p => p.PlayerId == result.PlayerId);
            if (player != null)
            {
                player.LastUpdateDate = DateTime.UtcNow;
                player.Balance += result.Win;
            } else
            {
                player = new Player
                {
                    Balance = result.Win,
                    LastUpdateDate = DateTime.UtcNow,
                    PlayerId = result.PlayerId
                };
                this.players.Add(player);
            }
        }
    }
}
