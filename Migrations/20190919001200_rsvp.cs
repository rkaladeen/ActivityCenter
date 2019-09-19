using Microsoft.EntityFrameworkCore.Migrations;

namespace ActivityCenter.Migrations
{
    public partial class rsvp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RSVPs_Activities_Activity_Id",
                table: "RSVPs");

            migrationBuilder.DropForeignKey(
                name: "FK_RSVPs_Users_User_Id",
                table: "RSVPs");

            migrationBuilder.AlterColumn<int>(
                name: "User_Id",
                table: "RSVPs",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Activity_Id",
                table: "RSVPs",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RSVPs_Activities_Activity_Id",
                table: "RSVPs",
                column: "Activity_Id",
                principalTable: "Activities",
                principalColumn: "Activity_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RSVPs_Users_User_Id",
                table: "RSVPs",
                column: "User_Id",
                principalTable: "Users",
                principalColumn: "User_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RSVPs_Activities_Activity_Id",
                table: "RSVPs");

            migrationBuilder.DropForeignKey(
                name: "FK_RSVPs_Users_User_Id",
                table: "RSVPs");

            migrationBuilder.AlterColumn<int>(
                name: "User_Id",
                table: "RSVPs",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Activity_Id",
                table: "RSVPs",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_RSVPs_Activities_Activity_Id",
                table: "RSVPs",
                column: "Activity_Id",
                principalTable: "Activities",
                principalColumn: "Activity_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RSVPs_Users_User_Id",
                table: "RSVPs",
                column: "User_Id",
                principalTable: "Users",
                principalColumn: "User_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
