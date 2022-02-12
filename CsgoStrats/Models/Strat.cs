using System;
using System.Collections.Generic;

namespace CsgoStrats.Models
{
    public partial class Strat
    {
        public int StratId { get; set; }
        public string StratTitle { get; set; } = null!;
        public string StratDescription { get; set; } = null!;
        public string StratVideoLink { get; set; } = null!;
        public string StratMap { get; set; } = null!;
        public string StratSide { get; set; } = null!;
    }
}
