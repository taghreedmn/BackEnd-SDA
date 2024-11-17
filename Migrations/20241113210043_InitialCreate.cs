using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:Enum:person_type", "person,system_admin,store_employee,customer");

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    CategoryName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Console",
                columns: table => new
                {
                    GameConsoleId = table.Column<Guid>(type: "uuid", nullable: false),
                    ConsoleName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Console", x => x.GameConsoleId);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    PaymentId = table.Column<Guid>(type: "uuid", nullable: false),
                    PaymentMethod = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.PaymentId);
                });

            migrationBuilder.CreateTable(
                name: "PersonIdCounters",
                columns: table => new
                {
                    PersonIdCounterId = table.Column<int>(type: "integer", nullable: false),
                    CurrentId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonIdCounters", x => x.PersonIdCounterId);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonName = table.Column<string>(type: "text", nullable: false),
                    PersonEmail = table.Column<string>(type: "text", nullable: false),
                    PersonPassword = table.Column<string>(type: "text", nullable: false),
                    PersonPhoneNumber = table.Column<string>(type: "text", nullable: true),
                    ProfilePicturePath = table.Column<string>(type: "text", nullable: true),
                    salt = table.Column<byte[]>(type: "bytea", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "Publisher",
                columns: table => new
                {
                    PublisherId = table.Column<Guid>(type: "uuid", nullable: false),
                    PublisherName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    PublisherEmail = table.Column<string>(type: "text", nullable: false),
                    PublisherPicturePath = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publisher", x => x.PublisherId);
                });

            migrationBuilder.CreateTable(
                name: "Store",
                columns: table => new
                {
                    StoreId = table.Column<Guid>(type: "uuid", nullable: false),
                    WorkHours = table.Column<int>(type: "integer", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.StoreId);
                });

            migrationBuilder.CreateTable(
                name: "Studio",
                columns: table => new
                {
                    GameStudioId = table.Column<Guid>(type: "uuid", nullable: false),
                    StudioName = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    StudioPicturePath = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studio", x => x.GameStudioId);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    SupplierId = table.Column<Guid>(type: "uuid", nullable: false),
                    SupplierName = table.Column<string>(type: "text", nullable: true),
                    SupplierBankInfo = table.Column<string>(type: "text", nullable: true),
                    SupplierContactInfo = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.SupplierId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "integer", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_Customers_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SystemAdmins",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "integer", nullable: false),
                    ManageStores = table.Column<bool>(type: "boolean", nullable: false),
                    ManageEmployees = table.Column<bool>(type: "boolean", nullable: false),
                    ManageGames = table.Column<bool>(type: "boolean", nullable: false),
                    ManageCustomers = table.Column<bool>(type: "boolean", nullable: false),
                    ManageSystemAdmins = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemAdmins", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_SystemAdmins_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VideoGameInfo",
                columns: table => new
                {
                    VideoGameInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    GameName = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    YearOfRelease = table.Column<string>(type: "text", nullable: true),
                    TotalRating = table.Column<int>(type: "integer", nullable: false),
                    PublisherId = table.Column<Guid>(type: "uuid", nullable: false),
                    GamePicturePath = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoGameInfo", x => x.VideoGameInfoId);
                    table.ForeignKey(
                        name: "FK_VideoGameInfo_Publisher_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publisher",
                        principalColumn: "PublisherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StoreEmployees",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "integer", nullable: false),
                    Role = table.Column<string>(type: "text", nullable: false),
                    Salary = table.Column<float>(type: "real", nullable: false),
                    YearsOfService = table.Column<int>(type: "integer", nullable: false),
                    StoreId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreEmployees", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_StoreEmployees_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoreEmployees_Store_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Store",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryVideoGameInfo",
                columns: table => new
                {
                    CategoriesCategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    VideoGameInfosVideoGameInfoId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryVideoGameInfo", x => new { x.CategoriesCategoryId, x.VideoGameInfosVideoGameInfoId });
                    table.ForeignKey(
                        name: "FK_CategoryVideoGameInfo_Category_CategoriesCategoryId",
                        column: x => x.CategoriesCategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryVideoGameInfo_VideoGameInfo_VideoGameInfosVideoGame~",
                        column: x => x.VideoGameInfosVideoGameInfoId,
                        principalTable: "VideoGameInfo",
                        principalColumn: "VideoGameInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GameStudioVideoGameInfo",
                columns: table => new
                {
                    GameStudiosGameStudioId = table.Column<Guid>(type: "uuid", nullable: false),
                    VideoGamesVideoGameInfoId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameStudioVideoGameInfo", x => new { x.GameStudiosGameStudioId, x.VideoGamesVideoGameInfoId });
                    table.ForeignKey(
                        name: "FK_GameStudioVideoGameInfo_Studio_GameStudiosGameStudioId",
                        column: x => x.GameStudiosGameStudioId,
                        principalTable: "Studio",
                        principalColumn: "GameStudioId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameStudioVideoGameInfo_VideoGameInfo_VideoGamesVideoGameIn~",
                        column: x => x.VideoGamesVideoGameInfoId,
                        principalTable: "VideoGameInfo",
                        principalColumn: "VideoGameInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RatedBy",
                columns: table => new
                {
                    RatedById = table.Column<Guid>(type: "uuid", nullable: false),
                    Rating = table.Column<float>(type: "real", nullable: false),
                    Comment = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    VideoGameInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    PersonId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RatedBy", x => x.RatedById);
                    table.ForeignKey(
                        name: "FK_RatedBy_Customers_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Customers",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RatedBy_VideoGameInfo_VideoGameInfoId",
                        column: x => x.VideoGameInfoId,
                        principalTable: "VideoGameInfo",
                        principalColumn: "VideoGameInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VideoGameVersion",
                columns: table => new
                {
                    VideoGameVersionId = table.Column<Guid>(type: "uuid", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    VideoGameInfoId = table.Column<Guid>(type: "uuid", nullable: false),
                    GameConsoleId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoGameVersion", x => x.VideoGameVersionId);
                    table.ForeignKey(
                        name: "FK_VideoGameVersion_Console_GameConsoleId",
                        column: x => x.GameConsoleId,
                        principalTable: "Console",
                        principalColumn: "GameConsoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VideoGameVersion_VideoGameInfo_VideoGameInfoId",
                        column: x => x.VideoGameInfoId,
                        principalTable: "VideoGameInfo",
                        principalColumn: "VideoGameInfoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "uuid", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    TotalPrice = table.Column<float>(type: "real", nullable: false),
                    PaymentId = table.Column<Guid>(type: "uuid", nullable: false),
                    StoreId = table.Column<Guid>(type: "uuid", nullable: false),
                    EmployeeId = table.Column<int>(type: "integer", nullable: false),
                    CustomerId = table.Column<int>(type: "integer", nullable: false),
                    StoreEmployeePersonId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Order_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Payment_PaymentId",
                        column: x => x.PaymentId,
                        principalTable: "Payment",
                        principalColumn: "PaymentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_StoreEmployees_StoreEmployeePersonId",
                        column: x => x.StoreEmployeePersonId,
                        principalTable: "StoreEmployees",
                        principalColumn: "PersonId");
                    table.ForeignKey(
                        name: "FK_Order_Store_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Store",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    VideoGameVersionId = table.Column<Guid>(type: "uuid", nullable: false),
                    StoreId = table.Column<Guid>(type: "uuid", nullable: false),
                    GameQuantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => new { x.StoreId, x.VideoGameVersionId });
                    table.ForeignKey(
                        name: "FK_Inventory_Store_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Store",
                        principalColumn: "StoreId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inventory_VideoGameVersion_VideoGameVersionId",
                        column: x => x.VideoGameVersionId,
                        principalTable: "VideoGameVersion",
                        principalColumn: "VideoGameVersionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderedGames",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OrderId = table.Column<Guid>(type: "uuid", nullable: false),
                    VideoGameVersionId = table.Column<Guid>(type: "uuid", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderedGames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderedGames_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderedGames_VideoGameVersion_VideoGameVersionId",
                        column: x => x.VideoGameVersionId,
                        principalTable: "VideoGameVersion",
                        principalColumn: "VideoGameVersionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Supply",
                columns: table => new
                {
                    SupplyId = table.Column<Guid>(type: "uuid", nullable: false),
                    SupplierId = table.Column<Guid>(type: "uuid", nullable: false),
                    VideoGameVersionId = table.Column<Guid>(type: "uuid", nullable: false),
                    InventoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    SupplyQuantity = table.Column<float>(type: "real", nullable: false),
                    SupplierDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    InventoryStoreId = table.Column<Guid>(type: "uuid", nullable: true),
                    InventoryVideoGameVersionId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supply", x => x.SupplyId);
                    table.ForeignKey(
                        name: "FK_Supply_Inventory_InventoryStoreId_InventoryVideoGameVersion~",
                        columns: x => new { x.InventoryStoreId, x.InventoryVideoGameVersionId },
                        principalTable: "Inventory",
                        principalColumns: new[] { "StoreId", "VideoGameVersionId" });
                    table.ForeignKey(
                        name: "FK_Supply_Supplier_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Supplier",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Supply_VideoGameVersion_VideoGameVersionId",
                        column: x => x.VideoGameVersionId,
                        principalTable: "VideoGameVersion",
                        principalColumn: "VideoGameVersionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { new Guid("0b387646-e3f1-4892-857c-b260a7113ca4"), "Racing" },
                    { new Guid("2e32f726-203b-4fa3-a960-3a2c1a275864"), "Action" },
                    { new Guid("4867a76e-ccc5-4470-a25a-dd1e91cbc87d"), "Adventure" },
                    { new Guid("fe93817b-e277-476d-a27f-7450a0fe72b2"), "simulation" }
                });

            migrationBuilder.InsertData(
                table: "Console",
                columns: new[] { "GameConsoleId", "ConsoleName" },
                values: new object[,]
                {
                    { new Guid("0268a1b4-571e-4962-90be-471f315c0497"), "GamerBox" },
                    { new Guid("2d952229-3668-48f3-88f5-4ddd9779524c"), "PC" },
                    { new Guid("36be9397-03a5-4dff-a2f2-1f7061faff98"), "FusionPlay" },
                    { new Guid("41c5f56f-7ebe-4f73-8298-04b3171e56a0"), "RetroCube" },
                    { new Guid("d31bda97-60bc-4cee-b564-daad86ad2ca6"), "Playstation" }
                });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "PaymentId", "PaymentMethod" },
                values: new object[,]
                {
                    { new Guid("4c02ee7d-5a8b-4dba-9df0-5d84aba66837"), "Cash on delivery" },
                    { new Guid("649bd2f6-fd7b-4af9-aaad-c30aae9d0f53"), "Mada" },
                    { new Guid("77965d61-af9f-41a5-a9df-fbe8e9386a2a"), "Apple Pay" },
                    { new Guid("93d71ec8-adfe-4b40-93ba-bc4a389e6393"), "Visa" }
                });

            migrationBuilder.InsertData(
                table: "PersonIdCounters",
                columns: new[] { "PersonIdCounterId", "CurrentId" },
                values: new object[,]
                {
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 4 }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "PersonId", "PersonEmail", "PersonName", "PersonPassword", "PersonPhoneNumber", "ProfilePicturePath", "salt" },
                values: new object[,]
                {
                    { 1, "Zayed1@mail.com", "Zayd Al-Nasser", "0E-31-5C-CE-A0-D8-57-D8-4A-D2-11-FC-EB-78-55-84-3E-D8-9D-F6-A7-D3-89-87-05-01-13-40-AC-BE-2E-6C", "+966503010080", "", new byte[] { 180, 28, 49, 63, 8, 88, 147, 233, 188, 50, 87, 164, 60, 228, 21, 3, 40, 92, 247, 213, 230, 245, 105, 166, 90, 0, 98, 81, 85, 54, 56, 172, 255, 101, 86, 162, 58, 145, 211, 87, 96, 86, 126, 222, 232, 196, 164, 228, 251, 215, 13, 216, 69, 162, 73, 79, 12, 72, 198, 222, 160, 33, 66, 113 } },
                    { 2, "Tariq2@mail.com", "Tariq Hassan", "23-56-56-BA-59-C9-E6-EF-57-1B-8A-EA-62-76-92-BB-66-DB-D0-B4-71-AA-5A-CA-ED-58-A6-57-95-31-46-51", "+966503011180", "", new byte[] { 52, 1, 79, 241, 139, 40, 176, 146, 31, 123, 235, 254, 95, 86, 103, 246, 60, 19, 65, 58, 239, 147, 8, 144, 81, 80, 170, 226, 110, 205, 84, 228, 161, 23, 231, 35, 198, 18, 225, 156, 12, 242, 245, 251, 110, 244, 168, 72, 72, 118, 161, 237, 252, 32, 204, 109, 62, 94, 225, 222, 20, 199, 59, 80 } },
                    { 3, "Sara3@mail.com", "Sara Al-Hassan", "AD-3E-A3-99-BF-43-51-F7-54-36-C9-1E-7F-2B-57-AC-FE-72-EE-28-4D-52-60-D7-D5-1A-E7-69-05-D9-B1-DB", "+966503017840", "", new byte[] { 29, 4, 190, 66, 143, 160, 18, 114, 235, 196, 231, 6, 187, 153, 36, 92, 83, 194, 123, 7, 93, 30, 6, 242, 189, 58, 115, 146, 90, 251, 136, 50, 125, 254, 51, 93, 136, 166, 191, 64, 200, 7, 5, 42, 8, 213, 49, 72, 124, 207, 129, 211, 160, 25, 194, 203, 35, 122, 234, 188, 27, 242, 198, 128 } },
                    { 1001, "employeeAhmed1@hotmail.com", "Ahmed Al-Farsi", "EE-95-77-11-F9-1B-6C-0C-31-A2-EA-11-38-C9-4B-C3-A9-1A-1D-40-47-65-A3-85-8B-2C-9C-0A-44-2B-20-7A", "+966500000005", "", new byte[] { 92, 121, 165, 107, 120, 205, 136, 195, 94, 146, 16, 159, 66, 164, 34, 179, 37, 213, 211, 60, 1, 179, 197, 180, 35, 207, 242, 123, 68, 100, 75, 20, 126, 15, 86, 104, 101, 91, 175, 72, 180, 70, 3, 38, 245, 161, 151, 178, 127, 173, 227, 87, 160, 80, 166, 179, 31, 39, 54, 166, 52, 191, 103, 165 } },
                    { 1002, "employeeOmer2@gmail.com", "Omar El-Mansour", "18-72-02-CB-65-5F-7D-F6-DD-51-41-EC-EF-5F-20-C6-83-4C-87-C1-4D-D6-49-2F-BE-8D-9E-01-96-04-AE-C1", "+966504071005", "", new byte[] { 151, 28, 124, 168, 204, 72, 237, 0, 140, 210, 112, 245, 86, 234, 229, 37, 138, 79, 30, 247, 194, 225, 52, 161, 38, 11, 219, 137, 59, 181, 25, 53, 101, 125, 127, 18, 216, 64, 156, 161, 241, 188, 102, 86, 22, 76, 239, 253, 133, 75, 74, 139, 27, 197, 241, 197, 109, 144, 87, 201, 118, 169, 185, 127 } },
                    { 1003, "employeeFatima3@gmail.com", "Fatima El-Amin", "8A-7E-46-B6-C0-E0-AD-AC-37-6E-BD-98-90-54-D9-03-98-25-65-80-46-05-45-16-C5-76-79-A3-9C-8E-CD-00", "+966504071006", "", new byte[] { 45, 185, 206, 190, 161, 200, 107, 50, 39, 17, 193, 136, 86, 10, 96, 24, 234, 93, 96, 196, 198, 112, 42, 108, 246, 74, 47, 27, 187, 37, 209, 21, 17, 219, 83, 81, 88, 194, 113, 228, 32, 62, 231, 38, 118, 79, 63, 141, 222, 52, 157, 96, 123, 155, 191, 100, 135, 112, 83, 195, 140, 14, 133, 221 } },
                    { 100001, "Miraaa1@gmail.com", "Mira Al-Sharif", "CD-57-43-8D-F5-BA-69-AB-78-EC-6D-D8-95-CD-77-F9-3A-C1-DC-8A-62-39-3E-04-C1-CC-7D-E7-C1-50-CF-81", "+966504071075", "", new byte[] { 239, 157, 242, 99, 244, 94, 8, 201, 31, 171, 228, 26, 21, 102, 51, 101, 205, 76, 161, 92, 215, 184, 232, 51, 154, 199, 85, 190, 20, 146, 186, 95, 158, 216, 42, 108, 73, 205, 237, 46, 248, 2, 165, 193, 197, 166, 58, 193, 217, 127, 103, 39, 171, 75, 213, 136, 71, 78, 239, 140, 78, 9, 175, 222 } },
                    { 100002, "NoorFarouq2@gmail.com", "Noor Al-Farouq", "6D-C4-D6-D7-11-E9-52-CF-D8-5C-01-BF-75-83-61-D2-7A-10-B2-17-4D-23-92-3F-A6-26-BC-4C-84-4A-DF-A5", "+966504060980", "", new byte[] { 221, 241, 218, 85, 83, 34, 195, 92, 103, 231, 169, 146, 111, 95, 113, 162, 179, 37, 190, 125, 144, 248, 255, 83, 112, 207, 67, 36, 74, 81, 109, 121, 225, 248, 86, 234, 182, 37, 57, 174, 101, 162, 118, 178, 231, 66, 196, 12, 185, 246, 244, 58, 186, 109, 180, 73, 128, 161, 56, 135, 151, 201, 188, 83 } },
                    { 100003, "Khalidd3@gmail.com", "Khalid Al-Jabari", "1D-C7-BB-C9-B9-C7-64-06-07-EA-98-86-E1-45-A4-27-94-71-DF-74-5C-DA-36-52-29-BB-1B-40-A5-AC-E8-F9", "+966503371005", "", new byte[] { 100, 130, 192, 243, 153, 84, 151, 201, 227, 71, 93, 42, 192, 64, 254, 53, 217, 82, 245, 157, 117, 249, 184, 142, 90, 65, 72, 102, 168, 227, 204, 128, 210, 208, 19, 199, 151, 177, 203, 39, 170, 194, 87, 219, 50, 204, 200, 150, 188, 206, 140, 78, 31, 211, 48, 21, 154, 207, 242, 225, 47, 122, 25, 46 } },
                    { 100004, "YasinOm4@gmail.com", "Yasin Al-Omari", "8F-2B-22-36-AC-72-FC-F5-ED-83-33-7E-42-9C-6E-2B-61-4B-D5-82-B7-A8-90-E7-D3-A1-36-BD-AB-0F-03-E1", "+966504471195", "", new byte[] { 110, 81, 34, 31, 111, 218, 200, 187, 78, 214, 119, 142, 237, 102, 0, 227, 94, 22, 212, 237, 131, 93, 210, 135, 247, 154, 93, 163, 19, 22, 180, 26, 63, 139, 60, 102, 0, 123, 128, 188, 126, 247, 45, 75, 190, 42, 222, 92, 141, 246, 3, 226, 161, 35, 8, 34, 127, 186, 3, 57, 182, 141, 53, 224 } }
                });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "PublisherEmail", "PublisherName", "PublisherPicturePath" },
                values: new object[,]
                {
                    { new Guid("12ba59b8-6c30-4864-9d48-0f95bd278b40"), "creators@us.square-enix.com", "Square Enix", "http://localhost:5125/images/Publishers/12ba59b8-6c30-4864-9d48-0f95bd278b40/12ba59b8-6c30-4864-9d48-0f95bd278b40.jpg" },
                    { new Guid("df5d8791-98b3-445d-8120-07b33695da10"), " help@codemasters.com", "Codemasters", "http://localhost:5125/images/Publishers/df5d8791-98b3-445d-8120-07b33695da10/df5d8791-98b3-445d-8120-07b33695da10.png" },
                    { new Guid("f5ea9a66-8a49-4f1f-ae5d-09ce38a7c80d"), " support@telltalegames.com", "Telltale Games", "http://localhost:5125/images/Publishers/f5ea9a66-8a49-4f1f-ae5d-09ce38a7c80d/f5ea9a66-8a49-4f1f-ae5d-09ce38a7c80d.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Store",
                columns: new[] { "StoreId", "Location", "WorkHours" },
                values: new object[,]
                {
                    { new Guid("06ed9de3-fd34-4b16-9c8c-150bb751c156"), "Jeddah", 40 },
                    { new Guid("b15664cd-da73-46bf-a47f-7be46fdd346a"), "Riyadh", 35 }
                });

            migrationBuilder.InsertData(
                table: "Studio",
                columns: new[] { "GameStudioId", "StudioName", "StudioPicturePath" },
                values: new object[,]
                {
                    { new Guid("0b4ad2e6-b78c-47a8-bf70-fb667cb7a138"), "Feral Interactive", "http://localhost:5125/images/Studios/0b4ad2e6-b78c-47a8-bf70-fb667cb7a138/0b4ad2e6-b78c-47a8-bf70-fb667cb7a138.png" },
                    { new Guid("5502bbf3-535e-4042-85b8-052b35594542"), "IO Interactive", "http://localhost:5125/images/Studios/5502bbf3-535e-4042-85b8-052b35594542/5502bbf3-535e-4042-85b8-052b35594542.jpg" },
                    { new Guid("646e4c3c-bfc2-41dc-9f49-14b7905516b8"), "Deck Nine Games", "http://localhost:5125/images/Studios/646e4c3c-bfc2-41dc-9f49-14b7905516b8/646e4c3c-bfc2-41dc-9f49-14b7905516b8.png" },
                    { new Guid("727cffb5-6ba3-4a56-a1eb-fe1962c8f044"), "Liquid Entertainment", "http://localhost:5125/images/Studios/727cffb5-6ba3-4a56-a1eb-fe1962c8f044/727cffb5-6ba3-4a56-a1eb-fe1962c8f044.jpg" },
                    { new Guid("86b47e62-089e-4f3e-b9c4-f29ea6720fd0"), "Crystal Dynamics", "http://localhost:5125/images/Studios/86b47e62-089e-4f3e-b9c4-f29ea6720fd0/86b47e62-089e-4f3e-b9c4-f29ea6720fd0.png" },
                    { new Guid("8720de28-1bf5-49ad-b272-ddfee747f22c"), "Telltale Games", "http://localhost:5125/images/Studios/8720de28-1bf5-49ad-b272-ddfee747f22c/8720de28-1bf5-49ad-b272-ddfee747f22c.jpg" },
                    { new Guid("9fc928ce-aa2a-4e7b-816d-b3468ea552ed"), "Blue Omega Entertainment", "http://localhost:5125/images/Studios/9fc928ce-aa2a-4e7b-816d-b3468ea552ed/9fc928ce-aa2a-4e7b-816d-b3468ea552ed.jpg" },
                    { new Guid("bbd8f143-d7e1-41ef-9702-9bfb27567b80"), "Codemaster", "http://localhost:5125/images/Studios/bbd8f143-d7e1-41ef-9702-9bfb27567b80/bbd8f143-d7e1-41ef-9702-9bfb27567b80.png" },
                    { new Guid("bfe21050-cd59-4feb-ab5e-459031e4b3f3"), "Avalanche Studios", "http://localhost:5125/images/Studios/bfe21050-cd59-4feb-ab5e-459031e4b3f3/bfe21050-cd59-4feb-ab5e-459031e4b3f3.png" },
                    { new Guid("cf04439e-6b5d-406f-b2e1-a5616a3aee8a"), "Skybound Entertainment", "http://localhost:5125/images/Studios/cf04439e-6b5d-406f-b2e1-a5616a3aee8a/cf04439e-6b5d-406f-b2e1-a5616a3aee8a.png" }
                });

            migrationBuilder.InsertData(
                table: "Supplier",
                columns: new[] { "SupplierId", "SupplierBankInfo", "SupplierContactInfo", "SupplierName" },
                values: new object[,]
                {
                    { new Guid("47c88b33-d1cb-4b2d-94b5-b6867c6d6639"), "Account No: 123456789", "contact@techsupplies.com, +966-800-555-0199", "Tech Supplies Co" },
                    { new Guid("8f851df0-b73d-49af-acb4-3f812b483430"), "Account No: 987654321", "support@gaminggoods.com, +966-800-555-0198", "Gaming Goods Ltd" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "PersonId", "Age" },
                values: new object[,]
                {
                    { 100001, 35 },
                    { 100002, 30 },
                    { 100003, 23 },
                    { 100004, 25 }
                });

            migrationBuilder.InsertData(
                table: "StoreEmployees",
                columns: new[] { "PersonId", "Role", "Salary", "StoreId", "YearsOfService" },
                values: new object[,]
                {
                    { 1001, "StoreEmployee", 4827f, new Guid("b15664cd-da73-46bf-a47f-7be46fdd346a"), 5 },
                    { 1002, "StoreEmployee", 12000f, new Guid("06ed9de3-fd34-4b16-9c8c-150bb751c156"), 8 },
                    { 1003, "StoreEmployee", 10000f, new Guid("b15664cd-da73-46bf-a47f-7be46fdd346a"), 6 }
                });

            migrationBuilder.InsertData(
                table: "SystemAdmins",
                columns: new[] { "PersonId", "ManageCustomers", "ManageEmployees", "ManageGames", "ManageStores", "ManageSystemAdmins" },
                values: new object[,]
                {
                    { 1, true, true, true, true, true },
                    { 2, true, false, true, false, false },
                    { 3, false, true, false, true, false }
                });

            migrationBuilder.InsertData(
                table: "VideoGameInfo",
                columns: new[] { "VideoGameInfoId", "Description", "GameName", "GamePicturePath", "PublisherId", "TotalRating", "YearOfRelease" },
                values: new object[,]
                {
                    { new Guid("007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23"), "The Walking Dead: Michonne - A Telltale Miniseries stars the iconic, blade-wielding character from Robert Kirkman's best-selling comic books. Haunted by her past, and coping with unimaginable loss and regret, the story explores Michonne's absence between issues #126 and #139 of the comic book. In this three part miniseries, players will discover what took Michonne away from Rick, Ezekiel, and the rest of her trusted group… and what brought her back.", "The Walking Dead: Michonne", "http://localhost:5125/images/Games/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23.jpg", new Guid("f5ea9a66-8a49-4f1f-ae5d-09ce38a7c80d"), 5, "Feb 22, 2016" },
                    { new Guid("02b0bb70-4fc8-4c72-86a7-731f4332b9a5"), "Operation Flashpoint: Red River is a tactical first-person shooter, set in the modern world. The game is a sequel to Operation Flashpoint: Dragon Rising, and overall a third game in the series.The game’s protagonists are a squad of four US Marine Corps soldiers,each with their unique skills and fighting capabilities.The main campaign focuses on a fictional conflict in the Middle East,featuring both single - player mode and cooperative multiplayer.The battles in Operation Flashpoint are unique in a way that the players will feel the battleground,facing a real threat of getting their platoon killed,therefore making them plan their every step and use the surroundings to ensure victory.While,the game lacks competitive multiplayer,due to its focus on realism and refined experience of a fast - paced military simulator,the cooperative experience will allow players to fully immerse themselves in what would seem like a real test of nerves,teamwork,and tactics.", "Operation Flashpoint: Red River", "http://localhost:5125/images/Games/02b0bb70-4fc8-4c72-86a7-731f4332b9a5/02b0bb70-4fc8-4c72-86a7-731f4332b9a5.jpg", new Guid("df5d8791-98b3-445d-8120-07b33695da10"), 5, "Apr 19, 2011" },
                    { new Guid("0ce33067-7091-4c51-a1c4-3a93751c748c"), "Playing poker is good in itself and as an occasion for live communication, a disclosure of communicative talents, a great way to spend time with friends. Especially if these friends know how to play and have fun playing.This poker simulator allows you to spend time in a beautiful company.The game lets you play with Sam(Sam & Max franchise),assisted by Max,Brock Samson(The Venture Bros.),Ash Williams(The Evil Dead) and Claptrap(Borderlands).The dealer of the game is GLaDOS(Portal series). Some other popular characters take part as additional characters or cameos.All players start the game with the same amount of in-game money,the goal is to win the money of other players.The game can be played in Texas hold 'em style or in Omaha hold' em.", "Poker Night 2", "http://localhost:5125/images/Games/0ce33067-7091-4c51-a1c4-3a93751c748c/0ce33067-7091-4c51-a1c4-3a93751c748c.jpg", new Guid("f5ea9a66-8a49-4f1f-ae5d-09ce38a7c80d"), 5, "Apr 24, 2013" },
                    { new Guid("338b764e-b0f1-4969-89c8-164ca308e226"), "The Walking Dead: Michonne - Episode 2: Give No Shelter is an adventure game developed by Skybound. It came out on 29-03-2016. It was published by Telltale Games. Most rawgers rated the game as 'Recommended'. The Walking Dead: Michonne - Episode 2: Give No Shelter is available on PC and PlayStation 3.", "The Walking Dead: Michonne - Episode 2: Give No Shelter", "http://localhost:5125/images/Games/338b764e-b0f1-4969-89c8-164ca308e226/338b764e-b0f1-4969-89c8-164ca308e226.jpg", new Guid("f5ea9a66-8a49-4f1f-ae5d-09ce38a7c80d"), 5, "Mar 29, 2016" },
                    { new Guid("339b171d-1256-4569-a330-506e46bb06c6"), "Evolving the shooter genre with its unique and exhilarating combination of fluid action and combat, Damnation features huge, open environments, frenetic combat, daredevil acrobatics and high-octane vehicle-based stunts. Presenting players with an intense test of reflexes, quick thinking and rapid-fire conflict, Damnation will feature vast, breathtaking landscapes, each covering miles of distance and thousands of vertical feet. Billed as a shooter gone vertical and visually inspired by iconic elements of American history, these massive streaming landscapes will form the battlegrounds for a post-industrial conflict between humanity and an unstoppable arms dealer hell - bent on total world domination.", "Damnation", "http://localhost:5125/images/Games/339b171d-1256-4569-a330-506e46bb06c6/339b171d-1256-4569-a330-506e46bb06c6.jpg", new Guid("df5d8791-98b3-445d-8120-07b33695da10"), 5, "May 22, 2009" },
                    { new Guid("426a499a-41c1-4763-a615-fca426836e3f"), "Security systems have failed and the creatures of the park roam free. Now, a rogue corporation will stop at nothing to acquire the dinosaur embryos stolen and lost by Dennis Nedry. Experience a brand new adventure set during the events of the first Jurassic Park movie and see new areas and dinosaurs in this landmark adventure 65 million years in the making!", "Jurassic Park: The Game", "http://localhost:5125/images/Games/426a499a-41c1-4763-a615-fca426836e3f/426a499a-41c1-4763-a615-fca426836e3f.jpg", new Guid("f5ea9a66-8a49-4f1f-ae5d-09ce38a7c80d"), 5, "Nov 15, 2011" },
                    { new Guid("4cdb49aa-17a7-4029-a50a-e01f5aa5fd3c"), "How evil can you get? Discover how corruptible you are in Overlord, the twisted fantasy action adventure where you can be evil(or really evil).In the game's seriously warped fantasy world, players will become the Overlord and get first-hand experience of how absolute power corrupts absolutely. You could be a regular run-of-the-mill Overlord. However, with incredible power at your disposal and a team of evil-minded impish critters, the Minions, on hand to do your bidding, how will you resist the temptation to be wonderfully despotic?!Go deeper into the Overlord's twisted world as the single-player expansion content opens a series of hellish new levels, each a supernatural abyss for the game's five kingdoms: Mellow Hills, Evernight, Heaven's Peak, the Golden Halls and the Ruborian Desert. Access to each abyss is via a portal, which opens once a kingdom has been successfully conquered and the previous ruler banished to a personal hell within. However it's not just the fallen heroes that have been dragged into the abyss: the Overlord's newly loyal peasants have also been taken down into hell too.", "Overlord: Raising Hell", "http://localhost:5125/images/Games/4cdb49aa-17a7-4029-a50a-e01f5aa5fd3c/4cdb49aa-17a7-4029-a50a-e01f5aa5fd3c.jpg", new Guid("df5d8791-98b3-445d-8120-07b33695da10"), 5, "Feb 15, 2008" },
                    { new Guid("7248c5a6-49e0-4f88-be50-8d87a54c938f"), "Max Caulfield, photographer-in-residence at the prestigious Caledon University, discovers her closest new friend, Safi, dead in the snow. Murdered. To save her, Max tries to Rewind time - a power she’s not used in years... instead, Max opens the way to a parallel timeline where Safi is still alive, and still in danger! Max realizes the killer will soon strike again - in both versions of reality. With her new power to Shift between two timelines - can Max solve and prevent the same murder?", "Life is Strange: Double Exposure", "http://localhost:5125/images/Games/7248c5a6-49e0-4f88-be50-8d87a54c938f/7248c5a6-49e0-4f88-be50-8d87a54c938f.jpg", new Guid("12ba59b8-6c30-4864-9d48-0f95bd278b40"), 3, "Oct 29, 2024" },
                    { new Guid("72daabe6-62ec-4657-8e27-3ef881adcdd0"), "Just Cause 3 is an open-world action adventure with the large locus on freedom of exploring. It is the thirds title in the Just Cause series produced by Avalanche Studios, preceded by the first two numerical parts and having the 4th part not yet released as its successor.Rico Rodriguez is the protagonist of the game, who is continually being forced to deal with bandits and dictators somewhere in the Mediterranean.The events of the third game in the series take place 6 years after the second installment.", "Just Cause 3", "http://localhost:5125/images/Games/72daabe6-62ec-4657-8e27-3ef881adcdd0/72daabe6-62ec-4657-8e27-3ef881adcdd0.jpg", new Guid("12ba59b8-6c30-4864-9d48-0f95bd278b40"), 5, "Nov 30, 2015" },
                    { new Guid("7fe582b8-0308-48d8-8173-800102aebcfb"), "Hitman is a six episodes game with different contracts. The action takes place as a prequel to Hitman: Agent 47 (only prologue) and episodes take place six years after Hitman: Absolution. All contracts are being ordered by a 'shadow client' and seem to be unrelated. But as you fulfil those contracts, you start to realise that all of the targets somehow are a part of a secret organisation called the Providence.", "Hitman", "http://localhost:5125/images/Games/7fe582b8-0308-48d8-8173-800102aebcfb/7fe582b8-0308-48d8-8173-800102aebcfb.jpg", new Guid("12ba59b8-6c30-4864-9d48-0f95bd278b40"), 5, "Mar 11, 2016" },
                    { new Guid("9215201e-133d-43e1-b9b8-7b73ac3327c5"), "Law & Order: Legacies is an adventure game developed by Telltale Games. It was originally released in 2012. It was published by Telltale Games. The game is rated as 'Recommended' on RAWG. Law & Order: Legacies is available on PC. Dave Felton and Jason Lars Berquist produced the game. It was scored by Jared Emerson-Johnson and Mike Post.", "Law & Order: Legacies", "http://localhost:5125/images/Games/9215201e-133d-43e1-b9b8-7b73ac3327c5/9215201e-133d-43e1-b9b8-7b73ac3327c5.jpg", new Guid("f5ea9a66-8a49-4f1f-ae5d-09ce38a7c80d"), 5, "Jan 30, 2012" },
                    { new Guid("96ae6e7a-5c53-4ded-bf98-6a791f1ebdd3"), "Just Cause II follows a story of Rico Rodriguez, who arrives yet on another fictional island. Previously being on the Caribbean, now he is coming to Panau - an island in Southeast Asia. This time, Rico has to overthrow the dictatorial regime with its leader, Pandak 'Baby' Panay and confront his former mentor, Tom Sheldon. When Rico arrives at the island, he discovers three criminal gangs: The Roaches, The Reapers and the Ular Boys. In order to prevail, Rico has to fight all of the three fractions as well.One of the key features of the game is speed.This game is filled with adrenaline and ways of doing things very fastly.A wide variety of vehicles such as planes,boats,cars and other.A grappling hook is also available for the player as he can make his character fly around like Spider - Man or tie enemies to each other.There is a big choice of weaponry as well - you can have a pistol, two pistols, auto - rifles or even a grenade launcher! Having an open world map provides a player with experience do whatever they please - flying around, making missions or just discovering new things on the island.", "Just Cause 2", "http://localhost:5125/images/Games/96ae6e7a-5c53-4ded-bf98-6a791f1ebdd3/96ae6e7a-5c53-4ded-bf98-6a791f1ebdd3.jpg", new Guid("12ba59b8-6c30-4864-9d48-0f95bd278b40"), 5, "Mar 23, 2010" },
                    { new Guid("a0ed6f38-b3e3-4090-86f1-40c09cdaaecd"), "Pro Race Driver features 42 licensed touring and racecars, including the Holden Commodore, Ford Falcon, Mercedes CLK, Alfa Romeo GTV, and Viper GTS. Thirty-eight international circuits are re-created under license, including Bathurst, Hockenheimring, and Silverstone. The 13 global championships include DTM from Germany, V8 Supercars from Australia, and the British Touring Car Championship. The state-of-the-art car physics engine was tested for realism by professional race drivers. A customizable car setup provides a uniquely true-to-life driving and performance experience. Real, visible damage is created using the crash test industry's FEM system, and it affects the handling and drivability of vehicles.", "ToCA Race Driver", "http://localhost:5125/images/Games/a0ed6f38-b3e3-4090-86f1-40c09cdaaecd/a0ed6f38-b3e3-4090-86f1-40c09cdaaecd.jpg", new Guid("df5d8791-98b3-445d-8120-07b33695da10"), 5, "Apr 1, 2003" },
                    { new Guid("c5618a1b-eef8-43ec-aa1b-25415fb5bc2f"), "GRID is a racing game that lets the player dive into the motorsport, assume the real racer’s role and even control their own racing team. Races and racing championships are held in three main locations – the United States, Europe, and Japan. All racing circuits in the game are the mixture of imaginary and the existing ones. The gameplay is divided into 6 racing classes: GT championships, drifting, touge (climbing the narrow mountain pass like Pikes Peak), open wheel racing, demolition derby, and 24 Hours of Le Mans (additional at the end of the season). Each car of 43 available in the game is tied to one of the event types. Several professional teams compete within these championships. Therefore, to start the career player have to choose one of the disciplines and a professional team to join. While progressing GRID gives an opportunity to create your own racing team, hire sponsors and other drivers, and participate in different events. The gameplay also has a remarkable feature called “flashback” that allows rewinding time to prevent driver’s mistakes.", "GRID (2008)", "http://localhost:5125/images/Games/c5618a1b-eef8-43ec-aa1b-25415fb5bc2f/c5618a1b-eef8-43ec-aa1b-25415fb5bc2f.png", new Guid("df5d8791-98b3-445d-8120-07b33695da10"), 5, "Jun 3, 2008" },
                    { new Guid("d6cd4ffd-62d1-41e6-b6b4-5a05babb8d45"), "Rise of the Tomb Raider is the eleventh entry in the franchise, being a sequel to its predecessor, Tomb Raider, a reboot of the franchise. This story follows Lara Croft, one year after battling her supernatural experiences in Yamatai. This time she is trying to find the legendary city of Kitezh in Siberia, Russia. The legend behind the city begins in the 12th century and still comes nowadays, that this ancient city grants with a promise of immortality. While Lara tries to solve the mystery of Siberia, she encounters an organisation called Trinity. They want to retrieve this gift to themselves. Following the notes of her father, Lara tries to discover the secrets of the ancient city and stop Trinity in doing so.Exploring the Soviet motive,even more,the game has the DLC's - Baba Yaga, the Temple of the Witch, which follows Lara in the Soviet mine and confronting the legendary witch of Russian folk-tales, Cold Darkness Awakened, the story about a secret biological weapon and Blood Ties and Lara's Nightmare - a fight for ownership of the Croft estate.", "Rise of the Tomb Raider", "http://localhost:5125/images/Games/d6cd4ffd-62d1-41e6-b6b4-5a05babb8d45/d6cd4ffd-62d1-41e6-b6b4-5a05babb8d45.jpg", new Guid("12ba59b8-6c30-4864-9d48-0f95bd278b40"), 5, "Nov 10, 2015" },
                    { new Guid("dce59101-3621-461e-bf10-61807163a946"), "The direct sequel to the Hitman: Blood money, Absolution tells the story of Agent 47, the true intentions of his Agency and how top Agent became a renegade on the run. Unlike previous games in the series, players will get more linear and cinematic experience. The game revolves around objective-based missions, providing various methods of completion. Players can avoid direct confrontation by disguising themselves in other people’s uniforms and use environmental interactions to distract or kill unsuspecting targets. And in case of raising the alarm, players can try to rush the mission with the direct attack, using dozens of available weapons.Players can use special vision mechanic,called Instinct.It allows seeing through the solid surfaces in order to observe NPC’s,items that can be interacted with and predict the movement of patrolling guards.Absolution provides players with additional challenges and collectibles in order to invite players to explore the maps.", "Hitman: Absolution", "http://localhost:5125/images/Games/dce59101-3621-461e-bf10-61807163a946/dce59101-3621-461e-bf10-61807163a946.jpg", new Guid("12ba59b8-6c30-4864-9d48-0f95bd278b40"), 5, "Nov 19, 2012" },
                    { new Guid("e09688b3-257e-413f-9ef4-0f4a9916a2c7"), "The role model: Released in 2008, the game, is similar to another well - known representative of the genre of action - role - playing games God of War series.Developers became studio Liquid Entertainment, and the publisher company Codemasters.The game appeared on the PC and on the most popular consoles of its generation: Playstation 3 and Xbox 360. The story and the setting: The plot of the game tells about Jason, and the action takes place in Ancient Greece. Like God of War, the game uses ancient Greek mythology to build a game universe. The modified myth of Jason and the Argonauts, who went on a journey for the Golden Fleece was used as inspiration.According to the scriptwriters of the game, Jason is a Greek king, whose wife was killed in front of him.The only way for a grieving husband to return the beloved is the Golden Fleece, which can resurrect the dead.Other well-known heroes of myths appear in the game: Hercules, Achilles, Medea, Medusa, Patroclus, and others. Together they travel through a variety of real and imaginary locations: Iolcu, Delphi, Mycenae, Tartar, and Kifr.", "Rise of the Argonauts", "http://localhost:5125/images/Games/e09688b3-257e-413f-9ef4-0f4a9916a2c7/e09688b3-257e-413f-9ef4-0f4a9916a2c7.jpg", new Guid("df5d8791-98b3-445d-8120-07b33695da10"), 5, "Dec 12, 2008" },
                    { new Guid("e439131b-d595-48e3-8873-be55a1357748"), "Marty McFly and Doc Brown return in a completely new Back to the Future adventure. Six months after the events of the third film, the DeLorean Time Machine mysteriously returns to Hill Valley - driverless! Marty must go back in time and get aid from a resistant teenage Emmett Brown, or else the space time continuum will forever be unraveled!", "Back to the Future: The Game", "http://localhost:5125/images/Games/e439131b-d595-48e3-8873-be55a1357748/e439131b-d595-48e3-8873-be55a1357748.jpg", new Guid("f5ea9a66-8a49-4f1f-ae5d-09ce38a7c80d"), 5, "Dec 21, 2010" },
                    { new Guid("e5a9c78f-863e-428d-81a5-3b2d4ce62494"), "F1 2015 is a racing simulator based on the 2015 Formula One season, but with teams from the 2014 season (including the Hockenheimring track, which is missed from the 2015 season calendar). Seventh in the series. It presents the crews and pilots who participated directly in this season. Unlike its predecessors, the game received a new engine, improved physics and graphics.A 'Pro Season' mode was featured.This mode was different from the usual championship in a complete lack of interface and management assistance, as well as the highest level of complexity.The career mode, which was in the previous parts of the series, did not appear in the game.", "F1 2015", "http://localhost:5125/images/Games/e5a9c78f-863e-428d-81a5-3b2d4ce62494/e5a9c78f-863e-428d-81a5-3b2d4ce62494.jpg", new Guid("df5d8791-98b3-445d-8120-07b33695da10"), 5, "Jul 9, 2015" },
                    { new Guid("ee4836d4-d131-47fe-b741-3c104f14df71"), "The Wolf Among Us is a five-part episodic game relying heavily on dialogues and choices of the player. The game is considered a prequel to Bill Willingham's 'Fables' comic book and features usual TellTale stylistics: cartoon-like graphics, comparing your choices to the decisions of the other players and QTEs. 'The Wolf' is the first part of the series with a promised expansion to the second season coming out in 2019.You play as Bigby Wolf; he is a Sheriff of a Fabletown: as a typical Sheriff, you need to fulfill the requests of the Fabletown's residents and uncover mysteries lying behind the crimes there. The gameplay consists of choosing the dialogue options, reacting to QTE button-mash and watching cutscenes.", "The Wolf Among Us", "http://localhost:5125/images/Games/ee4836d4-d131-47fe-b741-3c104f14df71/ee4836d4-d131-47fe-b741-3c104f14df71.jpg", new Guid("f5ea9a66-8a49-4f1f-ae5d-09ce38a7c80d"), 5, "Oct 10, 2013" }
                });

            migrationBuilder.InsertData(
                table: "CategoryVideoGameInfo",
                columns: new[] { "CategoriesCategoryId", "VideoGameInfosVideoGameInfoId" },
                values: new object[,]
                {
                    { new Guid("0b387646-e3f1-4892-857c-b260a7113ca4"), new Guid("a0ed6f38-b3e3-4090-86f1-40c09cdaaecd") },
                    { new Guid("0b387646-e3f1-4892-857c-b260a7113ca4"), new Guid("c5618a1b-eef8-43ec-aa1b-25415fb5bc2f") },
                    { new Guid("0b387646-e3f1-4892-857c-b260a7113ca4"), new Guid("e5a9c78f-863e-428d-81a5-3b2d4ce62494") },
                    { new Guid("2e32f726-203b-4fa3-a960-3a2c1a275864"), new Guid("02b0bb70-4fc8-4c72-86a7-731f4332b9a5") },
                    { new Guid("2e32f726-203b-4fa3-a960-3a2c1a275864"), new Guid("339b171d-1256-4569-a330-506e46bb06c6") },
                    { new Guid("2e32f726-203b-4fa3-a960-3a2c1a275864"), new Guid("426a499a-41c1-4763-a615-fca426836e3f") },
                    { new Guid("2e32f726-203b-4fa3-a960-3a2c1a275864"), new Guid("4cdb49aa-17a7-4029-a50a-e01f5aa5fd3c") },
                    { new Guid("2e32f726-203b-4fa3-a960-3a2c1a275864"), new Guid("72daabe6-62ec-4657-8e27-3ef881adcdd0") },
                    { new Guid("2e32f726-203b-4fa3-a960-3a2c1a275864"), new Guid("96ae6e7a-5c53-4ded-bf98-6a791f1ebdd3") },
                    { new Guid("2e32f726-203b-4fa3-a960-3a2c1a275864"), new Guid("d6cd4ffd-62d1-41e6-b6b4-5a05babb8d45") },
                    { new Guid("2e32f726-203b-4fa3-a960-3a2c1a275864"), new Guid("dce59101-3621-461e-bf10-61807163a946") },
                    { new Guid("2e32f726-203b-4fa3-a960-3a2c1a275864"), new Guid("e09688b3-257e-413f-9ef4-0f4a9916a2c7") },
                    { new Guid("4867a76e-ccc5-4470-a25a-dd1e91cbc87d"), new Guid("007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23") },
                    { new Guid("4867a76e-ccc5-4470-a25a-dd1e91cbc87d"), new Guid("338b764e-b0f1-4969-89c8-164ca308e226") },
                    { new Guid("4867a76e-ccc5-4470-a25a-dd1e91cbc87d"), new Guid("7248c5a6-49e0-4f88-be50-8d87a54c938f") },
                    { new Guid("4867a76e-ccc5-4470-a25a-dd1e91cbc87d"), new Guid("72daabe6-62ec-4657-8e27-3ef881adcdd0") },
                    { new Guid("4867a76e-ccc5-4470-a25a-dd1e91cbc87d"), new Guid("7fe582b8-0308-48d8-8173-800102aebcfb") },
                    { new Guid("4867a76e-ccc5-4470-a25a-dd1e91cbc87d"), new Guid("9215201e-133d-43e1-b9b8-7b73ac3327c5") },
                    { new Guid("4867a76e-ccc5-4470-a25a-dd1e91cbc87d"), new Guid("e439131b-d595-48e3-8873-be55a1357748") },
                    { new Guid("4867a76e-ccc5-4470-a25a-dd1e91cbc87d"), new Guid("ee4836d4-d131-47fe-b741-3c104f14df71") },
                    { new Guid("fe93817b-e277-476d-a27f-7450a0fe72b2"), new Guid("0ce33067-7091-4c51-a1c4-3a93751c748c") }
                });

            migrationBuilder.InsertData(
                table: "GameStudioVideoGameInfo",
                columns: new[] { "GameStudiosGameStudioId", "VideoGamesVideoGameInfoId" },
                values: new object[,]
                {
                    { new Guid("0b4ad2e6-b78c-47a8-bf70-fb667cb7a138"), new Guid("d6cd4ffd-62d1-41e6-b6b4-5a05babb8d45") },
                    { new Guid("5502bbf3-535e-4042-85b8-052b35594542"), new Guid("7fe582b8-0308-48d8-8173-800102aebcfb") },
                    { new Guid("5502bbf3-535e-4042-85b8-052b35594542"), new Guid("dce59101-3621-461e-bf10-61807163a946") },
                    { new Guid("646e4c3c-bfc2-41dc-9f49-14b7905516b8"), new Guid("7248c5a6-49e0-4f88-be50-8d87a54c938f") },
                    { new Guid("727cffb5-6ba3-4a56-a1eb-fe1962c8f044"), new Guid("e09688b3-257e-413f-9ef4-0f4a9916a2c7") },
                    { new Guid("86b47e62-089e-4f3e-b9c4-f29ea6720fd0"), new Guid("d6cd4ffd-62d1-41e6-b6b4-5a05babb8d45") },
                    { new Guid("8720de28-1bf5-49ad-b272-ddfee747f22c"), new Guid("007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23") },
                    { new Guid("8720de28-1bf5-49ad-b272-ddfee747f22c"), new Guid("0ce33067-7091-4c51-a1c4-3a93751c748c") },
                    { new Guid("8720de28-1bf5-49ad-b272-ddfee747f22c"), new Guid("426a499a-41c1-4763-a615-fca426836e3f") },
                    { new Guid("8720de28-1bf5-49ad-b272-ddfee747f22c"), new Guid("9215201e-133d-43e1-b9b8-7b73ac3327c5") },
                    { new Guid("8720de28-1bf5-49ad-b272-ddfee747f22c"), new Guid("e439131b-d595-48e3-8873-be55a1357748") },
                    { new Guid("8720de28-1bf5-49ad-b272-ddfee747f22c"), new Guid("ee4836d4-d131-47fe-b741-3c104f14df71") },
                    { new Guid("9fc928ce-aa2a-4e7b-816d-b3468ea552ed"), new Guid("339b171d-1256-4569-a330-506e46bb06c6") },
                    { new Guid("bbd8f143-d7e1-41ef-9702-9bfb27567b80"), new Guid("02b0bb70-4fc8-4c72-86a7-731f4332b9a5") },
                    { new Guid("bbd8f143-d7e1-41ef-9702-9bfb27567b80"), new Guid("4cdb49aa-17a7-4029-a50a-e01f5aa5fd3c") },
                    { new Guid("bbd8f143-d7e1-41ef-9702-9bfb27567b80"), new Guid("a0ed6f38-b3e3-4090-86f1-40c09cdaaecd") },
                    { new Guid("bbd8f143-d7e1-41ef-9702-9bfb27567b80"), new Guid("c5618a1b-eef8-43ec-aa1b-25415fb5bc2f") },
                    { new Guid("bbd8f143-d7e1-41ef-9702-9bfb27567b80"), new Guid("e5a9c78f-863e-428d-81a5-3b2d4ce62494") },
                    { new Guid("bfe21050-cd59-4feb-ab5e-459031e4b3f3"), new Guid("72daabe6-62ec-4657-8e27-3ef881adcdd0") },
                    { new Guid("bfe21050-cd59-4feb-ab5e-459031e4b3f3"), new Guid("96ae6e7a-5c53-4ded-bf98-6a791f1ebdd3") },
                    { new Guid("cf04439e-6b5d-406f-b2e1-a5616a3aee8a"), new Guid("338b764e-b0f1-4969-89c8-164ca308e226") }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderId", "CustomerId", "EmployeeId", "OrderDate", "PaymentId", "StoreEmployeePersonId", "StoreId", "TotalPrice" },
                values: new object[,]
                {
                    { new Guid("c4f5e3e1-2c4c-4f4e-a4d1-5e5e6139d703"), 100002, 1003, new DateTime(2024, 11, 13, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(5245), new Guid("649bd2f6-fd7b-4af9-aaad-c30aae9d0f53"), null, new Guid("06ed9de3-fd34-4b16-9c8c-150bb751c156"), 890f },
                    { new Guid("c9ebf2c7-5a7f-4b5d-bb7f-2f2c4d8e4a88"), 100002, 1002, new DateTime(2024, 11, 13, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(5243), new Guid("93d71ec8-adfe-4b40-93ba-bc4a389e6393"), null, new Guid("06ed9de3-fd34-4b16-9c8c-150bb751c156"), 500f },
                    { new Guid("d3c4b5e8-1f3a-4c8c-897e-2d8cf3e7c4f6"), 100001, 1002, new DateTime(2024, 11, 13, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(5247), new Guid("77965d61-af9f-41a5-a9df-fbe8e9386a2a"), null, new Guid("b15664cd-da73-46bf-a47f-7be46fdd346a"), 100f },
                    { new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"), 100004, 1001, new DateTime(2024, 11, 13, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(5239), new Guid("4c02ee7d-5a8b-4dba-9df0-5d84aba66837"), null, new Guid("b15664cd-da73-46bf-a47f-7be46fdd346a"), 600f }
                });

            migrationBuilder.InsertData(
                table: "RatedBy",
                columns: new[] { "RatedById", "Comment", "PersonId", "Rating", "VideoGameInfoId" },
                values: new object[,]
                {
                    { new Guid("16ed8a7d-4f1b-4ec7-b4ed-79c6b8ac7e0a"), "good game ! ", 100003, 4f, new Guid("d6cd4ffd-62d1-41e6-b6b4-5a05babb8d45") },
                    { new Guid("b9e7f8a1-5e9a-4e79-a0b7-6e5c6d2b5f9c"), "very nice game I like itt :)", 100002, 4.5f, new Guid("ee4836d4-d131-47fe-b741-3c104f14df71") },
                    { new Guid("e2f0c1a7-8c2c-4f51-9f4e-4a7f3b1c7e4b"), "very nice service ! thank you", 100001, 5f, new Guid("ee4836d4-d131-47fe-b741-3c104f14df71") }
                });

            migrationBuilder.InsertData(
                table: "VideoGameVersion",
                columns: new[] { "VideoGameVersionId", "GameConsoleId", "Price", "VideoGameInfoId" },
                values: new object[,]
                {
                    { new Guid("00347265-4220-4f99-8bd6-27342e15ef45"), new Guid("d31bda97-60bc-4cee-b564-daad86ad2ca6"), 100f, new Guid("e439131b-d595-48e3-8873-be55a1357748") },
                    { new Guid("015dd706-c2dd-4740-81c7-b5dc47806f85"), new Guid("2d952229-3668-48f3-88f5-4ddd9779524c"), 75f, new Guid("c5618a1b-eef8-43ec-aa1b-25415fb5bc2f") },
                    { new Guid("05fb1770-4363-445e-8bd9-37d2d47086b3"), new Guid("d31bda97-60bc-4cee-b564-daad86ad2ca6"), 70f, new Guid("007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23") },
                    { new Guid("1161e5b3-5ad1-475b-aa84-4afdff09b982"), new Guid("d31bda97-60bc-4cee-b564-daad86ad2ca6"), 125f, new Guid("338b764e-b0f1-4969-89c8-164ca308e226") },
                    { new Guid("21b39eb5-a567-4ec8-a0b9-c7e50f311dc0"), new Guid("d31bda97-60bc-4cee-b564-daad86ad2ca6"), 109f, new Guid("e5a9c78f-863e-428d-81a5-3b2d4ce62494") },
                    { new Guid("22ce0bc9-4b20-42d8-b883-5d9156024c7a"), new Guid("2d952229-3668-48f3-88f5-4ddd9779524c"), 100f, new Guid("7fe582b8-0308-48d8-8173-800102aebcfb") },
                    { new Guid("22d7f20b-e812-4faf-9645-73c34e826b65"), new Guid("2d952229-3668-48f3-88f5-4ddd9779524c"), 65f, new Guid("a0ed6f38-b3e3-4090-86f1-40c09cdaaecd") },
                    { new Guid("34bb9d50-8f6f-4dc1-9c8e-4bd3d6bbb725"), new Guid("2d952229-3668-48f3-88f5-4ddd9779524c"), 85f, new Guid("ee4836d4-d131-47fe-b741-3c104f14df71") },
                    { new Guid("53c84e6c-de22-45b5-9fa8-ca2958b362b4"), new Guid("2d952229-3668-48f3-88f5-4ddd9779524c"), 203f, new Guid("e09688b3-257e-413f-9ef4-0f4a9916a2c7") },
                    { new Guid("76708e1d-6810-47f1-a31e-d5e787623dbb"), new Guid("2d952229-3668-48f3-88f5-4ddd9779524c"), 120f, new Guid("9215201e-133d-43e1-b9b8-7b73ac3327c5") },
                    { new Guid("8fa26dfb-b2e3-4f5c-bc6a-d01001fac01f"), new Guid("d31bda97-60bc-4cee-b564-daad86ad2ca6"), 90f, new Guid("d6cd4ffd-62d1-41e6-b6b4-5a05babb8d45") },
                    { new Guid("951fe8f0-27ec-4fc6-bb0f-37101cd907ff"), new Guid("2d952229-3668-48f3-88f5-4ddd9779524c"), 65f, new Guid("0ce33067-7091-4c51-a1c4-3a93751c748c") },
                    { new Guid("a6060751-2511-43ed-ba82-a19fe5c58a05"), new Guid("2d952229-3668-48f3-88f5-4ddd9779524c"), 84f, new Guid("dce59101-3621-461e-bf10-61807163a946") },
                    { new Guid("b31898f5-ad46-4530-a7c5-26c70caeb5b1"), new Guid("2d952229-3668-48f3-88f5-4ddd9779524c"), 73f, new Guid("426a499a-41c1-4763-a615-fca426836e3f") },
                    { new Guid("bc86a13f-c64f-4827-a0b7-9cdf16e8f1c7"), new Guid("2d952229-3668-48f3-88f5-4ddd9779524c"), 110f, new Guid("4cdb49aa-17a7-4029-a50a-e01f5aa5fd3c") },
                    { new Guid("ca89b58b-f2d8-4bbe-8fb0-c5c6bf8cce91"), new Guid("d31bda97-60bc-4cee-b564-daad86ad2ca6"), 125f, new Guid("72daabe6-62ec-4657-8e27-3ef881adcdd0") },
                    { new Guid("d04514c0-df00-4608-ac8e-14c81dc4f77b"), new Guid("d31bda97-60bc-4cee-b564-daad86ad2ca6"), 80f, new Guid("7248c5a6-49e0-4f88-be50-8d87a54c938f") },
                    { new Guid("e4f3ff4c-ca6c-4784-afe2-cb4b0d267ae4"), new Guid("d31bda97-60bc-4cee-b564-daad86ad2ca6"), 105f, new Guid("339b171d-1256-4569-a330-506e46bb06c6") },
                    { new Guid("e666929b-6816-46c2-8d36-f8fd722952bb"), new Guid("d31bda97-60bc-4cee-b564-daad86ad2ca6"), 95f, new Guid("96ae6e7a-5c53-4ded-bf98-6a791f1ebdd3") },
                    { new Guid("f5aad30c-2849-45fe-bba2-ee0dee2ccc4f"), new Guid("2d952229-3668-48f3-88f5-4ddd9779524c"), 85f, new Guid("02b0bb70-4fc8-4c72-86a7-731f4332b9a5") }
                });

            migrationBuilder.InsertData(
                table: "Inventory",
                columns: new[] { "StoreId", "VideoGameVersionId", "GameQuantity" },
                values: new object[,]
                {
                    { new Guid("b15664cd-da73-46bf-a47f-7be46fdd346a"), new Guid("00347265-4220-4f99-8bd6-27342e15ef45"), 400 },
                    { new Guid("b15664cd-da73-46bf-a47f-7be46fdd346a"), new Guid("015dd706-c2dd-4740-81c7-b5dc47806f85"), 350 },
                    { new Guid("b15664cd-da73-46bf-a47f-7be46fdd346a"), new Guid("05fb1770-4363-445e-8bd9-37d2d47086b3"), 210 },
                    { new Guid("b15664cd-da73-46bf-a47f-7be46fdd346a"), new Guid("1161e5b3-5ad1-475b-aa84-4afdff09b982"), 200 },
                    { new Guid("b15664cd-da73-46bf-a47f-7be46fdd346a"), new Guid("21b39eb5-a567-4ec8-a0b9-c7e50f311dc0"), 350 },
                    { new Guid("b15664cd-da73-46bf-a47f-7be46fdd346a"), new Guid("22ce0bc9-4b20-42d8-b883-5d9156024c7a"), 450 },
                    { new Guid("b15664cd-da73-46bf-a47f-7be46fdd346a"), new Guid("22d7f20b-e812-4faf-9645-73c34e826b65"), 500 },
                    { new Guid("b15664cd-da73-46bf-a47f-7be46fdd346a"), new Guid("34bb9d50-8f6f-4dc1-9c8e-4bd3d6bbb725"), 150 },
                    { new Guid("b15664cd-da73-46bf-a47f-7be46fdd346a"), new Guid("53c84e6c-de22-45b5-9fa8-ca2958b362b4"), 700 },
                    { new Guid("b15664cd-da73-46bf-a47f-7be46fdd346a"), new Guid("76708e1d-6810-47f1-a31e-d5e787623dbb"), 600 },
                    { new Guid("b15664cd-da73-46bf-a47f-7be46fdd346a"), new Guid("8fa26dfb-b2e3-4f5c-bc6a-d01001fac01f"), 50 },
                    { new Guid("b15664cd-da73-46bf-a47f-7be46fdd346a"), new Guid("951fe8f0-27ec-4fc6-bb0f-37101cd907ff"), 30 },
                    { new Guid("b15664cd-da73-46bf-a47f-7be46fdd346a"), new Guid("a6060751-2511-43ed-ba82-a19fe5c58a05"), 90 },
                    { new Guid("b15664cd-da73-46bf-a47f-7be46fdd346a"), new Guid("b31898f5-ad46-4530-a7c5-26c70caeb5b1"), 400 },
                    { new Guid("b15664cd-da73-46bf-a47f-7be46fdd346a"), new Guid("bc86a13f-c64f-4827-a0b7-9cdf16e8f1c7"), 250 },
                    { new Guid("b15664cd-da73-46bf-a47f-7be46fdd346a"), new Guid("ca89b58b-f2d8-4bbe-8fb0-c5c6bf8cce91"), 300 },
                    { new Guid("b15664cd-da73-46bf-a47f-7be46fdd346a"), new Guid("d04514c0-df00-4608-ac8e-14c81dc4f77b"), 250 },
                    { new Guid("b15664cd-da73-46bf-a47f-7be46fdd346a"), new Guid("e4f3ff4c-ca6c-4784-afe2-cb4b0d267ae4"), 400 },
                    { new Guid("b15664cd-da73-46bf-a47f-7be46fdd346a"), new Guid("e666929b-6816-46c2-8d36-f8fd722952bb"), 200 },
                    { new Guid("b15664cd-da73-46bf-a47f-7be46fdd346a"), new Guid("f5aad30c-2849-45fe-bba2-ee0dee2ccc4f"), 300 }
                });

            migrationBuilder.InsertData(
                table: "OrderedGames",
                columns: new[] { "Id", "OrderId", "Quantity", "VideoGameVersionId" },
                values: new object[,]
                {
                    { new Guid("1c6e2e0a-9c4e-4b07-bb8f-5d9d8e7f5a3c"), new Guid("c9ebf2c7-5a7f-4b5d-bb7f-2f2c4d8e4a88"), 1, new Guid("d04514c0-df00-4608-ac8e-14c81dc4f77b") },
                    { new Guid("3f9e2a1a-5c2d-4f3e-8b0f-4d5e6c7b8a9c"), new Guid("d3c4b5e8-1f3a-4c8c-897e-2d8cf3e7c4f6"), 2, new Guid("8fa26dfb-b2e3-4f5c-bc6a-d01001fac01f") },
                    { new Guid("7f8d9b7e-4c3b-4f6a-9a5b-1a2c3d4e5f6a"), new Guid("c4f5e3e1-2c4c-4f4e-a4d1-5e5e6139d703"), 1, new Guid("34bb9d50-8f6f-4dc1-9c8e-4bd3d6bbb725") },
                    { new Guid("b2a3e9f8-3a7c-4b02-b0f9-8a3d4c5f6e7b"), new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"), 2, new Guid("d04514c0-df00-4608-ac8e-14c81dc4f77b") }
                });

            migrationBuilder.InsertData(
                table: "Supply",
                columns: new[] { "SupplyId", "InventoryId", "InventoryStoreId", "InventoryVideoGameVersionId", "SupplierDate", "SupplierId", "SupplyQuantity", "VideoGameVersionId" },
                values: new object[,]
                {
                    { new Guid("0a9c8263-7f5e-4e25-bb85-7a4c0a1e3a5c"), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new DateTime(2024, 11, 13, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4936), new Guid("47c88b33-d1cb-4b2d-94b5-b6867c6d6639"), 100f, new Guid("e666929b-6816-46c2-8d36-f8fd722952bb") },
                    { new Guid("0bb3c011-9ba9-47e7-9ce0-3268f85e1ffc"), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new DateTime(2024, 11, 13, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4925), new Guid("47c88b33-d1cb-4b2d-94b5-b6867c6d6639"), 100f, new Guid("d04514c0-df00-4608-ac8e-14c81dc4f77b") },
                    { new Guid("18a64e64-3707-451c-b54d-51dbb9933aa0"), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new DateTime(2024, 11, 12, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4958), new Guid("8f851df0-b73d-49af-acb4-3f812b483430"), 50f, new Guid("53c84e6c-de22-45b5-9fa8-ca2958b362b4") },
                    { new Guid("1b234567-89ab-cdef-0123-456789abcdef"), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new DateTime(2024, 11, 13, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4931), new Guid("47c88b33-d1cb-4b2d-94b5-b6867c6d6639"), 100f, new Guid("8fa26dfb-b2e3-4f5c-bc6a-d01001fac01f") },
                    { new Guid("2b7c5a63-8e93-4d88-bc90-85c42d1574ae"), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new DateTime(2024, 11, 13, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4940), new Guid("47c88b33-d1cb-4b2d-94b5-b6867c6d6639"), 100f, new Guid("951fe8f0-27ec-4fc6-bb0f-37101cd907ff") },
                    { new Guid("34f2c84e-6c77-4c4a-b5f3-eef62d87b4be"), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new DateTime(2024, 11, 12, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4950), new Guid("8f851df0-b73d-49af-acb4-3f812b483430"), 50f, new Guid("bc86a13f-c64f-4827-a0b7-9cdf16e8f1c7") },
                    { new Guid("3d8f49b2-ef8b-4b3e-8f5d-1f68d8f4f4b1"), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new DateTime(2024, 11, 13, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4929), new Guid("47c88b33-d1cb-4b2d-94b5-b6867c6d6639"), 100f, new Guid("34bb9d50-8f6f-4dc1-9c8e-4bd3d6bbb725") },
                    { new Guid("4d8d76aa-48e5-4c2b-95f1-5a77c73c0f11"), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new DateTime(2024, 11, 13, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4932), new Guid("47c88b33-d1cb-4b2d-94b5-b6867c6d6639"), 100f, new Guid("015dd706-c2dd-4740-81c7-b5dc47806f85") },
                    { new Guid("59259348-41da-4bbc-b85c-48ee82f474ce"), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new DateTime(2024, 11, 12, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4944), new Guid("8f851df0-b73d-49af-acb4-3f812b483430"), 50f, new Guid("b31898f5-ad46-4530-a7c5-26c70caeb5b1") },
                    { new Guid("5a6e8d59-0c3d-4e54-a105-50f44dcb9e4b"), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new DateTime(2024, 11, 13, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4939), new Guid("47c88b33-d1cb-4b2d-94b5-b6867c6d6639"), 100f, new Guid("05fb1770-4363-445e-8bd9-37d2d47086b3") },
                    { new Guid("5e4f2822-bb47-45b4-83c0-6c1de2b5f900"), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new DateTime(2024, 11, 12, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4959), new Guid("8f851df0-b73d-49af-acb4-3f812b483430"), 50f, new Guid("e4f3ff4c-ca6c-4784-afe2-cb4b0d267ae4") },
                    { new Guid("72b24a8d-4e5b-43e5-aeae-ecf9dc1b52d9"), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new DateTime(2024, 11, 12, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4955), new Guid("8f851df0-b73d-49af-acb4-3f812b483430"), 50f, new Guid("22ce0bc9-4b20-42d8-b883-5d9156024c7a") },
                    { new Guid("7f1f7c59-f92e-4c3b-a3f4-9c2a4cd474cb"), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new DateTime(2024, 11, 13, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4934), new Guid("47c88b33-d1cb-4b2d-94b5-b6867c6d6639"), 100f, new Guid("f5aad30c-2849-45fe-bba2-ee0dee2ccc4f") },
                    { new Guid("8b5c0f77-e3f1-4972-9102-6c1dfbb5a601"), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new DateTime(2024, 11, 12, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4961), new Guid("8f851df0-b73d-49af-acb4-3f812b483430"), 50f, new Guid("22d7f20b-e812-4faf-9645-73c34e826b65") },
                    { new Guid("8d5c8e30-dede-4ef0-9158-f7692c41acb2"), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new DateTime(2024, 11, 12, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4948), new Guid("8f851df0-b73d-49af-acb4-3f812b483430"), 50f, new Guid("21b39eb5-a567-4ec8-a0b9-c7e50f311dc0") },
                    { new Guid("9b7f3e43-50bc-41d5-8f43-b8e0e1f47732"), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new DateTime(2024, 11, 12, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4953), new Guid("8f851df0-b73d-49af-acb4-3f812b483430"), 50f, new Guid("1161e5b3-5ad1-475b-aa84-4afdff09b982") },
                    { new Guid("9e7b22d3-c5a5-429e-82dc-e5c573745e1d"), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new DateTime(2024, 11, 13, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4942), new Guid("47c88b33-d1cb-4b2d-94b5-b6867c6d6639"), 100f, new Guid("00347265-4220-4f99-8bd6-27342e15ef45") },
                    { new Guid("c7f1f4f5-74e3-4b4f-9c5a-3e2059d8b72d"), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new DateTime(2024, 11, 12, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4952), new Guid("8f851df0-b73d-49af-acb4-3f812b483430"), 50f, new Guid("76708e1d-6810-47f1-a31e-d5e787623dbb") },
                    { new Guid("e43ff624-3f3c-4e8e-b5eb-11c0c3a244fa"), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new DateTime(2024, 11, 13, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4937), new Guid("47c88b33-d1cb-4b2d-94b5-b6867c6d6639"), 100f, new Guid("a6060751-2511-43ed-ba82-a19fe5c58a05") },
                    { new Guid("f3b00c12-3b5e-4c8e-9bb0-7a5c7408cd07"), new Guid("00000000-0000-0000-0000-000000000000"), null, null, new DateTime(2024, 11, 12, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4956), new Guid("8f851df0-b73d-49af-acb4-3f812b483430"), 50f, new Guid("ca89b58b-f2d8-4bbe-8fb0-c5c6bf8cce91") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryVideoGameInfo_VideoGameInfosVideoGameInfoId",
                table: "CategoryVideoGameInfo",
                column: "VideoGameInfosVideoGameInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_GameStudioVideoGameInfo_VideoGamesVideoGameInfoId",
                table: "GameStudioVideoGameInfo",
                column: "VideoGamesVideoGameInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_VideoGameVersionId",
                table: "Inventory",
                column: "VideoGameVersionId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_PaymentId",
                table: "Order",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_StoreEmployeePersonId",
                table: "Order",
                column: "StoreEmployeePersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_StoreId",
                table: "Order",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderedGames_OrderId",
                table: "OrderedGames",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderedGames_VideoGameVersionId",
                table: "OrderedGames",
                column: "VideoGameVersionId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_PersonEmail",
                table: "Persons",
                column: "PersonEmail",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_PersonPhoneNumber",
                table: "Persons",
                column: "PersonPhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RatedBy_PersonId",
                table: "RatedBy",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_RatedBy_VideoGameInfoId",
                table: "RatedBy",
                column: "VideoGameInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_StoreEmployees_StoreId",
                table: "StoreEmployees",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Supply_InventoryStoreId_InventoryVideoGameVersionId",
                table: "Supply",
                columns: new[] { "InventoryStoreId", "InventoryVideoGameVersionId" });

            migrationBuilder.CreateIndex(
                name: "IX_Supply_SupplierId",
                table: "Supply",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Supply_VideoGameVersionId",
                table: "Supply",
                column: "VideoGameVersionId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoGameInfo_PublisherId",
                table: "VideoGameInfo",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoGameVersion_GameConsoleId",
                table: "VideoGameVersion",
                column: "GameConsoleId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoGameVersion_VideoGameInfoId",
                table: "VideoGameVersion",
                column: "VideoGameInfoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryVideoGameInfo");

            migrationBuilder.DropTable(
                name: "GameStudioVideoGameInfo");

            migrationBuilder.DropTable(
                name: "OrderedGames");

            migrationBuilder.DropTable(
                name: "PersonIdCounters");

            migrationBuilder.DropTable(
                name: "RatedBy");

            migrationBuilder.DropTable(
                name: "Supply");

            migrationBuilder.DropTable(
                name: "SystemAdmins");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Studio");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "StoreEmployees");

            migrationBuilder.DropTable(
                name: "VideoGameVersion");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Store");

            migrationBuilder.DropTable(
                name: "Console");

            migrationBuilder.DropTable(
                name: "VideoGameInfo");

            migrationBuilder.DropTable(
                name: "Publisher");
        }
    }
}
