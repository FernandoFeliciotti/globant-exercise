using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PresidentsExcercise.Model
{
    [Table("Presidents", Schema = "Exercise")]
    public class President
    {
        [Key]
        public int PresidentID { get; set; }

        [MaxLength(100, ErrorMessage = "100 characters maxlength")]
        [Column("President")]
        public string Fullname { get; set; }

        public DateTime? Birthday { get; set; }

        [MaxLength(100, ErrorMessage = "100 characters maxlength")]
        public string Birthplace { get; set; }

        public DateTime? Deathday { get; set; }

        [MaxLength(100, ErrorMessage = "100 characters maxlength")]
        public string Deathplace { get; set; }
    }
}
