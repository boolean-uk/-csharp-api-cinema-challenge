﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using api_cinema_challenge.Data;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    [DbContext(typeof(CinemaContext))]
    partial class CinemaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("api_cinema_challenge.Models.Customers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("phone");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("customers");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(3390),
                            Email = "johndoe@example.com",
                            Name = "John Doe",
                            Phone = "555-1234",
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(3393)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(3858),
                            Email = "janesmith@example.com",
                            Name = "Jane Smith",
                            Phone = "555-5678",
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(3860)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(3863),
                            Email = "michaelj@example.com",
                            Name = "Michael Johnson",
                            Phone = "555-9876",
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(3864)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(3867),
                            Email = "emilyd@example.com",
                            Name = "Emily Davis",
                            Phone = "555-4321",
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(3869)
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(3872),
                            Email = "chriswilliams@example.com",
                            Name = "Chris Williams",
                            Phone = "555-8765",
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(3873)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Movies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("rating");

                    b.Property<int>("RuntimeMins")
                        .HasColumnType("integer")
                        .HasColumnName("runetime_mins");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("movies");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 381, DateTimeKind.Utc).AddTicks(4045),
                            Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                            Rating = "R",
                            RuntimeMins = 142,
                            Title = "The Shawshank Redemption",
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(1236)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(2945),
                            Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
                            Rating = "R",
                            RuntimeMins = 175,
                            Title = "The Godfather",
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(2952)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(2956),
                            Description = "When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.",
                            Rating = "PG-13",
                            RuntimeMins = 152,
                            Title = "The Dark Knight",
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(2958)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(2960),
                            Description = "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an extraordinary, though simple, life.",
                            Rating = "PG-13",
                            RuntimeMins = 142,
                            Title = "Forrest Gump",
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(2962)
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(2965),
                            Description = "A thief who enters the dreams of others to steal secrets from their subconscious is given the inverse task of planting an idea into the mind of a CEO.",
                            Rating = "PG-13",
                            RuntimeMins = 148,
                            Title = "Inception",
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(2967)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screenings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("integer")
                        .HasColumnName("capacity");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<int>("MovieId")
                        .HasColumnType("integer")
                        .HasColumnName("movie_id");

                    b.Property<int>("ScreenNumber")
                        .HasColumnType("integer")
                        .HasColumnName("screen_number");

                    b.Property<DateTime>("StartsAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("starts_at");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("screenings");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(4616),
                            MovieId = 1,
                            ScreenNumber = 1,
                            StartsAt = new DateTime(2025, 1, 28, 21, 23, 39, 384, DateTimeKind.Utc).AddTicks(4971),
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(4620)
                        },
                        new
                        {
                            Id = 3,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5085),
                            MovieId = 1,
                            ScreenNumber = 1,
                            StartsAt = new DateTime(2025, 1, 28, 22, 23, 39, 384, DateTimeKind.Utc).AddTicks(5090),
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5087)
                        },
                        new
                        {
                            Id = 4,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5093),
                            MovieId = 1,
                            ScreenNumber = 1,
                            StartsAt = new DateTime(2025, 1, 28, 23, 23, 39, 384, DateTimeKind.Utc).AddTicks(5121),
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5095)
                        },
                        new
                        {
                            Id = 5,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5124),
                            MovieId = 1,
                            ScreenNumber = 1,
                            StartsAt = new DateTime(2025, 1, 29, 0, 23, 39, 384, DateTimeKind.Utc).AddTicks(5128),
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5126)
                        },
                        new
                        {
                            Id = 6,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5130),
                            MovieId = 2,
                            ScreenNumber = 1,
                            StartsAt = new DateTime(2025, 1, 29, 1, 23, 39, 384, DateTimeKind.Utc).AddTicks(5136),
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5132)
                        },
                        new
                        {
                            Id = 7,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5140),
                            MovieId = 2,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2025, 1, 28, 21, 23, 39, 384, DateTimeKind.Utc).AddTicks(5144),
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5142)
                        },
                        new
                        {
                            Id = 8,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5147),
                            MovieId = 2,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2025, 1, 28, 22, 23, 39, 384, DateTimeKind.Utc).AddTicks(5151),
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5148)
                        },
                        new
                        {
                            Id = 9,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5153),
                            MovieId = 2,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2025, 1, 28, 23, 23, 39, 384, DateTimeKind.Utc).AddTicks(5157),
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5155)
                        },
                        new
                        {
                            Id = 10,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5160),
                            MovieId = 2,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2025, 1, 29, 0, 23, 39, 384, DateTimeKind.Utc).AddTicks(5164),
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5161)
                        },
                        new
                        {
                            Id = 11,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5166),
                            MovieId = 2,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2025, 1, 29, 1, 23, 39, 384, DateTimeKind.Utc).AddTicks(5170),
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5168)
                        },
                        new
                        {
                            Id = 12,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5172),
                            MovieId = 3,
                            ScreenNumber = 3,
                            StartsAt = new DateTime(2025, 1, 28, 21, 23, 39, 384, DateTimeKind.Utc).AddTicks(5176),
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5174)
                        },
                        new
                        {
                            Id = 13,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5179),
                            MovieId = 3,
                            ScreenNumber = 3,
                            StartsAt = new DateTime(2025, 1, 28, 22, 23, 39, 384, DateTimeKind.Utc).AddTicks(5183),
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5180)
                        },
                        new
                        {
                            Id = 14,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5189),
                            MovieId = 3,
                            ScreenNumber = 3,
                            StartsAt = new DateTime(2025, 1, 28, 23, 23, 39, 384, DateTimeKind.Utc).AddTicks(5193),
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5191)
                        },
                        new
                        {
                            Id = 15,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5195),
                            MovieId = 3,
                            ScreenNumber = 3,
                            StartsAt = new DateTime(2025, 1, 29, 0, 23, 39, 384, DateTimeKind.Utc).AddTicks(5199),
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5197)
                        },
                        new
                        {
                            Id = 16,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5202),
                            MovieId = 3,
                            ScreenNumber = 3,
                            StartsAt = new DateTime(2025, 1, 29, 1, 23, 39, 384, DateTimeKind.Utc).AddTicks(5206),
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5204)
                        },
                        new
                        {
                            Id = 17,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5208),
                            MovieId = 1,
                            ScreenNumber = 1,
                            StartsAt = new DateTime(2025, 1, 29, 2, 23, 39, 384, DateTimeKind.Utc).AddTicks(5227),
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5210)
                        },
                        new
                        {
                            Id = 18,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5230),
                            MovieId = 1,
                            ScreenNumber = 1,
                            StartsAt = new DateTime(2025, 1, 29, 3, 23, 39, 384, DateTimeKind.Utc).AddTicks(5234),
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5231)
                        },
                        new
                        {
                            Id = 19,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5236),
                            MovieId = 1,
                            ScreenNumber = 1,
                            StartsAt = new DateTime(2025, 1, 29, 4, 23, 39, 384, DateTimeKind.Utc).AddTicks(5240),
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5238)
                        },
                        new
                        {
                            Id = 20,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5242),
                            MovieId = 1,
                            ScreenNumber = 1,
                            StartsAt = new DateTime(2025, 1, 29, 5, 23, 39, 384, DateTimeKind.Utc).AddTicks(5246),
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5244)
                        },
                        new
                        {
                            Id = 21,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5249),
                            MovieId = 2,
                            ScreenNumber = 1,
                            StartsAt = new DateTime(2025, 1, 29, 6, 23, 39, 384, DateTimeKind.Utc).AddTicks(5253),
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5250)
                        },
                        new
                        {
                            Id = 22,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5255),
                            MovieId = 2,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2025, 1, 29, 2, 23, 39, 384, DateTimeKind.Utc).AddTicks(5259),
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5257)
                        },
                        new
                        {
                            Id = 23,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5261),
                            MovieId = 2,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2025, 1, 29, 3, 23, 39, 384, DateTimeKind.Utc).AddTicks(5265),
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5263)
                        },
                        new
                        {
                            Id = 24,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5267),
                            MovieId = 2,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2025, 1, 29, 4, 23, 39, 384, DateTimeKind.Utc).AddTicks(5271),
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5269)
                        },
                        new
                        {
                            Id = 25,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5274),
                            MovieId = 2,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2025, 1, 29, 5, 23, 39, 384, DateTimeKind.Utc).AddTicks(5277),
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5275)
                        },
                        new
                        {
                            Id = 26,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5280),
                            MovieId = 2,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2025, 1, 29, 6, 23, 39, 384, DateTimeKind.Utc).AddTicks(5284),
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5281)
                        },
                        new
                        {
                            Id = 27,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5286),
                            MovieId = 3,
                            ScreenNumber = 3,
                            StartsAt = new DateTime(2025, 1, 29, 2, 23, 39, 384, DateTimeKind.Utc).AddTicks(5290),
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5288)
                        },
                        new
                        {
                            Id = 28,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5292),
                            MovieId = 3,
                            ScreenNumber = 3,
                            StartsAt = new DateTime(2025, 1, 29, 3, 23, 39, 384, DateTimeKind.Utc).AddTicks(5296),
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5294)
                        },
                        new
                        {
                            Id = 29,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5298),
                            MovieId = 3,
                            ScreenNumber = 3,
                            StartsAt = new DateTime(2025, 1, 29, 4, 23, 39, 384, DateTimeKind.Utc).AddTicks(5302),
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5300)
                        },
                        new
                        {
                            Id = 30,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5304),
                            MovieId = 3,
                            ScreenNumber = 3,
                            StartsAt = new DateTime(2025, 1, 29, 5, 23, 39, 384, DateTimeKind.Utc).AddTicks(5308),
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5306)
                        },
                        new
                        {
                            Id = 31,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5311),
                            MovieId = 3,
                            ScreenNumber = 3,
                            StartsAt = new DateTime(2025, 1, 29, 6, 23, 39, 384, DateTimeKind.Utc).AddTicks(5317),
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(5312)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Tickets", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer")
                        .HasColumnName("customer_id");

                    b.Property<int>("NumSeats")
                        .HasColumnType("integer")
                        .HasColumnName("num_seats");

                    b.Property<int>("ScreeningId")
                        .HasColumnType("integer")
                        .HasColumnName("screening_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("tickets");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(6745),
                            CustomerId = 0,
                            NumSeats = 4,
                            ScreeningId = 1,
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(6751)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(7010),
                            CustomerId = 0,
                            NumSeats = 2,
                            ScreeningId = 2,
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(7012)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(7015),
                            CustomerId = 0,
                            NumSeats = 4,
                            ScreeningId = 2,
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(7017)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(7019),
                            CustomerId = 0,
                            NumSeats = 1,
                            ScreeningId = 3,
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(7021)
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(7024),
                            CustomerId = 0,
                            NumSeats = 1,
                            ScreeningId = 3,
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(7026)
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(7028),
                            CustomerId = 0,
                            NumSeats = 1,
                            ScreeningId = 3,
                            UpdatedAt = new DateTime(2025, 1, 28, 20, 23, 39, 384, DateTimeKind.Utc).AddTicks(7030)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
