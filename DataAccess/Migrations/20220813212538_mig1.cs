using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TcNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlateNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApartmentInformations",
                columns: table => new
                {
                    ApartmentInformationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlockNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApartmentType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    ApartmentNo = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApartmentInformations", x => x.ApartmentInformationId);
                    table.ForeignKey(
                        name: "FK_ApartmentInformations_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MessageStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageID);
                    table.ForeignKey(
                        name: "FK_Messages_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BillOrders",
                columns: table => new
                {
                    BillOrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    LastPaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApartmentInformationId = table.Column<int>(type: "int", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillOrders", x => x.BillOrderId);
                    table.ForeignKey(
                        name: "FK_BillOrders_ApartmentInformations_ApartmentInformationId",
                        column: x => x.ApartmentInformationId,
                        principalTable: "ApartmentInformations",
                        principalColumn: "ApartmentInformationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ApartmentInformations",
                columns: new[] { "ApartmentInformationId", "ApartmentNo", "ApartmentType", "AppUserId", "BlockNo", "Floor" },
                values: new object[,]
                {
                    { 1, 1, "3+1", null, "A", 1 },
                    { 19, 9, "4+1", null, "B", 5 },
                    { 18, 8, "4+1", null, "B", 4 },
                    { 17, 7, "4+1", null, "B", 4 },
                    { 16, 6, "4+1", null, "B", 3 },
                    { 15, 5, "4+1", null, "B", 3 },
                    { 14, 4, "4+1", null, "B", 2 },
                    { 13, 3, "4+1", null, "B", 2 },
                    { 12, 2, "4+1", null, "B", 1 },
                    { 20, 10, "4+1", null, "B", 5 },
                    { 11, 1, "4+1", null, "B", 1 },
                    { 9, 9, "3+1", null, "A", 5 },
                    { 8, 8, "3+1", null, "A", 4 },
                    { 7, 7, "3+1", null, "A", 4 },
                    { 6, 6, "3+1", null, "A", 3 },
                    { 5, 5, "3+1", null, "A", 3 },
                    { 4, 4, "3+1", null, "A", 2 },
                    { 3, 3, "3+1", null, "A", 2 },
                    { 2, 2, "3+1", null, "A", 1 },
                    { 10, 10, "3+1", null, "A", 5 }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 1, "914ebd0b-3055-47c5-ab2b-f3143d17d389", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "BillOrders",
                columns: new[] { "BillOrderId", "ApartmentInformationId", "LastPaymentDate", "Name", "PaymentDate", "Price" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aidat", null, 100.0 },
                    { 12, 12, new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aidat", null, 100.0 },
                    { 32, 12, new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Su", null, 25.0 },
                    { 13, 13, new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aidat", null, 100.0 },
                    { 33, 13, new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Su", null, 25.0 },
                    { 14, 14, new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aidat", null, 100.0 },
                    { 34, 14, new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Su", null, 25.0 },
                    { 15, 15, new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aidat", null, 100.0 },
                    { 31, 11, new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Su", null, 25.0 },
                    { 35, 15, new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Su", null, 25.0 },
                    { 36, 16, new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Su", null, 25.0 },
                    { 17, 17, new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aidat", null, 100.0 },
                    { 37, 17, new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Su", null, 25.0 },
                    { 18, 18, new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aidat", null, 100.0 },
                    { 38, 18, new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Su", null, 25.0 },
                    { 19, 19, new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aidat", null, 100.0 },
                    { 39, 19, new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Su", null, 25.0 },
                    { 16, 16, new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aidat", null, 100.0 },
                    { 11, 11, new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aidat", null, 100.0 },
                    { 30, 10, new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Su", null, 25.0 },
                    { 10, 10, new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aidat", null, 100.0 },
                    { 21, 1, new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Su", null, 25.0 },
                    { 2, 2, new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aidat", null, 100.0 },
                    { 22, 2, new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Su", null, 25.0 },
                    { 3, 3, new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aidat", null, 100.0 },
                    { 23, 3, new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Su", null, 25.0 },
                    { 4, 4, new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aidat", null, 100.0 },
                    { 24, 4, new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Su", null, 25.0 },
                    { 5, 5, new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aidat", null, 100.0 },
                    { 25, 5, new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Su", null, 25.0 },
                    { 6, 6, new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aidat", null, 100.0 },
                    { 26, 6, new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Su", null, 25.0 },
                    { 7, 7, new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aidat", null, 100.0 },
                    { 27, 7, new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Su", null, 25.0 },
                    { 8, 8, new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aidat", null, 100.0 },
                    { 28, 8, new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Su", null, 25.0 },
                    { 9, 9, new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aidat", null, 100.0 },
                    { 29, 9, new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Su", null, 25.0 },
                    { 20, 20, new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aidat", null, 100.0 },
                    { 40, 20, new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Su", null, 25.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApartmentInformations_AppUserId",
                table: "ApartmentInformations",
                column: "AppUserId",
                unique: true,
                filter: "[AppUserId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BillOrders_ApartmentInformationId",
                table: "BillOrders",
                column: "ApartmentInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_AppUserId",
                table: "Messages",
                column: "AppUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BillOrders");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "ApartmentInformations");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
