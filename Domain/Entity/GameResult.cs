using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
    public class GameResult : EntityBase
    {
        public long PlayerId { get; set; }
        public long GameId { get; set; }
        public long Win { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
