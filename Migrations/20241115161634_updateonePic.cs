using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class updateonePic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c4f5e3e1-2c4c-4f4e-a4d1-5e5e6139d703"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c9ebf2c7-5a7f-4b5d-bb7f-2f2c4d8e4a88"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("d3c4b5e8-1f3a-4c8c-897e-2d8cf3e7c4f6"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "45-0C-0F-C1-22-6F-59-71-3C-A4-B7-F6-38-FD-08-E6-00-C2-03-0D-A6-17-60-F9-61-53-10-6B-5E-C2-35-7C", new byte[] { 5, 90, 86, 96, 122, 169, 173, 20, 126, 255, 73, 26, 17, 227, 211, 58, 19, 214, 69, 124, 82, 174, 16, 23, 190, 51, 216, 27, 193, 118, 115, 222, 199, 192, 45, 156, 28, 205, 162, 194, 243, 218, 53, 154, 2, 189, 196, 53, 85, 59, 14, 62, 159, 67, 235, 99, 225, 172, 128, 234, 122, 149, 16, 252 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "EB-BD-C3-49-A1-EC-7A-27-66-1D-0D-8A-08-33-0B-88-85-F0-CE-82-B0-D0-EA-2D-73-3A-01-6D-8C-D5-E0-08", new byte[] { 94, 175, 190, 158, 43, 33, 164, 36, 96, 14, 62, 139, 110, 11, 83, 175, 175, 177, 235, 30, 181, 172, 183, 226, 12, 234, 53, 188, 117, 55, 158, 49, 232, 157, 244, 137, 161, 131, 147, 237, 46, 148, 122, 145, 160, 182, 228, 189, 167, 60, 100, 28, 225, 191, 66, 141, 205, 55, 82, 79, 226, 43, 80, 61 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "81-12-3A-47-AD-19-1D-4A-19-DF-76-A1-2E-5B-C6-27-46-1E-40-79-3B-C7-23-5E-38-23-99-A7-2F-23-2F-18", new byte[] { 141, 157, 55, 75, 158, 59, 141, 240, 227, 200, 165, 0, 4, 150, 217, 55, 117, 239, 177, 186, 123, 216, 136, 12, 100, 165, 7, 229, 31, 179, 188, 141, 168, 106, 34, 30, 223, 102, 230, 218, 43, 247, 23, 227, 6, 40, 139, 248, 53, 11, 32, 72, 115, 111, 232, 188, 20, 124, 125, 231, 98, 34, 227, 130 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "50-5B-13-B6-B5-18-CD-18-C9-8F-39-A0-50-C2-81-52-0F-C0-F8-B2-D4-7D-7A-3C-0C-00-DD-5E-EC-D8-B4-38", new byte[] { 203, 127, 165, 12, 235, 57, 140, 166, 238, 158, 163, 203, 112, 87, 14, 131, 39, 6, 73, 246, 172, 146, 2, 138, 110, 51, 236, 207, 4, 44, 211, 174, 40, 57, 209, 189, 225, 245, 153, 245, 30, 183, 12, 195, 134, 75, 224, 138, 180, 165, 34, 112, 22, 220, 109, 96, 65, 38, 52, 38, 185, 75, 74, 242 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "68-6C-78-5D-45-48-01-CC-3E-CA-E7-AB-10-75-1D-F5-24-32-E4-58-A9-06-7D-13-4A-44-14-15-EB-9F-1D-E3", new byte[] { 35, 56, 230, 189, 18, 27, 195, 6, 113, 158, 111, 92, 52, 117, 65, 185, 129, 14, 121, 112, 226, 219, 161, 37, 125, 58, 113, 193, 13, 134, 68, 26, 114, 96, 117, 162, 129, 40, 60, 190, 10, 138, 164, 105, 201, 204, 20, 198, 111, 159, 225, 76, 11, 145, 231, 210, 233, 122, 35, 194, 227, 80, 12, 183 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "D7-A2-8B-E9-60-F0-16-2D-D0-B4-D2-C4-28-CC-14-B2-C4-DF-8E-34-0A-38-1A-FB-9F-29-1E-F5-78-B4-FC-3D", new byte[] { 146, 60, 112, 40, 17, 229, 189, 56, 14, 243, 42, 88, 49, 220, 251, 169, 185, 83, 190, 220, 51, 235, 130, 164, 187, 184, 198, 21, 209, 88, 59, 171, 179, 227, 98, 164, 55, 161, 167, 33, 56, 30, 78, 215, 128, 180, 70, 92, 52, 210, 206, 29, 87, 184, 31, 167, 167, 24, 31, 194, 238, 109, 202, 236 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "A4-5B-E3-E0-3D-35-BF-BA-65-76-D4-68-B4-8A-39-DA-D1-E4-4E-4B-DF-CF-D2-53-C1-7F-0D-E1-42-BB-65-38", new byte[] { 127, 206, 167, 154, 136, 48, 102, 202, 252, 23, 223, 119, 84, 120, 34, 234, 151, 33, 34, 4, 251, 107, 226, 92, 76, 160, 195, 173, 60, 255, 75, 69, 143, 212, 13, 47, 212, 140, 186, 161, 115, 226, 118, 143, 62, 93, 208, 220, 3, 11, 95, 198, 162, 8, 222, 240, 63, 102, 178, 109, 207, 34, 249, 91 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "61-C5-C9-65-AD-BC-48-97-B6-46-09-5D-20-82-75-93-8C-C7-D5-8D-9C-21-B9-94-7F-57-0B-B6-A4-41-35-25", new byte[] { 97, 93, 133, 74, 67, 43, 242, 81, 234, 155, 90, 149, 163, 157, 124, 143, 90, 195, 80, 154, 104, 143, 0, 111, 227, 83, 43, 189, 40, 242, 4, 163, 232, 8, 88, 69, 147, 60, 241, 64, 50, 188, 206, 71, 18, 62, 149, 9, 125, 82, 238, 117, 104, 70, 19, 37, 89, 149, 31, 47, 12, 201, 255, 235 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "7E-76-C3-AF-63-28-EA-10-FA-58-97-CE-A8-DD-4A-9F-47-EB-52-64-A7-BE-44-43-65-62-3D-BB-90-95-22-A5", new byte[] { 71, 184, 1, 189, 20, 149, 116, 236, 244, 30, 222, 57, 22, 90, 133, 220, 162, 170, 133, 213, 109, 116, 145, 149, 131, 174, 215, 230, 50, 3, 154, 90, 160, 64, 160, 24, 136, 137, 160, 107, 210, 134, 48, 200, 71, 123, 214, 72, 53, 52, 115, 59, 185, 169, 83, 37, 118, 80, 198, 180, 203, 62, 91, 40 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100004,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "85-6F-33-C6-80-6E-D5-0E-15-40-86-7D-7D-77-D2-80-FA-19-71-5E-CA-AD-6D-39-39-8C-24-35-4C-0C-E3-F3", new byte[] { 129, 109, 98, 102, 229, 50, 68, 131, 170, 240, 15, 7, 9, 13, 228, 37, 6, 15, 100, 251, 53, 93, 82, 97, 207, 53, 151, 52, 184, 80, 77, 142, 127, 136, 185, 115, 184, 23, 121, 25, 17, 64, 211, 33, 108, 185, 61, 162, 139, 6, 18, 28, 129, 187, 243, 29, 69, 20, 15, 36, 243, 13, 162, 180 } });

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0a9c8263-7f5e-4e25-bb85-7a4c0a1e3a5c"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0bb3c011-9ba9-47e7-9ce0-3268f85e1ffc"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("18a64e64-3707-451c-b54d-51dbb9933aa0"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("1b234567-89ab-cdef-0123-456789abcdef"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("2b7c5a63-8e93-4d88-bc90-85c42d1574ae"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("34f2c84e-6c77-4c4a-b5f3-eef62d87b4be"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("3d8f49b2-ef8b-4b3e-8f5d-1f68d8f4f4b1"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("4d8d76aa-48e5-4c2b-95f1-5a77c73c0f11"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("59259348-41da-4bbc-b85c-48ee82f474ce"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5a6e8d59-0c3d-4e54-a105-50f44dcb9e4b"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5e4f2822-bb47-45b4-83c0-6c1de2b5f900"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("72b24a8d-4e5b-43e5-aeae-ecf9dc1b52d9"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("7f1f7c59-f92e-4c3b-a3f4-9c2a4cd474cb"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8b5c0f77-e3f1-4972-9102-6c1dfbb5a601"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8d5c8e30-dede-4ef0-9158-f7692c41acb2"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9b7f3e43-50bc-41d5-8f43-b8e0e1f47732"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e7b22d3-c5a5-429e-82dc-e5c573745e1d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("c7f1f4f5-74e3-4b4f-9c5a-3e2059d8b72d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("e43ff624-3f3c-4e8e-b5eb-11c0c3a244fa"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("f3b00c12-3b5e-4c8e-9bb0-7a5c7408cd07"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23"),
                column: "GamePicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Games/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23.jpg");
        }
    }
}
