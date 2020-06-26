using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test2retake.DTOs
{
    public class FirefighterActionResponse
    {
        public int IdAction { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
