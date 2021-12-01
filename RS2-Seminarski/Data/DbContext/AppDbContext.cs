using Data.EntityModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.DbContext
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<DetaljiPlana> DetaljiPlana { get; set; }
        public DbSet<GodisnjiPlan> GodisnjiPlan { get; set; }
        public DbSet<Grad> Grad { get; set; }
        public DbSet<Izvještaj> Izvještaj { get; set; }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<KorisniLink> KorisniLink { get; set; }
        public DbSet<Najava> Najava { get; set; }
        public DbSet<Obavijest> Obavijest { get; set; }
        public DbSet<Sekcija> Sekcija { get; set; }
        public DbSet<Skola> Skola { get; set; }
        public DbSet<Spol> Spol { get; set; }
        public DbSet<TipSkole> TipSkole { get; set; }
        public DbSet<Ucenici> Ucenici { get; set; }
        public DbSet<Uplata> Uplata { get; set; }
        public DbSet<Volonter> Volonter { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Mjesec> Mjesec { get; set; }
        public DbSet<Stanje> Stanje { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        }
}
