using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace test2retake.Models
{
    public class FireTruck_Action
    {
        [Key]
        public int IdFireTruckAction { get; set; }
        [ForeignKey("FireTruck")]
        public int IdFireTruck { get; set; }
        [ForeignKey("Action")]
        public int IdAction { get; set; }
        [Required]
        public DateTime AssignmentDate { get; set; }
        public virtual FireTruck FireTruck { get; set; }
        public virtual Action Action { get; set; }
    }
}
