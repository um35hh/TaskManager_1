using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskManager_1.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserTasks",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DueDate", "IsCompleted", "TaskName" },
                values: new object[] { 1, "System", new DateTime(2023, 2, 13, 18, 13, 1, 562, DateTimeKind.Local).AddTicks(5097), new DateTime(2023, 2, 13, 18, 13, 1, 564, DateTimeKind.Local).AddTicks(2231), true, "task1" });

            migrationBuilder.InsertData(
                table: "UserTasks",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DueDate", "IsCompleted", "TaskName" },
                values: new object[] { 2, "System", new DateTime(2023, 2, 13, 18, 13, 1, 564, DateTimeKind.Local).AddTicks(3013), new DateTime(2023, 2, 13, 18, 13, 1, 564, DateTimeKind.Local).AddTicks(3018), false, "task2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserTasks",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
