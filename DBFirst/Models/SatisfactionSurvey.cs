﻿using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class SatisfactionSurvey
    {
        public int Id { get; set; }
        public Guid AccountGid { get; set; }
        public int MachineId { get; set; }
        public int Score { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Account AccountG { get; set; } = null!;
        public virtual Machine Machine { get; set; } = null!;
    }
}
