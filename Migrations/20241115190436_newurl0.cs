using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class newurl0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c4f5e3e1-2c4c-4f4e-a4d1-5e5e6139d703"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 19, 4, 35, 991, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c9ebf2c7-5a7f-4b5d-bb7f-2f2c4d8e4a88"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 19, 4, 35, 991, DateTimeKind.Utc).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("d3c4b5e8-1f3a-4c8c-897e-2d8cf3e7c4f6"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 19, 4, 35, 991, DateTimeKind.Utc).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 19, 4, 35, 991, DateTimeKind.Utc).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "98-DA-31-00-35-A2-DB-2A-60-7D-9D-BC-65-C2-8A-AF-82-EE-CB-62-DF-F7-65-E9-E8-0F-20-EB-67-71-DF-05", new byte[] { 130, 37, 112, 155, 228, 64, 113, 161, 51, 10, 156, 67, 208, 208, 144, 149, 60, 155, 254, 144, 72, 236, 92, 179, 249, 73, 152, 31, 243, 235, 125, 209, 156, 145, 72, 51, 162, 49, 48, 253, 230, 32, 135, 112, 251, 36, 46, 240, 251, 118, 246, 156, 191, 156, 190, 239, 177, 33, 25, 141, 255, 208, 2, 156 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "4A-7B-A7-BE-CC-47-37-B7-19-2B-BF-59-93-52-D9-74-94-A5-7D-DD-76-83-E5-EA-58-FB-10-83-0D-19-6E-2E", new byte[] { 70, 7, 73, 95, 122, 63, 114, 136, 54, 71, 55, 213, 55, 170, 147, 135, 155, 248, 18, 90, 253, 104, 184, 38, 48, 20, 218, 169, 25, 77, 167, 54, 13, 29, 231, 231, 158, 232, 147, 199, 198, 52, 104, 144, 142, 122, 11, 167, 14, 80, 42, 177, 254, 214, 65, 9, 160, 128, 114, 254, 55, 169, 165, 110 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "3C-FD-F4-9E-CA-FC-FE-7B-D7-EF-87-B0-42-05-01-3C-3D-27-4C-CD-CB-4E-94-9E-19-CA-07-68-69-D0-79-7E", new byte[] { 77, 171, 95, 229, 219, 65, 238, 43, 230, 25, 84, 239, 134, 200, 10, 41, 22, 124, 215, 149, 207, 72, 219, 52, 119, 202, 246, 239, 140, 160, 166, 35, 107, 109, 29, 39, 207, 193, 228, 5, 236, 195, 133, 160, 39, 189, 155, 29, 72, 183, 22, 162, 74, 7, 195, 125, 182, 72, 98, 217, 12, 65, 171, 38 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "97-DC-B3-4B-3D-60-18-9F-A3-84-FB-A4-E8-FD-F6-0F-98-0B-46-4C-61-83-09-E6-D2-58-6F-F6-B8-FF-76-A1", new byte[] { 242, 168, 182, 59, 235, 219, 99, 145, 192, 30, 175, 11, 253, 41, 211, 209, 49, 62, 22, 242, 86, 44, 216, 233, 19, 4, 148, 45, 180, 200, 124, 60, 10, 86, 203, 31, 217, 102, 216, 89, 202, 78, 61, 93, 195, 183, 232, 26, 30, 68, 10, 126, 176, 242, 81, 122, 131, 200, 200, 88, 248, 220, 199, 6 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "07-4A-23-49-42-E8-E1-7B-77-0D-19-87-1D-5E-E7-03-82-C3-66-21-DF-DD-26-F7-1E-C7-A5-E3-04-6E-26-BC", new byte[] { 30, 4, 183, 28, 62, 214, 110, 100, 70, 142, 95, 113, 136, 136, 80, 226, 23, 223, 73, 81, 170, 248, 113, 92, 73, 177, 176, 92, 23, 199, 146, 67, 45, 252, 208, 92, 210, 17, 178, 165, 75, 93, 101, 174, 246, 47, 140, 206, 8, 238, 205, 0, 33, 33, 87, 107, 62, 198, 191, 26, 196, 86, 163, 46 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "0E-41-74-96-ED-AF-A0-88-87-53-3A-F8-9F-55-73-62-07-12-D7-83-14-8B-1B-26-22-37-5C-63-7A-FB-7C-E1", new byte[] { 69, 108, 88, 114, 10, 8, 203, 177, 120, 115, 144, 8, 236, 184, 233, 102, 33, 97, 136, 54, 237, 251, 32, 189, 103, 161, 25, 106, 182, 242, 130, 205, 105, 85, 216, 209, 125, 151, 90, 136, 194, 2, 4, 54, 148, 112, 246, 149, 211, 156, 154, 252, 169, 55, 165, 188, 12, 40, 195, 188, 37, 209, 116, 132 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "CF-87-26-CE-8C-03-A5-20-C5-27-EE-35-7B-44-3A-AD-22-DA-65-19-98-02-B0-A1-59-C5-3A-23-EC-47-9D-1B", new byte[] { 68, 231, 175, 62, 39, 244, 123, 249, 82, 116, 34, 172, 138, 4, 67, 116, 63, 224, 115, 55, 162, 247, 145, 19, 75, 149, 73, 155, 176, 102, 52, 192, 91, 68, 218, 51, 191, 160, 163, 173, 112, 178, 24, 211, 87, 85, 112, 112, 132, 167, 103, 16, 10, 227, 89, 230, 222, 88, 221, 150, 172, 67, 253, 107 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "74-8C-B3-C0-05-A8-10-41-0F-FB-36-39-A1-66-2E-3A-8E-57-24-6D-C6-FA-D0-47-88-92-B1-F6-67-45-B7-A8", new byte[] { 85, 76, 55, 46, 26, 81, 194, 179, 67, 41, 124, 39, 63, 168, 143, 158, 166, 13, 145, 62, 208, 83, 149, 194, 157, 203, 198, 195, 166, 126, 144, 86, 41, 90, 155, 5, 52, 38, 27, 98, 73, 214, 248, 208, 29, 229, 246, 7, 214, 113, 81, 109, 160, 128, 189, 107, 209, 96, 172, 135, 180, 102, 216, 116 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "59-D5-38-E2-7C-78-53-69-B2-CB-4B-A3-50-24-F5-A9-60-35-51-47-B0-FC-FE-0F-D9-E1-69-D1-14-E0-FF-12", new byte[] { 70, 136, 28, 29, 188, 100, 0, 247, 250, 116, 201, 136, 247, 83, 154, 161, 124, 165, 209, 202, 73, 9, 1, 225, 35, 108, 191, 17, 102, 108, 4, 190, 194, 253, 63, 20, 14, 222, 237, 194, 136, 250, 43, 171, 18, 9, 30, 7, 246, 162, 223, 94, 81, 178, 87, 20, 128, 213, 214, 10, 173, 45, 98, 11 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100004,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "CB-66-BC-01-7A-6B-BD-4C-C0-EF-BF-DB-41-31-EE-18-CE-FB-44-B8-86-46-AE-20-02-6B-6C-11-0E-B7-F0-FF", new byte[] { 31, 18, 41, 72, 29, 208, 115, 29, 233, 72, 136, 21, 100, 1, 86, 15, 217, 221, 126, 30, 44, 102, 25, 170, 27, 96, 46, 217, 236, 97, 73, 49, 75, 253, 98, 220, 30, 161, 169, 227, 235, 172, 130, 35, 117, 42, 190, 202, 200, 26, 182, 76, 158, 88, 249, 124, 217, 25, 71, 133, 68, 20, 109, 118 } });

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0a9c8263-7f5e-4e25-bb85-7a4c0a1e3a5c"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 4, 35, 991, DateTimeKind.Utc).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0bb3c011-9ba9-47e7-9ce0-3268f85e1ffc"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 4, 35, 991, DateTimeKind.Utc).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("18a64e64-3707-451c-b54d-51dbb9933aa0"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 4, 35, 991, DateTimeKind.Utc).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("1b234567-89ab-cdef-0123-456789abcdef"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 4, 35, 991, DateTimeKind.Utc).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("2b7c5a63-8e93-4d88-bc90-85c42d1574ae"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 4, 35, 991, DateTimeKind.Utc).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("34f2c84e-6c77-4c4a-b5f3-eef62d87b4be"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 4, 35, 991, DateTimeKind.Utc).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("3d8f49b2-ef8b-4b3e-8f5d-1f68d8f4f4b1"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 4, 35, 991, DateTimeKind.Utc).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("4d8d76aa-48e5-4c2b-95f1-5a77c73c0f11"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 4, 35, 991, DateTimeKind.Utc).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("59259348-41da-4bbc-b85c-48ee82f474ce"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 4, 35, 991, DateTimeKind.Utc).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5a6e8d59-0c3d-4e54-a105-50f44dcb9e4b"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 4, 35, 991, DateTimeKind.Utc).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5e4f2822-bb47-45b4-83c0-6c1de2b5f900"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 4, 35, 991, DateTimeKind.Utc).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("72b24a8d-4e5b-43e5-aeae-ecf9dc1b52d9"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 4, 35, 991, DateTimeKind.Utc).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("7f1f7c59-f92e-4c3b-a3f4-9c2a4cd474cb"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 4, 35, 991, DateTimeKind.Utc).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8b5c0f77-e3f1-4972-9102-6c1dfbb5a601"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 4, 35, 991, DateTimeKind.Utc).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8d5c8e30-dede-4ef0-9158-f7692c41acb2"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 4, 35, 991, DateTimeKind.Utc).AddTicks(2489));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9b7f3e43-50bc-41d5-8f43-b8e0e1f47732"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 4, 35, 991, DateTimeKind.Utc).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e7b22d3-c5a5-429e-82dc-e5c573745e1d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 4, 35, 991, DateTimeKind.Utc).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("c7f1f4f5-74e3-4b4f-9c5a-3e2059d8b72d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 4, 35, 991, DateTimeKind.Utc).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("e43ff624-3f3c-4e8e-b5eb-11c0c3a244fa"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 4, 35, 991, DateTimeKind.Utc).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("f3b00c12-3b5e-4c8e-9bb0-7a5c7408cd07"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 4, 35, 991, DateTimeKind.Utc).AddTicks(2497));

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
    }
}
