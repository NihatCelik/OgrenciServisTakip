using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciServisTakip.Model
{
    public abstract class EntityBase
    {
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public bool IsActive { get; set; }

        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; }
    }
}
