using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class render : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c4f5e3e1-2c4c-4f4e-a4d1-5e5e6139d703"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 16, 51, 53, 635, DateTimeKind.Utc).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c9ebf2c7-5a7f-4b5d-bb7f-2f2c4d8e4a88"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 16, 51, 53, 635, DateTimeKind.Utc).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("d3c4b5e8-1f3a-4c8c-897e-2d8cf3e7c4f6"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 16, 51, 53, 635, DateTimeKind.Utc).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 16, 51, 53, 635, DateTimeKind.Utc).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "C8-72-17-E3-F4-AD-87-E4-EE-68-CD-29-A0-64-9D-50-7F-B1-27-BA-18-A0-C0-9F-DF-3D-20-C1-1A-DB-71-52", new byte[] { 28, 0, 162, 14, 206, 92, 250, 137, 165, 135, 236, 139, 96, 3, 180, 87, 241, 83, 82, 225, 101, 4, 241, 46, 242, 62, 108, 136, 230, 172, 43, 129, 127, 49, 64, 222, 141, 202, 224, 225, 137, 132, 103, 159, 120, 21, 183, 64, 95, 233, 215, 91, 154, 2, 94, 88, 42, 217, 234, 203, 149, 225, 104, 41 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "E7-57-D9-8F-24-A5-79-7D-19-30-ED-21-66-30-6F-99-D3-62-C4-85-0B-6A-31-E5-B4-4C-65-B7-40-D5-2B-B5", new byte[] { 187, 244, 88, 54, 191, 77, 186, 40, 181, 21, 190, 20, 61, 10, 60, 225, 201, 107, 167, 248, 92, 46, 101, 148, 52, 170, 108, 25, 134, 60, 6, 64, 102, 77, 236, 12, 47, 76, 251, 215, 36, 54, 103, 234, 26, 156, 126, 51, 36, 185, 54, 160, 190, 250, 255, 244, 126, 17, 184, 215, 64, 49, 88, 7 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "32-CE-A6-D1-5D-E5-B2-9C-58-21-FF-F7-52-EB-6B-47-A7-B1-5A-94-26-32-F3-20-75-8C-A5-10-41-4C-11-67", new byte[] { 165, 66, 218, 219, 160, 147, 72, 106, 68, 150, 91, 28, 246, 160, 39, 140, 45, 169, 73, 44, 245, 100, 178, 7, 39, 180, 245, 200, 165, 103, 141, 100, 177, 84, 30, 89, 55, 193, 54, 202, 198, 102, 180, 171, 91, 70, 147, 126, 184, 21, 63, 7, 142, 199, 96, 172, 237, 1, 242, 124, 250, 1, 149, 144 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "41-5B-55-7B-CB-4A-EF-89-F4-D4-9E-9A-D9-99-DA-46-C1-DB-92-CC-37-C7-8A-B0-35-48-2E-07-67-C7-53-73", new byte[] { 118, 127, 148, 45, 251, 84, 123, 121, 143, 208, 7, 1, 133, 43, 240, 13, 160, 1, 27, 114, 199, 177, 251, 33, 41, 226, 14, 163, 58, 231, 123, 115, 182, 77, 29, 161, 32, 94, 245, 255, 164, 209, 52, 185, 122, 147, 31, 202, 77, 235, 111, 209, 90, 139, 165, 75, 107, 173, 96, 73, 121, 0, 153, 205 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "97-4D-54-6E-B3-38-9D-0B-6E-08-24-17-53-C4-F4-48-16-06-C4-73-74-D1-39-0B-B3-E3-6E-96-5C-35-6E-56", new byte[] { 43, 14, 100, 119, 109, 118, 22, 123, 112, 121, 119, 60, 170, 222, 13, 179, 42, 131, 229, 153, 170, 236, 133, 236, 200, 79, 154, 182, 107, 242, 194, 44, 99, 64, 197, 213, 125, 70, 83, 110, 9, 115, 225, 113, 135, 127, 53, 216, 164, 118, 109, 249, 253, 152, 235, 106, 178, 193, 247, 206, 45, 229, 47, 72 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "94-B1-32-3A-45-E1-67-5F-44-ED-BE-91-08-B0-AF-DA-65-3E-E3-A3-9D-B7-4C-81-79-89-07-BD-DD-0A-D7-B0", new byte[] { 242, 4, 232, 169, 253, 225, 248, 0, 209, 154, 55, 166, 193, 203, 81, 150, 60, 54, 147, 129, 208, 88, 204, 213, 57, 90, 121, 52, 110, 26, 34, 203, 41, 139, 112, 26, 211, 156, 125, 83, 125, 95, 179, 253, 236, 23, 129, 50, 212, 201, 84, 200, 73, 182, 213, 235, 165, 233, 51, 103, 110, 247, 209, 63 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "16-C1-F3-A9-07-EE-D8-85-75-AB-EF-44-53-A3-1F-C6-7B-13-61-2B-51-00-A0-85-0C-A8-3B-F1-52-54-14-CE", new byte[] { 31, 178, 195, 28, 147, 82, 248, 111, 190, 164, 140, 172, 121, 64, 204, 16, 121, 204, 215, 78, 206, 136, 120, 24, 240, 186, 56, 130, 187, 88, 132, 101, 240, 158, 230, 184, 104, 52, 123, 235, 234, 131, 70, 235, 90, 205, 7, 75, 249, 241, 226, 159, 134, 106, 148, 77, 248, 207, 69, 23, 176, 122, 114, 143 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "86-22-31-E3-98-E0-AD-76-89-DA-CA-64-3E-4D-49-A0-85-08-6C-AC-68-CE-5F-B5-E8-48-A1-A5-EF-D0-51-26", new byte[] { 166, 48, 237, 184, 72, 224, 75, 154, 82, 111, 85, 218, 138, 87, 94, 155, 115, 207, 228, 3, 203, 138, 253, 89, 33, 78, 31, 123, 186, 92, 67, 239, 29, 127, 94, 101, 230, 73, 213, 177, 174, 141, 216, 69, 25, 5, 161, 153, 85, 234, 99, 181, 183, 58, 93, 47, 99, 17, 56, 17, 216, 40, 14, 221 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "BB-7A-DE-DF-9A-0B-AC-56-31-E0-E9-F9-A0-FF-A1-2B-38-4E-7E-B1-8A-37-C9-E7-70-6B-3E-47-B8-AD-46-8A", new byte[] { 154, 84, 155, 233, 139, 44, 248, 19, 150, 233, 96, 97, 250, 236, 72, 239, 150, 182, 9, 106, 56, 145, 213, 212, 52, 161, 46, 187, 16, 244, 180, 213, 25, 104, 28, 58, 157, 205, 46, 67, 107, 85, 99, 165, 71, 114, 165, 134, 98, 36, 219, 98, 252, 36, 31, 219, 72, 35, 213, 159, 13, 15, 15, 192 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100004,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "8B-56-97-D4-9F-50-6F-61-FB-07-DD-2C-6F-A8-63-75-F1-90-19-5A-F2-52-52-FD-B1-12-DD-46-99-20-81-F1", new byte[] { 187, 159, 218, 203, 183, 130, 23, 162, 0, 248, 34, 173, 67, 154, 47, 87, 76, 39, 100, 125, 105, 182, 196, 165, 106, 8, 103, 129, 159, 54, 39, 15, 141, 93, 44, 77, 11, 112, 146, 20, 112, 211, 122, 62, 182, 3, 72, 51, 17, 191, 252, 231, 228, 177, 179, 217, 175, 68, 90, 81, 232, 41, 86, 45 } });

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0a9c8263-7f5e-4e25-bb85-7a4c0a1e3a5c"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 51, 53, 635, DateTimeKind.Utc).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0bb3c011-9ba9-47e7-9ce0-3268f85e1ffc"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 51, 53, 635, DateTimeKind.Utc).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("18a64e64-3707-451c-b54d-51dbb9933aa0"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 51, 53, 635, DateTimeKind.Utc).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("1b234567-89ab-cdef-0123-456789abcdef"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 51, 53, 635, DateTimeKind.Utc).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("2b7c5a63-8e93-4d88-bc90-85c42d1574ae"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 51, 53, 635, DateTimeKind.Utc).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("34f2c84e-6c77-4c4a-b5f3-eef62d87b4be"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 51, 53, 635, DateTimeKind.Utc).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("3d8f49b2-ef8b-4b3e-8f5d-1f68d8f4f4b1"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 51, 53, 635, DateTimeKind.Utc).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("4d8d76aa-48e5-4c2b-95f1-5a77c73c0f11"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 51, 53, 635, DateTimeKind.Utc).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("59259348-41da-4bbc-b85c-48ee82f474ce"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 51, 53, 635, DateTimeKind.Utc).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5a6e8d59-0c3d-4e54-a105-50f44dcb9e4b"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 51, 53, 635, DateTimeKind.Utc).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5e4f2822-bb47-45b4-83c0-6c1de2b5f900"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 51, 53, 635, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("72b24a8d-4e5b-43e5-aeae-ecf9dc1b52d9"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 51, 53, 635, DateTimeKind.Utc).AddTicks(5183));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("7f1f7c59-f92e-4c3b-a3f4-9c2a4cd474cb"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 51, 53, 635, DateTimeKind.Utc).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8b5c0f77-e3f1-4972-9102-6c1dfbb5a601"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 51, 53, 635, DateTimeKind.Utc).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8d5c8e30-dede-4ef0-9158-f7692c41acb2"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 51, 53, 635, DateTimeKind.Utc).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9b7f3e43-50bc-41d5-8f43-b8e0e1f47732"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 51, 53, 635, DateTimeKind.Utc).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e7b22d3-c5a5-429e-82dc-e5c573745e1d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 51, 53, 635, DateTimeKind.Utc).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("c7f1f4f5-74e3-4b4f-9c5a-3e2059d8b72d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 51, 53, 635, DateTimeKind.Utc).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("e43ff624-3f3c-4e8e-b5eb-11c0c3a244fa"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 51, 53, 635, DateTimeKind.Utc).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("f3b00c12-3b5e-4c8e-9bb0-7a5c7408cd07"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 51, 53, 635, DateTimeKind.Utc).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23"),
                column: "GamePicturePath",
                value: "https://gamesland.onrender.com/images/Games/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c4f5e3e1-2c4c-4f4e-a4d1-5e5e6139d703"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c9ebf2c7-5a7f-4b5d-bb7f-2f2c4d8e4a88"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("d3c4b5e8-1f3a-4c8c-897e-2d8cf3e7c4f6"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "C0-98-36-8D-2E-AF-71-30-F9-05-BB-60-2C-73-01-7F-4E-45-73-59-5B-A1-7D-F7-11-0A-9B-03-87-FC-C9-98", new byte[] { 102, 174, 31, 251, 137, 114, 47, 46, 33, 56, 87, 88, 17, 231, 246, 114, 214, 63, 255, 37, 172, 76, 139, 40, 255, 109, 249, 126, 39, 64, 106, 209, 234, 92, 123, 76, 189, 195, 33, 6, 139, 127, 86, 226, 147, 177, 31, 253, 235, 20, 81, 88, 197, 72, 189, 16, 130, 203, 179, 75, 174, 70, 18, 48 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "5E-7D-90-60-BB-09-10-2F-47-22-6A-65-90-1C-8B-C9-79-16-04-D2-7B-79-BD-8D-F6-1A-A8-9C-29-2D-FF-65", new byte[] { 61, 77, 191, 139, 107, 186, 62, 17, 88, 6, 132, 94, 75, 34, 213, 179, 69, 40, 219, 168, 252, 115, 11, 133, 186, 139, 27, 183, 249, 145, 221, 175, 109, 250, 49, 74, 53, 161, 98, 135, 185, 66, 108, 48, 152, 205, 238, 166, 29, 48, 95, 114, 127, 140, 15, 16, 151, 141, 209, 238, 14, 64, 182, 158 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "44-81-DE-E4-F7-AE-4C-D4-FC-EE-CD-F9-A5-ED-A9-9C-16-F4-BF-6A-73-87-E9-DA-A4-87-F0-73-7E-47-9D-A2", new byte[] { 67, 8, 116, 39, 48, 10, 220, 79, 20, 136, 179, 48, 241, 255, 252, 15, 250, 130, 195, 252, 27, 255, 76, 5, 144, 188, 49, 128, 205, 74, 7, 5, 153, 123, 133, 116, 108, 69, 41, 49, 247, 163, 213, 210, 221, 43, 214, 189, 252, 81, 220, 83, 148, 159, 140, 46, 141, 196, 215, 253, 43, 135, 120, 60 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "12-EC-FB-7C-91-8F-C8-90-FF-6C-05-6B-87-27-51-1C-48-AF-26-60-9F-46-0E-41-11-C5-E2-9A-01-09-82-D0", new byte[] { 29, 242, 120, 58, 141, 50, 124, 237, 84, 189, 37, 199, 98, 153, 144, 219, 248, 195, 239, 139, 22, 240, 223, 151, 203, 73, 48, 76, 144, 96, 183, 122, 71, 103, 157, 84, 113, 15, 236, 47, 58, 218, 152, 87, 181, 178, 205, 240, 207, 70, 216, 149, 133, 108, 82, 126, 149, 228, 66, 188, 51, 240, 86, 177 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "AB-5C-7D-63-9A-3D-B4-DD-9A-DF-66-2F-95-CA-9A-67-A5-E3-DF-F9-A7-C4-31-D3-3C-AA-DC-D8-F5-50-5A-57", new byte[] { 117, 227, 177, 56, 160, 120, 63, 107, 14, 117, 74, 199, 163, 28, 170, 147, 70, 78, 192, 108, 41, 175, 164, 216, 181, 44, 118, 108, 154, 15, 80, 5, 96, 111, 221, 64, 226, 135, 95, 98, 213, 220, 182, 175, 29, 110, 157, 43, 227, 228, 217, 153, 62, 15, 1, 94, 76, 207, 241, 139, 164, 111, 114, 148 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "11-14-57-32-C3-6B-CD-F3-7C-55-C1-1D-BF-B6-1D-05-E6-29-88-C5-CA-A8-4C-44-2B-86-9A-C4-02-A8-B6-DD", new byte[] { 248, 225, 84, 189, 248, 10, 169, 170, 136, 84, 44, 29, 128, 16, 96, 135, 104, 200, 63, 14, 182, 199, 91, 181, 97, 37, 173, 173, 95, 140, 212, 111, 170, 2, 219, 140, 53, 50, 111, 153, 91, 223, 181, 27, 116, 140, 8, 95, 116, 229, 190, 222, 180, 177, 163, 20, 67, 98, 249, 229, 112, 203, 242, 59 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "37-BD-52-04-DD-B5-9B-D9-7C-74-EA-FE-24-52-71-41-5F-2C-CE-06-3B-30-06-4E-AA-0D-B6-F8-96-C6-B5-32", new byte[] { 34, 118, 153, 95, 253, 90, 87, 67, 208, 220, 82, 201, 192, 32, 160, 160, 219, 142, 75, 87, 147, 63, 133, 212, 41, 213, 145, 39, 135, 84, 127, 223, 50, 151, 189, 222, 106, 254, 100, 59, 220, 40, 73, 100, 129, 96, 132, 119, 128, 114, 23, 75, 38, 120, 77, 59, 103, 2, 217, 227, 39, 22, 209, 110 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "85-5C-7F-12-B1-C8-08-C4-D5-8A-CB-A2-68-90-B0-8D-E9-72-E5-5D-19-1C-D3-5D-67-18-6B-5A-EA-88-58-B2", new byte[] { 162, 82, 144, 174, 50, 131, 213, 42, 93, 83, 195, 76, 55, 88, 54, 226, 52, 38, 15, 83, 68, 146, 162, 235, 117, 72, 3, 148, 121, 229, 73, 254, 188, 100, 34, 218, 0, 17, 3, 217, 81, 26, 23, 0, 76, 207, 225, 224, 168, 163, 229, 24, 46, 188, 229, 243, 163, 27, 183, 39, 164, 104, 6, 222 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "D0-7E-8C-C7-FA-22-C3-11-B2-26-48-B8-EE-6C-1E-E1-85-80-F2-82-AB-56-9A-D6-09-57-B5-E9-3D-4D-F4-62", new byte[] { 4, 153, 89, 120, 170, 197, 201, 21, 124, 174, 174, 102, 202, 181, 179, 0, 27, 239, 69, 74, 57, 2, 42, 94, 176, 10, 232, 193, 177, 181, 252, 153, 193, 194, 173, 97, 111, 218, 70, 226, 16, 117, 110, 232, 88, 157, 160, 34, 73, 121, 3, 121, 2, 64, 143, 252, 163, 189, 185, 141, 136, 73, 246, 185 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100004,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "75-35-D8-A2-6F-11-A2-39-EA-DA-88-7A-38-06-9E-A1-2F-2F-09-75-C0-2E-2C-B8-B5-98-E7-17-AC-47-42-B0", new byte[] { 77, 189, 142, 84, 38, 38, 153, 68, 86, 61, 57, 11, 108, 167, 205, 171, 168, 4, 192, 213, 104, 207, 45, 29, 219, 40, 195, 205, 90, 2, 109, 70, 11, 128, 51, 26, 242, 185, 210, 233, 93, 158, 233, 205, 111, 96, 141, 2, 199, 123, 62, 213, 127, 185, 179, 73, 76, 96, 219, 188, 104, 164, 242, 100 } });

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0a9c8263-7f5e-4e25-bb85-7a4c0a1e3a5c"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0bb3c011-9ba9-47e7-9ce0-3268f85e1ffc"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("18a64e64-3707-451c-b54d-51dbb9933aa0"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("1b234567-89ab-cdef-0123-456789abcdef"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("2b7c5a63-8e93-4d88-bc90-85c42d1574ae"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("34f2c84e-6c77-4c4a-b5f3-eef62d87b4be"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("3d8f49b2-ef8b-4b3e-8f5d-1f68d8f4f4b1"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("4d8d76aa-48e5-4c2b-95f1-5a77c73c0f11"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("59259348-41da-4bbc-b85c-48ee82f474ce"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5a6e8d59-0c3d-4e54-a105-50f44dcb9e4b"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5e4f2822-bb47-45b4-83c0-6c1de2b5f900"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("72b24a8d-4e5b-43e5-aeae-ecf9dc1b52d9"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("7f1f7c59-f92e-4c3b-a3f4-9c2a4cd474cb"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8b5c0f77-e3f1-4972-9102-6c1dfbb5a601"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8d5c8e30-dede-4ef0-9158-f7692c41acb2"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9b7f3e43-50bc-41d5-8f43-b8e0e1f47732"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e7b22d3-c5a5-429e-82dc-e5c573745e1d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("c7f1f4f5-74e3-4b4f-9c5a-3e2059d8b72d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("e43ff624-3f3c-4e8e-b5eb-11c0c3a244fa"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("f3b00c12-3b5e-4c8e-9bb0-7a5c7408cd07"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23"),
                column: "GamePicturePath",
                value: "http://localhost:5125/images/Games/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23.jpg");
        }
    }
}
