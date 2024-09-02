using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResumeAppApi.Infrustructre.Migrations
{
    /// <inheritdoc />
    public partial class ChangeInformationAboutMaxLength : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "About",
                table: "Informations",
                type: "varchar(3500)",
                maxLength: 3500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(750)",
                oldMaxLength: 750);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "About",
                table: "Informations",
                type: "varchar(750)",
                maxLength: 750,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(3500)",
                oldMaxLength: 3500);
        }
    }
}
