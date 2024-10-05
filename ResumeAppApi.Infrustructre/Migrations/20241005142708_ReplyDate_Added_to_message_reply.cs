using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResumeAppApi.Infrustructre.Migrations
{
    /// <inheritdoc />
    public partial class ReplyDate_Added_to_message_reply : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ReplyDate",
                table: "MessageReplies",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReplyDate",
                table: "MessageReplies");
        }
    }
}
