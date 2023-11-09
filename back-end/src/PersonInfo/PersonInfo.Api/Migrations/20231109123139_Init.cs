using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PersonInfo.Api.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SectorId = table.Column<int>(type: "int", nullable: false),
                    AgreeToTerms = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sectors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sectors_Sectors_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Sectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "Sectors",
                columns: new[] { "Id", "Name", "ParentId" },
                values: new object[,]
                {
                    { -1, "Select Sector", -1 },
                    { 1, "Manufacturing", -1 },
                    { 61, "Other", -1 },
                    { 65, "Service", -1 },
                    { 2, "Construction materials", 1 },
                    { 3, "Electronics and Optics", 1 },
                    { 4, "Food and Beverage", 1 },
                    { 12, "Furniture", 1 },
                    { 22, "Machinery", 1 },
                    { 33, "Metalworking", 1 },
                    { 42, "Plastic and Rubber", 1 },
                    { 50, "Printing", 1 },
                    { 54, "Textile and Clothing", 1 },
                    { 57, "Wood", 1 },
                    { 62, "Creative industries", 61 },
                    { 63, "Energy technology", 61 },
                    { 64, "Environment", 61 },
                    { 66, "Business services", 65 },
                    { 67, "Engineering", 65 },
                    { 68, "Information Technology and Telecommunications", 65 },
                    { 73, "Tourism", 65 },
                    { 74, "Translation services", 65 },
                    { 75, "Transport and Logistics", 65 },
                    { 5, "Bakery & confectionery products", 4 },
                    { 6, "Beverages", 4 },
                    { 7, "Fish & fish products", 4 },
                    { 8, "Meat & meat products", 4 },
                    { 9, "Milk & dairy products", 4 },
                    { 10, "Other", 4 },
                    { 11, "Sweets & snack food", 4 },
                    { 13, "Bathroom/sauna", 12 },
                    { 14, "Bedroom", 12 },
                    { 15, "Children's room", 12 },
                    { 16, "Kitchen", 12 },
                    { 17, "Living room", 12 },
                    { 18, "Office", 12 },
                    { 19, "Other (Furniture)", 12 },
                    { 20, "Outdoor", 12 },
                    { 21, "Project furniture", 12 },
                    { 23, "Machinery components", 22 },
                    { 24, "Machinery equipment/tools", 22 },
                    { 25, "Manufacture of machinery", 22 },
                    { 26, "Maritime", 22 },
                    { 30, "Metal structures", 22 },
                    { 31, "Other", 22 },
                    { 32, "Repair and maintenance service", 22 },
                    { 34, "Construction of metal structures", 33 },
                    { 35, "Houses and buildings", 33 },
                    { 36, "Metal products", 33 },
                    { 37, "Metal works", 33 },
                    { 43, "Packaging", 42 },
                    { 44, "Plastic goods", 42 },
                    { 45, "Plastic processing technology", 42 },
                    { 49, "Plastic profiles", 42 },
                    { 51, "Advertising", 50 },
                    { 52, "Book/Periodicals printing", 50 },
                    { 53, "Labelling and packaging printing", 50 },
                    { 55, "Clothing", 54 },
                    { 56, "Textile", 54 },
                    { 58, "Other (Wood)", 57 },
                    { 59, "Wooden building materials", 57 },
                    { 60, "Wooden houses", 57 },
                    { 69, "Data processing, Web portals, E-marketing", 68 },
                    { 70, "Programming, Consultancy", 68 },
                    { 71, "Software, Hardware", 68 },
                    { 72, "Telecommunications", 68 },
                    { 76, "Air", 75 },
                    { 77, "Rail", 75 },
                    { 78, "Road", 75 },
                    { 79, "Water", 75 },
                    { 27, "Aluminium and steel workboats", 26 },
                    { 28, "Boat/Yacht building", 26 },
                    { 29, "Ship repair and conversion", 26 },
                    { 38, "CNC-machining", 37 },
                    { 39, "Forgings, Fasteners", 37 },
                    { 40, "Gas, Plasma, Laser cutting", 37 },
                    { 41, "MIG, TIG, Aluminum welding", 37 },
                    { 46, "Blowing", 45 },
                    { 47, "Moulding", 45 },
                    { 48, "Plastics welding and processing", 45 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sectors_ParentId",
                table: "Sectors",
                column: "ParentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Sectors");
        }
    }
}
