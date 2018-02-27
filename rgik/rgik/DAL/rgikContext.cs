using Microsoft.AspNet.Identity.EntityFramework;
using rgik.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace rgik.DAL
{
    /// <summary>
    /// With IdentityDbContext we will add every tables neccesary for users that is login,registers,roles etc.
    /// </summary>
    public class rgikContext : IdentityDbContext<ApplicationUser>
    {
        public rgikContext() : base("rgikContext")
        {

        }
        
        static rgikContext()
        {
            Database.SetInitializer<rgikContext>(new rgikInitializer());
        }

        public static rgikContext Create()
        {
            return new rgikContext();
        }

        public DbSet<Gra> Gra { get; set; }
        public DbSet<Ksiazka> Ksiazka { get; set; }
        public DbSet<Gatunek> Gatunek { get; set; }
        public DbSet<Platforma> Platforma { get; set; }
        public DbSet<PublikacjaGry> PublikacjaGry { get; set; }
        public DbSet<PublikacjaKsiazki> PublikacjaKsiazki { get; set; }

        // DO NOT ADD s AT THE END OF TABLE NAME!!
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        
    }
}