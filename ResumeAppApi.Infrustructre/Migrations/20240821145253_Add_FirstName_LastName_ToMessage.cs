using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResumeAppApi.Infrustructre.Migrations
{
    /// <inheritdoc />
    public partial class Add_FirstName_LastName_ToMessage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SenderFirstName",
                table: "Messages",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "SenderLastName",
                table: "Messages",
                type: "longtext",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SenderFirstName",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "SenderLastName",
                table: "Messages");
        }
    }
}
