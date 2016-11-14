namespace GiftCard.Repository.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GiftCardEntityContext : DbContext
    {
        public GiftCardEntityContext()
            : base("name=GiftCardEntityContext")
        {
        }

        public virtual DbSet<GiftCard> GiftCards { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GiftCard>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<GiftCard>()
                .Property(e => e.Description)
                .IsUnicode(false);
        }
    }
}
