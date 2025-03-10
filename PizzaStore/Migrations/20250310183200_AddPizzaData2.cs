using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PizzaStore.Migrations
{
    /// <inheritdoc />
    public partial class AddPizzaData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pizzas",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 3, "BBQ Chicken Pizza with onions and cilantro", "BBQ Chicken" },
                    { 4, "Pizza with ham and pineapple", "Hawaiian" },
                    { 5, "Vegetarian Pizza with bell peppers, olives, and mushrooms", "Veggie" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pizzas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
