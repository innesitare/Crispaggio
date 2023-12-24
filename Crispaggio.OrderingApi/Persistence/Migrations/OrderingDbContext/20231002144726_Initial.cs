#nullable disable

using Microsoft.EntityFrameworkCore.Migrations;

namespace Crispaggio.OrderingApi.Persistence.Migrations.OrderingDbContext
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", unicode: false, nullable: false),
                    PartyGroupId = table.Column<Guid>(type: "uuid", unicode: false, nullable: false),
                    Username = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "character varying(50)", unicode: false, maxLength: 50, nullable: false),
                    PhotoUrl = table.Column<string>(type: "text", unicode: false, nullable: false),
                    LoyaltyPoints = table.Column<int>(type: "integer", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DeliveryAddresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uuid", nullable: false),
                    Postcode = table.Column<string>(type: "text", nullable: false),
                    HouseNumber = table.Column<string>(type: "text", nullable: false),
                    UnitNumber = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeliveryAddresses_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", unicode: false, nullable: false),
                    CustomerId = table.Column<Guid>(type: "uuid", unicode: false, nullable: false),
                    OrderStatus = table.Column<int>(type: "integer", nullable: false),
                    DeliveryAddressId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_DeliveryAddresses_DeliveryAddressId",
                        column: x => x.DeliveryAddressId,
                        principalTable: "DeliveryAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Image = table.Column<byte[]>(type: "bytea", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    Rating = table.Column<double>(type: "double precision", nullable: false),
                    OrderId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Topic",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    OrderItemId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Topic_OrderItem_OrderItemId",
                        column: x => x.OrderItemId,
                        principalTable: "OrderItem",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CustomerId",
                table: "Customers",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryAddresses_CustomerId",
                table: "DeliveryAddresses",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DeliveryAddressId",
                table: "Orders",
                column: "DeliveryAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Topic_OrderItemId",
                table: "Topic",
                column: "OrderItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Topic");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "DeliveryAddresses");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
