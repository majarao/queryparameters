using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QueryParameters.Migrations
{
    /// <inheritdoc />
    public partial class Start : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Category 1" },
                    { 2, "Category 2" },
                    { 3, "Category 3" },
                    { 4, "Category 4" },
                    { 5, "Category 5" },
                    { 6, "Category 6" },
                    { 7, "Category 7" },
                    { 8, "Category 8" },
                    { 9, "Category 9" },
                    { 10, "Category 10" },
                    { 11, "Category 11" },
                    { 12, "Category 12" },
                    { 13, "Category 13" },
                    { 14, "Category 14" },
                    { 15, "Category 15" },
                    { 16, "Category 16" },
                    { 17, "Category 17" },
                    { 18, "Category 18" },
                    { 19, "Category 19" },
                    { 20, "Category 20" },
                    { 21, "Category 21" },
                    { 22, "Category 22" },
                    { 23, "Category 23" },
                    { 24, "Category 24" },
                    { 25, "Category 25" },
                    { 26, "Category 26" },
                    { 27, "Category 27" },
                    { 28, "Category 28" },
                    { 29, "Category 29" },
                    { 30, "Category 30" },
                    { 31, "Category 31" },
                    { 32, "Category 32" },
                    { 33, "Category 33" },
                    { 34, "Category 34" },
                    { 35, "Category 35" },
                    { 36, "Category 36" },
                    { 37, "Category 37" },
                    { 38, "Category 38" },
                    { 39, "Category 39" },
                    { 40, "Category 40" },
                    { 41, "Category 41" },
                    { 42, "Category 42" },
                    { 43, "Category 43" },
                    { 44, "Category 44" },
                    { 45, "Category 45" },
                    { 46, "Category 46" },
                    { 47, "Category 47" },
                    { 48, "Category 48" },
                    { 49, "Category 49" },
                    { 50, "Category 50" },
                    { 51, "Category 51" },
                    { 52, "Category 52" },
                    { 53, "Category 53" },
                    { 54, "Category 54" },
                    { 55, "Category 55" },
                    { 56, "Category 56" },
                    { 57, "Category 57" },
                    { 58, "Category 58" },
                    { 59, "Category 59" },
                    { 60, "Category 60" },
                    { 61, "Category 61" },
                    { 62, "Category 62" },
                    { 63, "Category 63" },
                    { 64, "Category 64" },
                    { 65, "Category 65" },
                    { 66, "Category 66" },
                    { 67, "Category 67" },
                    { 68, "Category 68" },
                    { 69, "Category 69" },
                    { 70, "Category 70" },
                    { 71, "Category 71" },
                    { 72, "Category 72" },
                    { 73, "Category 73" },
                    { 74, "Category 74" },
                    { 75, "Category 75" },
                    { 76, "Category 76" },
                    { 77, "Category 77" },
                    { 78, "Category 78" },
                    { 79, "Category 79" },
                    { 80, "Category 80" },
                    { 81, "Category 81" },
                    { 82, "Category 82" },
                    { 83, "Category 83" },
                    { 84, "Category 84" },
                    { 85, "Category 85" },
                    { 86, "Category 86" },
                    { 87, "Category 87" },
                    { 88, "Category 88" },
                    { 89, "Category 89" },
                    { 90, "Category 90" },
                    { 91, "Category 91" },
                    { 92, "Category 92" },
                    { 93, "Category 93" },
                    { 94, "Category 94" },
                    { 95, "Category 95" },
                    { 96, "Category 96" },
                    { 97, "Category 97" },
                    { 98, "Category 98" },
                    { 99, "Category 99" },
                    { 100, "Category 100" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
