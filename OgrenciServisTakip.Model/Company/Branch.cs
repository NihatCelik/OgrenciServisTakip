using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciServisTakip.Model.Company
{
    [Table("tblBranch")]
    public class Branch
    {
        [Key]
        public int BranchID { get; set; }

        [Required]
        public int CompanyID { get; set; }

        [Required]
        [MaxLength(25)]
        public string BranchName { get; set; }

        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool IsActive { get; set; }

        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
