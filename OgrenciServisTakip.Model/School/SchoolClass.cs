using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciServisTakip.Model.School
{
    [Table("tblSchoolClass")]
    public class SchoolClass : EntityBase
    {
        [Key]
        public int SchoolClassID { get; set; }

        public int SchoolID { get; set; }

        [Required]
        [MaxLength(15)]
        public string ClassName { get; set; }
    }
}
