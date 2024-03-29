﻿// <auto-generated />
using BlazorTickets_Grupp.Data.DataBase.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorTickets.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240222105326_hej")]
    partial class hej
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorTickets_Grupp.Data.DataBase.Models.ResponseModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Response")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubmittedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TicketId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TicketId");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Response = "Response for Ticket 1",
                            SubmittedBy = "User1",
                            TicketId = 1
                        },
                        new
                        {
                            Id = 2,
                            Response = "Response for Ticket 2",
                            SubmittedBy = "User2",
                            TicketId = 2
                        },
                        new
                        {
                            Id = 3,
                            Response = "Response for Ticket 3",
                            SubmittedBy = "User3",
                            TicketId = 3
                        });
                });

            modelBuilder.Entity("BlazorTickets_Grupp.Data.DataBase.Models.TagModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "CSharp"
                        },
                        new
                        {
                            Id = 2,
                            Name = "DotNet"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Blazor"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Java"
                        },
                        new
                        {
                            Id = 5,
                            Name = "JavaScript"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Python"
                        },
                        new
                        {
                            Id = 7,
                            Name = "HTML"
                        },
                        new
                        {
                            Id = 8,
                            Name = "CSS"
                        },
                        new
                        {
                            Id = 9,
                            Name = "SQL"
                        },
                        new
                        {
                            Id = 10,
                            Name = "NoSQL"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Git"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Docker"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Kubernetes"
                        },
                        new
                        {
                            Id = 14,
                            Name = "MachineLearning"
                        },
                        new
                        {
                            Id = 15,
                            Name = "ArtificialIntelligence"
                        },
                        new
                        {
                            Id = 16,
                            Name = "DataScience"
                        },
                        new
                        {
                            Id = 17,
                            Name = "WebDevelopment"
                        },
                        new
                        {
                            Id = 18,
                            Name = "MobileDevelopment"
                        },
                        new
                        {
                            Id = 19,
                            Name = "GameDevelopment"
                        },
                        new
                        {
                            Id = 20,
                            Name = "CloudComputing"
                        },
                        new
                        {
                            Id = 21,
                            Name = "AWS"
                        },
                        new
                        {
                            Id = 22,
                            Name = "BlazorTickets4Azure"
                        },
                        new
                        {
                            Id = 23,
                            Name = "GCP"
                        },
                        new
                        {
                            Id = 24,
                            Name = "DevOps"
                        },
                        new
                        {
                            Id = 25,
                            Name = "CI_CD"
                        },
                        new
                        {
                            Id = 26,
                            Name = "Agile"
                        },
                        new
                        {
                            Id = 27,
                            Name = "Scrum"
                        },
                        new
                        {
                            Id = 28,
                            Name = "Security"
                        },
                        new
                        {
                            Id = 29,
                            Name = "Blockchain"
                        },
                        new
                        {
                            Id = 30,
                            Name = "IoT"
                        },
                        new
                        {
                            Id = 31,
                            Name = "AR_VR"
                        },
                        new
                        {
                            Id = 32,
                            Name = "UI_UX"
                        },
                        new
                        {
                            Id = 33,
                            Name = "Algorithms"
                        },
                        new
                        {
                            Id = 34,
                            Name = "DataStructures"
                        },
                        new
                        {
                            Id = 35,
                            Name = "DesignPatterns"
                        },
                        new
                        {
                            Id = 36,
                            Name = "FunctionalProgramming"
                        },
                        new
                        {
                            Id = 37,
                            Name = "ObjectOrientedProgramming"
                        });
                });

            modelBuilder.Entity("BlazorTickets_Grupp.Data.DataBase.Models.TicketModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsResolved")
                        .HasColumnType("bit");

                    b.Property<string>("SubmittedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Description for Ticket 1",
                            IsResolved = false,
                            SubmittedBy = "User1",
                            Title = "Ticket 1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Description for Ticket 2",
                            IsResolved = false,
                            SubmittedBy = "User2",
                            Title = "Ticket 2"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Description for Ticket 3",
                            IsResolved = false,
                            SubmittedBy = "User3",
                            Title = "Ticket 3"
                        });
                });

            modelBuilder.Entity("BlazorTickets_Grupp.Data.DataBase.Models.TicketTag", b =>
                {
                    b.Property<int>("TicketId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("TicketId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("TicketTags");

                    b.HasData(
                        new
                        {
                            TicketId = 1,
                            TagId = 1
                        });
                });

            modelBuilder.Entity("BlazorTickets_Grupp.Data.DataBase.Models.ResponseModel", b =>
                {
                    b.HasOne("BlazorTickets_Grupp.Data.DataBase.Models.TicketModel", "Ticket")
                        .WithMany("Responses")
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ticket");
                });

            modelBuilder.Entity("BlazorTickets_Grupp.Data.DataBase.Models.TicketTag", b =>
                {
                    b.HasOne("BlazorTickets_Grupp.Data.DataBase.Models.TagModel", "Tag")
                        .WithMany("TicketTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorTickets_Grupp.Data.DataBase.Models.TicketModel", "Ticket")
                        .WithMany("TicketTags")
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tag");

                    b.Navigation("Ticket");
                });

            modelBuilder.Entity("BlazorTickets_Grupp.Data.DataBase.Models.TagModel", b =>
                {
                    b.Navigation("TicketTags");
                });

            modelBuilder.Entity("BlazorTickets_Grupp.Data.DataBase.Models.TicketModel", b =>
                {
                    b.Navigation("Responses");

                    b.Navigation("TicketTags");
                });
#pragma warning restore 612, 618
        }
    }
}
