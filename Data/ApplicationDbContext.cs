using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TicketsLC.Data.Mapeamento;
using TicketsLC.Models;

namespace TicketsLC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Tipo> Tipo { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new TipoMap());
            modelBuilder.ApplyConfiguration(new IdentityUserMap());
            modelBuilder.ApplyConfiguration(new IdentityUserClaimMap());
            modelBuilder.ApplyConfiguration(new IdentityUserLoginMap());
            modelBuilder.ApplyConfiguration(new IdentityUserTokenMap());
            modelBuilder.ApplyConfiguration(new IdentityRoleMap());
            modelBuilder.ApplyConfiguration(new IdentityRoleClaimMap());
            modelBuilder.ApplyConfiguration(new IdentityUserRoleMap());
            modelBuilder.ApplyConfiguration(new TicketMap());

        }

    }
}
