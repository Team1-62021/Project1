using Microsoft.EntityFrameworkCore.Migrations;

namespace Group_Project.Migrations
{
    public partial class myMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    AppointmentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupName = table.Column<string>(type: "TEXT", nullable: false),
                    GroupSize = table.Column<int>(type: "INTEGER", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: true),
                    Time = table.Column<int>(type: "INTEGER", nullable: false),
                    Date = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.AppointmentId);
                });

            migrationBuilder.CreateTable(
                name: "Availablities",
                columns: table => new
                {
                    Date = table.Column<string>(type: "TEXT", nullable: false),
                    Time8 = table.Column<bool>(type: "INTEGER", nullable: false),
                    Time9 = table.Column<bool>(type: "INTEGER", nullable: false),
                    Time10 = table.Column<bool>(type: "INTEGER", nullable: false),
                    Time11 = table.Column<bool>(type: "INTEGER", nullable: false),
                    Time12 = table.Column<bool>(type: "INTEGER", nullable: false),
                    Time13 = table.Column<bool>(type: "INTEGER", nullable: false),
                    Time14 = table.Column<bool>(type: "INTEGER", nullable: false),
                    Time15 = table.Column<bool>(type: "INTEGER", nullable: false),
                    Time16 = table.Column<bool>(type: "INTEGER", nullable: false),
                    Time17 = table.Column<bool>(type: "INTEGER", nullable: false),
                    Time18 = table.Column<bool>(type: "INTEGER", nullable: false),
                    Time19 = table.Column<bool>(type: "INTEGER", nullable: false),
                    Time20 = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Availablities", x => x.Date);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Availablities");
        }
    }
}
