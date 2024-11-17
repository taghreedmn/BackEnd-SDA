using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class newurl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c4f5e3e1-2c4c-4f4e-a4d1-5e5e6139d703"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 17, 25, 57, 696, DateTimeKind.Utc).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c9ebf2c7-5a7f-4b5d-bb7f-2f2c4d8e4a88"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 17, 25, 57, 696, DateTimeKind.Utc).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("d3c4b5e8-1f3a-4c8c-897e-2d8cf3e7c4f6"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 17, 25, 57, 696, DateTimeKind.Utc).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 17, 25, 57, 696, DateTimeKind.Utc).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "35-3E-26-30-3B-92-B5-E1-22-C8-E2-DC-CB-F7-9E-37-5C-8D-31-10-1E-2E-E2-10-E4-76-F1-96-22-C7-0D-64", new byte[] { 107, 189, 202, 109, 239, 193, 1, 178, 126, 25, 162, 93, 145, 246, 223, 167, 251, 254, 89, 134, 162, 245, 165, 208, 198, 179, 8, 172, 91, 203, 211, 198, 158, 113, 115, 131, 92, 55, 29, 163, 2, 212, 61, 59, 34, 95, 18, 155, 148, 61, 104, 90, 26, 24, 217, 75, 169, 47, 123, 122, 200, 51, 243, 104 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "55-98-4B-68-9A-FF-F1-D2-13-7C-83-3E-DB-6A-F0-2B-C4-69-01-6F-14-13-3E-D2-7B-9E-CB-A8-72-EA-DC-CC", new byte[] { 105, 69, 79, 179, 47, 254, 124, 142, 75, 120, 147, 246, 195, 81, 60, 18, 52, 208, 152, 36, 35, 222, 130, 207, 166, 146, 199, 96, 104, 62, 10, 194, 62, 93, 94, 104, 40, 189, 248, 128, 167, 56, 232, 28, 240, 190, 237, 227, 83, 33, 214, 71, 112, 100, 38, 237, 151, 95, 15, 252, 119, 150, 150, 157 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "D2-6E-DE-62-03-00-23-66-83-1D-6A-CE-B6-28-4B-AB-AF-5A-A8-25-16-39-3B-33-67-64-EA-99-F4-F0-3E-5B", new byte[] { 122, 9, 74, 255, 33, 176, 167, 127, 84, 206, 142, 37, 78, 247, 96, 189, 80, 12, 180, 178, 132, 99, 58, 198, 192, 186, 11, 207, 74, 198, 33, 182, 33, 22, 33, 10, 6, 47, 148, 130, 103, 222, 135, 226, 122, 62, 241, 143, 59, 111, 7, 111, 176, 124, 244, 111, 76, 3, 168, 177, 222, 93, 68, 237 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "D7-82-41-B5-9B-5D-B7-2E-78-A5-5E-E8-82-6C-43-5B-39-8F-D3-9B-A6-6E-D5-61-51-EC-93-B2-4E-34-35-A6", new byte[] { 46, 230, 200, 195, 159, 81, 3, 50, 163, 191, 194, 223, 72, 207, 62, 170, 82, 5, 193, 31, 53, 143, 181, 197, 247, 212, 60, 129, 10, 172, 187, 105, 92, 158, 79, 234, 46, 250, 134, 80, 143, 216, 26, 189, 206, 56, 117, 210, 1, 94, 128, 139, 68, 207, 179, 97, 111, 231, 49, 160, 36, 209, 24, 184 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "66-0B-7B-31-A4-49-BB-D7-2C-06-15-49-BD-2B-62-70-3A-66-D2-B1-1C-21-DD-BD-CE-6C-09-08-8A-9C-17-39", new byte[] { 118, 3, 189, 116, 78, 6, 171, 140, 142, 173, 238, 58, 51, 21, 64, 50, 120, 114, 1, 209, 246, 123, 251, 110, 29, 108, 116, 95, 158, 119, 197, 6, 227, 118, 196, 107, 121, 255, 202, 26, 4, 39, 242, 103, 192, 19, 18, 148, 121, 143, 34, 10, 23, 149, 20, 58, 149, 171, 198, 40, 202, 247, 16, 128 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "CA-9E-F8-CA-BE-F4-DB-51-6E-33-D0-F2-6D-01-94-9E-3D-D2-29-35-2C-48-2B-8B-49-76-63-10-A1-30-A4-8A", new byte[] { 30, 209, 46, 192, 22, 27, 199, 183, 27, 92, 152, 178, 153, 29, 63, 113, 238, 102, 60, 51, 68, 149, 123, 158, 230, 63, 8, 185, 223, 243, 2, 70, 177, 124, 51, 237, 5, 233, 205, 248, 135, 191, 166, 255, 97, 231, 4, 107, 72, 181, 61, 51, 125, 174, 6, 254, 123, 132, 13, 131, 51, 88, 204, 144 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "9E-5D-6F-2A-07-5C-0A-DB-71-DC-1C-F8-B3-9A-2E-10-33-30-CB-9A-2D-31-62-DB-0A-B9-02-8D-0A-6B-A0-9B", new byte[] { 219, 227, 195, 151, 93, 59, 211, 58, 52, 2, 49, 212, 171, 73, 225, 174, 211, 138, 253, 149, 111, 106, 229, 191, 103, 141, 231, 65, 79, 251, 85, 71, 251, 47, 119, 221, 241, 188, 234, 140, 212, 63, 78, 119, 56, 87, 197, 3, 220, 166, 251, 116, 208, 9, 80, 222, 80, 204, 214, 205, 94, 66, 121, 70 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "CA-B7-1F-6D-FE-0A-2C-B5-BC-57-F6-FF-2F-1A-F9-F3-20-14-7E-B0-AA-C8-92-D5-95-45-4E-50-18-C6-8B-FD", new byte[] { 69, 137, 217, 192, 145, 41, 211, 203, 145, 51, 72, 11, 85, 144, 145, 55, 25, 32, 115, 178, 201, 38, 63, 165, 31, 188, 6, 144, 162, 117, 227, 23, 230, 94, 202, 96, 113, 239, 205, 23, 248, 167, 53, 36, 204, 46, 193, 201, 69, 75, 243, 176, 186, 145, 138, 0, 82, 164, 141, 156, 40, 255, 182, 128 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "06-BA-31-9B-8A-35-85-E7-1C-33-DE-0C-65-FB-06-2F-D0-B2-D8-8A-B1-D7-BE-FF-CA-3B-04-D7-63-3E-D0-4E", new byte[] { 98, 46, 203, 30, 44, 209, 102, 189, 164, 136, 66, 44, 221, 57, 172, 41, 22, 78, 55, 252, 234, 55, 43, 71, 156, 191, 252, 120, 117, 90, 210, 126, 190, 53, 231, 39, 0, 194, 0, 172, 106, 54, 86, 50, 104, 3, 86, 81, 87, 229, 154, 58, 235, 154, 70, 56, 66, 138, 73, 210, 74, 133, 175, 120 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100004,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "C3-C6-24-51-F5-3F-A5-CB-93-5E-BA-BB-22-C6-E3-12-29-EF-29-2E-ED-13-24-38-73-22-55-AD-56-B1-29-FD", new byte[] { 54, 130, 208, 100, 94, 191, 79, 56, 77, 150, 173, 135, 100, 83, 201, 61, 209, 101, 194, 160, 15, 18, 41, 90, 235, 210, 15, 66, 22, 19, 106, 161, 236, 234, 52, 48, 41, 70, 89, 160, 184, 60, 172, 88, 169, 186, 35, 143, 139, 135, 223, 173, 160, 200, 61, 73, 228, 220, 122, 38, 144, 54, 105, 236 } });

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0a9c8263-7f5e-4e25-bb85-7a4c0a1e3a5c"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 25, 57, 696, DateTimeKind.Utc).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0bb3c011-9ba9-47e7-9ce0-3268f85e1ffc"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 25, 57, 696, DateTimeKind.Utc).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("18a64e64-3707-451c-b54d-51dbb9933aa0"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 25, 57, 696, DateTimeKind.Utc).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("1b234567-89ab-cdef-0123-456789abcdef"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 25, 57, 696, DateTimeKind.Utc).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("2b7c5a63-8e93-4d88-bc90-85c42d1574ae"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 25, 57, 696, DateTimeKind.Utc).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("34f2c84e-6c77-4c4a-b5f3-eef62d87b4be"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 25, 57, 696, DateTimeKind.Utc).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("3d8f49b2-ef8b-4b3e-8f5d-1f68d8f4f4b1"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 25, 57, 696, DateTimeKind.Utc).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("4d8d76aa-48e5-4c2b-95f1-5a77c73c0f11"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 25, 57, 696, DateTimeKind.Utc).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("59259348-41da-4bbc-b85c-48ee82f474ce"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 25, 57, 696, DateTimeKind.Utc).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5a6e8d59-0c3d-4e54-a105-50f44dcb9e4b"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 25, 57, 696, DateTimeKind.Utc).AddTicks(6761));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5e4f2822-bb47-45b4-83c0-6c1de2b5f900"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 25, 57, 696, DateTimeKind.Utc).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("72b24a8d-4e5b-43e5-aeae-ecf9dc1b52d9"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 25, 57, 696, DateTimeKind.Utc).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("7f1f7c59-f92e-4c3b-a3f4-9c2a4cd474cb"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 25, 57, 696, DateTimeKind.Utc).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8b5c0f77-e3f1-4972-9102-6c1dfbb5a601"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 25, 57, 696, DateTimeKind.Utc).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8d5c8e30-dede-4ef0-9158-f7692c41acb2"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 25, 57, 696, DateTimeKind.Utc).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9b7f3e43-50bc-41d5-8f43-b8e0e1f47732"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 25, 57, 696, DateTimeKind.Utc).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e7b22d3-c5a5-429e-82dc-e5c573745e1d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 25, 57, 696, DateTimeKind.Utc).AddTicks(6764));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("c7f1f4f5-74e3-4b4f-9c5a-3e2059d8b72d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 25, 57, 696, DateTimeKind.Utc).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("e43ff624-3f3c-4e8e-b5eb-11c0c3a244fa"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 25, 57, 696, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("f3b00c12-3b5e-4c8e-9bb0-7a5c7408cd07"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 25, 57, 696, DateTimeKind.Utc).AddTicks(6830));

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
                value: new DateTime(2024, 11, 15, 17, 15, 19, 667, DateTimeKind.Utc).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c9ebf2c7-5a7f-4b5d-bb7f-2f2c4d8e4a88"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 17, 15, 19, 667, DateTimeKind.Utc).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("d3c4b5e8-1f3a-4c8c-897e-2d8cf3e7c4f6"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 17, 15, 19, 667, DateTimeKind.Utc).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 17, 15, 19, 667, DateTimeKind.Utc).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "41-7E-3A-41-F0-05-DA-02-99-04-4E-2D-CA-96-17-34-7B-23-96-F6-36-26-39-5A-0D-16-F2-63-53-0B-34-14", new byte[] { 101, 104, 103, 42, 48, 181, 31, 59, 56, 57, 74, 8, 112, 152, 60, 129, 125, 12, 206, 178, 65, 245, 8, 164, 46, 224, 28, 98, 122, 188, 193, 242, 4, 206, 121, 107, 22, 237, 165, 52, 150, 129, 13, 172, 144, 238, 113, 111, 43, 89, 232, 183, 55, 158, 109, 210, 173, 5, 82, 17, 111, 213, 43, 33 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "5C-C9-AD-8A-F4-D1-9A-5A-02-D7-52-1D-66-D5-54-0D-63-A6-AF-EF-69-E5-FE-8D-BF-1D-D0-5D-D7-44-A8-8D", new byte[] { 76, 79, 252, 15, 10, 183, 103, 26, 14, 148, 68, 15, 212, 173, 179, 252, 124, 226, 52, 142, 87, 246, 120, 0, 146, 88, 235, 151, 167, 43, 161, 199, 61, 2, 105, 88, 68, 239, 43, 30, 16, 12, 232, 251, 149, 44, 8, 120, 228, 108, 185, 87, 122, 11, 160, 156, 131, 111, 9, 119, 208, 147, 199, 159 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "63-7D-3C-38-BB-B7-6E-70-81-B6-E8-55-60-72-21-58-55-D0-53-65-28-02-6A-3D-67-0A-B3-9C-4A-21-30-CB", new byte[] { 5, 55, 31, 133, 111, 159, 33, 62, 119, 60, 55, 33, 42, 172, 170, 190, 148, 155, 16, 213, 107, 201, 211, 56, 57, 49, 15, 121, 143, 94, 33, 235, 226, 237, 144, 132, 209, 99, 165, 97, 179, 191, 86, 219, 144, 10, 142, 160, 195, 117, 221, 141, 227, 152, 168, 137, 205, 20, 37, 204, 204, 70, 194, 231 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "24-68-64-B6-13-A4-E7-4F-C3-82-2D-38-A3-33-0B-F9-CF-6E-44-56-45-3D-B5-45-B2-A9-94-8D-6F-10-46-B8", new byte[] { 212, 210, 52, 31, 224, 138, 116, 159, 109, 194, 173, 196, 227, 252, 245, 212, 39, 229, 29, 165, 164, 189, 225, 103, 185, 42, 31, 230, 231, 228, 120, 206, 197, 39, 222, 81, 132, 166, 172, 206, 92, 43, 171, 116, 186, 145, 141, 8, 121, 128, 84, 69, 16, 16, 59, 244, 173, 145, 99, 202, 162, 77, 40, 2 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "C6-93-25-A0-31-AC-A4-8C-72-13-3A-95-68-AE-98-5A-3C-58-1B-56-F3-32-F1-A9-2A-CA-27-35-4D-03-FB-CA", new byte[] { 233, 52, 202, 74, 129, 139, 210, 200, 119, 4, 146, 80, 45, 9, 19, 147, 49, 154, 31, 205, 96, 168, 76, 198, 226, 47, 161, 5, 204, 67, 158, 194, 99, 143, 120, 149, 110, 142, 193, 174, 40, 180, 100, 103, 4, 56, 97, 66, 14, 70, 255, 139, 170, 52, 201, 3, 75, 181, 85, 6, 45, 55, 231, 76 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "05-29-34-24-7F-6E-4E-0C-B1-F0-8B-FB-AF-FA-5F-B7-A8-66-70-97-9C-00-A2-28-8D-EF-E4-DD-B6-2F-93-6E", new byte[] { 14, 38, 155, 240, 132, 89, 149, 161, 158, 48, 160, 182, 98, 129, 171, 178, 56, 59, 217, 98, 47, 169, 202, 101, 255, 60, 143, 226, 61, 216, 117, 255, 251, 40, 132, 16, 253, 130, 202, 237, 11, 163, 42, 44, 223, 25, 159, 250, 250, 19, 210, 157, 247, 118, 113, 196, 57, 49, 176, 201, 201, 246, 56, 7 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "A3-C5-01-66-77-DD-34-0A-5C-65-36-D0-D9-EB-1D-A2-BD-36-36-E5-1C-9B-20-95-13-86-A9-63-FD-8D-E2-36", new byte[] { 155, 74, 52, 252, 88, 253, 17, 99, 146, 187, 91, 183, 199, 184, 58, 71, 142, 253, 233, 117, 19, 42, 184, 151, 131, 73, 242, 101, 225, 192, 32, 71, 89, 120, 124, 240, 53, 97, 226, 47, 215, 158, 214, 163, 195, 81, 244, 244, 20, 36, 170, 252, 95, 220, 216, 146, 135, 179, 206, 75, 115, 39, 68, 135 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "0F-65-0F-46-86-A1-61-74-39-26-25-F0-67-BD-58-13-CD-CB-4B-DB-76-A3-3F-0C-F5-E3-4E-03-72-97-E1-BA", new byte[] { 210, 75, 166, 119, 93, 133, 65, 24, 110, 22, 211, 159, 185, 226, 81, 23, 112, 243, 28, 177, 96, 86, 35, 142, 33, 109, 151, 103, 1, 216, 65, 222, 182, 215, 96, 112, 152, 73, 217, 90, 21, 136, 176, 233, 101, 122, 196, 8, 172, 88, 107, 237, 19, 46, 60, 220, 163, 12, 0, 103, 189, 166, 175, 57 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "59-45-FE-E8-3D-CD-DE-62-2E-83-2D-B4-3E-F7-20-68-A0-EC-BE-22-A4-C5-B7-8C-16-CC-24-1F-1C-67-8E-D1", new byte[] { 168, 77, 55, 87, 186, 239, 42, 105, 11, 186, 82, 209, 84, 97, 237, 235, 218, 151, 204, 208, 102, 143, 152, 122, 218, 10, 248, 254, 188, 105, 155, 208, 151, 232, 246, 214, 161, 107, 218, 214, 193, 107, 129, 216, 109, 11, 114, 14, 28, 196, 251, 216, 30, 48, 177, 88, 189, 29, 78, 202, 243, 136, 8, 70 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100004,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "6E-26-53-91-8B-AA-04-99-74-AE-A7-9F-06-0D-B3-36-A7-FD-2E-CE-43-AB-DB-46-2B-EC-2D-9D-E0-16-0A-9D", new byte[] { 51, 175, 92, 248, 134, 61, 176, 249, 130, 144, 217, 33, 29, 176, 168, 243, 147, 107, 135, 41, 15, 101, 204, 195, 133, 77, 43, 111, 91, 81, 56, 7, 206, 70, 204, 7, 150, 232, 98, 82, 53, 25, 74, 59, 193, 9, 65, 60, 127, 207, 200, 199, 58, 255, 184, 3, 226, 102, 28, 46, 146, 237, 255, 8 } });

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0a9c8263-7f5e-4e25-bb85-7a4c0a1e3a5c"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 15, 19, 667, DateTimeKind.Utc).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0bb3c011-9ba9-47e7-9ce0-3268f85e1ffc"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 15, 19, 667, DateTimeKind.Utc).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("18a64e64-3707-451c-b54d-51dbb9933aa0"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 15, 19, 667, DateTimeKind.Utc).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("1b234567-89ab-cdef-0123-456789abcdef"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 15, 19, 667, DateTimeKind.Utc).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("2b7c5a63-8e93-4d88-bc90-85c42d1574ae"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 15, 19, 667, DateTimeKind.Utc).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("34f2c84e-6c77-4c4a-b5f3-eef62d87b4be"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 15, 19, 667, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("3d8f49b2-ef8b-4b3e-8f5d-1f68d8f4f4b1"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 15, 19, 667, DateTimeKind.Utc).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("4d8d76aa-48e5-4c2b-95f1-5a77c73c0f11"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 15, 19, 667, DateTimeKind.Utc).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("59259348-41da-4bbc-b85c-48ee82f474ce"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 15, 19, 667, DateTimeKind.Utc).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5a6e8d59-0c3d-4e54-a105-50f44dcb9e4b"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 15, 19, 667, DateTimeKind.Utc).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5e4f2822-bb47-45b4-83c0-6c1de2b5f900"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 15, 19, 667, DateTimeKind.Utc).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("72b24a8d-4e5b-43e5-aeae-ecf9dc1b52d9"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 15, 19, 667, DateTimeKind.Utc).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("7f1f7c59-f92e-4c3b-a3f4-9c2a4cd474cb"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 15, 19, 667, DateTimeKind.Utc).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8b5c0f77-e3f1-4972-9102-6c1dfbb5a601"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 15, 19, 667, DateTimeKind.Utc).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8d5c8e30-dede-4ef0-9158-f7692c41acb2"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 15, 19, 667, DateTimeKind.Utc).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9b7f3e43-50bc-41d5-8f43-b8e0e1f47732"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 15, 19, 667, DateTimeKind.Utc).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e7b22d3-c5a5-429e-82dc-e5c573745e1d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 15, 19, 667, DateTimeKind.Utc).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("c7f1f4f5-74e3-4b4f-9c5a-3e2059d8b72d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 15, 19, 667, DateTimeKind.Utc).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("e43ff624-3f3c-4e8e-b5eb-11c0c3a244fa"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 15, 19, 667, DateTimeKind.Utc).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("f3b00c12-3b5e-4c8e-9bb0-7a5c7408cd07"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 15, 19, 667, DateTimeKind.Utc).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23"),
                column: "GamePicturePath",
                value: "https://fusiontech-0dxp.onrender.com/.jpg");
        }
    }
}
