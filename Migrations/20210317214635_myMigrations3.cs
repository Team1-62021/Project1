using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Group_Project.Migrations
{
    public partial class myMigrations3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Time10",
                table: "Availablities");

            migrationBuilder.DropColumn(
                name: "Time11",
                table: "Availablities");

            migrationBuilder.DropColumn(
                name: "Time12",
                table: "Availablities");

            migrationBuilder.DropColumn(
                name: "Time13",
                table: "Availablities");

            migrationBuilder.DropColumn(
                name: "Time14",
                table: "Availablities");

            migrationBuilder.DropColumn(
                name: "Time15",
                table: "Availablities");

            migrationBuilder.DropColumn(
                name: "Time16",
                table: "Availablities");

            migrationBuilder.DropColumn(
                name: "Time17",
                table: "Availablities");

            migrationBuilder.DropColumn(
                name: "Time18",
                table: "Availablities");

            migrationBuilder.DropColumn(
                name: "Time19",
                table: "Availablities");

            migrationBuilder.DropColumn(
                name: "Time20",
                table: "Availablities");

            migrationBuilder.DropColumn(
                name: "Time8",
                table: "Availablities");

            migrationBuilder.DropColumn(
                name: "Time9",
                table: "Availablities");

            migrationBuilder.AddColumn<DateTime>(
                name: "Time",
                table: "Availablities",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Time",
                table: "Availablities");

            migrationBuilder.AddColumn<bool>(
                name: "Time10",
                table: "Availablities",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Time11",
                table: "Availablities",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Time12",
                table: "Availablities",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Time13",
                table: "Availablities",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Time14",
                table: "Availablities",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Time15",
                table: "Availablities",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Time16",
                table: "Availablities",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Time17",
                table: "Availablities",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Time18",
                table: "Availablities",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Time19",
                table: "Availablities",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Time20",
                table: "Availablities",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Time8",
                table: "Availablities",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Time9",
                table: "Availablities",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
