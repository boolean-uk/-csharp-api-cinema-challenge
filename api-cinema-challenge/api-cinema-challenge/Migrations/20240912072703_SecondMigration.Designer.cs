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
    [Migration("20240912072703_SecondMigration")]
    partial class SecondMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
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

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("phone_number");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id");

                    b.ToTable("customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3111),
                            Email = "anne@anne.com",
                            Name = "Anne Anneson",
                            PhoneNumber = "47473828",
                            UpdatedAt = new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3113)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3117),
                            Email = "bent@bentson.com",
                            Name = "Bent Bentson",
                            PhoneNumber = "33929274",
                            UpdatedAt = new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3118)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3119),
                            Email = "carl@carlson.com",
                            Name = "Carl Carlson",
                            PhoneNumber = "98472288",
                            UpdatedAt = new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3120)
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
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<int>("DurationMinutes")
                        .HasColumnType("integer")
                        .HasColumnName("duration_minutes");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("rating");

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
                            CreatedAt = new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3123),
                            Description = "You're a wizard Harry",
                            DurationMinutes = 190,
                            Rating = "Pg-13",
                            Title = "Harry Potter and The Philosphers Stone",
                            UpdatedAt = new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3124)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3126),
                            Description = "You're still a wizard Harry",
                            DurationMinutes = 200,
                            Rating = "Pg-13",
                            Title = "Harry Potter and The Chamber of Secrets",
                            UpdatedAt = new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3126)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3127),
                            Description = "You're a still still a wizard Harry",
                            DurationMinutes = 170,
                            Rating = "Pg-13",
                            Title = "Harry Potter and The Prizoner of Azkaban",
                            UpdatedAt = new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3128)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3129),
                            Description = "You're a still still still a wizard Harry",
                            DurationMinutes = 170,
                            Rating = "Pg-13",
                            Title = "Harry Potter and The Half Blood Prince",
                            UpdatedAt = new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3129)
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

                    b.ToTable("screenings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 100,
                            CreatedAt = new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3133),
                            MovieId = 1,
                            ScreenNumber = 1,
                            StartsAt = new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3133),
                            UpdatedAt = new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3134)
                        },
                        new
                        {
                            Id = 2,
                            Capacity = 200,
                            CreatedAt = new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3136),
                            MovieId = 2,
                            ScreenNumber = 2,
                            StartsAt = new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3136),
                            UpdatedAt = new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3136)
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
                        .HasColumnName("seat_number");

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
                            Id = 1,
                            CreatedAt = new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3139),
                            CustomerId = 1,
                            NumSeats = 2,
                            ScreeningId = 1,
                            UpdatedAt = new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3140)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3142),
                            CustomerId = 2,
                            NumSeats = 4,
                            ScreeningId = 2,
                            UpdatedAt = new DateTime(2024, 9, 12, 7, 27, 3, 597, DateTimeKind.Utc).AddTicks(3142)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
