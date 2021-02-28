using System;
using System.Collections.Generic;
using System.Text;
using Domain.DTO;
using Domain.Entity;
using Infrastructure.LocalDatabase;

namespace Services.Player
{
    public class PlayerService : IPlayerService
    {
        private readonly ILocalDatabase _localDatabase;

        public PlayerService(ILocalDatabase localDatabase)
        {
            _localDatabase = localDatabase;
        }

        public List<PlayerDTO> GetLeaderboards()
        {
            var players = new List<PlayerDTO>();
            _localDatabase.GetTopPlayers(100).ForEach(p => {
                players.Add(new PlayerDTO
                {
                    Balance = p.Balance,
                    LastUpdateDate = p.LastUpdateDate,
                    PlayerId = p.PlayerId
                });
            });
            return players;
        }

        public void AddGameResult(GameResultDTO result)
        {
            var res = new GameResult
            {
                GameId = result.GameId,
                PlayerId = result.PlayerId,
                Timestamp = result.Timestamp,
                Win = result.Win
            };
            _localDatabase.AddGameResult(res);
        }
    }
}
