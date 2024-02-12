﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using api_cinema_challenge.Data;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    [DbContext(typeof(CinemaContext))]
    [Migration("20240212114521_firstMigration")]
    partial class firstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("api_cinema_challenge.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("createdAt");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("phone");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("customer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4468),
                            Email = "Jimi Obama@gov.ru",
                            Name = "Jimi Obama",
                            PhoneNumber = "59943377",
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4468)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4470),
                            Email = "Barack Trump@something.com",
                            Name = "Barack Trump",
                            PhoneNumber = "67137459",
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4471)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4472),
                            Email = "Barack Jagger@theworld.ca",
                            Name = "Barack Jagger",
                            PhoneNumber = "31878797",
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4473)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4474),
                            Email = "Jimi Middleton@gov.nl",
                            Name = "Jimi Middleton",
                            PhoneNumber = "31878797",
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4474)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4475),
                            Email = "Kate Hepburn@gov.us",
                            Name = "Kate Hepburn",
                            PhoneNumber = "20778913",
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4476)
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4477),
                            Email = "Jimi Jagger@nasa.org.us",
                            Name = "Jimi Jagger",
                            PhoneNumber = "61428868",
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4478)
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4479),
                            Email = "Charles Hendrix@nasa.org.us",
                            Name = "Charles Hendrix",
                            PhoneNumber = "31878797",
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4479)
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4480),
                            Email = "Elvis Obama@gov.us",
                            Name = "Elvis Obama",
                            PhoneNumber = "67137459",
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4481)
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4482),
                            Email = "Kate Presley@something.com",
                            Name = "Kate Presley",
                            PhoneNumber = "31878797",
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4482)
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4483),
                            Email = "Mick Trump@something.com",
                            Name = "Mick Trump",
                            PhoneNumber = "59943377",
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4484)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("createdAt");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("rating");

                    b.Property<int>("Runtime")
                        .HasColumnType("integer")
                        .HasColumnName("runtime");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4418),
                            Description = "Very scary",
                            Rating = "PG",
                            Runtime = 190,
                            Title = "A herd of Microscopic Flowers",
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4419)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4421),
                            Description = "Boooring",
                            Rating = "NC-17",
                            Runtime = 135,
                            Title = "An army of Zombies",
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4422)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4423),
                            Description = "Lorem ipsum test ummmm",
                            Rating = "NC-17",
                            Runtime = 190,
                            Title = "Two Purple Flowers",
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4423)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4424),
                            Description = "Very scary",
                            Rating = "R",
                            Runtime = 135,
                            Title = "Several",
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4424)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4424),
                            Description = "Lorem ipsum test ummmm",
                            Rating = "R",
                            Runtime = 60,
                            Title = "A herd of Microscopic Flowers",
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4425)
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4454),
                            Description = "Lorem ipsum test ummmm",
                            Rating = "PG-13",
                            Runtime = 60,
                            Title = "Fifteen Transparent Planets",
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4455)
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4455),
                            Description = "Boooring",
                            Rating = "R",
                            Runtime = 135,
                            Title = "An army of Zombies",
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4456)
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4456),
                            Description = "Lorem ipsum test ummmm",
                            Rating = "PG",
                            Runtime = 190,
                            Title = "A herd of Microscopic Flowers",
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4457)
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4457),
                            Description = "Very scary",
                            Rating = "NC-17",
                            Runtime = 190,
                            Title = "Two Purple Flowers",
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4458)
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4459),
                            Description = "Very scary",
                            Rating = "PG-13",
                            Runtime = 122,
                            Title = "Two Purple Flowers",
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4459)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("integer")
                        .HasColumnName("capacity");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("createdAt");

                    b.Property<int>("MovieId")
                        .HasColumnType("integer")
                        .HasColumnName("movieId");

                    b.Property<int>("ScreenNumber")
                        .HasColumnType("integer")
                        .HasColumnName("screenNumber");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("UpdatedAt");

                    b.Property<DateTime>("startsAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("startsAt");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("screenings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 69,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4494),
                            MovieId = 8,
                            ScreenNumber = 8,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4494),
                            startsAt = new DateTime(2024, 3, 5, 7, 56, 21, 640, DateTimeKind.Utc).AddTicks(4486)
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 93,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4498),
                            MovieId = 9,
                            ScreenNumber = 8,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4498),
                            startsAt = new DateTime(2024, 2, 24, 20, 30, 21, 640, DateTimeKind.Utc).AddTicks(4497)
                        },
                        new
                        {
                            Id = 3,
                            Capacity = 63,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4499),
                            MovieId = 4,
                            ScreenNumber = 5,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4500),
                            startsAt = new DateTime(2024, 3, 1, 11, 39, 21, 640, DateTimeKind.Utc).AddTicks(4499)
                        },
                        new
                        {
                            Id = 4,
                            Capacity = 56,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4501),
                            MovieId = 2,
                            ScreenNumber = 3,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4501),
                            startsAt = new DateTime(2024, 2, 17, 13, 20, 21, 640, DateTimeKind.Utc).AddTicks(4500)
                        },
                        new
                        {
                            Id = 5,
                            Capacity = 21,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4502),
                            MovieId = 3,
                            ScreenNumber = 10,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4502),
                            startsAt = new DateTime(2024, 2, 21, 13, 36, 21, 640, DateTimeKind.Utc).AddTicks(4501)
                        },
                        new
                        {
                            Id = 6,
                            Capacity = 53,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4504),
                            MovieId = 8,
                            ScreenNumber = 4,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4504),
                            startsAt = new DateTime(2024, 3, 1, 21, 32, 21, 640, DateTimeKind.Utc).AddTicks(4503)
                        },
                        new
                        {
                            Id = 7,
                            Capacity = 94,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4505),
                            MovieId = 8,
                            ScreenNumber = 8,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4505),
                            startsAt = new DateTime(2024, 2, 22, 20, 17, 21, 640, DateTimeKind.Utc).AddTicks(4505)
                        },
                        new
                        {
                            Id = 8,
                            Capacity = 56,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4506),
                            MovieId = 6,
                            ScreenNumber = 8,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4507),
                            startsAt = new DateTime(2024, 3, 1, 11, 2, 21, 640, DateTimeKind.Utc).AddTicks(4506)
                        },
                        new
                        {
                            Id = 9,
                            Capacity = 81,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4508),
                            MovieId = 6,
                            ScreenNumber = 4,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4508),
                            startsAt = new DateTime(2024, 3, 1, 6, 54, 21, 640, DateTimeKind.Utc).AddTicks(4507)
                        },
                        new
                        {
                            Id = 10,
                            Capacity = 54,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4509),
                            MovieId = 4,
                            ScreenNumber = 2,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4509),
                            startsAt = new DateTime(2024, 2, 15, 19, 59, 21, 640, DateTimeKind.Utc).AddTicks(4509)
                        },
                        new
                        {
                            Id = 11,
                            Capacity = 46,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4510),
                            MovieId = 1,
                            ScreenNumber = 2,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4510),
                            startsAt = new DateTime(2024, 2, 21, 6, 54, 21, 640, DateTimeKind.Utc).AddTicks(4510)
                        },
                        new
                        {
                            Id = 12,
                            Capacity = 45,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4511),
                            MovieId = 2,
                            ScreenNumber = 7,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4512),
                            startsAt = new DateTime(2024, 3, 9, 8, 15, 21, 640, DateTimeKind.Utc).AddTicks(4511)
                        },
                        new
                        {
                            Id = 13,
                            Capacity = 92,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4512),
                            MovieId = 9,
                            ScreenNumber = 1,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4513),
                            startsAt = new DateTime(2024, 3, 7, 22, 45, 21, 640, DateTimeKind.Utc).AddTicks(4512)
                        },
                        new
                        {
                            Id = 14,
                            Capacity = 86,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4514),
                            MovieId = 1,
                            ScreenNumber = 8,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4514),
                            startsAt = new DateTime(2024, 2, 15, 19, 40, 21, 640, DateTimeKind.Utc).AddTicks(4513)
                        },
                        new
                        {
                            Id = 15,
                            Capacity = 56,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4515),
                            MovieId = 3,
                            ScreenNumber = 8,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4515),
                            startsAt = new DateTime(2024, 3, 8, 22, 46, 21, 640, DateTimeKind.Utc).AddTicks(4514)
                        },
                        new
                        {
                            Id = 16,
                            Capacity = 24,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4516),
                            MovieId = 8,
                            ScreenNumber = 2,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4516),
                            startsAt = new DateTime(2024, 3, 10, 6, 17, 21, 640, DateTimeKind.Utc).AddTicks(4515)
                        },
                        new
                        {
                            Id = 17,
                            Capacity = 24,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4517),
                            MovieId = 4,
                            ScreenNumber = 8,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4517),
                            startsAt = new DateTime(2024, 2, 14, 18, 21, 21, 640, DateTimeKind.Utc).AddTicks(4516)
                        },
                        new
                        {
                            Id = 18,
                            Capacity = 45,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4518),
                            MovieId = 3,
                            ScreenNumber = 3,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4519),
                            startsAt = new DateTime(2024, 2, 20, 4, 52, 21, 640, DateTimeKind.Utc).AddTicks(4518)
                        },
                        new
                        {
                            Id = 19,
                            Capacity = 95,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4519),
                            MovieId = 7,
                            ScreenNumber = 5,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4520),
                            startsAt = new DateTime(2024, 2, 21, 7, 4, 21, 640, DateTimeKind.Utc).AddTicks(4519)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("createdAt");

                    b.Property<int>("CustomerID")
                        .HasColumnType("integer")
                        .HasColumnName("customerID");

                    b.Property<int>("ScreeningId")
                        .HasColumnType("integer")
                        .HasColumnName("screeningID");

                    b.Property<int>("SeatNumber")
                        .HasColumnType("integer")
                        .HasColumnName("seatNumber");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("CustomerID");

                    b.HasIndex("ScreeningId");

                    b.ToTable("ticket");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4521),
                            CustomerID = 1,
                            ScreeningId = 11,
                            SeatNumber = 38,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4522)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4525),
                            CustomerID = 7,
                            ScreeningId = 5,
                            SeatNumber = 38,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4525)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4526),
                            CustomerID = 6,
                            ScreeningId = 8,
                            SeatNumber = 49,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4526)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4527),
                            CustomerID = 8,
                            ScreeningId = 4,
                            SeatNumber = 23,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4527)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4528),
                            CustomerID = 3,
                            ScreeningId = 11,
                            SeatNumber = 46,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4528)
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4529),
                            CustomerID = 2,
                            ScreeningId = 7,
                            SeatNumber = 18,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4530)
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4530),
                            CustomerID = 9,
                            ScreeningId = 5,
                            SeatNumber = 48,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4530)
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4531),
                            CustomerID = 3,
                            ScreeningId = 12,
                            SeatNumber = 16,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4531)
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4532),
                            CustomerID = 4,
                            ScreeningId = 18,
                            SeatNumber = 31,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4532)
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4533),
                            CustomerID = 3,
                            ScreeningId = 10,
                            SeatNumber = 36,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4533)
                        },
                        new
                        {
                            Id = 11,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4534),
                            CustomerID = 3,
                            ScreeningId = 16,
                            SeatNumber = 45,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4534)
                        },
                        new
                        {
                            Id = 12,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4534),
                            CustomerID = 4,
                            ScreeningId = 15,
                            SeatNumber = 25,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4534)
                        },
                        new
                        {
                            Id = 13,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4535),
                            CustomerID = 2,
                            ScreeningId = 5,
                            SeatNumber = 26,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4535)
                        },
                        new
                        {
                            Id = 14,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4536),
                            CustomerID = 6,
                            ScreeningId = 16,
                            SeatNumber = 46,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4536)
                        },
                        new
                        {
                            Id = 15,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4536),
                            CustomerID = 2,
                            ScreeningId = 11,
                            SeatNumber = 8,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4536)
                        },
                        new
                        {
                            Id = 16,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4537),
                            CustomerID = 7,
                            ScreeningId = 12,
                            SeatNumber = 44,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4537)
                        },
                        new
                        {
                            Id = 17,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4537),
                            CustomerID = 3,
                            ScreeningId = 17,
                            SeatNumber = 13,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4538)
                        },
                        new
                        {
                            Id = 18,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4539),
                            CustomerID = 9,
                            ScreeningId = 1,
                            SeatNumber = 20,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4539)
                        },
                        new
                        {
                            Id = 19,
                            CreatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4539),
                            CustomerID = 8,
                            ScreeningId = 17,
                            SeatNumber = 2,
                            UpdatedAt = new DateTime(2024, 2, 12, 11, 45, 21, 640, DateTimeKind.Utc).AddTicks(4540)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.HasOne("api_cinema_challenge.Models.Movie", "Movie")
                        .WithMany("Screenings")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Ticket", b =>
                {
                    b.HasOne("api_cinema_challenge.Models.Customer", "Customer")
                        .WithMany("Tickets")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api_cinema_challenge.Models.Screening", "Screening")
                        .WithMany("Tickets")
                        .HasForeignKey("ScreeningId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Screening");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Customer", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Movie", b =>
                {
                    b.Navigation("Screenings");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
