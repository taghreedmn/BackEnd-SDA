using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c4f5e3e1-2c4c-4f4e-a4d1-5e5e6139d703"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 19, 9, 24, 129, DateTimeKind.Utc).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c9ebf2c7-5a7f-4b5d-bb7f-2f2c4d8e4a88"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 19, 9, 24, 129, DateTimeKind.Utc).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("d3c4b5e8-1f3a-4c8c-897e-2d8cf3e7c4f6"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 19, 9, 24, 129, DateTimeKind.Utc).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 19, 9, 24, 129, DateTimeKind.Utc).AddTicks(5776));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "E7-A2-A6-C7-AE-01-B1-C8-5E-A5-7C-0F-63-46-74-1D-83-C7-C5-98-1C-F9-1E-72-8F-6C-6B-A2-63-AD-73-17", new byte[] { 228, 231, 70, 85, 186, 170, 183, 228, 191, 109, 63, 171, 254, 73, 171, 195, 90, 220, 83, 132, 193, 71, 216, 122, 24, 12, 91, 120, 34, 97, 111, 78, 92, 0, 5, 104, 74, 158, 232, 30, 216, 197, 36, 226, 42, 146, 34, 240, 151, 132, 39, 211, 139, 139, 13, 204, 164, 105, 198, 244, 161, 196, 147, 119 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "59-89-D0-22-39-E5-4E-20-FB-91-0E-B5-7E-35-D1-6F-97-EE-DC-40-37-1B-9F-28-98-FC-00-ED-9B-75-28-78", new byte[] { 247, 33, 60, 115, 58, 26, 179, 252, 86, 18, 192, 123, 132, 129, 4, 94, 161, 112, 184, 41, 173, 192, 214, 151, 157, 229, 29, 153, 237, 62, 232, 71, 75, 153, 254, 202, 109, 152, 178, 40, 30, 136, 16, 248, 149, 252, 84, 136, 6, 110, 118, 20, 102, 101, 71, 128, 231, 123, 195, 215, 109, 233, 144, 14 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "60-00-73-1D-01-8B-0A-94-13-69-A9-FB-31-71-B7-BC-8C-33-A6-D2-79-E8-1F-A3-DD-3B-85-E2-DC-43-ED-49", new byte[] { 80, 29, 194, 48, 140, 24, 107, 192, 136, 243, 95, 143, 44, 9, 158, 219, 40, 147, 73, 197, 243, 108, 57, 255, 152, 141, 196, 5, 181, 158, 18, 72, 142, 144, 195, 132, 184, 84, 140, 202, 42, 239, 112, 67, 50, 72, 245, 128, 54, 134, 49, 4, 117, 95, 21, 167, 85, 194, 102, 99, 252, 115, 227, 55 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "82-32-CE-6B-4B-E9-AF-51-C7-30-61-96-F9-47-7F-23-63-47-E7-0D-65-12-BE-39-46-93-EA-5A-D4-FD-90-00", new byte[] { 200, 251, 35, 175, 184, 70, 143, 90, 11, 110, 0, 147, 152, 138, 252, 94, 139, 2, 136, 196, 107, 134, 184, 183, 45, 179, 102, 205, 115, 249, 85, 159, 173, 190, 199, 151, 219, 96, 141, 232, 178, 82, 156, 90, 164, 25, 42, 107, 58, 51, 125, 219, 106, 228, 160, 55, 213, 196, 216, 186, 197, 92, 140, 246 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "E7-3A-73-5C-F6-D2-41-C0-9F-5D-C3-3B-B6-3E-F1-AB-FD-80-D1-49-1C-E9-99-94-D9-48-3E-4C-66-69-50-2A", new byte[] { 125, 189, 179, 187, 40, 181, 171, 232, 89, 133, 75, 179, 126, 223, 67, 68, 200, 102, 8, 252, 221, 112, 188, 85, 80, 173, 197, 66, 77, 74, 228, 53, 213, 77, 151, 102, 160, 183, 57, 122, 131, 51, 237, 11, 134, 169, 59, 209, 35, 120, 200, 248, 137, 119, 54, 220, 235, 144, 46, 146, 127, 127, 233, 219 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "79-52-98-F8-DF-FE-BE-BA-57-4A-84-95-AB-2E-8F-D2-F6-38-96-D1-2A-A3-AC-AA-61-46-DE-DF-51-77-80-0B", new byte[] { 117, 201, 9, 36, 84, 105, 119, 160, 228, 26, 164, 54, 104, 28, 11, 64, 161, 201, 153, 213, 170, 103, 121, 154, 97, 208, 164, 80, 88, 241, 197, 92, 99, 58, 218, 253, 30, 180, 236, 179, 130, 204, 167, 73, 3, 212, 154, 200, 227, 162, 192, 23, 39, 140, 208, 38, 137, 45, 200, 161, 164, 33, 53, 47 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "6A-69-16-E6-5F-56-C8-AD-EF-D4-DC-30-43-3D-A6-2B-9B-0D-46-28-55-F3-2A-C1-AC-53-B5-68-F2-52-63-3A", new byte[] { 83, 35, 63, 53, 101, 221, 255, 104, 137, 210, 84, 166, 62, 90, 150, 39, 49, 21, 96, 137, 4, 133, 120, 162, 55, 146, 203, 145, 30, 23, 128, 255, 124, 165, 157, 195, 151, 109, 102, 5, 27, 42, 84, 206, 182, 148, 161, 28, 12, 124, 163, 126, 103, 28, 144, 105, 29, 0, 182, 35, 41, 155, 145, 103 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "63-A4-71-80-D3-5C-4A-9B-59-3E-30-5A-66-60-6A-B5-19-D8-64-F7-96-86-31-63-01-FA-D6-54-DD-22-8D-14", new byte[] { 134, 206, 96, 106, 48, 125, 103, 107, 150, 226, 54, 78, 31, 142, 141, 75, 2, 242, 34, 97, 15, 151, 208, 109, 237, 110, 57, 93, 25, 170, 168, 189, 57, 76, 113, 186, 161, 134, 45, 251, 214, 65, 150, 30, 254, 197, 98, 75, 218, 203, 48, 4, 225, 48, 15, 242, 30, 1, 145, 161, 73, 45, 252, 127 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "F7-FB-E2-C2-C9-74-E1-5C-A2-0A-6A-F5-AE-C6-05-18-BC-0F-3D-10-C1-45-7D-26-79-F2-7C-CE-40-62-BB-91", new byte[] { 11, 27, 76, 194, 119, 97, 55, 240, 34, 0, 228, 132, 243, 182, 211, 114, 121, 234, 187, 252, 92, 168, 135, 28, 18, 185, 26, 16, 23, 28, 140, 86, 251, 167, 94, 129, 234, 146, 229, 255, 76, 222, 218, 231, 178, 162, 236, 76, 84, 110, 231, 132, 113, 253, 215, 197, 108, 29, 180, 53, 114, 255, 121, 178 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100004,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "B8-AA-6C-68-03-06-87-96-E7-07-5C-65-A4-A8-71-A3-52-4E-23-AE-85-9E-D1-F3-4C-D8-DE-F8-25-5F-89-86", new byte[] { 255, 47, 129, 119, 233, 2, 101, 242, 67, 223, 229, 211, 54, 175, 4, 35, 86, 255, 140, 179, 124, 89, 123, 240, 244, 108, 124, 206, 34, 99, 113, 76, 175, 241, 79, 228, 236, 61, 249, 52, 78, 191, 112, 72, 92, 217, 165, 35, 247, 215, 18, 238, 77, 64, 197, 94, 227, 58, 91, 113, 95, 206, 130, 55 } });

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0a9c8263-7f5e-4e25-bb85-7a4c0a1e3a5c"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 9, 24, 129, DateTimeKind.Utc).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0bb3c011-9ba9-47e7-9ce0-3268f85e1ffc"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 9, 24, 129, DateTimeKind.Utc).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("18a64e64-3707-451c-b54d-51dbb9933aa0"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 9, 24, 129, DateTimeKind.Utc).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("1b234567-89ab-cdef-0123-456789abcdef"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 9, 24, 129, DateTimeKind.Utc).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("2b7c5a63-8e93-4d88-bc90-85c42d1574ae"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 9, 24, 129, DateTimeKind.Utc).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("34f2c84e-6c77-4c4a-b5f3-eef62d87b4be"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 9, 24, 129, DateTimeKind.Utc).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("3d8f49b2-ef8b-4b3e-8f5d-1f68d8f4f4b1"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 9, 24, 129, DateTimeKind.Utc).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("4d8d76aa-48e5-4c2b-95f1-5a77c73c0f11"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 9, 24, 129, DateTimeKind.Utc).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("59259348-41da-4bbc-b85c-48ee82f474ce"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 9, 24, 129, DateTimeKind.Utc).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5a6e8d59-0c3d-4e54-a105-50f44dcb9e4b"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 9, 24, 129, DateTimeKind.Utc).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5e4f2822-bb47-45b4-83c0-6c1de2b5f900"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 9, 24, 129, DateTimeKind.Utc).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("72b24a8d-4e5b-43e5-aeae-ecf9dc1b52d9"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 9, 24, 129, DateTimeKind.Utc).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("7f1f7c59-f92e-4c3b-a3f4-9c2a4cd474cb"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 9, 24, 129, DateTimeKind.Utc).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8b5c0f77-e3f1-4972-9102-6c1dfbb5a601"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 9, 24, 129, DateTimeKind.Utc).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8d5c8e30-dede-4ef0-9158-f7692c41acb2"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 9, 24, 129, DateTimeKind.Utc).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9b7f3e43-50bc-41d5-8f43-b8e0e1f47732"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 9, 24, 129, DateTimeKind.Utc).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e7b22d3-c5a5-429e-82dc-e5c573745e1d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 9, 24, 129, DateTimeKind.Utc).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("c7f1f4f5-74e3-4b4f-9c5a-3e2059d8b72d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 9, 24, 129, DateTimeKind.Utc).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("e43ff624-3f3c-4e8e-b5eb-11c0c3a244fa"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 9, 24, 129, DateTimeKind.Utc).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("f3b00c12-3b5e-4c8e-9bb0-7a5c7408cd07"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 9, 24, 129, DateTimeKind.Utc).AddTicks(5654));

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
                value: new DateTime(2024, 11, 15, 19, 7, 9, 810, DateTimeKind.Utc).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c9ebf2c7-5a7f-4b5d-bb7f-2f2c4d8e4a88"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 19, 7, 9, 810, DateTimeKind.Utc).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("d3c4b5e8-1f3a-4c8c-897e-2d8cf3e7c4f6"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 19, 7, 9, 810, DateTimeKind.Utc).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 19, 7, 9, 810, DateTimeKind.Utc).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "7B-DE-A0-58-69-22-62-5C-B4-29-36-52-C5-89-4F-7F-03-CF-06-E3-09-BB-89-D7-13-2B-2A-E3-E8-F0-1A-75", new byte[] { 179, 50, 44, 117, 208, 116, 238, 163, 5, 170, 31, 233, 191, 57, 239, 232, 43, 35, 179, 40, 77, 178, 106, 219, 209, 209, 142, 95, 77, 212, 85, 230, 37, 84, 106, 71, 128, 254, 68, 163, 122, 59, 135, 182, 49, 119, 255, 94, 103, 251, 190, 255, 13, 60, 140, 30, 219, 136, 10, 27, 230, 55, 221, 235 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "60-29-B9-46-E6-F4-B2-E7-02-BA-AF-AE-4C-B3-84-98-FC-77-E8-40-99-BF-CE-A2-AD-42-2B-87-1C-EA-C1-9B", new byte[] { 243, 196, 134, 235, 229, 121, 83, 58, 111, 157, 173, 152, 249, 235, 209, 91, 113, 104, 155, 187, 19, 177, 164, 151, 86, 80, 60, 201, 170, 200, 211, 77, 183, 114, 93, 0, 71, 248, 49, 43, 26, 9, 222, 99, 71, 172, 195, 180, 176, 35, 199, 191, 79, 204, 225, 169, 58, 163, 35, 91, 255, 35, 145, 47 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "4E-57-D0-B3-B0-F5-99-EB-A9-7B-66-C5-B8-0F-9A-04-11-0C-34-00-C6-B9-6F-1F-18-92-4C-E6-7B-D0-5C-DA", new byte[] { 53, 221, 128, 116, 225, 15, 175, 33, 99, 108, 20, 127, 25, 163, 235, 72, 112, 76, 64, 38, 77, 226, 65, 38, 60, 147, 41, 27, 212, 169, 73, 237, 49, 129, 107, 120, 54, 230, 41, 237, 97, 64, 254, 122, 190, 88, 133, 217, 126, 93, 103, 61, 154, 107, 56, 60, 145, 225, 146, 7, 185, 181, 145, 144 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "13-13-D3-9B-67-5D-25-EE-C7-7B-15-CA-B2-BF-1F-1E-6D-75-F9-8E-E6-16-E2-0A-A2-0D-E7-12-F6-5A-EB-17", new byte[] { 83, 190, 46, 5, 70, 223, 48, 255, 186, 101, 99, 254, 139, 109, 164, 101, 178, 132, 120, 93, 240, 93, 155, 110, 55, 213, 111, 35, 105, 253, 223, 65, 152, 3, 117, 105, 116, 113, 21, 80, 191, 91, 87, 206, 46, 21, 5, 16, 133, 191, 51, 49, 242, 104, 14, 241, 137, 28, 171, 40, 117, 243, 162, 223 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "B9-AA-95-53-F2-B5-A5-B3-2D-51-DC-04-E3-D6-F1-E8-5E-D2-F7-3D-B3-97-C5-B5-E3-CC-D0-57-B2-17-61-75", new byte[] { 114, 24, 119, 186, 30, 152, 216, 168, 168, 161, 121, 246, 172, 28, 150, 103, 10, 223, 54, 173, 61, 31, 50, 123, 144, 166, 100, 35, 151, 0, 152, 192, 112, 220, 26, 169, 90, 156, 156, 72, 133, 7, 53, 140, 103, 124, 176, 227, 14, 193, 103, 65, 112, 28, 50, 93, 62, 120, 163, 99, 191, 72, 210, 94 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "51-D2-24-89-E4-77-BC-D4-25-C4-58-C6-51-EB-63-5B-BA-A8-D8-C2-0C-EE-23-C9-78-6E-FA-48-C3-EA-87-3F", new byte[] { 140, 110, 56, 251, 169, 117, 16, 74, 28, 147, 0, 26, 82, 186, 158, 249, 191, 91, 6, 208, 22, 52, 254, 189, 93, 148, 247, 138, 174, 25, 73, 61, 16, 175, 154, 62, 130, 101, 169, 65, 70, 247, 173, 23, 83, 225, 108, 236, 245, 113, 111, 125, 202, 134, 199, 248, 70, 2, 209, 221, 165, 40, 188, 70 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "F4-0C-95-B2-9E-E3-2E-17-00-2F-87-40-AC-54-D2-6A-62-89-42-59-4A-BC-20-FB-C2-43-B9-1F-2D-95-1E-41", new byte[] { 128, 184, 205, 51, 178, 101, 117, 101, 40, 225, 106, 194, 213, 75, 73, 80, 155, 63, 44, 245, 238, 50, 10, 23, 0, 55, 160, 135, 178, 166, 130, 113, 6, 157, 158, 239, 241, 16, 66, 238, 233, 100, 44, 208, 7, 16, 7, 83, 131, 148, 233, 195, 220, 165, 205, 111, 73, 12, 87, 164, 132, 18, 10, 157 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "C8-81-85-A5-39-EC-B4-8E-0A-B2-5F-EB-69-E5-30-CA-49-D3-D3-A8-F0-49-45-6B-CE-4E-4C-69-C8-F5-29-46", new byte[] { 169, 64, 35, 5, 31, 152, 31, 202, 22, 108, 124, 203, 244, 19, 124, 201, 224, 173, 168, 149, 120, 34, 192, 64, 179, 30, 108, 85, 22, 110, 146, 108, 14, 26, 148, 224, 85, 140, 22, 48, 28, 0, 193, 168, 195, 53, 127, 69, 253, 94, 65, 190, 135, 115, 208, 254, 33, 218, 62, 117, 172, 176, 196, 219 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "66-DF-F1-C9-B3-6C-D0-67-31-88-FC-E0-D6-FC-6A-E0-0A-B1-7E-43-79-3C-F2-A8-9D-3E-33-69-FF-60-B4-7E", new byte[] { 0, 246, 25, 110, 58, 136, 154, 233, 179, 143, 114, 117, 28, 46, 13, 54, 239, 60, 167, 202, 38, 81, 116, 139, 17, 191, 63, 162, 192, 183, 60, 18, 32, 105, 41, 163, 66, 97, 221, 182, 224, 89, 61, 48, 86, 223, 230, 178, 5, 70, 28, 181, 174, 63, 15, 137, 188, 109, 165, 209, 153, 114, 229, 186 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100004,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "16-BC-00-C4-BD-CE-42-65-E7-36-6A-11-19-14-FC-46-8F-B3-53-31-96-5B-D2-F2-EA-B7-DD-17-AE-03-FF-B9", new byte[] { 119, 178, 17, 59, 220, 57, 125, 29, 191, 251, 9, 90, 248, 188, 61, 104, 27, 247, 153, 251, 225, 27, 203, 207, 248, 104, 254, 243, 48, 161, 75, 60, 110, 123, 13, 237, 212, 123, 253, 213, 156, 112, 19, 7, 183, 126, 133, 8, 9, 189, 203, 191, 43, 157, 33, 153, 52, 67, 145, 132, 98, 70, 95, 233 } });

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0a9c8263-7f5e-4e25-bb85-7a4c0a1e3a5c"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 7, 9, 810, DateTimeKind.Utc).AddTicks(3010));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0bb3c011-9ba9-47e7-9ce0-3268f85e1ffc"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 7, 9, 810, DateTimeKind.Utc).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("18a64e64-3707-451c-b54d-51dbb9933aa0"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 7, 9, 810, DateTimeKind.Utc).AddTicks(3063));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("1b234567-89ab-cdef-0123-456789abcdef"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 7, 9, 810, DateTimeKind.Utc).AddTicks(3003));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("2b7c5a63-8e93-4d88-bc90-85c42d1574ae"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 7, 9, 810, DateTimeKind.Utc).AddTicks(3016));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("34f2c84e-6c77-4c4a-b5f3-eef62d87b4be"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 7, 9, 810, DateTimeKind.Utc).AddTicks(3054));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("3d8f49b2-ef8b-4b3e-8f5d-1f68d8f4f4b1"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 7, 9, 810, DateTimeKind.Utc).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("4d8d76aa-48e5-4c2b-95f1-5a77c73c0f11"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 7, 9, 810, DateTimeKind.Utc).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("59259348-41da-4bbc-b85c-48ee82f474ce"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 7, 9, 810, DateTimeKind.Utc).AddTicks(3019));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5a6e8d59-0c3d-4e54-a105-50f44dcb9e4b"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 7, 9, 810, DateTimeKind.Utc).AddTicks(3014));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5e4f2822-bb47-45b4-83c0-6c1de2b5f900"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 7, 9, 810, DateTimeKind.Utc).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("72b24a8d-4e5b-43e5-aeae-ecf9dc1b52d9"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 7, 9, 810, DateTimeKind.Utc).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("7f1f7c59-f92e-4c3b-a3f4-9c2a4cd474cb"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 7, 9, 810, DateTimeKind.Utc).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8b5c0f77-e3f1-4972-9102-6c1dfbb5a601"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 7, 9, 810, DateTimeKind.Utc).AddTicks(3067));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8d5c8e30-dede-4ef0-9158-f7692c41acb2"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 7, 9, 810, DateTimeKind.Utc).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9b7f3e43-50bc-41d5-8f43-b8e0e1f47732"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 7, 9, 810, DateTimeKind.Utc).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e7b22d3-c5a5-429e-82dc-e5c573745e1d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 7, 9, 810, DateTimeKind.Utc).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("c7f1f4f5-74e3-4b4f-9c5a-3e2059d8b72d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 7, 9, 810, DateTimeKind.Utc).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("e43ff624-3f3c-4e8e-b5eb-11c0c3a244fa"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 7, 9, 810, DateTimeKind.Utc).AddTicks(3012));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("f3b00c12-3b5e-4c8e-9bb0-7a5c7408cd07"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 7, 9, 810, DateTimeKind.Utc).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23"),
                column: "GamePicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Games/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23.jpg");
        }
    }
}
