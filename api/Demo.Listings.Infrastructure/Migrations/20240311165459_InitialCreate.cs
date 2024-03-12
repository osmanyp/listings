using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Demo.Listings.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Listings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Bathrooms = table.Column<int>(type: "INTEGER", nullable: false),
                    HalfBathrooms = table.Column<int>(type: "INTEGER", nullable: false),
                    Bedrooms = table.Column<int>(type: "INTEGER", nullable: false),
                    YearBuilt = table.Column<int>(type: "INTEGER", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    PhotoUrl = table.Column<string>(type: "TEXT", nullable: true),
                    Latitude = table.Column<double>(type: "REAL", nullable: true),
                    Longitude = table.Column<double>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Listings", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Listings",
                columns: new[] { "Id", "Address", "Bathrooms", "Bedrooms", "HalfBathrooms", "Latitude", "Longitude", "PhotoUrl", "Price", "YearBuilt" },
                values: new object[,]
                {
                    { 1, "04235 Hancock Glens, South Brettmouth, CT 68377", 4, 4, 1, -40.071434000000004, 5.7012020000000003, "https://example.com/photo1", 565231m, 2004 },
                    { 2, "42798 Nichole Branch Apt. 244, Port Philip, IN 72942", 2, 1, 2, 88.519002, 44.788677, "https://example.com/photo2", 127932m, 1907 },
                    { 3, "79361 Salas Unions Apt. 294, Sherrihaven, MA 67529", 3, 2, 0, 56.307156999999997, -10.128527, "https://example.com/photo3", 957331m, 1938 },
                    { 4, "6305 David Cliff, South Frank, DE 53924", 4, 5, 3, -15.923049000000001, -93.900028000000006, "https://example.com/photo4", 637492m, 1900 },
                    { 5, "84954 Johnson Camp Suite 156, South Carol, ND 86459", 4, 1, 1, -19.518991, -8.7739170000000009, "https://example.com/photo5", 971216m, 1917 },
                    { 6, "USNV Morgan, FPO AE 70370", 3, 3, 3, -30.447462999999999, 17.217974999999999, "https://example.com/photo6", 697592m, 1997 },
                    { 7, "73514 Mann Estate, Paulaburgh, IL 74054", 5, 5, 0, -16.127953000000002, -154.46768800000001, "https://example.com/photo7", 434863m, 2003 },
                    { 20, "PSC 2644, Box 4674, APO AE 52772", 4, 1, 2, -24.571092, 48.948146000000001, "https://example.com/photo20", 350412m, 1942 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Listings");
        }
    }
}
