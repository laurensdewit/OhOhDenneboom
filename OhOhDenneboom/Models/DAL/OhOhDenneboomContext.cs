using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using OhOhDenneboom.Models.DAL.Mapper;

namespace OhOhDenneboom.Models.DAL
{
    public class OhOhDenneboomContext : DbContext
    {
        public OhOhDenneboomContext() : base ("OhOhDenneboom")
        {
            
        }

        public DbSet<Boom> Bomen { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BoomMap());
        }
    }
}