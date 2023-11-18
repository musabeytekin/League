﻿// <auto-generated />
using AdessoWorldLeague.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AdessoWorldLeague.API.Migrations
{
    [DbContext(typeof(LeagueContext))]
    partial class LeagueContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AdessoWorldLeague.API.Models.DrawResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DrawnBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DrawResults", (string)null);
                });

            modelBuilder.Entity("AdessoWorldLeague.API.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("teams", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Country = "Turkiye",
                            Name = "Adesso Istanbul"
                        },
                        new
                        {
                            Id = 2,
                            Country = "Turkiye",
                            Name = "Adesso Ankara"
                        },
                        new
                        {
                            Id = 3,
                            Country = "Turkiye",
                            Name = "Adesso Izmir"
                        },
                        new
                        {
                            Id = 4,
                            Country = "Turkiye",
                            Name = "Adesso Antalya"
                        },
                        new
                        {
                            Id = 5,
                            Country = "Almanya",
                            Name = "Adesso Berlin"
                        },
                        new
                        {
                            Id = 6,
                            Country = "Almanya",
                            Name = "Adesso Frankfurt"
                        },
                        new
                        {
                            Id = 7,
                            Country = "Almanya",
                            Name = "Adesso Munih"
                        },
                        new
                        {
                            Id = 8,
                            Country = "Almanya",
                            Name = "Adesso Dortmund"
                        },
                        new
                        {
                            Id = 9,
                            Country = "Fransa",
                            Name = "Adesso Paris"
                        },
                        new
                        {
                            Id = 10,
                            Country = "Fransa",
                            Name = "Adesso Marsilya"
                        },
                        new
                        {
                            Id = 11,
                            Country = "Fransa",
                            Name = "Adesso Lyon"
                        },
                        new
                        {
                            Id = 12,
                            Country = "Fransa",
                            Name = "Adesso Nice"
                        },
                        new
                        {
                            Id = 13,
                            Country = "Hollanda",
                            Name = "Adesso Amsterdam"
                        },
                        new
                        {
                            Id = 14,
                            Country = "Hollanda",
                            Name = "Adesso Rotterdam"
                        },
                        new
                        {
                            Id = 15,
                            Country = "Hollanda",
                            Name = "Adesso Lahey"
                        },
                        new
                        {
                            Id = 16,
                            Country = "Hollanda",
                            Name = "Adesso Eindhoven"
                        },
                        new
                        {
                            Id = 17,
                            Country = "Portekiz",
                            Name = "Adesso Lisbon"
                        },
                        new
                        {
                            Id = 18,
                            Country = "Portekiz",
                            Name = "Adesso Porto"
                        },
                        new
                        {
                            Id = 19,
                            Country = "Portekiz",
                            Name = "Adesso Braga"
                        },
                        new
                        {
                            Id = 20,
                            Country = "Portekiz",
                            Name = "Adesso Coimbra"
                        },
                        new
                        {
                            Id = 21,
                            Country = "Italya",
                            Name = "Adesso Roma"
                        },
                        new
                        {
                            Id = 22,
                            Country = "Italya",
                            Name = "Adesso Milano"
                        },
                        new
                        {
                            Id = 23,
                            Country = "Italya",
                            Name = "Adesso Venedik"
                        },
                        new
                        {
                            Id = 24,
                            Country = "Italya",
                            Name = "Adesso Napoli"
                        },
                        new
                        {
                            Id = 25,
                            Country = "Ispanya",
                            Name = "Adesso Madrid"
                        },
                        new
                        {
                            Id = 26,
                            Country = "Ispanya",
                            Name = "Adesso Barselona"
                        },
                        new
                        {
                            Id = 27,
                            Country = "Ispanya",
                            Name = "Adesso Sevilla"
                        },
                        new
                        {
                            Id = 28,
                            Country = "Ispanya",
                            Name = "Adesso Granada"
                        },
                        new
                        {
                            Id = 29,
                            Country = "Belcika",
                            Name = "Adesso Bruksel"
                        },
                        new
                        {
                            Id = 30,
                            Country = "Belcika",
                            Name = "Adesso Brugge"
                        },
                        new
                        {
                            Id = 31,
                            Country = "Belcika",
                            Name = "Adesso Gent"
                        },
                        new
                        {
                            Id = 32,
                            Country = "Belcika",
                            Name = "Adesso Anvers"
                        });
                });

            modelBuilder.Entity("AdessoWorldLeague.API.Models.DrawResult", b =>
                {
                    b.OwnsMany("AdessoWorldLeague.API.Models.TeamResult", "Groups", b1 =>
                        {
                            b1.Property<int>("DrawResultId")
                                .HasColumnType("int");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<int>("Id"));

                            b1.Property<string>("GroupName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("DrawResultId", "Id");

                            b1.ToTable("TeamResults");

                            b1.WithOwner()
                                .HasForeignKey("DrawResultId");
                        });

                    b.Navigation("Groups");
                });
#pragma warning restore 612, 618
        }
    }
}
