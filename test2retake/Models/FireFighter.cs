using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace test2retake.Models
{
    public class FireFighter
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int IdFireFighter { get; set; }
        [MaxLength(30)]
        [Required]
        public string FirstName { get; set; }
        [MaxLength(50)]
        [Required]
        public string LastName { get; set; }
        public virtual ICollection<FireFighter_Action> FireFighter_Actions { get; set; }
    }
}
