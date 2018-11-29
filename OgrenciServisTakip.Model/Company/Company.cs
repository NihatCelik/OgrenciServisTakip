using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciServisTakip.Model.Company
{
    [Table("tblCompany")]
    public class Company
    {
        [Key]
        public int CompanyID { get; set; }

        [Required]
        [MaxLength(5)]
        public string DealerCode { get; set; }

        [Required]
        [MaxLength(50)]
        public string CompanyName { get; set; }

        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool IsActive { get; set; }

        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<Branch> Branches { get; set; }
    }
}
