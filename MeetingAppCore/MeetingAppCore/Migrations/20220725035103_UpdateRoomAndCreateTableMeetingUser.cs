using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MeetingAppCore.Migrations
{
    public partial class UpdateRoomAndCreateTableMeetingUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MeetingFile",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MeetingNote",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MeetingPlaceId",
                table: "Rooms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeMeeting",
                table: "Rooms",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TimeRange",
                table: "Rooms",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MeetingFile",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "MeetingNote",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "MeetingPlaceId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "TimeMeeting",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "TimeRange",
                table: "Rooms");
        }
    }
}
