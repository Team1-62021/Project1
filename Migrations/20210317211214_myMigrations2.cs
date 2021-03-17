using Microsoft.EntityFrameworkCore.Migrations;

namespace Group_Project.Migrations
{
    public partial class myMigrations2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppointmentListViewModelKey",
                table: "Availablities",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DateInfos",
                columns: table => new
                {
                    Date = table.Column<string>(type: "TEXT", nullable: false),
                    Time = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateInfos", x => x.Date);
                });

            migrationBuilder.CreateTable(
                name: "AppointmentListViewModels",
                columns: table => new
                {
                    Key = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateInfoDate = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentListViewModels", x => x.Key);
                    table.ForeignKey(
                        name: "FK_AppointmentListViewModels_DateInfos_DateInfoDate",
                        column: x => x.DateInfoDate,
                        principalTable: "DateInfos",
                        principalColumn: "Date",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Availablities_AppointmentListViewModelKey",
                table: "Availablities",
                column: "AppointmentListViewModelKey");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentListViewModels_DateInfoDate",
                table: "AppointmentListViewModels",
                column: "DateInfoDate");

            migrationBuilder.AddForeignKey(
                name: "FK_Availablities_AppointmentListViewModels_AppointmentListViewModelKey",
                table: "Availablities",
                column: "AppointmentListViewModelKey",
                principalTable: "AppointmentListViewModels",
                principalColumn: "Key",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Availablities_AppointmentListViewModels_AppointmentListViewModelKey",
                table: "Availablities");

            migrationBuilder.DropTable(
                name: "AppointmentListViewModels");

            migrationBuilder.DropTable(
                name: "DateInfos");

            migrationBuilder.DropIndex(
                name: "IX_Availablities_AppointmentListViewModelKey",
                table: "Availablities");

            migrationBuilder.DropColumn(
                name: "AppointmentListViewModelKey",
                table: "Availablities");
        }
    }
}
