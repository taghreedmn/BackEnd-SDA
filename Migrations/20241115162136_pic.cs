using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class pic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c4f5e3e1-2c4c-4f4e-a4d1-5e5e6139d703"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 16, 21, 36, 160, DateTimeKind.Utc).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c9ebf2c7-5a7f-4b5d-bb7f-2f2c4d8e4a88"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 16, 21, 36, 160, DateTimeKind.Utc).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("d3c4b5e8-1f3a-4c8c-897e-2d8cf3e7c4f6"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 16, 21, 36, 160, DateTimeKind.Utc).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 16, 21, 36, 160, DateTimeKind.Utc).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "4F-E8-12-A0-5E-A2-9E-01-33-17-B2-05-A3-74-72-43-79-A7-19-AF-99-4D-07-72-89-A7-0C-8A-8D-6B-85-87", new byte[] { 50, 103, 49, 190, 225, 235, 100, 233, 54, 123, 193, 228, 97, 62, 99, 102, 170, 215, 252, 131, 183, 30, 48, 195, 88, 230, 46, 234, 95, 44, 45, 10, 73, 103, 186, 42, 175, 190, 220, 159, 94, 14, 197, 40, 173, 201, 200, 14, 120, 58, 63, 68, 155, 29, 139, 146, 248, 179, 239, 161, 134, 93, 233, 240 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "92-AC-8A-F4-46-55-CD-B5-92-87-06-7F-8F-AF-EB-4C-6E-FC-87-4B-2C-66-12-9B-69-73-FB-AC-C9-31-12-EC", new byte[] { 45, 51, 124, 140, 9, 16, 200, 31, 218, 176, 124, 172, 61, 60, 227, 255, 197, 236, 61, 16, 208, 255, 36, 114, 44, 217, 136, 212, 128, 237, 116, 107, 235, 116, 113, 250, 194, 28, 232, 64, 202, 240, 196, 4, 0, 202, 81, 7, 131, 153, 210, 68, 117, 103, 224, 68, 129, 175, 157, 87, 149, 237, 109, 3 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "A1-31-DD-7B-8A-4D-47-35-20-74-11-EC-5F-D6-D7-51-3A-71-2E-EC-FA-62-2F-1E-17-DC-76-D9-1D-54-65-15", new byte[] { 201, 101, 125, 17, 17, 140, 175, 102, 37, 59, 121, 231, 176, 28, 75, 1, 12, 198, 7, 245, 8, 52, 210, 99, 194, 215, 80, 206, 236, 181, 201, 80, 96, 24, 142, 99, 250, 40, 105, 31, 134, 227, 166, 208, 54, 133, 249, 196, 173, 136, 116, 96, 183, 159, 41, 131, 156, 86, 10, 61, 155, 59, 22, 15 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "BF-83-0F-19-45-D8-F9-90-F4-7C-BD-4D-CB-88-8F-B2-42-02-7A-9F-BF-1D-0A-29-43-10-8C-94-53-23-76-A4", new byte[] { 139, 211, 221, 249, 83, 125, 248, 75, 147, 34, 14, 236, 203, 162, 79, 169, 163, 46, 47, 200, 38, 202, 124, 123, 188, 210, 170, 133, 193, 59, 92, 50, 96, 47, 36, 92, 187, 57, 58, 112, 1, 62, 72, 130, 22, 175, 138, 196, 3, 113, 17, 201, 181, 212, 237, 105, 251, 130, 198, 50, 131, 181, 38, 32 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "1E-70-C9-C7-F0-AD-66-BB-4F-93-4F-2E-ED-32-65-41-D1-6D-EE-15-25-84-DE-F7-86-C8-83-05-75-85-67-B8", new byte[] { 53, 46, 5, 34, 33, 212, 53, 207, 191, 87, 66, 31, 225, 4, 174, 252, 81, 101, 139, 212, 236, 246, 59, 85, 214, 197, 23, 213, 68, 148, 86, 39, 158, 150, 35, 204, 173, 183, 86, 152, 52, 140, 167, 244, 152, 45, 124, 201, 224, 94, 220, 157, 89, 82, 186, 248, 108, 113, 45, 170, 168, 47, 202, 197 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "27-7C-E2-DC-35-10-2E-E2-69-B9-69-8A-C3-69-5C-8B-25-6A-1A-CD-57-BC-E4-9A-30-32-81-25-67-1A-E6-CE", new byte[] { 209, 31, 231, 176, 6, 199, 61, 52, 242, 23, 199, 162, 241, 251, 253, 85, 177, 38, 12, 161, 188, 216, 23, 133, 104, 41, 206, 137, 179, 124, 10, 121, 80, 8, 59, 29, 79, 62, 130, 90, 179, 32, 41, 50, 63, 48, 160, 216, 59, 233, 219, 24, 174, 99, 18, 170, 235, 228, 4, 150, 187, 158, 241, 5 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "BD-81-3C-D3-3D-32-22-57-5B-72-16-21-32-27-06-71-87-60-4E-21-9A-2F-5E-0F-1D-DD-75-D4-30-38-B7-4C", new byte[] { 234, 205, 71, 55, 177, 21, 215, 211, 57, 12, 1, 19, 190, 103, 98, 196, 53, 180, 99, 54, 155, 242, 232, 177, 60, 139, 109, 169, 145, 182, 166, 149, 234, 118, 69, 206, 183, 228, 74, 92, 242, 81, 163, 173, 171, 45, 146, 73, 135, 234, 204, 54, 34, 142, 12, 245, 59, 139, 205, 242, 140, 91, 55, 73 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "C7-5C-7F-4C-18-3D-73-3D-7E-3E-8A-C3-E2-57-9A-5E-E3-F0-D9-44-A5-23-5B-96-F3-A5-F9-43-44-C3-56-B1", new byte[] { 171, 41, 238, 10, 245, 213, 211, 151, 206, 199, 173, 8, 177, 126, 91, 160, 140, 163, 174, 77, 195, 16, 164, 72, 140, 206, 28, 31, 213, 70, 170, 44, 243, 52, 221, 51, 238, 10, 56, 129, 177, 10, 247, 246, 126, 42, 10, 226, 108, 171, 195, 171, 188, 169, 58, 105, 194, 122, 33, 84, 214, 156, 60, 174 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "94-3A-26-B9-D2-78-98-8E-A1-4A-E0-54-7A-3C-C8-70-2B-0D-9A-65-48-69-47-01-C4-D8-29-4E-14-1E-89-6F", new byte[] { 64, 64, 113, 49, 26, 81, 162, 246, 143, 193, 224, 224, 3, 249, 26, 162, 195, 209, 134, 177, 210, 239, 89, 20, 42, 102, 230, 93, 14, 120, 179, 76, 46, 58, 30, 207, 58, 35, 14, 128, 90, 24, 130, 144, 187, 99, 86, 211, 209, 25, 137, 68, 113, 26, 63, 129, 251, 190, 210, 126, 161, 69, 252, 120 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100004,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "C7-DF-C2-A0-D4-D4-F3-B5-33-B5-07-A7-26-FA-EF-7D-6A-79-2A-E2-F8-41-7E-80-67-91-97-A8-7C-C7-A5-AA", new byte[] { 61, 126, 46, 173, 139, 229, 96, 166, 188, 156, 14, 167, 188, 129, 84, 254, 129, 250, 228, 243, 231, 140, 149, 208, 92, 169, 193, 172, 129, 220, 230, 195, 69, 143, 159, 64, 161, 114, 90, 194, 115, 81, 134, 133, 24, 62, 115, 182, 176, 1, 33, 179, 75, 7, 190, 120, 52, 117, 7, 169, 156, 215, 135, 70 } });

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0a9c8263-7f5e-4e25-bb85-7a4c0a1e3a5c"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 21, 36, 160, DateTimeKind.Utc).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0bb3c011-9ba9-47e7-9ce0-3268f85e1ffc"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 21, 36, 160, DateTimeKind.Utc).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("18a64e64-3707-451c-b54d-51dbb9933aa0"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 21, 36, 160, DateTimeKind.Utc).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("1b234567-89ab-cdef-0123-456789abcdef"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 21, 36, 160, DateTimeKind.Utc).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("2b7c5a63-8e93-4d88-bc90-85c42d1574ae"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 21, 36, 160, DateTimeKind.Utc).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("34f2c84e-6c77-4c4a-b5f3-eef62d87b4be"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 21, 36, 160, DateTimeKind.Utc).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("3d8f49b2-ef8b-4b3e-8f5d-1f68d8f4f4b1"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 21, 36, 160, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("4d8d76aa-48e5-4c2b-95f1-5a77c73c0f11"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 21, 36, 160, DateTimeKind.Utc).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("59259348-41da-4bbc-b85c-48ee82f474ce"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 21, 36, 160, DateTimeKind.Utc).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5a6e8d59-0c3d-4e54-a105-50f44dcb9e4b"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 21, 36, 160, DateTimeKind.Utc).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5e4f2822-bb47-45b4-83c0-6c1de2b5f900"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 21, 36, 160, DateTimeKind.Utc).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("72b24a8d-4e5b-43e5-aeae-ecf9dc1b52d9"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 21, 36, 160, DateTimeKind.Utc).AddTicks(753));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("7f1f7c59-f92e-4c3b-a3f4-9c2a4cd474cb"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 21, 36, 160, DateTimeKind.Utc).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8b5c0f77-e3f1-4972-9102-6c1dfbb5a601"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 21, 36, 160, DateTimeKind.Utc).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8d5c8e30-dede-4ef0-9158-f7692c41acb2"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 21, 36, 160, DateTimeKind.Utc).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9b7f3e43-50bc-41d5-8f43-b8e0e1f47732"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 21, 36, 160, DateTimeKind.Utc).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e7b22d3-c5a5-429e-82dc-e5c573745e1d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 21, 36, 160, DateTimeKind.Utc).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("c7f1f4f5-74e3-4b4f-9c5a-3e2059d8b72d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 21, 36, 160, DateTimeKind.Utc).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("e43ff624-3f3c-4e8e-b5eb-11c0c3a244fa"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 21, 36, 160, DateTimeKind.Utc).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("f3b00c12-3b5e-4c8e-9bb0-7a5c7408cd07"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 21, 36, 160, DateTimeKind.Utc).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23"),
                column: "GamePicturePath",
                value: "../wwwroot/images/Games/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c4f5e3e1-2c4c-4f4e-a4d1-5e5e6139d703"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c9ebf2c7-5a7f-4b5d-bb7f-2f2c4d8e4a88"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(169));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("d3c4b5e8-1f3a-4c8c-897e-2d8cf3e7c4f6"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "FB-7F-26-46-89-84-34-3D-D0-39-E1-96-1B-1C-C8-AC-9C-08-AD-63-5C-16-CF-73-AC-65-3A-75-00-57-38-29", new byte[] { 150, 217, 146, 12, 119, 18, 224, 149, 14, 84, 219, 128, 65, 101, 49, 114, 29, 17, 94, 222, 48, 151, 211, 68, 45, 222, 99, 109, 57, 189, 36, 111, 123, 50, 120, 206, 39, 2, 195, 226, 188, 146, 40, 81, 209, 126, 227, 69, 105, 203, 42, 2, 28, 173, 103, 188, 143, 101, 40, 188, 212, 169, 195, 141 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "6D-ED-03-E6-72-F7-7D-19-16-9D-E3-97-35-68-4E-19-72-1A-2E-3F-BB-53-9E-53-6C-86-A8-D3-11-12-0C-4E", new byte[] { 244, 233, 127, 121, 235, 155, 200, 117, 167, 225, 231, 42, 114, 202, 219, 101, 180, 143, 91, 95, 160, 191, 77, 18, 25, 177, 47, 156, 238, 56, 162, 167, 201, 17, 80, 11, 113, 242, 140, 117, 23, 89, 94, 84, 130, 172, 216, 74, 31, 23, 115, 200, 162, 57, 73, 187, 71, 111, 26, 110, 177, 200, 238, 47 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "74-5A-BA-0D-C7-EB-C2-4F-62-1E-65-45-79-A7-F1-7D-30-73-DE-03-58-9A-19-8A-21-CA-08-EE-25-12-EB-16", new byte[] { 50, 77, 122, 158, 213, 177, 139, 52, 199, 32, 142, 89, 37, 55, 207, 244, 239, 32, 107, 15, 135, 127, 46, 185, 128, 164, 167, 76, 103, 164, 82, 170, 103, 26, 170, 218, 151, 240, 163, 112, 12, 2, 75, 215, 56, 238, 198, 119, 252, 2, 61, 159, 81, 151, 253, 125, 132, 176, 204, 213, 157, 237, 102, 187 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "DB-9B-67-92-A5-F2-46-E9-8C-18-9C-A5-EF-8C-56-0B-77-A3-C0-67-B3-E4-B9-3B-A9-53-E0-15-CB-B2-5D-4B", new byte[] { 99, 0, 72, 63, 121, 207, 25, 9, 224, 22, 32, 63, 72, 13, 114, 120, 43, 77, 187, 54, 115, 76, 93, 56, 3, 46, 158, 75, 175, 6, 27, 119, 76, 200, 131, 235, 245, 61, 186, 231, 95, 7, 86, 34, 102, 184, 71, 24, 74, 2, 36, 196, 40, 34, 27, 234, 206, 65, 154, 223, 72, 184, 40, 160 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "A9-8A-49-07-0C-74-AD-20-DE-CC-10-77-57-0F-24-E1-95-CC-EC-88-28-6A-D1-AE-55-8B-F2-3D-A6-74-16-A1", new byte[] { 136, 28, 96, 58, 248, 167, 130, 143, 14, 28, 161, 18, 203, 58, 43, 21, 15, 160, 154, 236, 213, 44, 140, 135, 166, 81, 131, 127, 203, 116, 11, 83, 208, 71, 63, 227, 129, 143, 122, 49, 27, 26, 141, 131, 65, 111, 228, 219, 56, 211, 198, 127, 117, 216, 54, 253, 53, 231, 182, 4, 224, 149, 99, 242 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "47-49-46-7C-EE-A9-2B-27-73-3F-20-CA-37-51-AF-54-71-F8-98-A2-F5-07-C6-47-4E-A6-D3-0A-58-6E-E8-2D", new byte[] { 137, 224, 199, 248, 159, 43, 233, 101, 147, 12, 156, 71, 113, 197, 88, 66, 69, 217, 15, 190, 100, 3, 135, 62, 41, 249, 198, 168, 123, 230, 213, 234, 96, 123, 8, 234, 174, 23, 190, 5, 49, 27, 8, 45, 249, 120, 115, 200, 219, 144, 238, 21, 102, 195, 143, 231, 198, 122, 4, 73, 219, 172, 145, 197 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "40-79-DF-F3-C2-69-B5-00-AE-9E-98-14-1B-79-59-DB-47-CE-9E-1D-41-1E-2E-71-2A-2E-A0-A0-9F-A8-FD-44", new byte[] { 17, 65, 51, 32, 167, 83, 115, 151, 193, 170, 10, 47, 91, 114, 152, 148, 190, 226, 153, 180, 76, 81, 231, 71, 116, 76, 30, 24, 37, 62, 165, 239, 25, 240, 176, 229, 156, 159, 228, 122, 11, 235, 6, 127, 42, 159, 11, 9, 237, 86, 134, 105, 218, 141, 216, 4, 35, 139, 19, 34, 230, 143, 199, 82 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "3D-79-38-E3-1A-41-28-46-3D-D3-0F-5B-A6-F8-A3-BF-3B-4E-7E-0B-CA-FA-8E-A0-D2-D6-9D-0E-37-19-93-93", new byte[] { 216, 105, 191, 95, 253, 131, 251, 123, 236, 84, 16, 75, 38, 220, 120, 25, 169, 161, 41, 27, 168, 252, 211, 220, 141, 204, 171, 215, 114, 126, 29, 71, 48, 251, 199, 250, 108, 104, 107, 191, 210, 133, 133, 168, 124, 188, 170, 72, 217, 141, 97, 161, 101, 254, 142, 55, 161, 241, 101, 204, 115, 92, 206, 216 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "DD-82-E3-C8-38-35-B8-51-72-E3-EE-89-E2-24-C1-F3-DA-6D-6F-5E-DD-A4-14-75-90-13-60-09-25-E9-BD-31", new byte[] { 95, 130, 255, 105, 20, 46, 118, 53, 168, 99, 63, 87, 115, 120, 189, 195, 146, 192, 32, 94, 6, 207, 134, 20, 232, 142, 248, 194, 0, 144, 87, 206, 97, 160, 202, 41, 91, 194, 155, 124, 119, 95, 41, 121, 73, 61, 95, 86, 133, 25, 171, 110, 179, 62, 156, 123, 43, 76, 8, 242, 33, 224, 94, 217 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100004,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "76-08-F7-C8-68-BA-85-E9-FF-CE-F7-B3-40-7B-B1-B2-07-44-8E-8F-A9-3B-DB-98-F5-E6-79-F8-E6-E4-39-5B", new byte[] { 220, 220, 218, 172, 165, 135, 66, 106, 7, 186, 127, 170, 50, 163, 0, 31, 71, 121, 178, 237, 56, 129, 175, 195, 183, 125, 88, 16, 245, 181, 93, 156, 138, 61, 73, 0, 220, 148, 22, 204, 84, 1, 13, 98, 24, 63, 180, 206, 143, 191, 134, 127, 14, 125, 216, 249, 49, 199, 185, 71, 59, 63, 215, 200 } });

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0a9c8263-7f5e-4e25-bb85-7a4c0a1e3a5c"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0bb3c011-9ba9-47e7-9ce0-3268f85e1ffc"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 19, 57, 220, DateTimeKind.Utc).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("18a64e64-3707-451c-b54d-51dbb9933aa0"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("1b234567-89ab-cdef-0123-456789abcdef"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("2b7c5a63-8e93-4d88-bc90-85c42d1574ae"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("34f2c84e-6c77-4c4a-b5f3-eef62d87b4be"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("3d8f49b2-ef8b-4b3e-8f5d-1f68d8f4f4b1"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("4d8d76aa-48e5-4c2b-95f1-5a77c73c0f11"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("59259348-41da-4bbc-b85c-48ee82f474ce"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5a6e8d59-0c3d-4e54-a105-50f44dcb9e4b"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(12));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5e4f2822-bb47-45b4-83c0-6c1de2b5f900"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("72b24a8d-4e5b-43e5-aeae-ecf9dc1b52d9"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("7f1f7c59-f92e-4c3b-a3f4-9c2a4cd474cb"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8b5c0f77-e3f1-4972-9102-6c1dfbb5a601"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8d5c8e30-dede-4ef0-9158-f7692c41acb2"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9b7f3e43-50bc-41d5-8f43-b8e0e1f47732"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e7b22d3-c5a5-429e-82dc-e5c573745e1d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(15));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("c7f1f4f5-74e3-4b4f-9c5a-3e2059d8b72d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(27));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("e43ff624-3f3c-4e8e-b5eb-11c0c3a244fa"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("f3b00c12-3b5e-4c8e-9bb0-7a5c7408cd07"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 19, 57, 221, DateTimeKind.Utc).AddTicks(31));

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23"),
                column: "GamePicturePath",
                value: "./wwwroot/images/Games/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23.jpg");
        }
    }
}
