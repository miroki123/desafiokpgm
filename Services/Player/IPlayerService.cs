using Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Player
{
    public interface IPlayerService
    {
        void AddGameResult(GameResultDTO result);
        List<PlayerDTO> GetLeaderboards();
    }
}
