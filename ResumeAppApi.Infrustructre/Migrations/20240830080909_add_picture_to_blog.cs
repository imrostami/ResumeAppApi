using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResumeAppApi.Infrustructre.Migrations
{
    /// <inheritdoc />
    public partial class add_picture_to_blog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Picture",
                table: "Articles",
                type: "longtext",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "PircutrAlt",
                table: "Articles",
                type: "longtext",
                nullable: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "PircutrAlt",
                table: "Articles");
        }
    }
}
