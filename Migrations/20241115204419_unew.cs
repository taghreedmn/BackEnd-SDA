using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class unew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c4f5e3e1-2c4c-4f4e-a4d1-5e5e6139d703"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 20, 44, 18, 565, DateTimeKind.Utc).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c9ebf2c7-5a7f-4b5d-bb7f-2f2c4d8e4a88"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 20, 44, 18, 565, DateTimeKind.Utc).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("d3c4b5e8-1f3a-4c8c-897e-2d8cf3e7c4f6"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 20, 44, 18, 565, DateTimeKind.Utc).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 20, 44, 18, 565, DateTimeKind.Utc).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "0A-B8-10-6C-C7-FC-5A-07-93-14-77-2F-6E-03-9C-3C-D2-63-A3-8B-E0-17-09-68-8D-15-68-9E-E2-40-41-D8", new byte[] { 220, 229, 216, 17, 40, 160, 1, 5, 161, 13, 185, 33, 182, 25, 228, 5, 120, 131, 195, 223, 159, 68, 82, 207, 106, 111, 51, 242, 145, 40, 224, 178, 28, 176, 128, 105, 16, 242, 9, 131, 190, 220, 176, 77, 84, 76, 55, 18, 85, 182, 178, 69, 201, 28, 63, 196, 36, 165, 60, 108, 75, 108, 15, 95 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "68-3A-81-B9-45-F6-81-A5-91-BA-E1-07-8E-F6-72-39-B3-7C-B2-9F-F5-94-B0-C5-56-9C-31-71-93-7E-77-1D", new byte[] { 9, 190, 84, 105, 218, 85, 173, 155, 78, 142, 123, 250, 201, 216, 210, 1, 104, 113, 94, 65, 149, 219, 107, 247, 92, 162, 246, 115, 51, 165, 90, 177, 19, 223, 226, 95, 104, 32, 54, 202, 35, 224, 226, 17, 96, 147, 18, 151, 135, 29, 16, 244, 18, 130, 180, 222, 15, 223, 189, 165, 190, 216, 49, 215 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "4C-FA-14-08-94-89-05-55-E8-DB-A0-C5-C8-67-0B-CF-9E-79-4E-C7-D2-32-E6-3F-3D-AD-07-F9-36-E3-77-7F", new byte[] { 94, 65, 80, 247, 20, 56, 163, 69, 231, 116, 37, 127, 248, 43, 197, 7, 254, 33, 251, 88, 188, 125, 224, 252, 63, 6, 244, 63, 237, 69, 86, 21, 30, 70, 201, 41, 239, 119, 8, 206, 92, 248, 45, 28, 40, 8, 197, 60, 159, 121, 67, 15, 63, 143, 110, 227, 145, 28, 60, 131, 16, 8, 233, 124 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "EF-65-E6-21-51-AB-9A-DB-61-20-C1-51-12-45-19-6B-4A-E7-12-98-5A-29-5C-D4-01-EA-BA-70-41-6D-71-FE", new byte[] { 134, 3, 53, 77, 245, 249, 243, 159, 128, 209, 71, 27, 133, 64, 163, 18, 42, 47, 45, 79, 71, 133, 165, 7, 42, 227, 196, 210, 151, 161, 26, 237, 15, 99, 23, 137, 40, 62, 11, 243, 4, 182, 78, 65, 78, 223, 86, 245, 213, 20, 140, 118, 21, 177, 37, 70, 48, 26, 163, 140, 12, 195, 132, 14 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "75-1C-F7-52-2A-3F-59-4C-BF-8D-5D-17-91-38-C0-D6-9A-7D-C6-64-B4-22-99-D7-0A-16-82-D4-A2-C3-0B-24", new byte[] { 111, 213, 74, 210, 64, 250, 144, 129, 202, 16, 80, 234, 67, 216, 18, 240, 247, 238, 24, 30, 51, 193, 68, 180, 201, 167, 7, 91, 79, 218, 126, 127, 185, 205, 63, 0, 119, 110, 54, 29, 203, 34, 174, 191, 198, 35, 90, 58, 32, 145, 64, 87, 183, 43, 56, 214, 49, 1, 63, 28, 199, 54, 137, 75 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "A6-F8-A6-F8-C0-D2-7A-A6-47-00-39-EC-0E-AD-29-B7-F1-9C-0E-CE-DE-E7-C5-94-58-5A-05-C4-E0-79-49-F6", new byte[] { 109, 68, 195, 158, 80, 161, 5, 195, 41, 85, 222, 5, 216, 51, 222, 223, 77, 238, 3, 82, 189, 251, 227, 103, 4, 26, 94, 166, 47, 240, 159, 218, 248, 248, 6, 149, 245, 109, 192, 72, 52, 82, 197, 113, 163, 204, 21, 12, 22, 160, 46, 135, 236, 163, 121, 137, 166, 26, 231, 132, 229, 5, 134, 34 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "3D-45-08-22-46-F8-9D-B5-34-65-E2-5D-AB-53-8B-12-F7-FB-79-C5-F1-F5-AF-CE-FD-38-65-F1-75-A5-A9-B5", new byte[] { 252, 174, 154, 85, 29, 167, 188, 91, 174, 92, 248, 154, 125, 127, 59, 37, 241, 147, 217, 148, 50, 241, 98, 105, 114, 216, 244, 237, 113, 61, 0, 83, 100, 25, 111, 139, 168, 243, 219, 159, 165, 103, 55, 5, 6, 77, 180, 143, 105, 82, 34, 8, 195, 246, 184, 245, 56, 84, 252, 230, 48, 15, 149, 244 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "8C-8B-5A-A2-42-5D-FD-97-8D-4B-5F-D1-23-41-6F-23-A1-1B-8E-32-AF-8F-3B-6F-3D-27-DA-44-7A-E6-B7-DA", new byte[] { 220, 199, 233, 200, 183, 4, 236, 104, 126, 110, 185, 137, 208, 238, 99, 237, 21, 205, 235, 250, 3, 11, 176, 27, 173, 186, 33, 248, 8, 182, 16, 218, 145, 228, 26, 71, 4, 37, 202, 168, 122, 44, 200, 22, 29, 227, 225, 17, 42, 172, 27, 131, 123, 241, 47, 121, 108, 13, 118, 178, 195, 49, 183, 212 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "9F-BA-9D-0C-A4-5C-38-36-7E-47-B5-28-F5-07-D8-E7-18-7D-DA-8D-DB-2C-52-86-DC-7B-7E-58-16-1D-7F-58", new byte[] { 80, 231, 67, 90, 215, 58, 85, 36, 64, 153, 137, 193, 15, 59, 192, 2, 76, 3, 204, 119, 10, 13, 50, 68, 46, 108, 252, 97, 163, 226, 17, 167, 216, 210, 156, 192, 229, 109, 90, 142, 85, 150, 136, 10, 127, 116, 75, 230, 18, 73, 200, 243, 81, 53, 138, 66, 192, 186, 73, 230, 243, 99, 200, 144 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100004,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "F1-77-4E-2E-26-BE-56-47-F2-F0-A0-A9-8E-B2-48-C8-87-5C-82-F4-B8-42-C0-65-34-81-37-BE-4C-09-41-F7", new byte[] { 166, 8, 89, 42, 249, 83, 168, 129, 148, 156, 200, 127, 57, 212, 238, 75, 104, 209, 175, 69, 124, 129, 123, 52, 152, 13, 29, 17, 40, 103, 166, 241, 72, 30, 95, 94, 243, 93, 229, 110, 141, 226, 149, 21, 39, 128, 113, 98, 14, 120, 152, 50, 94, 222, 15, 0, 177, 212, 84, 33, 212, 37, 151, 196 } });

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0a9c8263-7f5e-4e25-bb85-7a4c0a1e3a5c"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 20, 44, 18, 565, DateTimeKind.Utc).AddTicks(144));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0bb3c011-9ba9-47e7-9ce0-3268f85e1ffc"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 20, 44, 18, 565, DateTimeKind.Utc).AddTicks(131));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("18a64e64-3707-451c-b54d-51dbb9933aa0"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 20, 44, 18, 565, DateTimeKind.Utc).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("1b234567-89ab-cdef-0123-456789abcdef"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 20, 44, 18, 565, DateTimeKind.Utc).AddTicks(137));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("2b7c5a63-8e93-4d88-bc90-85c42d1574ae"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 20, 44, 18, 565, DateTimeKind.Utc).AddTicks(151));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("34f2c84e-6c77-4c4a-b5f3-eef62d87b4be"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 20, 44, 18, 565, DateTimeKind.Utc).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("3d8f49b2-ef8b-4b3e-8f5d-1f68d8f4f4b1"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 20, 44, 18, 565, DateTimeKind.Utc).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("4d8d76aa-48e5-4c2b-95f1-5a77c73c0f11"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 20, 44, 18, 565, DateTimeKind.Utc).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("59259348-41da-4bbc-b85c-48ee82f474ce"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 20, 44, 18, 565, DateTimeKind.Utc).AddTicks(154));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5a6e8d59-0c3d-4e54-a105-50f44dcb9e4b"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 20, 44, 18, 565, DateTimeKind.Utc).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5e4f2822-bb47-45b4-83c0-6c1de2b5f900"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 20, 44, 18, 565, DateTimeKind.Utc).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("72b24a8d-4e5b-43e5-aeae-ecf9dc1b52d9"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 20, 44, 18, 565, DateTimeKind.Utc).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("7f1f7c59-f92e-4c3b-a3f4-9c2a4cd474cb"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 20, 44, 18, 565, DateTimeKind.Utc).AddTicks(142));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8b5c0f77-e3f1-4972-9102-6c1dfbb5a601"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 20, 44, 18, 565, DateTimeKind.Utc).AddTicks(178));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8d5c8e30-dede-4ef0-9158-f7692c41acb2"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 20, 44, 18, 565, DateTimeKind.Utc).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9b7f3e43-50bc-41d5-8f43-b8e0e1f47732"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 20, 44, 18, 565, DateTimeKind.Utc).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e7b22d3-c5a5-429e-82dc-e5c573745e1d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 20, 44, 18, 565, DateTimeKind.Utc).AddTicks(153));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("c7f1f4f5-74e3-4b4f-9c5a-3e2059d8b72d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 20, 44, 18, 565, DateTimeKind.Utc).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("e43ff624-3f3c-4e8e-b5eb-11c0c3a244fa"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 20, 44, 18, 565, DateTimeKind.Utc).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("f3b00c12-3b5e-4c8e-9bb0-7a5c7408cd07"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 20, 44, 18, 565, DateTimeKind.Utc).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23"),
                column: "GamePicturePath",
                value: "https://fusiontech-0dxp.onrender.com/wwwroot/images/Games/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c4f5e3e1-2c4c-4f4e-a4d1-5e5e6139d703"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c9ebf2c7-5a7f-4b5d-bb7f-2f2c4d8e4a88"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("d3c4b5e8-1f3a-4c8c-897e-2d8cf3e7c4f6"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "82-8C-3E-0B-D3-B6-5E-9D-56-92-A2-81-FD-4C-0A-9E-24-7E-35-25-E1-A6-04-4A-96-87-BF-96-90-F6-26-10", new byte[] { 48, 199, 226, 189, 95, 93, 60, 152, 199, 67, 92, 81, 118, 155, 226, 251, 129, 119, 22, 202, 211, 246, 139, 97, 161, 45, 142, 100, 219, 206, 251, 23, 56, 67, 164, 26, 172, 130, 22, 6, 156, 18, 230, 152, 127, 204, 252, 239, 30, 246, 202, 172, 81, 223, 191, 150, 80, 170, 197, 170, 95, 230, 190, 98 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "F6-0C-8A-BB-7E-E1-F0-C5-9A-7B-C4-50-C7-2C-BA-19-BC-27-11-49-FD-B1-FA-6B-8B-CD-D8-C4-3A-85-FD-40", new byte[] { 21, 52, 238, 11, 192, 1, 137, 91, 71, 181, 210, 206, 249, 46, 145, 156, 213, 181, 204, 158, 204, 34, 243, 23, 16, 142, 181, 27, 186, 140, 133, 3, 35, 130, 104, 222, 36, 167, 210, 167, 134, 147, 61, 90, 51, 95, 248, 161, 0, 53, 100, 142, 154, 96, 88, 58, 229, 141, 11, 166, 104, 77, 124, 222 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "2A-86-58-54-3C-53-24-03-EC-6B-43-9C-E0-14-28-23-09-43-AF-79-2B-FF-37-7B-AB-9F-A7-B5-95-2B-D4-F8", new byte[] { 33, 31, 218, 122, 85, 225, 92, 91, 174, 92, 123, 131, 145, 77, 46, 42, 224, 226, 67, 128, 29, 108, 61, 173, 178, 166, 225, 178, 93, 252, 127, 117, 30, 44, 184, 247, 116, 146, 193, 71, 94, 255, 150, 89, 144, 36, 250, 81, 174, 66, 3, 253, 129, 103, 196, 193, 183, 205, 217, 139, 129, 191, 59, 78 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "A6-83-A2-63-56-3A-29-19-B4-35-4D-CB-F2-DC-F8-0B-F1-EC-43-46-AA-8F-2C-2E-A0-4E-1B-FB-4E-FF-C9-E7", new byte[] { 162, 66, 61, 8, 154, 146, 34, 246, 152, 195, 236, 214, 253, 190, 128, 97, 153, 195, 99, 41, 32, 233, 143, 206, 32, 238, 142, 65, 240, 236, 46, 27, 104, 230, 51, 197, 212, 33, 59, 197, 219, 173, 97, 60, 35, 199, 111, 89, 151, 134, 247, 128, 175, 54, 13, 139, 12, 189, 166, 8, 72, 7, 54, 237 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "BA-33-3F-34-86-76-18-67-9D-03-75-09-E8-91-E9-B1-B3-C9-DE-68-EE-60-DE-1D-B8-70-89-72-B3-41-31-0C", new byte[] { 56, 1, 189, 130, 127, 139, 148, 155, 137, 172, 13, 140, 67, 188, 142, 241, 227, 148, 131, 224, 100, 200, 178, 60, 94, 66, 37, 103, 158, 22, 205, 50, 52, 44, 224, 175, 214, 7, 18, 33, 235, 133, 122, 161, 49, 149, 94, 225, 112, 140, 72, 156, 220, 244, 143, 13, 100, 5, 63, 186, 203, 13, 72, 18 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "97-FA-67-B3-4D-F4-E2-D2-46-26-F9-A3-02-93-6E-9B-11-8D-D6-85-93-D9-8D-42-3A-8A-05-72-33-F5-58-D6", new byte[] { 222, 204, 9, 171, 51, 253, 179, 6, 158, 252, 63, 174, 166, 211, 231, 217, 23, 194, 83, 109, 32, 70, 98, 59, 149, 214, 15, 105, 218, 208, 124, 48, 123, 126, 106, 55, 114, 77, 29, 130, 250, 39, 97, 87, 85, 148, 221, 176, 148, 170, 201, 14, 151, 146, 5, 111, 16, 53, 168, 215, 247, 100, 231, 86 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "3E-87-EF-1D-93-12-6A-37-55-A6-BF-B0-2C-7C-D3-C3-95-33-7B-29-7C-E3-95-35-BE-D9-F5-16-57-96-5D-4A", new byte[] { 190, 207, 217, 183, 124, 1, 160, 123, 244, 136, 220, 156, 46, 1, 135, 212, 244, 210, 75, 115, 52, 157, 23, 43, 206, 5, 187, 146, 126, 68, 199, 84, 202, 37, 172, 50, 5, 40, 86, 250, 60, 242, 51, 73, 87, 128, 202, 101, 201, 89, 58, 140, 82, 97, 160, 130, 78, 32, 109, 79, 27, 53, 99, 134 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "19-72-B8-8C-4C-4D-D3-06-41-20-4F-91-16-76-3D-33-E5-F3-5A-77-63-B4-37-B8-F4-11-06-BB-1A-F3-AB-AC", new byte[] { 172, 94, 172, 239, 12, 89, 21, 99, 190, 155, 194, 46, 50, 49, 92, 145, 162, 33, 74, 51, 85, 245, 232, 119, 107, 22, 238, 100, 78, 198, 55, 253, 119, 205, 27, 170, 248, 102, 137, 44, 77, 88, 187, 254, 110, 55, 215, 224, 112, 38, 161, 21, 108, 155, 239, 214, 229, 58, 202, 165, 202, 23, 144, 5 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "C6-FB-D1-5E-52-80-DD-A5-0A-5B-F8-23-C7-2B-A2-1D-B2-BF-BE-B2-FB-0B-0C-A0-62-0B-0B-D9-B8-50-6D-3B", new byte[] { 134, 76, 243, 38, 126, 62, 37, 35, 121, 177, 120, 94, 62, 170, 132, 182, 15, 146, 247, 166, 201, 179, 158, 34, 195, 32, 4, 136, 20, 248, 153, 108, 162, 52, 9, 146, 145, 228, 152, 126, 177, 147, 132, 8, 9, 78, 217, 175, 176, 84, 132, 59, 57, 46, 207, 191, 146, 1, 84, 130, 199, 77, 89, 25 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100004,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "BD-B3-BE-37-90-A7-54-78-62-39-1F-19-49-58-74-B6-62-9B-6A-77-54-17-41-24-17-44-7E-3C-20-B7-73-3F", new byte[] { 121, 84, 79, 42, 52, 69, 211, 150, 139, 70, 39, 55, 41, 182, 117, 139, 14, 150, 233, 68, 51, 48, 231, 174, 78, 72, 79, 30, 27, 65, 187, 80, 36, 227, 206, 179, 83, 255, 133, 89, 244, 27, 12, 64, 107, 183, 110, 17, 211, 48, 143, 31, 169, 16, 15, 139, 181, 130, 236, 239, 162, 123, 153, 70 } });

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0a9c8263-7f5e-4e25-bb85-7a4c0a1e3a5c"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0bb3c011-9ba9-47e7-9ce0-3268f85e1ffc"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("18a64e64-3707-451c-b54d-51dbb9933aa0"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("1b234567-89ab-cdef-0123-456789abcdef"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("2b7c5a63-8e93-4d88-bc90-85c42d1574ae"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("34f2c84e-6c77-4c4a-b5f3-eef62d87b4be"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("3d8f49b2-ef8b-4b3e-8f5d-1f68d8f4f4b1"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("4d8d76aa-48e5-4c2b-95f1-5a77c73c0f11"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("59259348-41da-4bbc-b85c-48ee82f474ce"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5a6e8d59-0c3d-4e54-a105-50f44dcb9e4b"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5e4f2822-bb47-45b4-83c0-6c1de2b5f900"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("72b24a8d-4e5b-43e5-aeae-ecf9dc1b52d9"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("7f1f7c59-f92e-4c3b-a3f4-9c2a4cd474cb"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8b5c0f77-e3f1-4972-9102-6c1dfbb5a601"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8d5c8e30-dede-4ef0-9158-f7692c41acb2"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9b7f3e43-50bc-41d5-8f43-b8e0e1f47732"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e7b22d3-c5a5-429e-82dc-e5c573745e1d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("c7f1f4f5-74e3-4b4f-9c5a-3e2059d8b72d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("e43ff624-3f3c-4e8e-b5eb-11c0c3a244fa"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("f3b00c12-3b5e-4c8e-9bb0-7a5c7408cd07"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23"),
                column: "GamePicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Games/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23.jpg");
        }
    }
}
