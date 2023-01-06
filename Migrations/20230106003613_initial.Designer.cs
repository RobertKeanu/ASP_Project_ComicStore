﻿// <auto-generated />
using System;
using ASP_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASPProject.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20230106003613_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ASP_Project.Models.Buy", b =>
                {
                    b.Property<Guid>("MagazineID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PersonID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BuyDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("NumberOfUnitsSold")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MagazineID", "PersonID");

                    b.HasIndex("PersonID");

                    b.ToTable("Buys");
                });

            modelBuilder.Entity("ASP_Project.Models.ComicStore", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ComicStoreID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ComicStoreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("LocationID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("LocationID")
                        .IsUnique();

                    b.ToTable("ComicStore");
                });

            modelBuilder.Entity("ASP_Project.Models.Comics", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BuyMagazineID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("BuyPersonID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ComicID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ComicStoreID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ComicsDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComicsName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ComicsPrice")
                        .HasColumnType("int");

                    b.Property<string>("ComicsType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ComicStoreID");

                    b.HasIndex("BuyMagazineID", "BuyPersonID");

                    b.ToTable("Comics");
                });

            modelBuilder.Entity("ASP_Project.Models.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumberStore")
                        .HasColumnType("int");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("ASP_Project.Models.Rent", b =>
                {
                    b.Property<Guid>("MagazineID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PersonID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("DateEnd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("DateStart")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("PricePerDay")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MagazineID", "PersonID");

                    b.HasIndex("PersonID");

                    b.ToTable("Rent");
                });

            modelBuilder.Entity("ASP_Project.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("DateOfBirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Preferences")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ASP_Project.Models.Buy", b =>
                {
                    b.HasOne("ASP_Project.Models.Comics", "Comic")
                        .WithMany("Buys")
                        .HasForeignKey("MagazineID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASP_Project.Models.User", "NewUser")
                        .WithMany("Buys")
                        .HasForeignKey("PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comic");

                    b.Navigation("NewUser");
                });

            modelBuilder.Entity("ASP_Project.Models.ComicStore", b =>
                {
                    b.HasOne("ASP_Project.Models.Location", "Location")
                        .WithOne("ComicStore")
                        .HasForeignKey("ASP_Project.Models.ComicStore", "LocationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("ASP_Project.Models.Comics", b =>
                {
                    b.HasOne("ASP_Project.Models.ComicStore", "ComicStore")
                        .WithMany("Comics")
                        .HasForeignKey("ComicStoreID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASP_Project.Models.Buy", null)
                        .WithMany("Comics")
                        .HasForeignKey("BuyMagazineID", "BuyPersonID");

                    b.Navigation("ComicStore");
                });

            modelBuilder.Entity("ASP_Project.Models.Rent", b =>
                {
                    b.HasOne("ASP_Project.Models.Comics", "Comic")
                        .WithMany("Rents")
                        .HasForeignKey("MagazineID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ASP_Project.Models.User", "NewUser")
                        .WithMany("Rents")
                        .HasForeignKey("PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comic");

                    b.Navigation("NewUser");
                });

            modelBuilder.Entity("ASP_Project.Models.Buy", b =>
                {
                    b.Navigation("Comics");
                });

            modelBuilder.Entity("ASP_Project.Models.ComicStore", b =>
                {
                    b.Navigation("Comics");
                });

            modelBuilder.Entity("ASP_Project.Models.Comics", b =>
                {
                    b.Navigation("Buys");

                    b.Navigation("Rents");
                });

            modelBuilder.Entity("ASP_Project.Models.Location", b =>
                {
                    b.Navigation("ComicStore")
                        .IsRequired();
                });

            modelBuilder.Entity("ASP_Project.Models.User", b =>
                {
                    b.Navigation("Buys");

                    b.Navigation("Rents");
                });
#pragma warning restore 612, 618
        }
    }
}
