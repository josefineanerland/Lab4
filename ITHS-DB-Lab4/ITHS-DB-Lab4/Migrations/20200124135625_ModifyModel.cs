using ITHS_DB_Lab4.Models;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ITHS_DB_Lab4.Migrations
{
    public partial class ModifyModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Firstname",
                table: "Users",
                maxLength: 255,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Lastname",
                table: "Users",
                maxLength: 255,
                nullable: false,
                defaultValue: "");


            migrationBuilder.Sql(
            @"
            UPDATE Users
                SET Firstname = (SELECT SUBSTRING(Name, 1, CHARINDEX(' ', Name) -1) FROM Users U WHERE U.UserId = Users.UserId),
	                Lastname = (SELECT SUBSTRING(Name,
                        CHARINDEX(' ', Name) + 1,
                            LEN(Name) - CHARINDEX(' ', Name)) FROM Users U WHERE U.UserId = Users.UserId)"
            );

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Users");

        }

        

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Firstname",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Lastname",
                table: "Users",
                newName: "Name");
        }
    }
}
