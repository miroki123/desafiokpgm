using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services.Player;

namespace desafiokpgm.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : ControllerBase
    {
        private readonly ILogger<GameController> _logger;
        private readonly IPlayerService _playerService;

        public GameController(ILogger<GameController> logger, IPlayerService playerService)
        {
            _logger = logger;
            _playerService = playerService;
        }

        [HttpGet("GetLeaderboards")]
        public IEnumerable<PlayerDTO> GetLeaderboards()
        {
            return _playerService.GetLeaderboards();
        }

        [HttpPost("PublishGameResult")]
        public void PublishGameResult(GameResultDTO result)
        {
            _playerService.AddGameResult(result);
        }
    }
}
