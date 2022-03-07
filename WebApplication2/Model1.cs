using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebApplication2
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Ders> Ders { get; set; }
        public virtual DbSet<Hoca> Hoca { get; set; }
        public virtual DbSet<HocaDers> HocaDers { get; set; }
        public virtual DbSet<OgrDers> OgrDers { get; set; }
        public virtual DbSet<Ogrenci> Ogrenci { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ders>()
                .Property(e => e.DersAdi)
                .IsUnicode(false);

            modelBuilder.Entity<Hoca>()
                .Property(e => e.HocaNo)
                .IsUnicode(false);

            modelBuilder.Entity<Hoca>()
                .Property(e => e.HocaAd)
                .IsUnicode(false);

            modelBuilder.Entity<Hoca>()
                .Property(e => e.HocaSoyad)
                .IsUnicode(false);

            modelBuilder.Entity<OgrDers>()
                .Property(e => e.Vize)
                .HasPrecision(5, 2);

            modelBuilder.Entity<OgrDers>()
                .Property(e => e.Final)
                .HasPrecision(5, 2);

            modelBuilder.Entity<OgrDers>()
                .Property(e => e.Ortalama)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Ogrenci>()
                .Property(e => e.OgrNo)
                .IsUnicode(false);

            modelBuilder.Entity<Ogrenci>()
                .Property(e => e.OgrAd)
                .IsUnicode(false);

            modelBuilder.Entity<Ogrenci>()
                .Property(e => e.OgrSoyad)
                .IsUnicode(false);
        }
    }
}
