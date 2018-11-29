using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciServisTakip.Model.School
{
    [Table("tblSchool")]
    public class School : EntityBase
    {
        [Key]
        public int SchoolID { get; set; }

        [Required]
        [MaxLength(50)]
        public string SchoolName { get; set; }

        public virtual ICollection<SchoolClass> SchoolClasses { get; set; }
    }
}
