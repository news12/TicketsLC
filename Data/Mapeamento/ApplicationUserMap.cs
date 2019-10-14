using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketsLC.Models;

namespace TicketsLC.Data.Mapeamento
{
    public class ApplicationUserMap : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.Property(b => b.Nome).HasMaxLength(200);
            builder.Property(b => b.Sobrenome).HasMaxLength(200);
            builder.Property(b => b.Empresa).HasMaxLength(100);
            builder.ToTable("Users");
        }
    }
}
