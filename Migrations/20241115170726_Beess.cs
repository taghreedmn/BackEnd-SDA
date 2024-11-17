using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class Beess : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c4f5e3e1-2c4c-4f4e-a4d1-5e5e6139d703"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 17, 7, 25, 835, DateTimeKind.Utc).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c9ebf2c7-5a7f-4b5d-bb7f-2f2c4d8e4a88"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 17, 7, 25, 835, DateTimeKind.Utc).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("d3c4b5e8-1f3a-4c8c-897e-2d8cf3e7c4f6"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 17, 7, 25, 835, DateTimeKind.Utc).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 17, 7, 25, 835, DateTimeKind.Utc).AddTicks(5187));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "67-46-57-3C-E1-6C-B8-0F-39-0C-98-85-82-FC-53-01-11-EA-94-49-EB-B5-82-11-A5-60-82-00-E4-C9-4E-CF", new byte[] { 31, 231, 76, 91, 93, 45, 239, 13, 71, 70, 251, 94, 225, 62, 64, 118, 111, 117, 235, 20, 23, 141, 154, 17, 187, 125, 81, 170, 155, 151, 229, 53, 246, 113, 61, 211, 4, 20, 97, 191, 6, 75, 93, 5, 170, 34, 76, 34, 127, 248, 196, 249, 43, 216, 56, 126, 81, 64, 195, 4, 157, 42, 11, 177 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "1C-48-FA-D3-70-27-81-32-62-DC-5D-5D-DB-43-EE-D9-A5-04-15-FA-1D-E9-6C-74-00-D9-8A-D7-17-7F-30-19", new byte[] { 254, 145, 23, 13, 145, 218, 49, 115, 163, 103, 252, 21, 6, 104, 105, 144, 23, 0, 5, 240, 81, 195, 233, 193, 111, 69, 112, 83, 213, 199, 49, 136, 75, 57, 252, 202, 242, 185, 132, 209, 117, 200, 48, 207, 73, 14, 86, 59, 77, 82, 171, 132, 251, 201, 67, 169, 229, 120, 189, 38, 165, 48, 125, 239 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "2A-48-3D-45-74-06-19-D7-DC-42-29-85-82-96-15-13-45-BF-4D-DE-33-60-34-E5-6E-91-B7-B4-8D-B3-61-42", new byte[] { 162, 20, 77, 206, 58, 73, 205, 182, 131, 213, 116, 162, 193, 10, 76, 241, 174, 146, 98, 162, 192, 234, 151, 210, 6, 97, 152, 159, 68, 254, 80, 71, 2, 191, 55, 127, 110, 142, 21, 237, 104, 218, 0, 35, 33, 92, 95, 226, 210, 229, 93, 128, 117, 249, 98, 232, 74, 190, 198, 6, 249, 201, 146, 224 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "F7-5F-92-DF-C4-E4-B3-17-37-4B-E9-98-51-83-CA-F7-FF-BC-69-5C-B0-C6-90-6A-56-07-4B-B3-E8-EF-3E-30", new byte[] { 122, 84, 98, 169, 218, 58, 127, 193, 40, 198, 17, 108, 86, 11, 30, 172, 101, 95, 3, 65, 199, 21, 92, 188, 10, 221, 128, 100, 26, 0, 172, 155, 227, 26, 136, 85, 194, 255, 159, 62, 135, 255, 170, 218, 148, 184, 89, 134, 119, 89, 199, 94, 251, 199, 14, 44, 203, 242, 156, 146, 187, 55, 232, 153 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "DF-A2-15-CA-2D-A3-4D-24-2E-85-2E-C8-40-4F-80-E4-B1-3F-5F-01-C8-65-35-A0-D8-C7-45-96-B3-2D-08-61", new byte[] { 6, 129, 163, 122, 27, 115, 8, 108, 43, 91, 129, 191, 201, 249, 80, 62, 19, 111, 243, 117, 38, 100, 105, 140, 20, 101, 128, 142, 17, 66, 110, 214, 239, 116, 150, 65, 249, 19, 109, 114, 193, 44, 12, 130, 178, 249, 49, 193, 148, 64, 77, 240, 233, 73, 177, 224, 49, 68, 117, 218, 92, 68, 4, 71 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "64-73-F5-99-E3-77-7A-73-2E-A6-E2-2D-83-F8-66-BE-6D-80-C0-77-B8-55-D6-07-E9-FC-A2-9A-56-DD-72-CE", new byte[] { 19, 240, 213, 119, 116, 9, 14, 48, 204, 60, 161, 48, 76, 108, 46, 220, 148, 92, 33, 203, 212, 190, 26, 169, 229, 48, 30, 19, 49, 125, 120, 216, 123, 124, 94, 10, 157, 69, 198, 253, 198, 4, 59, 78, 3, 93, 87, 32, 227, 192, 80, 139, 174, 9, 238, 131, 94, 211, 135, 124, 186, 101, 27, 88 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "04-C8-E9-47-60-39-FC-B7-2A-98-A9-61-7C-5D-95-2E-09-88-BA-79-E5-0E-F2-2D-77-8D-2C-D8-C5-35-42-A9", new byte[] { 171, 53, 25, 1, 14, 23, 142, 100, 173, 232, 240, 210, 68, 202, 156, 197, 197, 160, 233, 255, 241, 150, 65, 150, 102, 132, 32, 4, 108, 53, 206, 25, 79, 252, 162, 103, 234, 50, 159, 222, 19, 14, 199, 49, 143, 144, 231, 189, 154, 160, 181, 39, 60, 217, 129, 224, 239, 166, 252, 56, 68, 16, 47, 126 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "2A-34-7F-D9-83-6B-34-79-A5-9B-F2-9D-18-18-1C-31-EA-5A-9A-32-7B-36-44-BB-26-C7-DB-9F-C2-06-F4-85", new byte[] { 122, 77, 139, 194, 41, 151, 151, 9, 79, 1, 150, 7, 134, 72, 204, 189, 146, 42, 196, 90, 229, 174, 211, 247, 148, 84, 5, 102, 155, 237, 133, 151, 151, 76, 110, 17, 189, 20, 214, 31, 57, 175, 23, 97, 203, 83, 112, 254, 171, 85, 94, 121, 6, 133, 201, 102, 164, 217, 2, 42, 66, 90, 124, 18 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "4C-B4-AE-33-C6-53-B6-FA-A1-67-11-A5-18-23-3E-80-6C-0C-36-DF-6D-5B-87-B5-D9-5F-1E-26-C2-06-21-14", new byte[] { 206, 238, 150, 250, 89, 216, 242, 4, 196, 81, 252, 81, 190, 52, 163, 195, 56, 234, 109, 8, 192, 16, 15, 122, 169, 87, 100, 162, 74, 20, 41, 73, 19, 75, 168, 130, 61, 107, 10, 11, 22, 11, 128, 237, 61, 151, 94, 196, 65, 208, 229, 235, 154, 27, 62, 253, 45, 120, 214, 212, 181, 156, 241, 171 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100004,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "2D-49-AD-E8-C8-A3-20-15-E9-55-77-27-25-EC-AE-98-80-5D-77-99-18-EC-C7-17-67-DF-C2-92-13-BB-F1-C7", new byte[] { 212, 139, 22, 167, 56, 85, 249, 189, 251, 111, 234, 30, 17, 8, 137, 173, 233, 197, 97, 94, 101, 118, 213, 24, 149, 145, 134, 96, 132, 96, 106, 142, 181, 193, 22, 115, 87, 149, 45, 44, 92, 142, 12, 36, 101, 25, 69, 175, 210, 241, 75, 45, 103, 107, 163, 39, 87, 139, 94, 36, 81, 111, 100, 253 } });

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0a9c8263-7f5e-4e25-bb85-7a4c0a1e3a5c"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 7, 25, 835, DateTimeKind.Utc).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0bb3c011-9ba9-47e7-9ce0-3268f85e1ffc"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 7, 25, 835, DateTimeKind.Utc).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("18a64e64-3707-451c-b54d-51dbb9933aa0"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 7, 25, 835, DateTimeKind.Utc).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("1b234567-89ab-cdef-0123-456789abcdef"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 7, 25, 835, DateTimeKind.Utc).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("2b7c5a63-8e93-4d88-bc90-85c42d1574ae"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 7, 25, 835, DateTimeKind.Utc).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("34f2c84e-6c77-4c4a-b5f3-eef62d87b4be"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 7, 25, 835, DateTimeKind.Utc).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("3d8f49b2-ef8b-4b3e-8f5d-1f68d8f4f4b1"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 7, 25, 835, DateTimeKind.Utc).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("4d8d76aa-48e5-4c2b-95f1-5a77c73c0f11"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 7, 25, 835, DateTimeKind.Utc).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("59259348-41da-4bbc-b85c-48ee82f474ce"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 7, 25, 835, DateTimeKind.Utc).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5a6e8d59-0c3d-4e54-a105-50f44dcb9e4b"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 7, 25, 835, DateTimeKind.Utc).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5e4f2822-bb47-45b4-83c0-6c1de2b5f900"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 7, 25, 835, DateTimeKind.Utc).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("72b24a8d-4e5b-43e5-aeae-ecf9dc1b52d9"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 7, 25, 835, DateTimeKind.Utc).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("7f1f7c59-f92e-4c3b-a3f4-9c2a4cd474cb"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 7, 25, 835, DateTimeKind.Utc).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8b5c0f77-e3f1-4972-9102-6c1dfbb5a601"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 7, 25, 835, DateTimeKind.Utc).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8d5c8e30-dede-4ef0-9158-f7692c41acb2"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 7, 25, 835, DateTimeKind.Utc).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9b7f3e43-50bc-41d5-8f43-b8e0e1f47732"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 7, 25, 835, DateTimeKind.Utc).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e7b22d3-c5a5-429e-82dc-e5c573745e1d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 7, 25, 835, DateTimeKind.Utc).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("c7f1f4f5-74e3-4b4f-9c5a-3e2059d8b72d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 7, 25, 835, DateTimeKind.Utc).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("e43ff624-3f3c-4e8e-b5eb-11c0c3a244fa"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 7, 25, 835, DateTimeKind.Utc).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("f3b00c12-3b5e-4c8e-9bb0-7a5c7408cd07"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 7, 25, 835, DateTimeKind.Utc).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23"),
                column: "GamePicturePath",
                value: "https://fusiontech-0dxp.onrender.com/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c4f5e3e1-2c4c-4f4e-a4d1-5e5e6139d703"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 17, 4, 36, 690, DateTimeKind.Utc).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c9ebf2c7-5a7f-4b5d-bb7f-2f2c4d8e4a88"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 17, 4, 36, 690, DateTimeKind.Utc).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("d3c4b5e8-1f3a-4c8c-897e-2d8cf3e7c4f6"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 17, 4, 36, 690, DateTimeKind.Utc).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 17, 4, 36, 690, DateTimeKind.Utc).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "12-68-80-B8-66-AC-A9-56-FB-5A-CB-6E-EA-97-59-01-3C-83-40-2F-FF-4F-A3-CE-68-E1-2D-FF-40-64-95-F0", new byte[] { 63, 28, 181, 154, 102, 139, 16, 82, 1, 176, 196, 130, 153, 63, 225, 54, 34, 14, 53, 59, 106, 46, 204, 208, 221, 37, 168, 48, 254, 37, 85, 130, 249, 42, 19, 150, 157, 82, 178, 100, 224, 175, 62, 61, 42, 7, 179, 97, 159, 181, 43, 51, 73, 48, 65, 95, 236, 165, 12, 117, 197, 187, 229, 104 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "D2-60-21-E5-7F-DA-AA-1C-B3-03-8E-7B-F9-8F-E7-8D-B4-33-DD-F5-0F-B9-15-93-10-26-97-4F-B7-96-3D-E4", new byte[] { 179, 248, 172, 21, 137, 214, 244, 109, 117, 255, 250, 108, 67, 98, 203, 171, 194, 110, 208, 149, 210, 64, 48, 221, 189, 30, 31, 77, 183, 78, 248, 84, 241, 87, 87, 231, 41, 213, 186, 247, 121, 93, 158, 172, 21, 25, 92, 59, 6, 155, 120, 56, 231, 202, 60, 162, 63, 255, 158, 88, 109, 163, 136, 24 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "25-E9-C6-76-F3-F2-B4-7D-1D-09-65-C2-EE-37-37-90-15-91-62-94-1F-68-88-65-56-D9-63-1D-D0-04-CB-65", new byte[] { 118, 134, 132, 82, 28, 138, 121, 151, 62, 143, 223, 54, 156, 188, 187, 24, 41, 83, 64, 185, 31, 109, 200, 1, 2, 156, 193, 17, 214, 199, 132, 132, 123, 109, 169, 59, 237, 173, 44, 88, 16, 178, 29, 241, 72, 110, 38, 95, 193, 82, 10, 237, 126, 228, 66, 205, 14, 248, 214, 67, 212, 202, 50, 35 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "BB-E0-B4-E1-64-47-45-66-7D-40-09-3E-6D-19-6B-EA-58-45-1D-6D-30-A5-A8-6A-86-00-DB-A8-D0-13-4B-5F", new byte[] { 99, 22, 197, 249, 131, 166, 169, 108, 66, 179, 214, 147, 132, 3, 67, 28, 100, 188, 53, 214, 126, 235, 191, 158, 110, 188, 214, 108, 34, 123, 59, 114, 119, 81, 21, 51, 35, 228, 243, 52, 203, 201, 115, 208, 154, 181, 148, 78, 32, 101, 226, 57, 143, 137, 140, 146, 136, 99, 102, 215, 146, 118, 56, 138 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "A9-77-BC-4D-84-33-88-19-69-06-9B-07-7B-DE-A7-0D-5C-56-46-D6-F0-4B-1E-01-4F-0B-F1-A0-A9-04-1B-17", new byte[] { 30, 193, 53, 90, 185, 97, 0, 15, 24, 255, 98, 104, 161, 160, 31, 133, 156, 48, 115, 243, 86, 145, 247, 221, 62, 158, 154, 155, 164, 133, 246, 164, 166, 109, 1, 168, 194, 147, 82, 255, 176, 5, 225, 29, 246, 241, 110, 93, 191, 10, 42, 220, 241, 86, 173, 124, 206, 8, 102, 87, 190, 64, 220, 9 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "71-55-F7-37-7A-F3-FB-B6-08-7B-EC-AC-08-45-FA-C1-7C-6F-73-1F-10-46-D5-AC-54-5D-2C-5D-37-64-23-90", new byte[] { 247, 66, 37, 44, 65, 202, 198, 213, 41, 175, 64, 149, 36, 56, 110, 90, 151, 38, 63, 100, 118, 131, 250, 102, 246, 56, 139, 61, 201, 66, 94, 110, 255, 211, 82, 98, 242, 6, 6, 156, 91, 89, 60, 99, 191, 98, 80, 28, 151, 234, 208, 59, 238, 20, 162, 243, 163, 114, 131, 124, 97, 75, 77, 139 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "A0-CB-FD-CE-BA-61-5A-D2-AF-E5-1F-49-D6-2A-25-2B-A7-E8-5D-DB-84-36-F4-98-85-2E-7D-B4-66-01-26-1D", new byte[] { 235, 36, 183, 131, 61, 189, 109, 244, 178, 136, 174, 141, 3, 43, 4, 170, 153, 99, 8, 185, 22, 110, 122, 193, 239, 209, 153, 100, 216, 193, 6, 121, 87, 114, 117, 223, 114, 136, 237, 172, 81, 63, 183, 233, 235, 24, 90, 109, 81, 200, 180, 164, 89, 124, 231, 39, 84, 125, 18, 180, 245, 178, 113, 122 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "93-26-BB-9F-E0-21-68-2A-C4-12-B3-BB-E8-E3-BD-00-EE-EF-28-BA-BB-FE-6E-52-60-72-6E-F0-90-5B-30-C5", new byte[] { 7, 68, 254, 202, 51, 60, 205, 196, 255, 192, 218, 48, 219, 68, 176, 63, 240, 86, 22, 29, 31, 3, 107, 29, 186, 37, 249, 218, 109, 118, 5, 226, 98, 233, 123, 237, 97, 84, 99, 163, 98, 203, 102, 35, 92, 25, 92, 109, 180, 179, 67, 214, 207, 96, 163, 166, 235, 114, 22, 8, 84, 122, 48, 242 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "D9-9B-70-DD-9E-23-72-65-69-E8-B7-05-42-CD-9B-C2-36-5D-F8-8B-58-63-BE-BF-48-AC-40-85-4A-A0-01-48", new byte[] { 161, 155, 39, 56, 98, 39, 130, 83, 53, 29, 21, 237, 147, 106, 237, 243, 134, 203, 130, 207, 216, 35, 208, 210, 235, 86, 145, 157, 59, 13, 190, 158, 232, 15, 96, 159, 170, 167, 103, 243, 212, 93, 167, 196, 109, 22, 57, 27, 113, 165, 160, 187, 8, 135, 231, 59, 147, 10, 247, 72, 172, 166, 251, 255 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100004,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "1F-14-4B-F7-BB-1E-B6-D9-C6-06-7B-49-5F-D7-68-74-90-EC-E8-B3-9B-DA-A7-67-6A-26-71-CF-6A-09-80-54", new byte[] { 199, 7, 78, 246, 43, 145, 161, 84, 91, 189, 251, 239, 18, 16, 64, 57, 48, 97, 109, 176, 169, 179, 97, 164, 115, 181, 226, 120, 106, 226, 99, 22, 102, 196, 218, 111, 155, 173, 16, 75, 124, 27, 6, 50, 24, 222, 50, 119, 64, 20, 152, 185, 101, 118, 120, 23, 176, 54, 70, 4, 78, 47, 96, 71 } });

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0a9c8263-7f5e-4e25-bb85-7a4c0a1e3a5c"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 4, 36, 690, DateTimeKind.Utc).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0bb3c011-9ba9-47e7-9ce0-3268f85e1ffc"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 4, 36, 690, DateTimeKind.Utc).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("18a64e64-3707-451c-b54d-51dbb9933aa0"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 4, 36, 690, DateTimeKind.Utc).AddTicks(5885));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("1b234567-89ab-cdef-0123-456789abcdef"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 4, 36, 690, DateTimeKind.Utc).AddTicks(5842));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("2b7c5a63-8e93-4d88-bc90-85c42d1574ae"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 4, 36, 690, DateTimeKind.Utc).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("34f2c84e-6c77-4c4a-b5f3-eef62d87b4be"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 4, 36, 690, DateTimeKind.Utc).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("3d8f49b2-ef8b-4b3e-8f5d-1f68d8f4f4b1"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 4, 36, 690, DateTimeKind.Utc).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("4d8d76aa-48e5-4c2b-95f1-5a77c73c0f11"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 4, 36, 690, DateTimeKind.Utc).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("59259348-41da-4bbc-b85c-48ee82f474ce"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 4, 36, 690, DateTimeKind.Utc).AddTicks(5853));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5a6e8d59-0c3d-4e54-a105-50f44dcb9e4b"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 4, 36, 690, DateTimeKind.Utc).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5e4f2822-bb47-45b4-83c0-6c1de2b5f900"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 4, 36, 690, DateTimeKind.Utc).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("72b24a8d-4e5b-43e5-aeae-ecf9dc1b52d9"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 4, 36, 690, DateTimeKind.Utc).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("7f1f7c59-f92e-4c3b-a3f4-9c2a4cd474cb"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 4, 36, 690, DateTimeKind.Utc).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8b5c0f77-e3f1-4972-9102-6c1dfbb5a601"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 4, 36, 690, DateTimeKind.Utc).AddTicks(5888));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8d5c8e30-dede-4ef0-9158-f7692c41acb2"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 4, 36, 690, DateTimeKind.Utc).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9b7f3e43-50bc-41d5-8f43-b8e0e1f47732"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 4, 36, 690, DateTimeKind.Utc).AddTicks(5862));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e7b22d3-c5a5-429e-82dc-e5c573745e1d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 4, 36, 690, DateTimeKind.Utc).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("c7f1f4f5-74e3-4b4f-9c5a-3e2059d8b72d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 4, 36, 690, DateTimeKind.Utc).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("e43ff624-3f3c-4e8e-b5eb-11c0c3a244fa"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 4, 36, 690, DateTimeKind.Utc).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("f3b00c12-3b5e-4c8e-9bb0-7a5c7408cd07"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 4, 36, 690, DateTimeKind.Utc).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23"),
                column: "GamePicturePath",
                value: "https://fusiontech-0dxp.onrender.com/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23.jpg");
        }
    }
}
