using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Order_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductCategory = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_Details", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personal_Details",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personal_Details", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Delivery_Detils",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AgentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgentNumber = table.Column<int>(type: "int", nullable: false),
                    OrderDetailsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Delivery_Detils", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Delivery_Detils_Order_Details_OrderDetailsId",
                        column: x => x.OrderDetailsId,
                        principalTable: "Order_Details",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Delivery_Detils_OrderDetailsId",
                table: "Delivery_Detils",
                column: "OrderDetailsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Delivery_Detils");

            migrationBuilder.DropTable(
                name: "Personal_Details");

            migrationBuilder.DropTable(
                name: "Order_Details");
        }
    }
}
