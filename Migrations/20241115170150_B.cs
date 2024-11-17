using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class B : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c4f5e3e1-2c4c-4f4e-a4d1-5e5e6139d703"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 17, 1, 50, 152, DateTimeKind.Utc).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c9ebf2c7-5a7f-4b5d-bb7f-2f2c4d8e4a88"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 17, 1, 50, 152, DateTimeKind.Utc).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("d3c4b5e8-1f3a-4c8c-897e-2d8cf3e7c4f6"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 17, 1, 50, 152, DateTimeKind.Utc).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 17, 1, 50, 152, DateTimeKind.Utc).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "ED-EF-53-15-99-BA-AD-01-FB-00-F8-E3-5E-C2-8A-98-0A-47-86-26-6A-80-4F-DA-68-F9-14-AC-39-F3-64-B3", new byte[] { 103, 208, 241, 241, 222, 156, 47, 249, 254, 191, 151, 36, 74, 230, 66, 20, 10, 131, 156, 114, 38, 130, 75, 206, 119, 163, 234, 232, 216, 184, 21, 104, 61, 78, 148, 60, 172, 70, 172, 57, 36, 88, 3, 119, 2, 127, 244, 94, 164, 172, 166, 93, 41, 213, 165, 101, 238, 14, 213, 159, 217, 122, 161, 66 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "E1-5E-D9-DF-FB-E5-AD-B9-15-DB-D7-6A-A9-F9-A3-24-00-3B-70-CF-29-EC-A8-4E-7B-C5-D8-3B-1A-F4-45-B1", new byte[] { 1, 159, 12, 14, 72, 213, 104, 243, 175, 53, 176, 127, 28, 31, 11, 25, 114, 8, 114, 186, 91, 104, 78, 219, 239, 214, 107, 100, 15, 207, 93, 166, 239, 10, 198, 51, 21, 77, 26, 72, 40, 218, 161, 100, 95, 129, 46, 137, 132, 20, 97, 201, 241, 245, 184, 244, 27, 83, 72, 125, 71, 102, 247, 240 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "9C-A8-8C-63-34-C5-6C-73-FA-D4-B3-AD-79-09-65-EA-52-5A-D6-AF-4D-88-B0-FA-3A-B8-DE-F0-A5-EE-F0-1E", new byte[] { 63, 220, 114, 78, 124, 222, 175, 50, 224, 140, 210, 185, 72, 10, 85, 64, 165, 93, 50, 205, 228, 58, 73, 68, 90, 121, 0, 178, 251, 127, 181, 169, 117, 96, 163, 143, 172, 53, 115, 174, 201, 180, 7, 15, 124, 227, 131, 59, 133, 183, 69, 203, 246, 192, 25, 81, 52, 80, 3, 105, 237, 49, 52, 237 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "44-EE-B4-1A-1F-CF-B7-6C-CA-C1-E4-DD-13-60-70-F0-9F-33-CD-71-D6-76-BE-7F-54-EF-57-AB-E7-0D-FD-AF", new byte[] { 100, 155, 143, 209, 168, 216, 104, 140, 133, 95, 71, 136, 227, 16, 158, 8, 254, 192, 184, 153, 176, 88, 180, 122, 138, 191, 115, 29, 54, 39, 180, 85, 39, 129, 236, 129, 126, 172, 78, 139, 102, 164, 18, 216, 142, 129, 114, 160, 10, 91, 60, 218, 163, 185, 172, 237, 83, 25, 247, 232, 113, 188, 72, 136 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "B8-39-6F-E1-EE-ED-B4-77-24-40-98-32-78-A8-B1-AF-26-40-25-85-30-AC-C2-23-7B-1C-FA-CC-70-FB-9C-D3", new byte[] { 201, 219, 143, 208, 62, 234, 160, 66, 16, 247, 201, 185, 211, 9, 180, 87, 153, 50, 94, 149, 250, 239, 229, 0, 42, 205, 251, 130, 250, 18, 248, 164, 194, 252, 106, 170, 202, 95, 229, 171, 245, 101, 66, 81, 244, 136, 240, 228, 42, 195, 106, 75, 137, 209, 153, 109, 51, 166, 53, 18, 207, 48, 11, 4 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "A8-E7-E2-CD-02-33-29-98-3E-26-3F-D6-0B-51-8B-00-D3-B1-DB-DE-13-06-B1-90-2C-56-D2-E3-99-7E-13-DE", new byte[] { 5, 164, 166, 92, 158, 90, 158, 244, 227, 70, 231, 48, 96, 226, 242, 197, 101, 140, 173, 169, 10, 152, 128, 208, 241, 245, 147, 174, 65, 74, 177, 12, 172, 4, 77, 253, 190, 23, 161, 246, 175, 148, 108, 48, 225, 153, 251, 55, 124, 168, 184, 126, 212, 79, 223, 135, 78, 240, 239, 143, 236, 145, 237, 100 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "AB-4B-F8-23-E5-61-3C-95-9A-19-B1-92-2A-E1-68-D3-BA-FC-F5-D2-14-CD-E6-20-BD-61-D7-5D-7D-62-91-33", new byte[] { 187, 81, 79, 34, 137, 255, 141, 169, 216, 10, 6, 181, 197, 55, 93, 144, 29, 207, 29, 229, 243, 248, 6, 119, 159, 124, 86, 167, 76, 34, 119, 219, 162, 182, 43, 157, 243, 225, 152, 102, 166, 23, 122, 176, 178, 25, 142, 164, 160, 81, 177, 193, 223, 68, 228, 124, 27, 206, 179, 80, 236, 254, 147, 246 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "E0-96-7A-64-34-21-53-1E-84-1B-49-D5-97-1D-36-C1-89-60-84-7E-9F-A5-A9-C7-84-9C-50-1A-72-30-69-8C", new byte[] { 109, 57, 46, 17, 51, 130, 86, 246, 111, 147, 65, 87, 81, 182, 82, 78, 38, 41, 55, 215, 159, 38, 14, 222, 222, 3, 222, 85, 151, 128, 110, 34, 52, 70, 151, 119, 249, 87, 72, 154, 193, 92, 231, 238, 39, 55, 34, 18, 103, 150, 227, 142, 235, 193, 196, 173, 184, 66, 235, 139, 69, 88, 78, 11 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "05-84-9D-D2-33-DA-14-0D-BF-CE-75-BC-CF-47-4C-40-3E-A7-68-09-45-37-04-97-88-0B-B1-C6-DC-50-EF-13", new byte[] { 104, 76, 43, 191, 222, 164, 189, 183, 142, 45, 16, 154, 72, 130, 217, 86, 45, 223, 251, 232, 153, 93, 108, 201, 50, 70, 115, 38, 57, 139, 210, 5, 20, 215, 25, 151, 80, 94, 103, 139, 195, 173, 224, 223, 247, 81, 58, 25, 26, 198, 199, 143, 59, 195, 84, 205, 128, 236, 156, 223, 11, 211, 203, 99 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100004,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "64-D3-AE-DF-2E-A5-87-EB-F3-D4-F8-DE-A3-C4-0A-A6-05-F1-7F-17-7A-AE-29-55-CE-DE-38-D5-75-29-5A-37", new byte[] { 174, 109, 116, 105, 185, 182, 109, 195, 36, 91, 110, 57, 31, 135, 0, 23, 160, 241, 221, 9, 157, 229, 31, 30, 163, 174, 15, 41, 124, 88, 138, 201, 177, 232, 223, 217, 161, 48, 212, 46, 26, 51, 100, 39, 110, 161, 213, 54, 119, 232, 94, 150, 79, 121, 252, 51, 122, 162, 253, 93, 188, 178, 236, 33 } });

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0a9c8263-7f5e-4e25-bb85-7a4c0a1e3a5c"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 1, 50, 152, DateTimeKind.Utc).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0bb3c011-9ba9-47e7-9ce0-3268f85e1ffc"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 1, 50, 152, DateTimeKind.Utc).AddTicks(198));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("18a64e64-3707-451c-b54d-51dbb9933aa0"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 1, 50, 152, DateTimeKind.Utc).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("1b234567-89ab-cdef-0123-456789abcdef"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 1, 50, 152, DateTimeKind.Utc).AddTicks(204));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("2b7c5a63-8e93-4d88-bc90-85c42d1574ae"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 1, 50, 152, DateTimeKind.Utc).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("34f2c84e-6c77-4c4a-b5f3-eef62d87b4be"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 1, 50, 152, DateTimeKind.Utc).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("3d8f49b2-ef8b-4b3e-8f5d-1f68d8f4f4b1"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 1, 50, 152, DateTimeKind.Utc).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("4d8d76aa-48e5-4c2b-95f1-5a77c73c0f11"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 1, 50, 152, DateTimeKind.Utc).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("59259348-41da-4bbc-b85c-48ee82f474ce"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 1, 50, 152, DateTimeKind.Utc).AddTicks(221));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5a6e8d59-0c3d-4e54-a105-50f44dcb9e4b"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 1, 50, 152, DateTimeKind.Utc).AddTicks(214));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5e4f2822-bb47-45b4-83c0-6c1de2b5f900"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 1, 50, 152, DateTimeKind.Utc).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("72b24a8d-4e5b-43e5-aeae-ecf9dc1b52d9"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 1, 50, 152, DateTimeKind.Utc).AddTicks(234));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("7f1f7c59-f92e-4c3b-a3f4-9c2a4cd474cb"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 1, 50, 152, DateTimeKind.Utc).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8b5c0f77-e3f1-4972-9102-6c1dfbb5a601"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 1, 50, 152, DateTimeKind.Utc).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8d5c8e30-dede-4ef0-9158-f7692c41acb2"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 1, 50, 152, DateTimeKind.Utc).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9b7f3e43-50bc-41d5-8f43-b8e0e1f47732"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 1, 50, 152, DateTimeKind.Utc).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e7b22d3-c5a5-429e-82dc-e5c573745e1d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 1, 50, 152, DateTimeKind.Utc).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("c7f1f4f5-74e3-4b4f-9c5a-3e2059d8b72d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 1, 50, 152, DateTimeKind.Utc).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("e43ff624-3f3c-4e8e-b5eb-11c0c3a244fa"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 1, 50, 152, DateTimeKind.Utc).AddTicks(211));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("f3b00c12-3b5e-4c8e-9bb0-7a5c7408cd07"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 1, 50, 152, DateTimeKind.Utc).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23"),
                column: "GamePicturePath",
                value: "https://fusiontech-0dxp.onrender.com/./images/Games/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c4f5e3e1-2c4c-4f4e-a4d1-5e5e6139d703"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 16, 57, 38, 766, DateTimeKind.Utc).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c9ebf2c7-5a7f-4b5d-bb7f-2f2c4d8e4a88"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 16, 57, 38, 766, DateTimeKind.Utc).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("d3c4b5e8-1f3a-4c8c-897e-2d8cf3e7c4f6"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 16, 57, 38, 766, DateTimeKind.Utc).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 16, 57, 38, 766, DateTimeKind.Utc).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "B0-24-2A-9F-9D-4C-7B-18-9A-7A-9E-24-9B-44-47-AE-6D-9F-00-29-B0-17-33-53-3D-CB-DF-04-AA-44-64-A3", new byte[] { 64, 208, 98, 1, 203, 163, 42, 76, 200, 177, 238, 81, 216, 136, 164, 36, 20, 44, 156, 139, 29, 122, 209, 143, 154, 80, 98, 52, 208, 143, 223, 27, 169, 34, 137, 156, 187, 124, 39, 193, 136, 231, 84, 205, 33, 60, 19, 227, 231, 242, 140, 79, 67, 37, 81, 161, 206, 205, 39, 30, 36, 89, 255, 138 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "7D-E5-02-20-52-68-04-AD-C2-80-A7-CC-6A-78-E3-32-18-C6-2E-CB-64-C9-B9-67-B7-0B-90-44-10-3C-BE-B3", new byte[] { 131, 131, 191, 39, 240, 217, 137, 196, 15, 12, 2, 199, 219, 173, 134, 77, 169, 140, 68, 208, 78, 230, 14, 46, 176, 142, 106, 191, 0, 82, 86, 4, 171, 225, 71, 42, 187, 220, 255, 119, 128, 240, 47, 97, 116, 83, 168, 35, 122, 3, 5, 39, 16, 5, 68, 201, 234, 30, 24, 252, 210, 67, 151, 85 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "DB-08-51-3E-4E-2D-39-B7-C4-AE-28-FC-DE-47-EC-E6-F6-66-6C-B3-CA-D1-22-B7-07-8A-8F-66-60-C3-3C-B7", new byte[] { 111, 109, 54, 5, 243, 100, 161, 66, 0, 71, 153, 177, 116, 205, 182, 214, 219, 91, 205, 11, 84, 207, 180, 45, 22, 228, 54, 93, 56, 14, 76, 93, 76, 102, 243, 62, 245, 24, 71, 169, 129, 27, 156, 34, 63, 0, 225, 131, 170, 54, 61, 7, 237, 103, 88, 68, 179, 241, 73, 144, 81, 130, 230, 233 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "87-C0-B2-37-4F-89-FD-88-1A-16-32-69-27-E9-3C-AB-91-0A-B7-67-30-BB-9B-D8-80-4A-24-D4-A8-5D-4F-BF", new byte[] { 145, 213, 62, 120, 33, 170, 79, 144, 151, 155, 224, 166, 149, 31, 195, 144, 252, 93, 114, 60, 135, 80, 170, 136, 153, 220, 118, 13, 15, 156, 98, 15, 129, 199, 57, 123, 167, 37, 68, 71, 240, 78, 97, 8, 6, 186, 29, 80, 49, 86, 100, 239, 203, 203, 239, 106, 94, 90, 186, 85, 145, 161, 84, 75 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "45-FB-BD-E3-C6-6A-58-F2-83-7C-49-D3-64-6D-E6-95-62-7F-B6-76-19-DB-B4-14-27-16-AA-BB-6C-6A-74-3F", new byte[] { 249, 83, 48, 151, 20, 236, 81, 168, 83, 187, 136, 116, 159, 179, 85, 150, 167, 13, 62, 36, 70, 198, 186, 152, 223, 233, 197, 14, 87, 198, 250, 205, 1, 172, 241, 71, 64, 208, 0, 163, 232, 185, 107, 76, 185, 36, 175, 251, 35, 16, 163, 37, 138, 104, 88, 129, 101, 184, 151, 78, 162, 248, 209, 243 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "54-68-45-CC-5F-00-D1-92-18-08-7B-9A-9B-F5-DB-5A-D6-0B-F8-B2-FE-AC-09-5E-D4-DD-14-75-EB-AD-73-25", new byte[] { 54, 193, 218, 30, 241, 152, 7, 210, 78, 238, 213, 47, 34, 240, 152, 29, 23, 2, 111, 165, 230, 50, 135, 136, 76, 198, 45, 222, 228, 164, 63, 125, 0, 96, 149, 109, 152, 113, 219, 240, 155, 76, 242, 123, 77, 6, 98, 24, 216, 66, 242, 17, 162, 82, 90, 104, 61, 41, 244, 117, 155, 12, 23, 102 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "8C-4E-92-E7-81-4A-27-96-3D-9E-4A-24-C1-4C-15-C5-AD-F0-A4-50-26-65-8D-33-0A-85-8E-4C-46-E1-D2-BB", new byte[] { 52, 93, 86, 33, 41, 122, 210, 191, 84, 36, 78, 43, 234, 156, 173, 236, 51, 245, 54, 7, 240, 45, 115, 91, 137, 215, 73, 195, 179, 132, 26, 34, 238, 90, 58, 8, 202, 49, 139, 34, 253, 225, 138, 151, 82, 158, 8, 117, 90, 191, 183, 162, 75, 212, 79, 175, 128, 124, 10, 63, 220, 137, 133, 47 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "48-17-42-81-91-5A-AD-2E-45-1D-D9-EF-40-1D-ED-AB-BC-87-B3-19-55-28-FC-C6-FA-5B-01-FC-AC-17-96-D5", new byte[] { 216, 70, 76, 160, 247, 153, 158, 158, 247, 178, 238, 15, 221, 141, 23, 238, 249, 83, 161, 35, 118, 241, 108, 124, 15, 34, 175, 210, 16, 174, 64, 185, 175, 32, 236, 132, 88, 18, 71, 240, 211, 21, 92, 158, 6, 28, 118, 145, 213, 139, 218, 95, 181, 44, 24, 52, 63, 131, 37, 153, 183, 18, 247, 142 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "EF-2D-96-75-B6-7B-02-0D-B7-77-F5-7A-7A-44-43-BE-D2-B3-BD-EB-66-07-C7-49-95-CC-51-BD-68-B0-C4-E3", new byte[] { 252, 255, 91, 212, 104, 34, 67, 44, 26, 109, 27, 152, 199, 228, 248, 233, 193, 139, 157, 144, 24, 176, 165, 222, 191, 215, 222, 120, 157, 51, 100, 186, 155, 117, 108, 177, 10, 51, 152, 219, 98, 68, 110, 235, 230, 236, 0, 166, 89, 195, 82, 16, 198, 254, 121, 73, 144, 29, 50, 131, 121, 73, 156, 42 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100004,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "32-AF-A9-4E-E8-8E-5E-B8-25-EF-A0-AF-A9-43-27-28-79-CD-2E-27-B3-AA-8F-65-D6-D2-BC-1D-18-52-5E-68", new byte[] { 200, 94, 203, 72, 106, 239, 132, 164, 245, 206, 34, 155, 236, 240, 30, 109, 129, 10, 134, 93, 14, 110, 139, 33, 96, 201, 198, 241, 241, 75, 60, 115, 15, 150, 36, 105, 105, 180, 128, 122, 66, 167, 138, 44, 186, 213, 176, 85, 153, 184, 27, 62, 202, 237, 209, 109, 43, 128, 42, 133, 132, 251, 43, 113 } });

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0a9c8263-7f5e-4e25-bb85-7a4c0a1e3a5c"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 57, 38, 766, DateTimeKind.Utc).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0bb3c011-9ba9-47e7-9ce0-3268f85e1ffc"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 57, 38, 766, DateTimeKind.Utc).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("18a64e64-3707-451c-b54d-51dbb9933aa0"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 57, 38, 766, DateTimeKind.Utc).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("1b234567-89ab-cdef-0123-456789abcdef"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 57, 38, 766, DateTimeKind.Utc).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("2b7c5a63-8e93-4d88-bc90-85c42d1574ae"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 57, 38, 766, DateTimeKind.Utc).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("34f2c84e-6c77-4c4a-b5f3-eef62d87b4be"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 57, 38, 766, DateTimeKind.Utc).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("3d8f49b2-ef8b-4b3e-8f5d-1f68d8f4f4b1"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 57, 38, 766, DateTimeKind.Utc).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("4d8d76aa-48e5-4c2b-95f1-5a77c73c0f11"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 57, 38, 766, DateTimeKind.Utc).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("59259348-41da-4bbc-b85c-48ee82f474ce"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 57, 38, 766, DateTimeKind.Utc).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5a6e8d59-0c3d-4e54-a105-50f44dcb9e4b"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 57, 38, 766, DateTimeKind.Utc).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5e4f2822-bb47-45b4-83c0-6c1de2b5f900"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 57, 38, 766, DateTimeKind.Utc).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("72b24a8d-4e5b-43e5-aeae-ecf9dc1b52d9"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 57, 38, 766, DateTimeKind.Utc).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("7f1f7c59-f92e-4c3b-a3f4-9c2a4cd474cb"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 57, 38, 766, DateTimeKind.Utc).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8b5c0f77-e3f1-4972-9102-6c1dfbb5a601"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 57, 38, 766, DateTimeKind.Utc).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8d5c8e30-dede-4ef0-9158-f7692c41acb2"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 57, 38, 766, DateTimeKind.Utc).AddTicks(4388));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9b7f3e43-50bc-41d5-8f43-b8e0e1f47732"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 57, 38, 766, DateTimeKind.Utc).AddTicks(4396));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e7b22d3-c5a5-429e-82dc-e5c573745e1d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 57, 38, 766, DateTimeKind.Utc).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("c7f1f4f5-74e3-4b4f-9c5a-3e2059d8b72d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 57, 38, 766, DateTimeKind.Utc).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("e43ff624-3f3c-4e8e-b5eb-11c0c3a244fa"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 57, 38, 766, DateTimeKind.Utc).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("f3b00c12-3b5e-4c8e-9bb0-7a5c7408cd07"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 57, 38, 766, DateTimeKind.Utc).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23"),
                column: "GamePicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Games/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23.jpg");
        }
    }
}
