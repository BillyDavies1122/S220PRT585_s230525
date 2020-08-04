﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using theatreMovie.Models;

namespace theatreMovie.Migrations
{
    [DbContext(typeof(theatreMovieContext))]
    [Migration("20200804134949_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("theatreMovie.Models.Catagory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CatagoryId");

                    b.Property<string>("Code");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CatagoryId");

                    b.ToTable("Catagory");
                });

            modelBuilder.Entity("theatreMovie.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CatagoryId");

                    b.Property<string>("Director");

                    b.Property<string>("Email");

                    b.Property<int>("Language");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("CatagoryId");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("theatreMovie.Models.Catagory", b =>
                {
                    b.HasOne("theatreMovie.Models.Catagory")
                        .WithMany("Catagories")
                        .HasForeignKey("CatagoryId");
                });

            modelBuilder.Entity("theatreMovie.Models.Movie", b =>
                {
                    b.HasOne("theatreMovie.Models.Catagory", "Catagory")
                        .WithMany()
                        .HasForeignKey("CatagoryId");
                });
#pragma warning restore 612, 618
        }
    }
}
