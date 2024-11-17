using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class pic8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c4f5e3e1-2c4c-4f4e-a4d1-5e5e6139d703"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c9ebf2c7-5a7f-4b5d-bb7f-2f2c4d8e4a88"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(169));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("d3c4b5e8-1f3a-4c8c-897e-2d8cf3e7c4f6"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "FB-7F-26-46-89-84-34-3D-D0-39-E1-96-1B-1C-C8-AC-9C-08-AD-63-5C-16-CF-73-AC-65-3A-75-00-57-38-29", new byte[] { 150, 217, 146, 12, 119, 18, 224, 149, 14, 84, 219, 128, 65, 101, 49, 114, 29, 17, 94, 222, 48, 151, 211, 68, 45, 222, 99, 109, 57, 189, 36, 111, 123, 50, 120, 206, 39, 2, 195, 226, 188, 146, 40, 81, 209, 126, 227, 69, 105, 203, 42, 2, 28, 173, 103, 188, 143, 101, 40, 188, 212, 169, 195, 141 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "6D-ED-03-E6-72-F7-7D-19-16-9D-E3-97-35-68-4E-19-72-1A-2E-3F-BB-53-9E-53-6C-86-A8-D3-11-12-0C-4E", new byte[] { 244, 233, 127, 121, 235, 155, 200, 117, 167, 225, 231, 42, 114, 202, 219, 101, 180, 143, 91, 95, 160, 191, 77, 18, 25, 177, 47, 156, 238, 56, 162, 167, 201, 17, 80, 11, 113, 242, 140, 117, 23, 89, 94, 84, 130, 172, 216, 74, 31, 23, 115, 200, 162, 57, 73, 187, 71, 111, 26, 110, 177, 200, 238, 47 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "74-5A-BA-0D-C7-EB-C2-4F-62-1E-65-45-79-A7-F1-7D-30-73-DE-03-58-9A-19-8A-21-CA-08-EE-25-12-EB-16", new byte[] { 50, 77, 122, 158, 213, 177, 139, 52, 199, 32, 142, 89, 37, 55, 207, 244, 239, 32, 107, 15, 135, 127, 46, 185, 128, 164, 167, 76, 103, 164, 82, 170, 103, 26, 170, 218, 151, 240, 163, 112, 12, 2, 75, 215, 56, 238, 198, 119, 252, 2, 61, 159, 81, 151, 253, 125, 132, 176, 204, 213, 157, 237, 102, 187 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "DB-9B-67-92-A5-F2-46-E9-8C-18-9C-A5-EF-8C-56-0B-77-A3-C0-67-B3-E4-B9-3B-A9-53-E0-15-CB-B2-5D-4B", new byte[] { 99, 0, 72, 63, 121, 207, 25, 9, 224, 22, 32, 63, 72, 13, 114, 120, 43, 77, 187, 54, 115, 76, 93, 56, 3, 46, 158, 75, 175, 6, 27, 119, 76, 200, 131, 235, 245, 61, 186, 231, 95, 7, 86, 34, 102, 184, 71, 24, 74, 2, 36, 196, 40, 34, 27, 234, 206, 65, 154, 223, 72, 184, 40, 160 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "A9-8A-49-07-0C-74-AD-20-DE-CC-10-77-57-0F-24-E1-95-CC-EC-88-28-6A-D1-AE-55-8B-F2-3D-A6-74-16-A1", new byte[] { 136, 28, 96, 58, 248, 167, 130, 143, 14, 28, 161, 18, 203, 58, 43, 21, 15, 160, 154, 236, 213, 44, 140, 135, 166, 81, 131, 127, 203, 116, 11, 83, 208, 71, 63, 227, 129, 143, 122, 49, 27, 26, 141, 131, 65, 111, 228, 219, 56, 211, 198, 127, 117, 216, 54, 253, 53, 231, 182, 4, 224, 149, 99, 242 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "47-49-46-7C-EE-A9-2B-27-73-3F-20-CA-37-51-AF-54-71-F8-98-A2-F5-07-C6-47-4E-A6-D3-0A-58-6E-E8-2D", new byte[] { 137, 224, 199, 248, 159, 43, 233, 101, 147, 12, 156, 71, 113, 197, 88, 66, 69, 217, 15, 190, 100, 3, 135, 62, 41, 249, 198, 168, 123, 230, 213, 234, 96, 123, 8, 234, 174, 23, 190, 5, 49, 27, 8, 45, 249, 120, 115, 200, 219, 144, 238, 21, 102, 195, 143, 231, 198, 122, 4, 73, 219, 172, 145, 197 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "40-79-DF-F3-C2-69-B5-00-AE-9E-98-14-1B-79-59-DB-47-CE-9E-1D-41-1E-2E-71-2A-2E-A0-A0-9F-A8-FD-44", new byte[] { 17, 65, 51, 32, 167, 83, 115, 151, 193, 170, 10, 47, 91, 114, 152, 148, 190, 226, 153, 180, 76, 81, 231, 71, 116, 76, 30, 24, 37, 62, 165, 239, 25, 240, 176, 229, 156, 159, 228, 122, 11, 235, 6, 127, 42, 159, 11, 9, 237, 86, 134, 105, 218, 141, 216, 4, 35, 139, 19, 34, 230, 143, 199, 82 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "3D-79-38-E3-1A-41-28-46-3D-D3-0F-5B-A6-F8-A3-BF-3B-4E-7E-0B-CA-FA-8E-A0-D2-D6-9D-0E-37-19-93-93", new byte[] { 216, 105, 191, 95, 253, 131, 251, 123, 236, 84, 16, 75, 38, 220, 120, 25, 169, 161, 41, 27, 168, 252, 211, 220, 141, 204, 171, 215, 114, 126, 29, 71, 48, 251, 199, 250, 108, 104, 107, 191, 210, 133, 133, 168, 124, 188, 170, 72, 217, 141, 97, 161, 101, 254, 142, 55, 161, 241, 101, 204, 115, 92, 206, 216 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "DD-82-E3-C8-38-35-B8-51-72-E3-EE-89-E2-24-C1-F3-DA-6D-6F-5E-DD-A4-14-75-90-13-60-09-25-E9-BD-31", new byte[] { 95, 130, 255, 105, 20, 46, 118, 53, 168, 99, 63, 87, 115, 120, 189, 195, 146, 192, 32, 94, 6, 207, 134, 20, 232, 142, 248, 194, 0, 144, 87, 206, 97, 160, 202, 41, 91, 194, 155, 124, 119, 95, 41, 121, 73, 61, 95, 86, 133, 25, 171, 110, 179, 62, 156, 123, 43, 76, 8, 242, 33, 224, 94, 217 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100004,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "76-08-F7-C8-68-BA-85-E9-FF-CE-F7-B3-40-7B-B1-B2-07-44-8E-8F-A9-3B-DB-98-F5-E6-79-F8-E6-E4-39-5B", new byte[] { 220, 220, 218, 172, 165, 135, 66, 106, 7, 186, 127, 170, 50, 163, 0, 31, 71, 121, 178, 237, 56, 129, 175, 195, 183, 125, 88, 16, 245, 181, 93, 156, 138, 61, 73, 0, 220, 148, 22, 204, 84, 1, 13, 98, 24, 63, 180, 206, 143, 191, 134, 127, 14, 125, 216, 249, 49, 199, 185, 71, 59, 63, 215, 200 } });

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0a9c8263-7f5e-4e25-bb85-7a4c0a1e3a5c"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0bb3c011-9ba9-47e7-9ce0-3268f85e1ffc"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 19, 57, 220, DateTimeKind.Utc).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("18a64e64-3707-451c-b54d-51dbb9933aa0"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("1b234567-89ab-cdef-0123-456789abcdef"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("2b7c5a63-8e93-4d88-bc90-85c42d1574ae"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("34f2c84e-6c77-4c4a-b5f3-eef62d87b4be"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("3d8f49b2-ef8b-4b3e-8f5d-1f68d8f4f4b1"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("4d8d76aa-48e5-4c2b-95f1-5a77c73c0f11"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("59259348-41da-4bbc-b85c-48ee82f474ce"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5a6e8d59-0c3d-4e54-a105-50f44dcb9e4b"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(12));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5e4f2822-bb47-45b4-83c0-6c1de2b5f900"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("72b24a8d-4e5b-43e5-aeae-ecf9dc1b52d9"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("7f1f7c59-f92e-4c3b-a3f4-9c2a4cd474cb"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8b5c0f77-e3f1-4972-9102-6c1dfbb5a601"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8d5c8e30-dede-4ef0-9158-f7692c41acb2"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9b7f3e43-50bc-41d5-8f43-b8e0e1f47732"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e7b22d3-c5a5-429e-82dc-e5c573745e1d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(15));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("c7f1f4f5-74e3-4b4f-9c5a-3e2059d8b72d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(27));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("e43ff624-3f3c-4e8e-b5eb-11c0c3a244fa"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("f3b00c12-3b5e-4c8e-9bb0-7a5c7408cd07"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(31));

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23"),
                column: "GamePicturePath",
                value: "./wwwroot/images/Games/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c4f5e3e1-2c4c-4f4e-a4d1-5e5e6139d703"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 16, 16, 33, 964, DateTimeKind.Utc).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c9ebf2c7-5a7f-4b5d-bb7f-2f2c4d8e4a88"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 16, 16, 33, 964, DateTimeKind.Utc).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("d3c4b5e8-1f3a-4c8c-897e-2d8cf3e7c4f6"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 16, 16, 33, 964, DateTimeKind.Utc).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 16, 16, 33, 964, DateTimeKind.Utc).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "DF-F4-E5-0D-78-DF-22-5E-8B-E2-4F-85-0D-64-F6-3E-B8-19-04-D4-90-2C-44-6F-B1-8F-CA-84-FD-6B-79-D0", new byte[] { 49, 175, 182, 198, 158, 145, 141, 206, 56, 130, 69, 148, 148, 136, 146, 62, 251, 23, 163, 21, 11, 45, 73, 148, 210, 201, 210, 83, 39, 8, 140, 162, 109, 110, 214, 230, 16, 168, 28, 247, 35, 126, 27, 13, 116, 240, 121, 23, 91, 215, 200, 85, 253, 144, 188, 76, 18, 45, 212, 97, 51, 242, 169, 150 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "8E-69-A0-1D-67-1E-40-25-14-EF-AF-4D-55-90-E9-B0-71-02-FF-B4-B8-0B-39-94-66-A9-D5-41-3A-78-2C-71", new byte[] { 218, 146, 89, 116, 61, 43, 212, 191, 206, 175, 191, 33, 63, 212, 228, 185, 207, 25, 36, 98, 114, 13, 87, 72, 56, 248, 81, 162, 118, 70, 161, 165, 110, 103, 34, 74, 0, 37, 146, 234, 25, 253, 40, 156, 21, 47, 52, 68, 175, 37, 35, 131, 226, 223, 109, 183, 7, 100, 176, 184, 192, 41, 221, 108 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "8F-1A-EE-D5-7C-62-C5-BC-31-52-E0-30-70-ED-10-74-9F-51-21-43-0B-B4-B9-7A-35-65-44-85-7F-41-F6-0B", new byte[] { 9, 149, 217, 226, 4, 191, 87, 223, 90, 76, 192, 151, 219, 47, 176, 150, 185, 102, 186, 163, 225, 239, 226, 155, 42, 123, 85, 125, 52, 128, 249, 5, 134, 166, 31, 121, 197, 232, 101, 178, 229, 116, 8, 56, 201, 42, 125, 223, 15, 11, 94, 99, 9, 19, 5, 179, 30, 91, 191, 67, 102, 107, 54, 11 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "9C-6E-4A-87-0D-B0-0F-89-4A-4D-DA-E2-5D-24-0B-FF-F1-16-06-DE-08-D3-C4-D9-D0-E9-5D-5D-6B-3E-AA-39", new byte[] { 191, 14, 212, 220, 99, 42, 80, 146, 85, 252, 36, 254, 161, 175, 92, 245, 166, 88, 178, 58, 122, 202, 241, 18, 237, 206, 55, 140, 148, 207, 44, 38, 33, 251, 139, 56, 87, 13, 164, 180, 239, 128, 65, 12, 145, 4, 97, 41, 218, 190, 125, 183, 35, 80, 117, 190, 170, 243, 242, 156, 227, 159, 200, 249 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "C1-3C-61-87-97-E3-27-82-00-E5-F4-A8-73-43-DB-99-F4-22-00-F9-E6-F1-5F-6B-EE-76-BC-C4-98-78-1B-8E", new byte[] { 248, 252, 124, 66, 51, 222, 156, 114, 186, 248, 206, 187, 223, 14, 247, 170, 70, 228, 69, 59, 28, 6, 76, 171, 116, 219, 156, 204, 173, 229, 129, 193, 100, 59, 113, 211, 172, 73, 225, 13, 87, 134, 142, 96, 141, 51, 46, 204, 80, 112, 87, 38, 21, 139, 68, 29, 154, 105, 250, 209, 154, 97, 4, 120 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "EF-C8-34-70-57-9B-B7-FE-FB-6C-5C-48-EB-3B-5F-CE-F9-C0-82-B9-8C-39-5F-6E-40-CF-0A-E2-22-11-B0-64", new byte[] { 170, 108, 144, 108, 87, 236, 147, 140, 73, 218, 20, 87, 65, 245, 165, 166, 110, 14, 16, 72, 147, 136, 96, 248, 210, 5, 206, 79, 240, 143, 116, 207, 221, 211, 145, 29, 158, 235, 29, 51, 104, 72, 82, 192, 7, 181, 178, 141, 155, 17, 17, 234, 187, 50, 35, 126, 25, 106, 13, 92, 1, 173, 82, 87 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "E2-4D-AC-86-6B-49-D8-D0-A9-91-7C-AF-3B-34-09-9E-14-92-50-69-F8-0D-5D-87-0D-A6-06-09-98-A8-A9-5B", new byte[] { 13, 1, 75, 212, 25, 11, 85, 49, 27, 224, 156, 138, 18, 147, 187, 10, 76, 8, 145, 210, 151, 68, 167, 14, 84, 39, 123, 182, 13, 237, 169, 214, 248, 163, 166, 146, 48, 125, 108, 180, 253, 58, 122, 223, 175, 34, 22, 131, 57, 221, 238, 31, 196, 4, 75, 238, 42, 97, 69, 28, 139, 138, 228, 240 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "D3-A2-90-55-12-0A-47-9B-24-41-8B-11-57-05-E1-BE-D8-4F-26-35-8B-17-54-CC-DD-1E-4D-8F-C5-50-58-C0", new byte[] { 237, 167, 143, 227, 235, 20, 181, 75, 25, 8, 10, 247, 115, 203, 119, 31, 227, 163, 31, 152, 173, 61, 49, 93, 197, 110, 189, 107, 116, 184, 56, 250, 183, 12, 236, 95, 81, 204, 201, 193, 204, 249, 206, 138, 56, 183, 111, 52, 80, 228, 64, 33, 62, 64, 118, 105, 30, 201, 130, 140, 38, 160, 152, 245 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "9D-57-FC-E4-75-97-77-2C-4A-9F-BA-7C-BB-55-09-6F-BB-4E-DD-46-9F-1C-82-32-6E-87-F6-2C-CC-D4-4D-68", new byte[] { 99, 97, 131, 74, 129, 228, 62, 188, 90, 95, 228, 73, 60, 65, 90, 47, 155, 83, 191, 53, 245, 205, 101, 58, 3, 136, 146, 139, 116, 168, 3, 108, 165, 37, 172, 155, 189, 17, 209, 113, 4, 238, 70, 24, 119, 39, 108, 187, 86, 19, 18, 40, 145, 232, 245, 36, 1, 86, 33, 43, 114, 50, 230, 30 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100004,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "CD-71-E7-5D-74-75-CB-05-BD-4A-F6-1C-0F-68-2B-68-FD-4D-E5-34-BF-77-8E-D1-3B-56-E3-7D-0F-84-FB-01", new byte[] { 228, 129, 199, 142, 7, 102, 32, 217, 108, 163, 5, 98, 92, 90, 171, 68, 5, 201, 214, 81, 94, 200, 205, 251, 248, 252, 249, 137, 115, 207, 165, 229, 107, 199, 254, 230, 236, 90, 25, 13, 218, 198, 212, 191, 250, 215, 17, 98, 146, 167, 116, 88, 88, 1, 138, 106, 88, 190, 78, 43, 205, 43, 130, 81 } });

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0a9c8263-7f5e-4e25-bb85-7a4c0a1e3a5c"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 16, 33, 964, DateTimeKind.Utc).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0bb3c011-9ba9-47e7-9ce0-3268f85e1ffc"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 16, 33, 964, DateTimeKind.Utc).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("18a64e64-3707-451c-b54d-51dbb9933aa0"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 16, 33, 964, DateTimeKind.Utc).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("1b234567-89ab-cdef-0123-456789abcdef"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 16, 33, 964, DateTimeKind.Utc).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("2b7c5a63-8e93-4d88-bc90-85c42d1574ae"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 16, 33, 964, DateTimeKind.Utc).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("34f2c84e-6c77-4c4a-b5f3-eef62d87b4be"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 16, 33, 964, DateTimeKind.Utc).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("3d8f49b2-ef8b-4b3e-8f5d-1f68d8f4f4b1"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 16, 33, 964, DateTimeKind.Utc).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("4d8d76aa-48e5-4c2b-95f1-5a77c73c0f11"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 16, 33, 964, DateTimeKind.Utc).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("59259348-41da-4bbc-b85c-48ee82f474ce"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 16, 33, 964, DateTimeKind.Utc).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5a6e8d59-0c3d-4e54-a105-50f44dcb9e4b"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 16, 33, 964, DateTimeKind.Utc).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5e4f2822-bb47-45b4-83c0-6c1de2b5f900"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 16, 33, 964, DateTimeKind.Utc).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("72b24a8d-4e5b-43e5-aeae-ecf9dc1b52d9"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 16, 33, 964, DateTimeKind.Utc).AddTicks(7651));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("7f1f7c59-f92e-4c3b-a3f4-9c2a4cd474cb"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 16, 33, 964, DateTimeKind.Utc).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8b5c0f77-e3f1-4972-9102-6c1dfbb5a601"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 16, 33, 964, DateTimeKind.Utc).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8d5c8e30-dede-4ef0-9158-f7692c41acb2"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 16, 33, 964, DateTimeKind.Utc).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9b7f3e43-50bc-41d5-8f43-b8e0e1f47732"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 16, 33, 964, DateTimeKind.Utc).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e7b22d3-c5a5-429e-82dc-e5c573745e1d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 16, 33, 964, DateTimeKind.Utc).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("c7f1f4f5-74e3-4b4f-9c5a-3e2059d8b72d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 16, 33, 964, DateTimeKind.Utc).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("e43ff624-3f3c-4e8e-b5eb-11c0c3a244fa"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 16, 33, 964, DateTimeKind.Utc).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("f3b00c12-3b5e-4c8e-9bb0-7a5c7408cd07"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 16, 33, 964, DateTimeKind.Utc).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23"),
                column: "GamePicturePath",
                value: "../images/Games/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23.jpg");
        }
    }
}
