using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskManager_1.Server.Data.Migrations
{
    public partial class ApplicationDbContext2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstNmae",
                table: "AspNetUsers",
                newName: "FirstName");

            migrationBuilder.AlterColumn<string>(
                name: "TaskName",
                table: "UserTasks",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                table: "UserTasks",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate" },
                values: new object[] { new DateTime(2023, 2, 14, 2, 56, 29, 224, DateTimeKind.Local).AddTicks(3016), new DateTime(2023, 2, 14, 2, 56, 29, 225, DateTimeKind.Local).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DueDate" },
                values: new object[] { new DateTime(2023, 2, 14, 2, 56, 29, 225, DateTimeKind.Local).AddTicks(6665), new DateTime(2023, 2, 14, 2, 56, 29, 225, DateTimeKind.Local).AddTicks(6670) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "AspNetUsers",
                newName: "FirstNmae");

            migrationBuilder.AlterColumn<string>(
                name: "TaskName",
                table: "UserTasks",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DueDate",
                table: "UserTasks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DueDate" },
                values: new object[] { new DateTime(2023, 2, 13, 18, 13, 1, 562, DateTimeKind.Local).AddTicks(5097), new DateTime(2023, 2, 13, 18, 13, 1, 564, DateTimeKind.Local).AddTicks(2231) });

            migrationBuilder.UpdateData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DueDate" },
                values: new object[] { new DateTime(2023, 2, 13, 18, 13, 1, 564, DateTimeKind.Local).AddTicks(3013), new DateTime(2023, 2, 13, 18, 13, 1, 564, DateTimeKind.Local).AddTicks(3018) });
        }
    }
}
