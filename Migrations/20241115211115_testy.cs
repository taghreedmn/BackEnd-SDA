using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class testy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
