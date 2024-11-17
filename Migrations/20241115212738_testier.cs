using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class testier : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c4f5e3e1-2c4c-4f4e-a4d1-5e5e6139d703"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c9ebf2c7-5a7f-4b5d-bb7f-2f2c4d8e4a88"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("d3c4b5e8-1f3a-4c8c-897e-2d8cf3e7c4f6"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "8B-40-52-F2-4B-0A-B4-88-63-99-AC-28-55-53-3E-5F-C4-84-9D-E0-8B-F7-52-70-05-73-48-31-F2-41-5F-0A", new byte[] { 47, 31, 165, 109, 249, 112, 69, 44, 59, 213, 37, 46, 211, 59, 57, 253, 8, 140, 38, 47, 212, 241, 81, 66, 148, 148, 2, 114, 18, 248, 105, 182, 193, 82, 219, 52, 60, 32, 201, 6, 79, 127, 247, 48, 13, 2, 173, 97, 24, 50, 40, 44, 28, 104, 205, 154, 255, 55, 187, 220, 26, 74, 234, 100 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "A6-EE-02-98-7D-C5-D8-D0-EB-2B-FE-43-C6-9B-BD-FC-1F-C5-5E-CB-5B-E4-29-68-52-98-2F-BD-38-02-47-A3", new byte[] { 92, 89, 230, 209, 0, 207, 16, 163, 212, 83, 40, 82, 21, 32, 179, 91, 252, 185, 134, 229, 229, 224, 86, 38, 48, 158, 157, 3, 123, 24, 108, 208, 212, 143, 7, 27, 188, 49, 170, 48, 79, 63, 214, 166, 86, 218, 185, 175, 35, 226, 208, 197, 2, 205, 78, 42, 133, 16, 235, 245, 8, 224, 207, 37 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "59-3C-A0-C7-E0-F2-64-22-C3-40-49-07-6A-45-32-D3-33-E6-6A-1C-5C-42-4F-C3-79-27-92-F4-6B-95-16-65", new byte[] { 174, 67, 143, 140, 210, 177, 132, 231, 90, 88, 107, 33, 149, 14, 31, 151, 19, 145, 167, 148, 10, 152, 201, 165, 146, 43, 220, 194, 87, 52, 136, 36, 11, 8, 206, 144, 19, 216, 115, 177, 236, 198, 173, 85, 115, 39, 251, 171, 8, 69, 187, 254, 11, 53, 64, 247, 221, 245, 3, 4, 183, 4, 159, 238 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "87-7E-99-49-5C-6D-89-C7-25-6D-47-4D-D3-5E-52-A8-EE-B2-15-70-F4-4F-F6-3F-5E-0F-78-0F-F4-B3-0B-BC", new byte[] { 188, 179, 223, 230, 41, 218, 56, 178, 27, 246, 61, 121, 97, 43, 193, 121, 10, 81, 0, 223, 204, 65, 254, 25, 176, 48, 66, 31, 179, 59, 77, 104, 85, 55, 188, 56, 28, 121, 23, 209, 88, 62, 172, 30, 84, 178, 189, 34, 175, 135, 184, 252, 0, 112, 7, 238, 12, 135, 156, 127, 78, 10, 74, 69 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "4E-43-EF-E1-BE-EB-FE-CE-80-89-B7-64-10-24-E7-EB-C7-2B-33-C5-68-62-B6-2A-80-A5-B3-F8-1E-63-A6-94", new byte[] { 168, 168, 49, 80, 46, 84, 158, 186, 210, 11, 15, 35, 35, 72, 6, 11, 129, 237, 193, 230, 166, 138, 7, 207, 230, 159, 249, 30, 6, 254, 191, 252, 33, 112, 52, 170, 59, 153, 214, 206, 218, 207, 4, 220, 68, 29, 112, 236, 85, 233, 64, 70, 234, 122, 76, 170, 171, 125, 141, 2, 92, 195, 22, 63 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "EF-90-D1-39-7A-9C-EC-B7-05-95-B1-19-DC-CA-5F-04-24-15-75-E9-B1-53-00-4F-62-4C-C6-4D-2D-55-3A-4A", new byte[] { 149, 15, 238, 252, 222, 154, 22, 39, 190, 132, 2, 13, 72, 202, 141, 60, 185, 130, 26, 198, 164, 153, 105, 6, 16, 24, 74, 99, 50, 191, 75, 212, 186, 230, 122, 225, 20, 164, 24, 54, 44, 156, 124, 247, 31, 193, 140, 232, 51, 1, 43, 148, 222, 96, 75, 34, 220, 147, 136, 21, 115, 52, 56, 109 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "65-65-4B-D4-76-D0-79-1A-8F-FC-4E-4D-74-20-33-8C-5D-AA-A8-8A-A2-C3-05-EE-F8-66-AF-8F-0F-DB-F2-D7", new byte[] { 240, 112, 213, 65, 107, 174, 85, 200, 151, 238, 122, 100, 31, 47, 46, 109, 171, 57, 70, 164, 76, 255, 116, 118, 34, 254, 36, 35, 218, 225, 23, 231, 236, 133, 133, 219, 115, 81, 36, 203, 30, 133, 196, 200, 43, 226, 112, 52, 128, 4, 22, 74, 156, 132, 186, 143, 164, 198, 19, 97, 51, 120, 85, 215 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "01-E5-B7-7D-76-B0-ED-61-6E-C2-1B-07-7F-68-E4-A1-40-19-68-74-43-D8-4B-FC-74-9A-28-66-36-B6-10-E9", new byte[] { 154, 219, 233, 90, 138, 231, 67, 214, 100, 87, 223, 160, 66, 45, 40, 222, 224, 149, 152, 135, 253, 146, 128, 233, 11, 219, 74, 185, 227, 6, 160, 10, 46, 130, 69, 200, 65, 248, 2, 235, 86, 165, 111, 190, 37, 42, 106, 243, 56, 87, 252, 154, 196, 139, 167, 41, 31, 236, 59, 75, 121, 187, 120, 50 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "1D-CF-D8-D2-99-66-22-18-0C-B6-9C-EF-EF-62-30-B7-A7-D4-91-D2-B2-D7-70-A3-C2-76-F8-7B-91-53-BE-29", new byte[] { 198, 158, 6, 71, 217, 100, 228, 114, 109, 255, 161, 125, 156, 158, 179, 235, 169, 13, 78, 146, 110, 109, 248, 177, 46, 148, 99, 114, 34, 148, 99, 201, 39, 249, 58, 100, 215, 120, 135, 143, 143, 88, 104, 28, 133, 171, 240, 59, 183, 121, 242, 236, 127, 191, 134, 141, 137, 54, 137, 219, 92, 206, 9, 222 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100004,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "46-BA-3B-2D-9C-74-28-96-8E-A2-A0-91-FC-97-C0-8A-0F-92-8D-CF-85-EA-74-73-90-77-22-08-E3-41-08-31", new byte[] { 159, 220, 17, 82, 166, 119, 138, 164, 101, 180, 248, 27, 182, 255, 168, 39, 122, 3, 198, 145, 3, 101, 112, 240, 153, 176, 106, 50, 108, 68, 4, 78, 25, 207, 190, 148, 100, 253, 109, 128, 23, 241, 182, 180, 234, 175, 149, 142, 245, 151, 230, 116, 115, 209, 219, 92, 243, 199, 188, 90, 209, 53, 170, 177 } });

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0a9c8263-7f5e-4e25-bb85-7a4c0a1e3a5c"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9812));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0bb3c011-9ba9-47e7-9ce0-3268f85e1ffc"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("18a64e64-3707-451c-b54d-51dbb9933aa0"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("1b234567-89ab-cdef-0123-456789abcdef"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("2b7c5a63-8e93-4d88-bc90-85c42d1574ae"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("34f2c84e-6c77-4c4a-b5f3-eef62d87b4be"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("3d8f49b2-ef8b-4b3e-8f5d-1f68d8f4f4b1"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("4d8d76aa-48e5-4c2b-95f1-5a77c73c0f11"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("59259348-41da-4bbc-b85c-48ee82f474ce"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5a6e8d59-0c3d-4e54-a105-50f44dcb9e4b"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5e4f2822-bb47-45b4-83c0-6c1de2b5f900"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("72b24a8d-4e5b-43e5-aeae-ecf9dc1b52d9"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("7f1f7c59-f92e-4c3b-a3f4-9c2a4cd474cb"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8b5c0f77-e3f1-4972-9102-6c1dfbb5a601"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8d5c8e30-dede-4ef0-9158-f7692c41acb2"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9b7f3e43-50bc-41d5-8f43-b8e0e1f47732"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e7b22d3-c5a5-429e-82dc-e5c573745e1d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("c7f1f4f5-74e3-4b4f-9c5a-3e2059d8b72d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9831));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("e43ff624-3f3c-4e8e-b5eb-11c0c3a244fa"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("f3b00c12-3b5e-4c8e-9bb0-7a5c7408cd07"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23"),
                column: "GamePicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Games/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c4f5e3e1-2c4c-4f4e-a4d1-5e5e6139d703"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 21, 11, 14, 652, DateTimeKind.Utc).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c9ebf2c7-5a7f-4b5d-bb7f-2f2c4d8e4a88"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 21, 11, 14, 652, DateTimeKind.Utc).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("d3c4b5e8-1f3a-4c8c-897e-2d8cf3e7c4f6"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 21, 11, 14, 652, DateTimeKind.Utc).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 21, 11, 14, 652, DateTimeKind.Utc).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "47-25-40-BF-84-8F-42-B9-AE-DC-0B-76-47-6B-6E-45-7C-62-62-C9-A5-D6-3F-F7-6F-E7-DD-DB-EB-01-CB-EC", new byte[] { 225, 65, 30, 238, 137, 249, 234, 16, 52, 23, 167, 143, 230, 125, 157, 225, 120, 64, 102, 161, 60, 107, 186, 187, 137, 221, 124, 23, 181, 200, 138, 16, 213, 230, 205, 154, 220, 164, 191, 159, 188, 66, 41, 228, 133, 164, 36, 228, 236, 201, 55, 45, 225, 128, 120, 249, 216, 169, 139, 251, 147, 224, 96, 5 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "E3-59-A7-33-ED-9C-EF-C3-72-B1-42-15-D7-35-0D-2B-A5-19-D2-F7-1F-62-00-49-E3-C6-76-97-04-A4-9D-91", new byte[] { 87, 232, 11, 166, 156, 229, 39, 3, 203, 109, 74, 172, 40, 90, 162, 182, 163, 84, 198, 31, 116, 149, 15, 179, 26, 54, 5, 80, 176, 55, 159, 15, 191, 117, 241, 144, 51, 83, 72, 7, 73, 26, 76, 135, 246, 127, 159, 89, 93, 79, 35, 151, 112, 228, 53, 140, 188, 114, 228, 12, 202, 65, 53, 146 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "45-D5-B3-18-AC-22-3A-06-B1-09-C5-A6-32-4F-86-59-3B-E3-3B-FA-01-64-F0-25-C0-6D-67-CA-A8-2E-F4-C3", new byte[] { 39, 99, 38, 151, 198, 229, 144, 111, 86, 239, 78, 181, 22, 11, 208, 13, 248, 79, 101, 217, 62, 68, 177, 221, 44, 145, 63, 20, 172, 65, 97, 69, 31, 141, 187, 25, 57, 9, 50, 110, 63, 216, 39, 169, 220, 255, 43, 109, 50, 246, 151, 185, 112, 66, 80, 231, 223, 135, 246, 141, 228, 136, 226, 53 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "50-98-DB-86-60-F1-8F-03-4D-41-95-D1-78-DB-6B-5D-1D-21-5C-25-2A-B3-15-D6-92-78-55-3E-C6-93-A2-A2", new byte[] { 35, 222, 101, 180, 228, 150, 33, 180, 170, 230, 14, 88, 194, 5, 137, 134, 228, 158, 77, 209, 56, 189, 46, 255, 233, 120, 41, 227, 70, 115, 12, 5, 43, 4, 145, 85, 46, 177, 164, 61, 154, 222, 10, 231, 220, 68, 151, 197, 52, 125, 10, 96, 160, 38, 164, 30, 16, 21, 246, 174, 74, 89, 248, 78 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "DE-CC-E5-14-85-1E-B8-86-4C-60-85-3E-05-16-DC-07-8B-14-72-C8-03-96-72-EF-76-E0-F1-6C-92-04-89-A4", new byte[] { 94, 71, 166, 205, 103, 43, 193, 189, 13, 186, 218, 144, 94, 236, 155, 139, 124, 139, 249, 27, 20, 82, 244, 100, 213, 229, 197, 162, 148, 164, 254, 118, 127, 215, 40, 231, 75, 226, 98, 172, 18, 40, 58, 242, 123, 58, 202, 103, 208, 233, 113, 23, 161, 23, 20, 142, 164, 86, 102, 52, 89, 213, 50, 234 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "3E-31-1D-B4-04-A3-D1-05-7C-64-28-CD-1C-96-5E-B3-E7-35-73-5D-E8-66-41-C7-BC-8C-21-E3-31-ED-80-76", new byte[] { 83, 124, 10, 66, 49, 227, 196, 82, 228, 229, 133, 71, 77, 136, 83, 8, 186, 71, 43, 202, 6, 172, 173, 105, 100, 3, 216, 131, 45, 196, 22, 80, 210, 66, 164, 166, 5, 202, 246, 168, 108, 224, 177, 82, 227, 126, 29, 128, 121, 33, 151, 66, 66, 241, 118, 74, 77, 156, 210, 213, 114, 224, 89, 68 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "51-5E-8B-BC-55-6C-A8-EC-60-76-E4-76-51-DB-46-A8-EE-DC-EA-BD-FC-45-F2-2C-B0-C9-2E-30-D6-C3-B2-5C", new byte[] { 119, 221, 74, 98, 89, 226, 240, 224, 71, 243, 232, 146, 20, 140, 33, 190, 148, 18, 173, 174, 131, 144, 85, 115, 219, 249, 106, 53, 175, 173, 186, 240, 165, 79, 155, 65, 123, 147, 150, 34, 113, 90, 165, 125, 52, 28, 57, 78, 114, 117, 110, 164, 12, 82, 136, 128, 219, 152, 142, 29, 155, 115, 101, 86 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "2F-43-00-5A-93-A4-85-FA-2E-AB-55-83-D0-B5-40-E4-03-38-9F-DE-05-23-16-0A-E1-77-28-88-45-26-71-6E", new byte[] { 101, 3, 203, 12, 45, 249, 121, 50, 88, 82, 166, 231, 61, 44, 142, 224, 85, 50, 134, 94, 146, 207, 111, 47, 147, 217, 250, 127, 180, 106, 65, 224, 53, 130, 217, 18, 6, 244, 201, 195, 131, 95, 21, 55, 129, 6, 69, 155, 193, 238, 104, 61, 42, 13, 68, 71, 95, 80, 50, 159, 249, 184, 17, 250 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "E6-A7-4D-3B-8E-B7-12-91-9F-93-4D-A1-89-E4-55-3A-2F-1B-2D-5E-92-B7-96-24-A6-31-A5-F1-B8-14-88-1A", new byte[] { 223, 244, 64, 96, 199, 61, 45, 36, 154, 66, 183, 83, 238, 232, 201, 21, 21, 56, 242, 21, 17, 131, 182, 237, 46, 54, 79, 175, 197, 245, 161, 245, 119, 220, 22, 215, 227, 105, 90, 137, 119, 225, 212, 12, 216, 174, 17, 39, 193, 63, 121, 50, 234, 195, 235, 216, 173, 3, 140, 17, 78, 149, 175, 135 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100004,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "B1-B3-DD-87-5C-64-3B-58-6B-ED-32-8E-54-CB-82-4B-87-CF-CB-1D-F9-BE-5A-1E-8C-D2-EC-BB-C7-C5-9F-8C", new byte[] { 107, 209, 114, 73, 192, 32, 77, 122, 33, 56, 132, 169, 19, 179, 33, 212, 131, 131, 249, 82, 103, 199, 30, 65, 137, 147, 47, 137, 132, 73, 197, 34, 79, 136, 243, 76, 228, 57, 146, 107, 235, 232, 254, 102, 56, 39, 102, 216, 191, 105, 50, 97, 34, 52, 47, 64, 193, 17, 196, 187, 222, 249, 119, 188 } });

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0a9c8263-7f5e-4e25-bb85-7a4c0a1e3a5c"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 11, 14, 652, DateTimeKind.Utc).AddTicks(8004));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0bb3c011-9ba9-47e7-9ce0-3268f85e1ffc"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 11, 14, 652, DateTimeKind.Utc).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("18a64e64-3707-451c-b54d-51dbb9933aa0"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 11, 14, 652, DateTimeKind.Utc).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("1b234567-89ab-cdef-0123-456789abcdef"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 11, 14, 652, DateTimeKind.Utc).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("2b7c5a63-8e93-4d88-bc90-85c42d1574ae"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 11, 14, 652, DateTimeKind.Utc).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("34f2c84e-6c77-4c4a-b5f3-eef62d87b4be"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 11, 14, 652, DateTimeKind.Utc).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("3d8f49b2-ef8b-4b3e-8f5d-1f68d8f4f4b1"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 11, 14, 652, DateTimeKind.Utc).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("4d8d76aa-48e5-4c2b-95f1-5a77c73c0f11"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 11, 14, 652, DateTimeKind.Utc).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("59259348-41da-4bbc-b85c-48ee82f474ce"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 11, 14, 652, DateTimeKind.Utc).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5a6e8d59-0c3d-4e54-a105-50f44dcb9e4b"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 11, 14, 652, DateTimeKind.Utc).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5e4f2822-bb47-45b4-83c0-6c1de2b5f900"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 11, 14, 652, DateTimeKind.Utc).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("72b24a8d-4e5b-43e5-aeae-ecf9dc1b52d9"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 11, 14, 652, DateTimeKind.Utc).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("7f1f7c59-f92e-4c3b-a3f4-9c2a4cd474cb"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 11, 14, 652, DateTimeKind.Utc).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8b5c0f77-e3f1-4972-9102-6c1dfbb5a601"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 11, 14, 652, DateTimeKind.Utc).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8d5c8e30-dede-4ef0-9158-f7692c41acb2"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 11, 14, 652, DateTimeKind.Utc).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9b7f3e43-50bc-41d5-8f43-b8e0e1f47732"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 11, 14, 652, DateTimeKind.Utc).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e7b22d3-c5a5-429e-82dc-e5c573745e1d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 11, 14, 652, DateTimeKind.Utc).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("c7f1f4f5-74e3-4b4f-9c5a-3e2059d8b72d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 11, 14, 652, DateTimeKind.Utc).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("e43ff624-3f3c-4e8e-b5eb-11c0c3a244fa"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 11, 14, 652, DateTimeKind.Utc).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("f3b00c12-3b5e-4c8e-9bb0-7a5c7408cd07"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 11, 14, 652, DateTimeKind.Utc).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23"),
                column: "GamePicturePath",
                value: "~/images/Games/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23.jpg");
        }
    }
}
