using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public bool IsActive { get; set; } = false;

        public DateTime RecordDate { get; set; } = DateTime.Now;

        public virtual ICollection<User> Users { get; set; }
    }
}
