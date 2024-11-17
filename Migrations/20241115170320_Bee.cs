using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class Bee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
