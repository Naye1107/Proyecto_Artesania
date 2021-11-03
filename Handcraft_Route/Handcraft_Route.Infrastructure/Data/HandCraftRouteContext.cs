﻿
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Handcraft_RouteApp.Domain.Entities;

#nullable disable
namespace Handcraft_RouteApp.Infrastructure.Data
{
    public partial class HandCraftRouteContext : DbContext
    {
        public HandCraftRouteContext()
        {
        }

        public HandCraftRouteContext(DbContextOptions<HandCraftRouteContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Association> Associations { get; set; }
        public virtual DbSet<Commerce> Commerces { get; set; }
        public virtual DbSet<Craft> Crafts { get; set; }
        public virtual DbSet<CraftTour> CraftTours { get; set; }
        public virtual DbSet<Craftman> Craftmen { get; set; }
        public virtual DbSet<FoodTour> FoodTours { get; set; }
        public virtual DbSet<GeoLocation> GeoLocations { get; set; }
   

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=basedatosweb.mssql.somee.com;Initial Catalog=basedatosweb;User ID=naye123_SQLLogin_2;Password=1uv4yx6brf;Persist Security Info=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasKey(e => e.IdAddress)
                    .HasName("PK_Addreess");

                entity.ToTable("Address");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Number)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Street)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                

                entity.HasOne(d => d.IdCraftmanNavigation)
              
                    .WithOne(p => p.Address)
                    .HasForeignKey<Address>(d => d.IdCraftman)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_Craftman");
            });

            modelBuilder.Entity<Association>(entity =>
            {
                entity.HasKey(e => e.IdAssociation)
                    .HasName("PK__Associat__F3D0E63D61B4FBA6");

                entity.ToTable("Association");

                entity.Property(e => e.IdAssociation).HasColumnName("Id_Association");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Commerce>(entity =>
            {
                entity.HasKey(e => e.IdCommerce)
                    .HasName("PK_Id_commerce");

                entity.Property(e => e.IdCommerce).HasColumnName("Id_commerce");

                entity.Property(e => e.NameCommerce)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Name_Commerce");

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Craft>(entity =>
            {
                entity.ToTable("Craft");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Image)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.NameCraft)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Name_craft");

                
            });

            modelBuilder.Entity<CraftTour>(entity =>
            {
                entity.ToTable("CraftTour");

                entity.Property(e => e.DescriptionCTour)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DescriptionC_Tour");

                entity.Property(e => e.MeetingPoint)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NameCTour)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NameC_Tour");

                entity.HasOne(d => d.MatrialCraftNavigation)
                    .WithMany(p => p.CraftTourMatrialCraftNavigations)
                    .HasForeignKey(d => d.MatrialCraft)
                    .HasConstraintName("Fk_MatrialCraft");

                entity.HasOne(d => d.VisitPoint1Navigation)
                    .WithMany(p => p.CraftTourVisitPoint1Navigations)
                    .HasForeignKey(d => d.VisitPoint1)
                    .HasConstraintName("FK_VisitPoint1");

                entity.HasOne(d => d.VisitPoint3Navigation)
                    .WithMany(p => p.CraftTourVisitPoint3Navigations)
                    .HasForeignKey(d => d.VisitPoint3)
                    .HasConstraintName("Fk_VisitPoint3");

                entity.HasOne(d => d.VisitPoint2Navigation)
                    .WithMany(p => p.CraftTourVisitPoint2Navigations)
                    .HasForeignKey(d => d.VisitPoint2)
                    .HasConstraintName("FK_VisitPoint2");
            });

            modelBuilder.Entity<Craftman>(entity =>
            {
                entity.HasKey(e => e.IdCraftman)
                    .HasName("PK_IdCraftman");

                entity.ToTable("Craftman");


                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Logo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telephone)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.AssociationNavigation)
                    .WithMany(p => p.Craftmen)
                    .HasForeignKey(d => d.Association)
                    .HasConstraintName("FK_Association");

                entity.HasOne(d => d.MunicipalityNavigation)
                    .WithMany(p => p.Craftmen)
                    .HasForeignKey(d => d.Municipality)
                    .HasConstraintName("FK_Municipality");

                entity.HasOne(d => d.SocialNetworksNavigation)
                    .WithMany(p => p.Craftmen)
                    .HasForeignKey(d => d.SocialNetworks)
                    .HasConstraintName("FK_SocialNetworks");
            });

            modelBuilder.Entity<FoodTour>(entity =>
            {
                entity.HasKey(e => e.IdFoodTour)
                    .HasName("PK_IdFoodTour");

                entity.ToTable("FoodTour");

                entity.Property(e => e.IdFoodTour).HasColumnName("Id_FoodTour");

                entity.Property(e => e.DescriptionFTour)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DescriptionF_Tour");

                entity.Property(e => e.FinalPoint)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Image1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Image3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Image2)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MeetingPoint)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MenuDescription)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NameFTour)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NameF_Tour");

                entity.HasOne(d => d.NameComerce1Navigation)
                    .WithMany(p => p.FoodTourNameComerce1Navigations)
                    .HasForeignKey(d => d.NameComerce1)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NameComerce1");

                entity.HasOne(d => d.NameComerce3Navigation)
                    .WithMany(p => p.FoodTourNameComerce3Navigations)
                    .HasForeignKey(d => d.NameComerce3)
                    .HasConstraintName("FK_NameComerce3");

                entity.HasOne(d => d.NameComerce2Navigation)
                    .WithMany(p => p.FoodTourNameComerce2Navigations)
                    .HasForeignKey(d => d.NameComerce2)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NameComerce2");
            });

            modelBuilder.Entity<GeoLocation>(entity =>
            {
                entity.HasKey(e => e.IdGeoLocation);

                entity.ToTable("GeoLocation");

                entity.Property(e => e.Altitude)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

        }