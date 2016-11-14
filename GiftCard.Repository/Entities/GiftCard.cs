namespace GiftCard.Repository.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GiftCard
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string UserName { get; set; }

        [StringLength(255)]
        public string Description { get; set; }
    }
}
