using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class BE : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
