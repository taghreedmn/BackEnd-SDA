using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class Br : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
