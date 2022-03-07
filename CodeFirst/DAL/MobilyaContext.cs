using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using CodeFirst.Models;

namespace CodeFirst.DAL
{
    public class MobilyaContext: DbContext
    {
        public MobilyaContext()
        {
            Database.SetInitializer(new initDB());
        }
        public DbSet<Mobilya> Mobilyalar { get; set; }
        public DbSet<Hammadde> Hammaddeler { get; set; }
        public DbSet<MobilyaTuru> MobilyaTurleri { get; set; }

    }
}