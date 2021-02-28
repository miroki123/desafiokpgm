using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
    public class Player : EntityBase
    {
        public long PlayerId { get; set; }
        public long Balance { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
