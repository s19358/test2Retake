using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace test2retake.Models
{
    public class FireTruck
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdFireTruck { get; set; }
        [MaxLength(10)]
        [Required]
        public string OperationalNumber { get; set; }
        [Required]
        public bool SpecialEquipment { get; set; }
        public virtual ICollection<FireTruck_Action> FireTruck_Actions { get; set; }
    }
}
