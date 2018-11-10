using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public bool IsActive { get; set; } = false;

        public DateTime RecordDate { get; set; } = DateTime.Now;

        public virtual ICollection<Branch> Branches { get; set; }
    }
}
