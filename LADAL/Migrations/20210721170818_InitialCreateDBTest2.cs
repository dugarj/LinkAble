using Microsoft.EntityFrameworkCore.Migrations;

namespace LADAL.Migrations
{
    public partial class InitialCreateDBTest2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LAUrl_LAUser_UserId",
                table: "LAUrl");

            migrationBuilder.DropTable(
                name: "LAUser");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "LAUrl",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Contact",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_LAUrl_AspNetUsers_UserId",
                table: "LAUrl",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LAUrl_AspNetUsers_UserId",
                table: "LAUrl");

            migrationBuilder.DropColumn(
                name: "Contact",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "LAUrl",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "LAUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LAUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LAUser_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_LAUrl_LAUser_UserId",
                table: "LAUrl",
                column: "UserId",
                principalTable: "LAUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
