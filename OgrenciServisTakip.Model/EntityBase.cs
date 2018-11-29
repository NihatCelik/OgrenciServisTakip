using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciServisTakip.Model
{
    public abstract class EntityBase
    {
        [Required]
        public int CompanyID { get; set; }
        [ForeignKey("CompanyID")]
        public Company.Company ApplicationCompanyID { get; set; }

        [Required]
        public int BranchID { get; set; }
        [ForeignKey("BranchID")]
        public Company.Branch ApplicationBranchID { get; set; }

        [Required]
        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public Company.User ApplicationUserID { get; set; }

        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool IsActive { get; set; }

        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; }
    }
}
