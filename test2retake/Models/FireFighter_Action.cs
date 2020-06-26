using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace test2retake.Models
{
    public class FireFighter_Action
    {

        [ForeignKey("FireFighter")]
        public int IdFireFighter { get; set; }
        [ForeignKey("Action")]
        public int IdAction { get; set; }
        public virtual FireFighter FireFighter { get; set; }
        public virtual Action Action { get; set; }
    }
}
