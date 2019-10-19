using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketsLC.Models;

namespace TicketsLC.Data.Mapeamento
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {

        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            
            builder.ToTable("Categoria");
        }

       
    }
}
