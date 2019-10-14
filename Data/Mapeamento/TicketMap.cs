using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketsLC.Models;

namespace TicketsLC.Data.Mapeamento
{
    public class TicketMap : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
         
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Titulo).IsRequired().HasMaxLength(50);
            builder.Property(b => b.Menssage).IsRequired().HasMaxLength(500);
            builder.ToTable("Tickets");
        }
    }
}
