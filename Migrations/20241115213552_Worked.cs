using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class Worked : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c4f5e3e1-2c4c-4f4e-a4d1-5e5e6139d703"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 21, 35, 52, 225, DateTimeKind.Utc).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c9ebf2c7-5a7f-4b5d-bb7f-2f2c4d8e4a88"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 21, 35, 52, 225, DateTimeKind.Utc).AddTicks(3445));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("d3c4b5e8-1f3a-4c8c-897e-2d8cf3e7c4f6"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 21, 35, 52, 225, DateTimeKind.Utc).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 21, 35, 52, 225, DateTimeKind.Utc).AddTicks(3442));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "6E-1F-86-91-40-AE-09-F8-CB-EF-FC-13-F2-B8-12-00-3E-40-75-1F-43-EE-FB-64-30-69-C8-A1-84-36-91-79", new byte[] { 39, 224, 204, 55, 177, 179, 90, 10, 49, 122, 197, 105, 225, 20, 83, 185, 168, 247, 7, 45, 216, 146, 166, 130, 184, 3, 8, 117, 24, 154, 129, 171, 220, 209, 208, 247, 107, 79, 173, 162, 114, 53, 57, 246, 38, 245, 47, 241, 122, 146, 35, 171, 171, 87, 41, 156, 163, 25, 222, 3, 29, 73, 237, 39 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "F6-8E-04-2C-A5-BB-7B-D1-CD-C2-24-A1-6A-CE-7D-43-75-47-A2-63-1E-C4-22-D7-94-AF-33-E3-DF-E4-C2-55", new byte[] { 219, 191, 123, 10, 168, 9, 100, 86, 26, 239, 83, 244, 8, 15, 74, 245, 151, 73, 252, 111, 68, 22, 36, 64, 88, 86, 161, 222, 150, 125, 2, 237, 234, 199, 190, 229, 88, 153, 131, 92, 19, 150, 205, 8, 239, 253, 164, 41, 182, 23, 12, 201, 185, 150, 215, 13, 202, 180, 144, 168, 227, 14, 183, 95 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "0C-1A-91-00-E5-2B-3F-DB-06-2E-07-7F-B7-B8-E4-B6-25-C0-FF-88-E2-A7-30-08-C6-83-3A-31-72-5E-34-64", new byte[] { 219, 71, 67, 65, 178, 219, 26, 90, 43, 153, 185, 171, 142, 219, 75, 40, 186, 232, 225, 99, 239, 221, 103, 31, 199, 138, 219, 126, 80, 66, 219, 196, 192, 109, 123, 135, 20, 168, 139, 246, 134, 151, 89, 254, 119, 89, 92, 100, 67, 227, 186, 64, 219, 196, 129, 54, 123, 46, 81, 122, 9, 134, 239, 144 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "6A-30-EF-1E-59-88-FE-7B-EC-FB-CF-71-BD-0A-B9-0E-F7-0D-9E-32-1B-BF-D9-EC-A6-A1-59-0F-63-1D-E9-86", new byte[] { 195, 147, 116, 195, 6, 186, 120, 59, 147, 124, 205, 151, 248, 2, 54, 108, 220, 174, 46, 46, 200, 70, 159, 179, 111, 249, 19, 69, 249, 57, 204, 224, 37, 50, 134, 195, 109, 23, 37, 178, 37, 136, 162, 122, 189, 252, 137, 180, 96, 93, 219, 109, 41, 15, 253, 226, 0, 236, 186, 162, 56, 55, 164, 24 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "A6-C9-AC-58-D3-6C-6B-03-16-01-3A-9A-20-E7-5E-7E-97-10-54-B7-00-77-62-AD-06-E4-6B-ED-8F-18-9C-16", new byte[] { 141, 121, 163, 42, 142, 224, 34, 33, 196, 53, 21, 66, 211, 23, 93, 136, 242, 217, 167, 143, 88, 194, 107, 49, 83, 56, 26, 246, 241, 227, 146, 106, 7, 133, 73, 130, 59, 167, 92, 114, 148, 253, 149, 5, 9, 153, 248, 227, 27, 96, 201, 30, 238, 206, 18, 211, 255, 157, 199, 178, 122, 5, 169, 199 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "EB-1D-4D-C7-48-EF-DF-5A-39-D2-35-E5-4D-82-9B-D8-26-14-27-2B-E6-67-78-86-25-C3-E6-01-87-C2-75-D0", new byte[] { 92, 177, 49, 23, 47, 26, 111, 70, 6, 197, 32, 87, 131, 134, 216, 183, 254, 51, 136, 55, 167, 197, 181, 202, 217, 24, 56, 26, 62, 195, 187, 5, 4, 111, 210, 23, 108, 48, 238, 204, 90, 135, 38, 134, 12, 254, 31, 182, 204, 146, 134, 207, 164, 97, 89, 59, 32, 97, 38, 177, 183, 70, 125, 106 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "AA-F0-87-C0-0B-07-95-CF-04-F1-9D-2D-CA-0D-CC-FF-79-4B-D9-F7-79-C8-2C-FF-7C-C6-98-64-92-E0-96-10", new byte[] { 157, 124, 68, 104, 121, 16, 131, 255, 101, 235, 36, 62, 184, 82, 171, 0, 71, 216, 195, 116, 200, 159, 228, 75, 213, 161, 243, 241, 145, 229, 25, 93, 246, 120, 84, 96, 168, 175, 85, 205, 245, 162, 114, 62, 250, 125, 128, 102, 165, 84, 240, 215, 104, 172, 81, 169, 109, 141, 80, 4, 101, 191, 213, 253 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "54-6E-CF-06-CB-77-3F-3D-0D-FB-11-A5-F3-BE-E4-B8-2A-31-0F-63-5F-DF-63-69-92-4D-0F-33-A8-51-B7-02", new byte[] { 202, 121, 80, 80, 33, 207, 177, 184, 222, 222, 75, 163, 160, 117, 45, 226, 184, 229, 249, 198, 230, 132, 95, 87, 188, 184, 26, 2, 199, 239, 240, 140, 104, 219, 240, 144, 144, 104, 139, 98, 52, 67, 137, 25, 222, 4, 252, 219, 156, 139, 143, 9, 127, 236, 165, 38, 27, 209, 184, 19, 86, 82, 211, 169 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "98-E4-E0-99-81-B8-F2-85-90-9C-A0-99-BC-7F-E3-65-82-FF-50-10-4D-28-D5-60-3F-9B-6E-8A-6F-43-0C-7A", new byte[] { 99, 148, 0, 212, 183, 228, 147, 26, 214, 108, 224, 161, 211, 141, 253, 140, 252, 35, 178, 86, 131, 5, 112, 98, 113, 235, 11, 191, 103, 82, 251, 127, 237, 97, 217, 162, 172, 201, 50, 243, 105, 230, 197, 161, 226, 11, 66, 100, 164, 163, 140, 42, 255, 90, 238, 224, 103, 71, 219, 61, 71, 226, 65, 240 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100004,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "C0-A4-D9-4E-74-30-AB-99-70-1B-33-3B-00-0A-93-8A-D1-40-67-1A-A3-7A-A6-DE-74-AA-5E-63-FE-AD-43-DE", new byte[] { 221, 172, 229, 99, 2, 60, 238, 158, 116, 98, 33, 50, 217, 160, 167, 47, 125, 184, 103, 170, 93, 62, 82, 30, 71, 169, 97, 51, 228, 255, 128, 47, 88, 154, 198, 26, 115, 248, 243, 199, 165, 188, 7, 123, 231, 183, 37, 199, 43, 203, 13, 0, 210, 74, 183, 50, 140, 40, 249, 92, 226, 36, 241, 55 } });

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0a9c8263-7f5e-4e25-bb85-7a4c0a1e3a5c"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 35, 52, 225, DateTimeKind.Utc).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0bb3c011-9ba9-47e7-9ce0-3268f85e1ffc"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 35, 52, 225, DateTimeKind.Utc).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("18a64e64-3707-451c-b54d-51dbb9933aa0"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 35, 52, 225, DateTimeKind.Utc).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("1b234567-89ab-cdef-0123-456789abcdef"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 35, 52, 225, DateTimeKind.Utc).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("2b7c5a63-8e93-4d88-bc90-85c42d1574ae"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 35, 52, 225, DateTimeKind.Utc).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("34f2c84e-6c77-4c4a-b5f3-eef62d87b4be"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 35, 52, 225, DateTimeKind.Utc).AddTicks(3329));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("3d8f49b2-ef8b-4b3e-8f5d-1f68d8f4f4b1"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 35, 52, 225, DateTimeKind.Utc).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("4d8d76aa-48e5-4c2b-95f1-5a77c73c0f11"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 35, 52, 225, DateTimeKind.Utc).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("59259348-41da-4bbc-b85c-48ee82f474ce"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 35, 52, 225, DateTimeKind.Utc).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5a6e8d59-0c3d-4e54-a105-50f44dcb9e4b"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 35, 52, 225, DateTimeKind.Utc).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5e4f2822-bb47-45b4-83c0-6c1de2b5f900"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 35, 52, 225, DateTimeKind.Utc).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("72b24a8d-4e5b-43e5-aeae-ecf9dc1b52d9"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 35, 52, 225, DateTimeKind.Utc).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("7f1f7c59-f92e-4c3b-a3f4-9c2a4cd474cb"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 35, 52, 225, DateTimeKind.Utc).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8b5c0f77-e3f1-4972-9102-6c1dfbb5a601"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 35, 52, 225, DateTimeKind.Utc).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8d5c8e30-dede-4ef0-9158-f7692c41acb2"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 35, 52, 225, DateTimeKind.Utc).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9b7f3e43-50bc-41d5-8f43-b8e0e1f47732"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 35, 52, 225, DateTimeKind.Utc).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e7b22d3-c5a5-429e-82dc-e5c573745e1d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 35, 52, 225, DateTimeKind.Utc).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("c7f1f4f5-74e3-4b4f-9c5a-3e2059d8b72d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 35, 52, 225, DateTimeKind.Utc).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("e43ff624-3f3c-4e8e-b5eb-11c0c3a244fa"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 35, 52, 225, DateTimeKind.Utc).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("f3b00c12-3b5e-4c8e-9bb0-7a5c7408cd07"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 35, 52, 225, DateTimeKind.Utc).AddTicks(3338));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c4f5e3e1-2c4c-4f4e-a4d1-5e5e6139d703"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c9ebf2c7-5a7f-4b5d-bb7f-2f2c4d8e4a88"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("d3c4b5e8-1f3a-4c8c-897e-2d8cf3e7c4f6"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "09-4F-27-42-2F-88-8B-9B-98-19-D2-34-C1-9C-5D-14-C3-BD-D8-40-B3-B0-DA-54-04-6C-C6-97-27-67-0A-56", new byte[] { 131, 79, 154, 0, 192, 124, 192, 118, 2, 202, 69, 173, 252, 125, 122, 193, 27, 201, 104, 162, 141, 154, 136, 27, 190, 180, 153, 212, 193, 133, 146, 210, 211, 205, 136, 21, 218, 123, 58, 56, 204, 194, 245, 145, 125, 208, 83, 235, 201, 225, 196, 131, 67, 229, 98, 139, 238, 148, 93, 239, 48, 128, 251, 96 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "23-EB-8B-2A-B0-C7-47-0D-6B-1C-B4-C4-C7-70-19-94-72-67-49-D9-93-38-DB-9E-8C-71-56-14-FC-F8-0E-11", new byte[] { 229, 191, 231, 126, 13, 252, 74, 134, 166, 249, 241, 216, 232, 255, 110, 200, 218, 213, 6, 126, 214, 39, 36, 32, 198, 123, 121, 33, 55, 178, 56, 217, 103, 19, 221, 165, 205, 207, 82, 99, 25, 25, 70, 167, 70, 142, 31, 196, 45, 210, 30, 0, 15, 171, 110, 58, 16, 102, 159, 70, 184, 126, 27, 8 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "87-FA-A0-89-0E-C5-E5-B5-8F-06-39-E3-98-9E-41-CB-C6-0E-71-53-41-BB-45-21-FD-8A-A3-3B-BD-73-DE-7C", new byte[] { 154, 245, 24, 54, 177, 218, 27, 254, 82, 213, 183, 23, 121, 14, 142, 180, 32, 191, 230, 52, 162, 254, 248, 200, 122, 20, 62, 253, 201, 108, 25, 164, 78, 12, 41, 113, 27, 163, 138, 88, 221, 172, 213, 248, 86, 205, 186, 151, 109, 231, 197, 243, 238, 121, 253, 94, 172, 226, 128, 221, 146, 207, 253, 230 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "2B-47-9B-94-F3-5E-D1-1D-94-6A-04-56-A1-E3-68-40-F1-59-CC-A4-8F-43-6D-DA-9C-23-9F-A2-75-8A-D7-F4", new byte[] { 170, 41, 237, 100, 124, 87, 22, 28, 202, 215, 242, 214, 188, 205, 221, 17, 73, 7, 13, 246, 141, 234, 102, 50, 203, 17, 206, 34, 230, 46, 52, 149, 18, 22, 214, 214, 244, 102, 252, 104, 217, 89, 227, 110, 50, 126, 26, 158, 188, 78, 124, 158, 47, 165, 48, 229, 9, 183, 201, 47, 206, 160, 251, 62 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "E9-F2-01-D5-38-5B-F8-49-36-66-2E-D0-0D-C3-37-AF-F8-14-78-39-CE-F7-92-22-B5-40-E9-E8-22-DC-EB-CC", new byte[] { 41, 204, 39, 207, 57, 170, 104, 91, 55, 201, 46, 150, 217, 18, 222, 29, 123, 92, 28, 29, 125, 113, 139, 52, 159, 60, 99, 238, 240, 95, 131, 43, 182, 109, 140, 19, 74, 17, 121, 253, 19, 173, 213, 194, 214, 139, 128, 131, 252, 242, 92, 60, 164, 14, 253, 90, 23, 164, 4, 156, 216, 10, 150, 229 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "1A-D9-B8-69-E5-A8-FA-24-E7-29-7B-A8-EE-F5-34-90-48-F4-42-AF-F7-7B-8A-CF-53-57-8E-86-7D-D6-76-98", new byte[] { 40, 91, 245, 59, 74, 227, 230, 180, 60, 250, 18, 99, 7, 53, 227, 141, 111, 220, 177, 144, 31, 133, 209, 167, 134, 165, 139, 204, 9, 124, 86, 50, 104, 89, 205, 159, 123, 239, 190, 216, 172, 230, 43, 137, 215, 0, 176, 122, 167, 171, 21, 95, 144, 29, 219, 251, 221, 70, 246, 161, 197, 251, 204, 20 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "D6-2C-BB-D9-83-F5-52-90-24-47-DB-FE-37-4D-F5-E5-71-3C-DA-9F-31-2B-2C-0B-5F-A7-98-96-64-30-CF-60", new byte[] { 4, 137, 220, 38, 115, 229, 148, 68, 25, 204, 140, 183, 18, 0, 186, 235, 202, 154, 145, 181, 62, 123, 217, 60, 71, 112, 56, 166, 226, 57, 187, 90, 82, 91, 167, 122, 252, 187, 104, 195, 56, 248, 134, 239, 252, 76, 169, 63, 231, 77, 245, 226, 251, 130, 253, 152, 44, 140, 155, 31, 96, 43, 203, 226 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "19-7F-D5-96-02-F0-C3-79-66-91-6B-05-CE-26-85-4C-CA-B2-F1-6C-D9-CF-D3-D6-43-F9-09-00-C5-F0-80-6E", new byte[] { 7, 108, 217, 214, 167, 23, 217, 130, 12, 229, 61, 250, 247, 93, 87, 56, 131, 59, 245, 103, 162, 43, 75, 194, 115, 5, 19, 92, 108, 116, 92, 112, 131, 64, 155, 183, 46, 221, 43, 4, 148, 35, 115, 128, 43, 131, 1, 30, 171, 154, 180, 121, 72, 105, 47, 248, 198, 43, 179, 160, 108, 209, 95, 75 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "01-58-86-97-45-42-41-F4-03-92-97-7A-80-AC-33-52-F0-11-13-5B-FA-A6-0F-73-47-F5-D4-98-D8-43-01-9E", new byte[] { 125, 195, 47, 175, 104, 204, 233, 0, 178, 145, 89, 184, 98, 249, 216, 214, 251, 192, 174, 116, 233, 170, 60, 52, 44, 112, 165, 28, 86, 242, 70, 123, 232, 235, 164, 206, 224, 75, 0, 113, 26, 220, 138, 181, 100, 173, 255, 242, 208, 172, 255, 156, 177, 137, 162, 241, 212, 140, 3, 177, 87, 140, 254, 162 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100004,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "62-C0-4F-93-E6-63-0C-D1-7E-93-7A-C7-FE-36-A8-84-5A-CA-FD-AF-BE-C9-7C-1E-B5-2B-F0-6B-A5-DC-70-B7", new byte[] { 236, 179, 43, 236, 47, 53, 243, 200, 22, 33, 65, 17, 135, 195, 5, 183, 230, 213, 70, 41, 145, 188, 255, 106, 207, 152, 73, 142, 46, 79, 109, 206, 66, 238, 191, 119, 172, 104, 93, 158, 92, 234, 187, 163, 70, 107, 181, 185, 34, 122, 132, 109, 1, 232, 185, 80, 108, 134, 253, 141, 14, 90, 177, 36 } });

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0a9c8263-7f5e-4e25-bb85-7a4c0a1e3a5c"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0bb3c011-9ba9-47e7-9ce0-3268f85e1ffc"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("18a64e64-3707-451c-b54d-51dbb9933aa0"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("1b234567-89ab-cdef-0123-456789abcdef"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("2b7c5a63-8e93-4d88-bc90-85c42d1574ae"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("34f2c84e-6c77-4c4a-b5f3-eef62d87b4be"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("3d8f49b2-ef8b-4b3e-8f5d-1f68d8f4f4b1"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("4d8d76aa-48e5-4c2b-95f1-5a77c73c0f11"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("59259348-41da-4bbc-b85c-48ee82f474ce"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5a6e8d59-0c3d-4e54-a105-50f44dcb9e4b"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5e4f2822-bb47-45b4-83c0-6c1de2b5f900"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("72b24a8d-4e5b-43e5-aeae-ecf9dc1b52d9"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("7f1f7c59-f92e-4c3b-a3f4-9c2a4cd474cb"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8b5c0f77-e3f1-4972-9102-6c1dfbb5a601"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8d5c8e30-dede-4ef0-9158-f7692c41acb2"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9b7f3e43-50bc-41d5-8f43-b8e0e1f47732"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e7b22d3-c5a5-429e-82dc-e5c573745e1d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("c7f1f4f5-74e3-4b4f-9c5a-3e2059d8b72d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("e43ff624-3f3c-4e8e-b5eb-11c0c3a244fa"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("f3b00c12-3b5e-4c8e-9bb0-7a5c7408cd07"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5200));
        }
    }
}
