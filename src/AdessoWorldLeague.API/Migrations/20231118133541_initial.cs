using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AdessoWorldLeague.API.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DrawResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DrawnBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrawResults", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DrawResultId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamResults", x => new { x.DrawResultId, x.Id });
                    table.ForeignKey(
                        name: "FK_TeamResults_DrawResults_DrawResultId",
                        column: x => x.DrawResultId,
                        principalTable: "DrawResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "teams",
                columns: new[] { "Id", "Country", "Name" },
                values: new object[,]
                {
                    { 1, "Turkiye", "Adesso Istanbul" },
                    { 2, "Turkiye", "Adesso Ankara" },
                    { 3, "Turkiye", "Adesso Izmir" },
                    { 4, "Turkiye", "Adesso Antalya" },
                    { 5, "Almanya", "Adesso Berlin" },
                    { 6, "Almanya", "Adesso Frankfurt" },
                    { 7, "Almanya", "Adesso Munih" },
                    { 8, "Almanya", "Adesso Dortmund" },
                    { 9, "Fransa", "Adesso Paris" },
                    { 10, "Fransa", "Adesso Marsilya" },
                    { 11, "Fransa", "Adesso Lyon" },
                    { 12, "Fransa", "Adesso Nice" },
                    { 13, "Hollanda", "Adesso Amsterdam" },
                    { 14, "Hollanda", "Adesso Rotterdam" },
                    { 15, "Hollanda", "Adesso Lahey" },
                    { 16, "Hollanda", "Adesso Eindhoven" },
                    { 17, "Portekiz", "Adesso Lisbon" },
                    { 18, "Portekiz", "Adesso Porto" },
                    { 19, "Portekiz", "Adesso Braga" },
                    { 20, "Portekiz", "Adesso Coimbra" },
                    { 21, "Italya", "Adesso Roma" },
                    { 22, "Italya", "Adesso Milano" },
                    { 23, "Italya", "Adesso Venedik" },
                    { 24, "Italya", "Adesso Napoli" },
                    { 25, "Ispanya", "Adesso Madrid" },
                    { 26, "Ispanya", "Adesso Barselona" },
                    { 27, "Ispanya", "Adesso Sevilla" },
                    { 28, "Ispanya", "Adesso Granada" },
                    { 29, "Belcika", "Adesso Bruksel" },
                    { 30, "Belcika", "Adesso Brugge" },
                    { 31, "Belcika", "Adesso Gent" },
                    { 32, "Belcika", "Adesso Anvers" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeamResults");

            migrationBuilder.DropTable(
                name: "teams");

            migrationBuilder.DropTable(
                name: "DrawResults");
        }
    }
}
