using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Last.Data.Migrations
{
    /// <inheritdoc />
    public partial class addprojecte : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Project_ProjectId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Project");

            migrationBuilder.RenameColumn(
                name: "ResolvedDate",
                table: "Ticket",
                newName: "UserId1");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Ticket",
                newName: "TicketId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Project",
                newName: "ProjectId");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Ticket",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "Ticket",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<DateTime>(
                name: "ClosedAt",
                table: "Ticket",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Ticket",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Priority",
                table: "Ticket",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Ticket",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Ticket",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Project",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "TEXT",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_UserId1",
                table: "Ticket",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ProjectId",
                table: "AspNetUsers",
                column: "ProjectId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Project_ProjectId",
                table: "AspNetUsers",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_AspNetUsers_UserId1",
                table: "Ticket",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Project_ProjectId",
                table: "Ticket",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "ProjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Project_ProjectId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_AspNetUsers_UserId1",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Project_ProjectId",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_UserId1",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ProjectId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ClosedAt",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "Priority",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "UserId1",
                table: "Ticket",
                newName: "ResolvedDate");

            migrationBuilder.RenameColumn(
                name: "TicketId",
                table: "Ticket",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "Project",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Ticket",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "Ticket",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Ticket",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Ticket",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Project",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Project",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Project",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Project",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Project_ProjectId",
                table: "Ticket",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
