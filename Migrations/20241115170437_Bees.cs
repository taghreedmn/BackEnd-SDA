using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class Bees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c4f5e3e1-2c4c-4f4e-a4d1-5e5e6139d703"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 17, 3, 20, 519, DateTimeKind.Utc).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c9ebf2c7-5a7f-4b5d-bb7f-2f2c4d8e4a88"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 17, 3, 20, 519, DateTimeKind.Utc).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("d3c4b5e8-1f3a-4c8c-897e-2d8cf3e7c4f6"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 17, 3, 20, 519, DateTimeKind.Utc).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 17, 3, 20, 519, DateTimeKind.Utc).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "27-F7-C6-51-E1-FA-5A-53-C1-E5-2D-98-E5-B1-B4-7F-BC-61-D5-49-A2-A2-78-B4-C2-42-DE-1D-5A-69-7B-3A", new byte[] { 137, 179, 95, 253, 119, 195, 131, 253, 63, 121, 6, 95, 121, 253, 145, 204, 182, 22, 156, 115, 227, 114, 119, 7, 188, 166, 80, 103, 43, 33, 21, 148, 213, 23, 127, 228, 157, 160, 68, 71, 57, 153, 236, 208, 111, 95, 125, 138, 234, 192, 166, 194, 179, 116, 237, 120, 93, 34, 158, 104, 108, 245, 45, 36 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "73-F7-B5-B0-75-55-AD-EE-D4-34-BC-52-A1-A6-C3-D6-5A-85-CD-6C-4E-1A-61-3B-87-35-42-EE-C6-5A-B7-F7", new byte[] { 107, 95, 41, 106, 195, 111, 182, 148, 164, 181, 87, 53, 146, 175, 19, 176, 238, 80, 183, 214, 51, 122, 173, 14, 227, 89, 111, 117, 138, 204, 108, 241, 158, 86, 30, 174, 85, 217, 245, 200, 49, 243, 80, 238, 222, 110, 70, 103, 142, 244, 175, 17, 115, 147, 86, 175, 202, 81, 29, 88, 110, 121, 247, 168 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "97-2F-B4-AB-A0-6E-9C-B7-49-8F-73-63-5F-51-A3-F0-B5-4F-52-A1-48-AE-DE-69-7B-14-86-D1-11-A9-1A-09", new byte[] { 136, 220, 238, 41, 119, 87, 79, 64, 197, 53, 196, 106, 91, 225, 200, 193, 56, 119, 187, 186, 185, 191, 93, 158, 125, 189, 244, 246, 42, 110, 152, 152, 235, 23, 127, 96, 12, 37, 123, 148, 180, 83, 246, 74, 115, 78, 103, 4, 88, 102, 217, 100, 124, 80, 169, 105, 198, 9, 192, 109, 111, 199, 127, 26 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "C9-4D-A8-B5-4A-BD-41-59-19-EE-18-A1-FC-9D-73-2B-74-4E-B0-33-91-62-E5-4F-FB-4D-44-73-C5-9D-30-84", new byte[] { 232, 168, 206, 211, 28, 13, 220, 55, 51, 43, 43, 49, 46, 120, 217, 21, 199, 204, 37, 23, 10, 154, 101, 44, 75, 10, 167, 149, 35, 54, 227, 123, 249, 64, 151, 50, 253, 200, 37, 82, 91, 157, 73, 26, 198, 173, 102, 209, 174, 188, 208, 165, 234, 79, 170, 48, 131, 55, 177, 205, 51, 239, 49, 210 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "75-A9-A0-4B-BE-49-5E-64-18-EC-43-27-00-3A-12-20-2D-5C-16-3F-EC-87-88-15-7D-E4-BC-6C-3D-DE-F0-CD", new byte[] { 224, 102, 44, 141, 208, 128, 152, 145, 125, 12, 248, 167, 60, 80, 176, 16, 71, 207, 82, 59, 205, 188, 248, 145, 40, 99, 120, 81, 87, 33, 94, 37, 115, 81, 197, 189, 234, 50, 66, 34, 174, 68, 135, 169, 255, 67, 194, 14, 248, 38, 206, 48, 139, 97, 170, 129, 121, 176, 163, 204, 8, 93, 179, 216 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "61-81-EA-0F-32-68-5F-D5-83-69-D7-3C-ED-CF-22-87-3C-7A-3C-D0-F7-C0-73-90-E8-8C-A2-3D-BC-FC-93-21", new byte[] { 125, 203, 66, 142, 208, 61, 173, 100, 35, 128, 113, 205, 190, 63, 204, 94, 172, 86, 250, 164, 10, 88, 191, 227, 242, 175, 210, 85, 38, 149, 210, 178, 158, 108, 34, 32, 50, 62, 78, 21, 179, 245, 20, 230, 24, 185, 55, 50, 243, 133, 81, 202, 216, 112, 50, 149, 136, 125, 205, 27, 19, 197, 62, 140 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "2C-51-94-8A-4F-CD-95-24-6A-90-47-57-02-58-D9-C7-FE-85-28-FB-AA-5E-81-40-4F-4D-ED-60-DD-75-19-4B", new byte[] { 70, 210, 18, 113, 134, 163, 57, 225, 235, 149, 252, 198, 113, 255, 17, 240, 3, 188, 36, 101, 250, 147, 171, 65, 105, 150, 183, 49, 81, 233, 129, 0, 61, 77, 150, 188, 25, 174, 106, 187, 57, 99, 79, 133, 69, 78, 77, 16, 54, 124, 184, 178, 142, 149, 96, 3, 48, 96, 44, 139, 235, 9, 157, 36 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "19-1D-BA-5B-E7-77-D4-EA-1A-B8-62-A0-85-81-1B-BB-2E-F9-48-96-5D-A8-B7-47-7B-29-B9-60-4F-E0-DA-DC", new byte[] { 217, 96, 137, 96, 116, 73, 29, 220, 100, 31, 94, 121, 101, 65, 208, 230, 130, 201, 49, 223, 132, 196, 87, 42, 54, 46, 195, 83, 172, 53, 148, 90, 127, 140, 166, 116, 228, 17, 152, 167, 222, 180, 6, 108, 114, 220, 160, 244, 186, 11, 244, 230, 228, 142, 25, 192, 207, 48, 130, 52, 58, 7, 128, 224 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "EE-4F-BE-2B-51-92-AB-81-C1-3C-DE-99-85-23-F8-88-81-09-CF-18-5E-10-2C-A2-A1-69-1F-30-36-C8-B9-BE", new byte[] { 234, 44, 245, 44, 144, 78, 56, 208, 38, 125, 43, 205, 237, 217, 165, 109, 18, 48, 254, 12, 218, 136, 214, 38, 82, 81, 105, 201, 217, 32, 184, 70, 172, 192, 249, 100, 84, 208, 64, 29, 186, 176, 197, 174, 104, 12, 50, 85, 144, 92, 159, 253, 238, 153, 144, 137, 101, 105, 181, 224, 253, 226, 53, 211 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100004,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "8E-0B-AE-DC-D8-8A-D3-3F-3C-B9-84-BF-8F-56-C8-A3-87-F6-A4-92-D9-32-1F-DE-E9-2B-C8-53-E4-CD-77-EA", new byte[] { 27, 155, 89, 107, 185, 93, 239, 35, 97, 211, 62, 107, 102, 207, 101, 137, 224, 6, 157, 32, 71, 28, 197, 93, 51, 137, 65, 159, 232, 16, 173, 133, 63, 68, 56, 156, 35, 250, 59, 234, 191, 162, 128, 228, 66, 211, 60, 149, 137, 114, 64, 144, 67, 228, 89, 36, 157, 80, 82, 186, 244, 210, 146, 153 } });

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0a9c8263-7f5e-4e25-bb85-7a4c0a1e3a5c"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 3, 20, 519, DateTimeKind.Utc).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0bb3c011-9ba9-47e7-9ce0-3268f85e1ffc"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 3, 20, 519, DateTimeKind.Utc).AddTicks(3474));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("18a64e64-3707-451c-b54d-51dbb9933aa0"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 3, 20, 519, DateTimeKind.Utc).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("1b234567-89ab-cdef-0123-456789abcdef"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 3, 20, 519, DateTimeKind.Utc).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("2b7c5a63-8e93-4d88-bc90-85c42d1574ae"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 3, 20, 519, DateTimeKind.Utc).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("34f2c84e-6c77-4c4a-b5f3-eef62d87b4be"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 3, 20, 519, DateTimeKind.Utc).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("3d8f49b2-ef8b-4b3e-8f5d-1f68d8f4f4b1"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 3, 20, 519, DateTimeKind.Utc).AddTicks(3479));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("4d8d76aa-48e5-4c2b-95f1-5a77c73c0f11"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 3, 20, 519, DateTimeKind.Utc).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("59259348-41da-4bbc-b85c-48ee82f474ce"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 3, 20, 519, DateTimeKind.Utc).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5a6e8d59-0c3d-4e54-a105-50f44dcb9e4b"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 3, 20, 519, DateTimeKind.Utc).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5e4f2822-bb47-45b4-83c0-6c1de2b5f900"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 3, 20, 519, DateTimeKind.Utc).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("72b24a8d-4e5b-43e5-aeae-ecf9dc1b52d9"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 3, 20, 519, DateTimeKind.Utc).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("7f1f7c59-f92e-4c3b-a3f4-9c2a4cd474cb"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 3, 20, 519, DateTimeKind.Utc).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8b5c0f77-e3f1-4972-9102-6c1dfbb5a601"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 3, 20, 519, DateTimeKind.Utc).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8d5c8e30-dede-4ef0-9158-f7692c41acb2"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 3, 20, 519, DateTimeKind.Utc).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9b7f3e43-50bc-41d5-8f43-b8e0e1f47732"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 3, 20, 519, DateTimeKind.Utc).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e7b22d3-c5a5-429e-82dc-e5c573745e1d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 3, 20, 519, DateTimeKind.Utc).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("c7f1f4f5-74e3-4b4f-9c5a-3e2059d8b72d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 3, 20, 519, DateTimeKind.Utc).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("e43ff624-3f3c-4e8e-b5eb-11c0c3a244fa"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 17, 3, 20, 519, DateTimeKind.Utc).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("f3b00c12-3b5e-4c8e-9bb0-7a5c7408cd07"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 17, 3, 20, 519, DateTimeKind.Utc).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23"),
                column: "GamePicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Games/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23.jpg");
        }
    }
}
