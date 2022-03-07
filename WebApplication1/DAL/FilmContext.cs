using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Models;
namespace WebApplication1.DAL
{
    public class FilmContext: DbContext
    {
        public FilmContext()
        {
            Database.SetInitializer(new initDB());
        }
        public DbSet<Film> Filmler { get; set; }
        public DbSet<FilmKalitesi> FilmKaliteleri { get; set; }
        public DbSet<FilmKare> FilmKareleri { get; set; }
        public DbSet<FilmTuru> FilmTurleri { get; set; }

        

    }
}