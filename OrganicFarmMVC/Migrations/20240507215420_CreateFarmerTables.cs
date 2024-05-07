using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrganicFarmMVC.Migrations
{
    /// <inheritdoc />
    public partial class CreateFarmerTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Farmers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstagramLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FacebookLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinkedinLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    XLink = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Farmers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Farmers");
        }
    }
}
