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
    [Migration("20250128211528_please")]
    partial class please
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("api_cinema_challenge.Models.Customer", b =>
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
                            Id = 1,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(7349),
                            Email = "johndoe@example.com",
                            Name = "John Doe",
                            Phone = "555-1234",
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(7351)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(7712),
                            Email = "janesmith@example.com",
                            Name = "Jane Smith",
                            Phone = "555-5678",
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(7714)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(7716),
                            Email = "michaelj@example.com",
                            Name = "Michael Johnson",
                            Phone = "555-9876",
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(7718)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(7720),
                            Email = "emilyd@example.com",
                            Name = "Emily Davis",
                            Phone = "555-4321",
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(7722)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(7725),
                            Email = "chriswilliams@example.com",
                            Name = "Chris Williams",
                            Phone = "555-8765",
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(7726)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Movie", b =>
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
                            Id = 1,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 207, DateTimeKind.Utc).AddTicks(5052),
                            Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                            Rating = "R",
                            RuntimeMins = 142,
                            Title = "The Shawshank Redemption",
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(5638)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(6984),
                            Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
                            Rating = "R",
                            RuntimeMins = 175,
                            Title = "The Godfather",
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(6990)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(6993),
                            Description = "When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.",
                            Rating = "PG-13",
                            RuntimeMins = 152,
                            Title = "The Dark Knight",
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(6995)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(6997),
                            Description = "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an extraordinary, though simple, life.",
                            Rating = "PG-13",
                            RuntimeMins = 142,
                            Title = "Forrest Gump",
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(6999)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(7001),
                            Description = "A thief who enters the dreams of others to steal secrets from their subconscious is given the inverse task of planting an idea into the mind of a CEO.",
                            Rating = "PG-13",
                            RuntimeMins = 148,
                            Title = "Inception",
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(7003)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screening", b =>
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

                    b.HasIndex("MovieId");

                    b.ToTable("screenings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8369),
                            MovieId = 1,
                            ScreenNumber = 1,
                            StartsAt = new DateTime(2025, 1, 28, 22, 15, 22, 209, DateTimeKind.Utc).AddTicks(8668),
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8372)
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8776),
                            MovieId = 1,
                            ScreenNumber = 1,
                            StartsAt = new DateTime(2025, 1, 28, 23, 15, 22, 209, DateTimeKind.Utc).AddTicks(8780),
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8778)
                        },
                        new
                        {
                            Id = 3,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8783),
                            MovieId = 1,
                            ScreenNumber = 1,
                            StartsAt = new DateTime(2025, 1, 29, 0, 15, 22, 209, DateTimeKind.Utc).AddTicks(8786),
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8784)
                        },
                        new
                        {
                            Id = 4,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8789),
                            MovieId = 1,
                            ScreenNumber = 1,
                            StartsAt = new DateTime(2025, 1, 29, 1, 15, 22, 209, DateTimeKind.Utc).AddTicks(8793),
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8791)
                        },
                        new
                        {
                            Id = 5,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8795),
                            MovieId = 2,
                            ScreenNumber = 1,
                            StartsAt = new DateTime(2025, 1, 29, 2, 15, 22, 209, DateTimeKind.Utc).AddTicks(8798),
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8796)
                        },
                        new
                        {
                            Id = 6,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8800),
                            MovieId = 2,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2025, 1, 28, 22, 15, 22, 209, DateTimeKind.Utc).AddTicks(8804),
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8802)
                        },
                        new
                        {
                            Id = 7,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8827),
                            MovieId = 2,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2025, 1, 28, 23, 15, 22, 209, DateTimeKind.Utc).AddTicks(8832),
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8829)
                        },
                        new
                        {
                            Id = 8,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8834),
                            MovieId = 2,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2025, 1, 29, 0, 15, 22, 209, DateTimeKind.Utc).AddTicks(8838),
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8836)
                        },
                        new
                        {
                            Id = 9,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8840),
                            MovieId = 2,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2025, 1, 29, 1, 15, 22, 209, DateTimeKind.Utc).AddTicks(8843),
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8841)
                        },
                        new
                        {
                            Id = 10,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8845),
                            MovieId = 2,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2025, 1, 29, 2, 15, 22, 209, DateTimeKind.Utc).AddTicks(8849),
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8847)
                        },
                        new
                        {
                            Id = 11,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8851),
                            MovieId = 3,
                            ScreenNumber = 3,
                            StartsAt = new DateTime(2025, 1, 28, 22, 15, 22, 209, DateTimeKind.Utc).AddTicks(8854),
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8852)
                        },
                        new
                        {
                            Id = 12,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8856),
                            MovieId = 3,
                            ScreenNumber = 3,
                            StartsAt = new DateTime(2025, 1, 28, 23, 15, 22, 209, DateTimeKind.Utc).AddTicks(8860),
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8858)
                        },
                        new
                        {
                            Id = 13,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8862),
                            MovieId = 3,
                            ScreenNumber = 3,
                            StartsAt = new DateTime(2025, 1, 29, 0, 15, 22, 209, DateTimeKind.Utc).AddTicks(8865),
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8863)
                        },
                        new
                        {
                            Id = 14,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8867),
                            MovieId = 3,
                            ScreenNumber = 3,
                            StartsAt = new DateTime(2025, 1, 29, 1, 15, 22, 209, DateTimeKind.Utc).AddTicks(8871),
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8869)
                        },
                        new
                        {
                            Id = 15,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8873),
                            MovieId = 3,
                            ScreenNumber = 3,
                            StartsAt = new DateTime(2025, 1, 29, 2, 15, 22, 209, DateTimeKind.Utc).AddTicks(8876),
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8874)
                        },
                        new
                        {
                            Id = 16,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8878),
                            MovieId = 1,
                            ScreenNumber = 1,
                            StartsAt = new DateTime(2025, 1, 29, 3, 15, 22, 209, DateTimeKind.Utc).AddTicks(8882),
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8880)
                        },
                        new
                        {
                            Id = 17,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8884),
                            MovieId = 1,
                            ScreenNumber = 1,
                            StartsAt = new DateTime(2025, 1, 29, 4, 15, 22, 209, DateTimeKind.Utc).AddTicks(8888),
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8885)
                        },
                        new
                        {
                            Id = 18,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8890),
                            MovieId = 1,
                            ScreenNumber = 1,
                            StartsAt = new DateTime(2025, 1, 29, 5, 15, 22, 209, DateTimeKind.Utc).AddTicks(8893),
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8891)
                        },
                        new
                        {
                            Id = 19,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8895),
                            MovieId = 1,
                            ScreenNumber = 1,
                            StartsAt = new DateTime(2025, 1, 29, 6, 15, 22, 209, DateTimeKind.Utc).AddTicks(8899),
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8897)
                        },
                        new
                        {
                            Id = 20,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8915),
                            MovieId = 2,
                            ScreenNumber = 1,
                            StartsAt = new DateTime(2025, 1, 29, 7, 15, 22, 209, DateTimeKind.Utc).AddTicks(8919),
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8917)
                        },
                        new
                        {
                            Id = 21,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8921),
                            MovieId = 2,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2025, 1, 29, 3, 15, 22, 209, DateTimeKind.Utc).AddTicks(8925),
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8923)
                        },
                        new
                        {
                            Id = 22,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8927),
                            MovieId = 2,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2025, 1, 29, 4, 15, 22, 209, DateTimeKind.Utc).AddTicks(8930),
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8928)
                        },
                        new
                        {
                            Id = 23,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8932),
                            MovieId = 2,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2025, 1, 29, 5, 15, 22, 209, DateTimeKind.Utc).AddTicks(8936),
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8934)
                        },
                        new
                        {
                            Id = 24,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8938),
                            MovieId = 2,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2025, 1, 29, 6, 15, 22, 209, DateTimeKind.Utc).AddTicks(8941),
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8939)
                        },
                        new
                        {
                            Id = 25,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8943),
                            MovieId = 2,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2025, 1, 29, 7, 15, 22, 209, DateTimeKind.Utc).AddTicks(8947),
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8945)
                        },
                        new
                        {
                            Id = 26,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8949),
                            MovieId = 3,
                            ScreenNumber = 3,
                            StartsAt = new DateTime(2025, 1, 29, 3, 15, 22, 209, DateTimeKind.Utc).AddTicks(8952),
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8950)
                        },
                        new
                        {
                            Id = 27,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8954),
                            MovieId = 3,
                            ScreenNumber = 3,
                            StartsAt = new DateTime(2025, 1, 29, 4, 15, 22, 209, DateTimeKind.Utc).AddTicks(8958),
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8956)
                        },
                        new
                        {
                            Id = 28,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8960),
                            MovieId = 3,
                            ScreenNumber = 3,
                            StartsAt = new DateTime(2025, 1, 29, 5, 15, 22, 209, DateTimeKind.Utc).AddTicks(8963),
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8961)
                        },
                        new
                        {
                            Id = 29,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8965),
                            MovieId = 3,
                            ScreenNumber = 3,
                            StartsAt = new DateTime(2025, 1, 29, 6, 15, 22, 209, DateTimeKind.Utc).AddTicks(8969),
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8967)
                        },
                        new
                        {
                            Id = 30,
                            Capacity = 50,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8971),
                            MovieId = 3,
                            ScreenNumber = 3,
                            StartsAt = new DateTime(2025, 1, 29, 7, 15, 22, 209, DateTimeKind.Utc).AddTicks(8974),
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 209, DateTimeKind.Utc).AddTicks(8972)
                        });
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Ticket", b =>
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

                    b.HasIndex("CustomerId");

                    b.HasIndex("ScreeningId");

                    b.ToTable("tickets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 210, DateTimeKind.Utc).AddTicks(579),
                            CustomerId = 1,
                            NumSeats = 4,
                            ScreeningId = 1,
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 210, DateTimeKind.Utc).AddTicks(587)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 210, DateTimeKind.Utc).AddTicks(895),
                            CustomerId = 2,
                            NumSeats = 2,
                            ScreeningId = 2,
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 210, DateTimeKind.Utc).AddTicks(897)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 210, DateTimeKind.Utc).AddTicks(900),
                            CustomerId = 3,
                            NumSeats = 4,
                            ScreeningId = 2,
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 210, DateTimeKind.Utc).AddTicks(901)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 210, DateTimeKind.Utc).AddTicks(904),
                            CustomerId = 4,
                            NumSeats = 1,
                            ScreeningId = 3,
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 210, DateTimeKind.Utc).AddTicks(905)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 210, DateTimeKind.Utc).AddTicks(908),
                            CustomerId = 5,
                            NumSeats = 1,
                            ScreeningId = 3,
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 210, DateTimeKind.Utc).AddTicks(909)
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 210, DateTimeKind.Utc).AddTicks(911),
                            CustomerId = 5,
                            NumSeats = 1,
                            ScreeningId = 3,
                            UpdatedAt = new DateTime(2025, 1, 28, 21, 15, 22, 210, DateTimeKind.Utc).AddTicks(913)
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
                        .HasForeignKey("CustomerId")
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
