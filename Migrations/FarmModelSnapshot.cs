﻿// <auto-generated />
using Farm;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Farm.Migrations
{
    [DbContext(typeof(Farm))]
    partial class FarmModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Farm.Models.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SpeciesId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("SpeciesId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Name = "Shaun",
                            SpeciesId = -1
                        },
                        new
                        {
                            Id = -2,
                            Name = "Timmy",
                            SpeciesId = -1
                        },
                        new
                        {
                            Id = -3,
                            Name = "Peppa",
                            SpeciesId = -2
                        });
                });

            modelBuilder.Entity("Farm.Models.Species", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Species");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Name = "sheep"
                        },
                        new
                        {
                            Id = -2,
                            Name = "pig"
                        });
                });

            modelBuilder.Entity("Farm.Models.Animal", b =>
                {
                    b.HasOne("Farm.Models.Species", "Species")
                        .WithMany("Animals")
                        .HasForeignKey("SpeciesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Species");
                });

            modelBuilder.Entity("Farm.Models.Species", b =>
                {
                    b.Navigation("Animals");
                });
#pragma warning restore 612, 618
        }
    }
}
