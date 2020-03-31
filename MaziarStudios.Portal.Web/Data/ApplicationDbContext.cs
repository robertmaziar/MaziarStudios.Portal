using System;
using System.Collections.Generic;
using System.Text;
using MaziarStudios.Portal.Web.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MaziarStudios.Portal.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<EventArtist>()
                .HasKey(ea => new { ea.EventId, ea.ArtistId });
            modelBuilder.Entity<EventArtist>()
                .HasOne(ea => ea.Event)
                .WithMany(e => e.EventArtists)
                .HasForeignKey(ea => ea.EventId);
            modelBuilder.Entity<EventArtist>()
                .HasOne(ea => ea.Artist)
                .WithMany(a => a.EventArtists)
                .HasForeignKey(ea => ea.ArtistId);
        }

        public virtual DbSet<Event> Event { get; set; }
    }
}
