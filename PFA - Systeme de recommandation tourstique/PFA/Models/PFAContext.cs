using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PFA.Models
{
    public partial class PFAContext : DbContext
    {
        public PFAContext(DbContextOptions<PFAContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Activities> Activities { get; set; }
        public virtual DbSet<Hotels> Hotels { get; set; }
        public virtual DbSet<LocationVacance> LocationVacance { get; set; }
        public virtual DbSet<Restaurants> Restaurants { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=prox;Initial Catalog=PFA;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activities>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActiviteTypes)
                    .HasColumnName("Activite_types")
                    .IsUnicode(false);

                entity.Property(e => e.Adresse).IsUnicode(false);

                entity.Property(e => e.Avis).HasColumnName("avis");

                entity.Property(e => e.ClassementIntype).HasColumnName("classement_Intype");

                entity.Property(e => e.Descriptions)
                    .HasColumnName("descriptions")
                    .IsUnicode(false);

                entity.Property(e => e.Fermeture)
                    .HasColumnName("fermeture")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Img)
                    .HasColumnName("img")
                    .IsUnicode(false);

                entity.Property(e => e.ImgInteret)
                    .HasColumnName("imgInteret")
                    .IsUnicode(false);

                entity.Property(e => e.Nom)
                    .HasColumnName("nom")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Overture)
                    .HasColumnName("overture")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PlusInfo)
                    .HasColumnName("plus_info")
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Hotels>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Adresse).IsUnicode(false);

                entity.Property(e => e.Avis).HasColumnName("avis");

                entity.Property(e => e.Classement).HasColumnName("classement");

                entity.Property(e => e.DescAFaire)
                    .HasColumnName("Desc_a_faire")
                    .IsUnicode(false);

                entity.Property(e => e.DescEquipementschambre)
                    .HasColumnName("Desc_Equipementschambre")
                    .IsUnicode(false);

                entity.Property(e => e.DescFourchetteDePrix)
                    .HasColumnName("Desc_fourchette_de_prix")
                    .IsUnicode(false);

                entity.Property(e => e.DescMeilleursServices)
                    .HasColumnName("Desc_Meilleurs_Services")
                    .IsUnicode(false);

                entity.Property(e => e.DescNbrEtoils).HasColumnName("Desc_nbr_etoils");

                entity.Property(e => e.Hotel)
                    .HasColumnName("hotel")
                    .IsUnicode(false);

                entity.Property(e => e.Img)
                    .HasColumnName("img")
                    .IsUnicode(false);

                entity.Property(e => e.LienRes)
                    .HasColumnName("lien_res")
                    .IsUnicode(false);

                entity.Property(e => e.Prix).HasColumnName("prix");

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LocationVacance>(entity =>
            {
                entity.ToTable("locationVacance");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Couchage).HasColumnName("couchage");

                entity.Property(e => e.Img)
                    .HasColumnName("img")
                    .IsUnicode(false);

                entity.Property(e => e.LienRes)
                    .HasColumnName("lien_res")
                    .IsUnicode(false);

                entity.Property(e => e.Lv)
                    .HasColumnName("LV")
                    .IsUnicode(false);

                entity.Property(e => e.LvServices)
                    .HasColumnName("LV_Services")
                    .IsUnicode(false);

                entity.Property(e => e.NbrChambres).HasColumnName("nbr_Chambres");

                entity.Property(e => e.Prix).HasColumnName("prix");

                entity.Property(e => e.SallesDeBains).HasColumnName("Salles_de_bains");
            });

            modelBuilder.Entity<Restaurants>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Adresse).IsUnicode(false);

                entity.Property(e => e.Classement).HasColumnName("classement");

                entity.Property(e => e.Conselle).IsUnicode(false);

                entity.Property(e => e.Desccriptions).IsUnicode(false);

                entity.Property(e => e.Img)
                    .HasColumnName("img")
                    .IsUnicode(false);

                entity.Property(e => e.InfoPlus)
                    .HasColumnName("infoPlus")
                    .IsUnicode(false);

                entity.Property(e => e.Repas).IsUnicode(false);

                entity.Property(e => e.ResEtab)
                    .HasColumnName("res_etab")
                    .IsUnicode(false);

                entity.Property(e => e.ServicesRestau).IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .IsUnicode(false);
            });
        }
    }
}
