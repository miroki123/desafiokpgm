using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DTO
{
    public class PlayerDTO
    {
        public long PlayerId { get; set; }
        public long Balance { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
