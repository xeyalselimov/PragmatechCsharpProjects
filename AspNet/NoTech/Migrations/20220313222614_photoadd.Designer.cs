﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NoTech.Models;

namespace NoTech.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20220313222614_photoadd")]
    partial class photoadd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("NoTech.Models.About", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Image1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("List")
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("Subheading")
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("Text")
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Title")
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.HasKey("ID");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("NoTech.Models.Blog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Title")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("byFrom")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("ID");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("NoTech.Models.Counter", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Odometer")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Text")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Title")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("ID");

                    b.ToTable("Counters");
                });

            modelBuilder.Entity("NoTech.Models.Feature", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("ID");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("NoTech.Models.Helping", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Helpings");
                });

            modelBuilder.Entity("NoTech.Models.Home", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title1")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Title2")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("VideoLink")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Homes");
                });

            modelBuilder.Entity("NoTech.Models.Layout", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<string>("Question")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SocialIcon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SocialLink")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Layouts");
                });

            modelBuilder.Entity("NoTech.Models.ProjectAbout", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("BoxText")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("List1")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("List2")
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("Text")
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Title")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("ProjectAbouts");
                });

            modelBuilder.Entity("NoTech.Models.ProjectBox", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("BoxTitle")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name1")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Name2")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("TopTitle")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ID");

                    b.ToTable("ProjectBoxes");
                });

            modelBuilder.Entity("NoTech.Models.ServicesBox", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text1")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Text2")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Title1")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Title2")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ID");

                    b.ToTable("ServicesBoxes");
                });

            modelBuilder.Entity("NoTech.Models.ServicesTitle", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubTitle1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubTitle2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("ServicesTitles");
                });

            modelBuilder.Entity("NoTech.Models.Testimonials", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Company")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Text")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("ID");

                    b.ToTable("Testimonials");
                });
#pragma warning restore 612, 618
        }
    }
}
