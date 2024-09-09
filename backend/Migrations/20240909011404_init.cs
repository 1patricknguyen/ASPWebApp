using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "groceryList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_groceryList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "groceryItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    groceryListId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_groceryItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_groceryItem_groceryList_groceryListId",
                        column: x => x.groceryListId,
                        principalTable: "groceryList",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_groceryItem_groceryListId",
                table: "groceryItem",
                column: "groceryListId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "groceryItem");

            migrationBuilder.DropTable(
                name: "groceryList");
        }
    }
}
