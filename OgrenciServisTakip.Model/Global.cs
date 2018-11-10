using System;
using System.ComponentModel.DataAnnotations;

namespace OgrenciServisTakip.Model
{
    public class Global
    {
        [Required]
        public int CompanyID { get; set; }

        [Required]
        public int BranchID { get; set; }

        [Required]
        public int UserID { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public DateTime RecordDate { get; set; }
    }
}
