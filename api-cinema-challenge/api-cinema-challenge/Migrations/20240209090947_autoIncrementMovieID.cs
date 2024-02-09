﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    /// <inheritdoc />
    public partial class autoIncrementMovieID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 9, 9, 47, 570, DateTimeKind.Utc).AddTicks(4695), new DateTime(2024, 2, 9, 9, 9, 47, 570, DateTimeKind.Utc).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 9, 9, 47, 570, DateTimeKind.Utc).AddTicks(4695), new DateTime(2024, 2, 9, 9, 9, 47, 570, DateTimeKind.Utc).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 9, 9, 47, 570, DateTimeKind.Utc).AddTicks(4695), new DateTime(2024, 2, 9, 9, 9, 47, 570, DateTimeKind.Utc).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 9, 9, 47, 570, DateTimeKind.Utc).AddTicks(4695), new DateTime(2024, 2, 9, 9, 9, 47, 570, DateTimeKind.Utc).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 9, 9, 47, 570, DateTimeKind.Utc).AddTicks(4695), new DateTime(2024, 2, 9, 9, 9, 47, 570, DateTimeKind.Utc).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 9, 9, 47, 570, DateTimeKind.Utc).AddTicks(4695), new DateTime(2024, 2, 9, 9, 9, 47, 570, DateTimeKind.Utc).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 9, 9, 47, 570, DateTimeKind.Utc).AddTicks(4695), new DateTime(2024, 2, 10, 9, 9, 47, 570, DateTimeKind.Utc).AddTicks(4695), new DateTime(2024, 2, 9, 9, 9, 47, 570, DateTimeKind.Utc).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 9, 9, 47, 570, DateTimeKind.Utc).AddTicks(4695), new DateTime(2024, 2, 11, 9, 9, 47, 570, DateTimeKind.Utc).AddTicks(4695), new DateTime(2024, 2, 9, 9, 9, 47, 570, DateTimeKind.Utc).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 9, 9, 47, 570, DateTimeKind.Utc).AddTicks(4695), new DateTime(2024, 2, 12, 9, 9, 47, 570, DateTimeKind.Utc).AddTicks(4695), new DateTime(2024, 2, 9, 9, 9, 47, 570, DateTimeKind.Utc).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 9, 9, 47, 570, DateTimeKind.Utc).AddTicks(4695), new DateTime(2024, 2, 9, 9, 9, 47, 570, DateTimeKind.Utc).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 9, 9, 47, 570, DateTimeKind.Utc).AddTicks(4695), new DateTime(2024, 2, 9, 9, 9, 47, 570, DateTimeKind.Utc).AddTicks(4695) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 9, 9, 9, 47, 570, DateTimeKind.Utc).AddTicks(4695), new DateTime(2024, 2, 9, 9, 9, 47, 570, DateTimeKind.Utc).AddTicks(4695) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 19, 33, 576, DateTimeKind.Utc).AddTicks(3172), new DateTime(2024, 2, 8, 10, 19, 33, 576, DateTimeKind.Utc).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 19, 33, 576, DateTimeKind.Utc).AddTicks(3172), new DateTime(2024, 2, 8, 10, 19, 33, 576, DateTimeKind.Utc).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "customers",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 19, 33, 576, DateTimeKind.Utc).AddTicks(3172), new DateTime(2024, 2, 8, 10, 19, 33, 576, DateTimeKind.Utc).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 19, 33, 576, DateTimeKind.Utc).AddTicks(3172), new DateTime(2024, 2, 8, 10, 19, 33, 576, DateTimeKind.Utc).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 19, 33, 576, DateTimeKind.Utc).AddTicks(3172), new DateTime(2024, 2, 8, 10, 19, 33, 576, DateTimeKind.Utc).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 19, 33, 576, DateTimeKind.Utc).AddTicks(3172), new DateTime(2024, 2, 8, 10, 19, 33, 576, DateTimeKind.Utc).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 19, 33, 576, DateTimeKind.Utc).AddTicks(3172), new DateTime(2024, 2, 9, 10, 19, 33, 576, DateTimeKind.Utc).AddTicks(3172), new DateTime(2024, 2, 8, 10, 19, 33, 576, DateTimeKind.Utc).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 19, 33, 576, DateTimeKind.Utc).AddTicks(3172), new DateTime(2024, 2, 10, 10, 19, 33, 576, DateTimeKind.Utc).AddTicks(3172), new DateTime(2024, 2, 8, 10, 19, 33, 576, DateTimeKind.Utc).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "starts_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 19, 33, 576, DateTimeKind.Utc).AddTicks(3172), new DateTime(2024, 2, 11, 10, 19, 33, 576, DateTimeKind.Utc).AddTicks(3172), new DateTime(2024, 2, 8, 10, 19, 33, 576, DateTimeKind.Utc).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 19, 33, 576, DateTimeKind.Utc).AddTicks(3172), new DateTime(2024, 2, 8, 10, 19, 33, 576, DateTimeKind.Utc).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 19, 33, 576, DateTimeKind.Utc).AddTicks(3172), new DateTime(2024, 2, 8, 10, 19, 33, 576, DateTimeKind.Utc).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "tickets",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_at", "updated_at" },
                values: new object[] { new DateTime(2024, 2, 8, 10, 19, 33, 576, DateTimeKind.Utc).AddTicks(3172), new DateTime(2024, 2, 8, 10, 19, 33, 576, DateTimeKind.Utc).AddTicks(3172) });
        }
    }
}
