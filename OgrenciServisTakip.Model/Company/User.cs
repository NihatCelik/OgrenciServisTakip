using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciServisTakip.Model.Company
{
    [Table("tblUser")]
    public class User
    {
        [Key]
        public int UserID { get; set; }

        public int BranchID { get; set; }

        [Required]
        public int CompanyID { get; set; }
        [ForeignKey("CompanyID")]
        public Company ApplicationCompanyID { get; set; }

        [Required]
        [MaxLength(20)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(15)]
        public string Password { get; set; }

        [Required]
        [MaxLength(15)]
        public string Name { get; set; }

        [MaxLength(15)]
        public string Surname { get; set; }

        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool IsActive { get; set; }

        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; }
    }
}
