using System;
using System.ComponentModel.DataAnnotations;

namespace OgrenciServisTakip.Model
{
    public class Global : EntityBase
    {
        [Required]
        public int CompanyID { get; set; }

        [Required]
        public int BranchID { get; set; }

        [Required]
        public int UserID { get; set; }
    }
}
