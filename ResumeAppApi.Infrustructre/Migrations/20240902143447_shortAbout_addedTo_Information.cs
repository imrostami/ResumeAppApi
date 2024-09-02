using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResumeAppApi.Infrustructre.Migrations
{
    /// <inheritdoc />
    public partial class shortAbout_addedTo_Information : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShortAbout",
                table: "Informations",
                type: "varchar(130)",
                maxLength: 130,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShortAbout",
                table: "Informations");
        }
    }
}
