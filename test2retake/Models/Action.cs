using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace test2retake.Models
{
    public class Action
    {
        [Key]
        public int IdAction { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        [Required]
        public bool NeedSpecialEquipment { get; set; }

        public virtual ICollection<FireFighter_Action> FireFighter_Actions { get; set; }
        public virtual ICollection<FireTruck_Action> FireTruck_Actions { get; set; }
    }
}
