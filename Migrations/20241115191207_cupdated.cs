using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class cupdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c4f5e3e1-2c4c-4f4e-a4d1-5e5e6139d703"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 19, 12, 6, 761, DateTimeKind.Utc).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c9ebf2c7-5a7f-4b5d-bb7f-2f2c4d8e4a88"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 19, 12, 6, 761, DateTimeKind.Utc).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("d3c4b5e8-1f3a-4c8c-897e-2d8cf3e7c4f6"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 19, 12, 6, 761, DateTimeKind.Utc).AddTicks(6354));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 19, 12, 6, 761, DateTimeKind.Utc).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "D4-BB-08-DD-4E-94-9E-EF-F4-02-1F-AF-B5-89-68-15-F1-4E-4E-DE-C5-D3-DA-55-EF-35-9E-41-A1-4B-B6-26", new byte[] { 73, 116, 176, 246, 216, 181, 195, 250, 224, 128, 38, 44, 145, 166, 192, 5, 161, 114, 175, 102, 127, 74, 178, 230, 51, 136, 100, 84, 79, 129, 235, 201, 148, 58, 153, 4, 124, 5, 141, 121, 188, 181, 29, 70, 91, 185, 255, 208, 95, 188, 78, 125, 196, 170, 225, 48, 165, 159, 211, 8, 125, 177, 59, 65 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "CF-65-1C-01-72-0C-A1-48-C1-84-6D-E0-6E-28-C2-7E-B3-FD-F2-BA-74-61-97-56-02-84-01-BE-7D-2D-D7-CA", new byte[] { 158, 239, 110, 99, 54, 183, 98, 250, 23, 82, 13, 185, 23, 149, 88, 213, 34, 176, 223, 181, 189, 56, 222, 251, 32, 232, 124, 244, 6, 96, 102, 174, 203, 21, 244, 245, 21, 56, 231, 176, 30, 40, 147, 92, 60, 228, 156, 217, 255, 78, 63, 36, 221, 17, 140, 200, 77, 205, 27, 236, 31, 209, 42, 233 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "F7-4D-51-0B-F3-91-46-25-A3-D4-B1-47-19-F1-AD-9B-9D-86-D2-20-B1-F4-2B-E8-10-24-D0-3F-05-60-61-3F", new byte[] { 230, 31, 102, 141, 105, 6, 68, 170, 188, 168, 29, 244, 132, 228, 250, 9, 10, 106, 250, 234, 251, 242, 8, 53, 104, 133, 180, 192, 209, 188, 171, 172, 49, 145, 195, 158, 120, 147, 5, 36, 130, 254, 29, 48, 67, 205, 13, 102, 192, 115, 1, 84, 145, 247, 60, 58, 121, 43, 231, 161, 211, 220, 16, 230 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "A3-DE-FC-37-2E-FA-87-F7-35-B7-58-7B-C0-E2-41-B4-4A-F7-DF-47-FA-9A-D8-01-23-E7-87-28-D0-11-B7-01", new byte[] { 90, 32, 137, 51, 104, 38, 138, 255, 153, 46, 103, 193, 83, 70, 161, 24, 254, 223, 156, 105, 190, 224, 33, 170, 109, 123, 108, 197, 43, 82, 13, 47, 128, 119, 30, 241, 241, 226, 142, 224, 166, 155, 67, 52, 64, 206, 77, 164, 64, 157, 20, 44, 228, 32, 137, 253, 202, 230, 14, 247, 126, 142, 24, 73 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "E6-22-7C-F6-E5-9F-6F-01-62-6F-7D-60-C0-DF-9B-03-E2-BC-2F-59-E0-99-0F-AF-D0-48-13-C4-7F-EA-E2-AB", new byte[] { 152, 104, 184, 148, 244, 95, 237, 223, 36, 81, 126, 54, 134, 143, 246, 8, 185, 85, 98, 46, 38, 225, 62, 116, 190, 60, 125, 123, 239, 114, 170, 63, 60, 53, 152, 239, 204, 119, 234, 199, 128, 191, 196, 32, 178, 86, 49, 169, 183, 127, 175, 121, 252, 93, 46, 152, 41, 232, 39, 166, 137, 185, 30, 114 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "90-EF-8C-B5-01-45-DB-70-56-EC-5F-D0-50-55-7A-EA-77-5A-79-C1-E7-B4-D7-71-3C-98-BF-87-A2-9A-47-CF", new byte[] { 1, 47, 12, 95, 175, 152, 59, 47, 97, 31, 56, 243, 46, 227, 179, 237, 46, 166, 194, 46, 24, 90, 68, 241, 117, 85, 184, 214, 12, 188, 43, 247, 216, 53, 218, 210, 120, 124, 165, 10, 133, 172, 115, 71, 85, 79, 162, 172, 5, 226, 237, 135, 71, 223, 174, 142, 219, 246, 180, 42, 116, 108, 246, 193 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "AA-78-94-F0-A5-D6-E7-2C-14-10-1E-67-0B-56-64-C0-FF-31-82-66-4D-BE-41-7C-34-E7-6B-53-6D-02-25-3C", new byte[] { 226, 31, 170, 70, 152, 8, 247, 39, 134, 211, 103, 199, 76, 178, 197, 142, 165, 129, 239, 38, 234, 177, 204, 254, 8, 80, 247, 100, 145, 148, 53, 227, 153, 199, 16, 121, 183, 60, 9, 109, 242, 156, 73, 89, 196, 239, 9, 251, 103, 219, 102, 129, 235, 204, 242, 131, 112, 71, 24, 29, 1, 156, 47, 6 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "85-55-27-B2-C5-1C-41-51-9E-C7-72-1C-E5-7F-2F-67-82-B8-96-BE-8D-E2-0D-18-A0-EE-31-C6-FF-59-AE-13", new byte[] { 190, 197, 116, 94, 237, 220, 80, 85, 18, 147, 249, 71, 252, 77, 97, 143, 102, 131, 45, 215, 242, 212, 111, 13, 65, 172, 103, 117, 244, 113, 173, 73, 246, 2, 201, 85, 133, 148, 78, 233, 203, 60, 68, 16, 133, 34, 198, 146, 222, 53, 119, 176, 14, 130, 17, 113, 163, 94, 23, 103, 61, 85, 50, 230 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "9D-A2-00-C4-C6-3A-72-84-09-90-D4-C0-D6-C1-B8-AE-34-DB-16-91-A4-C1-D6-0C-19-35-EF-ED-83-5E-7C-21", new byte[] { 244, 228, 96, 209, 101, 88, 90, 156, 42, 155, 125, 217, 177, 28, 144, 88, 188, 25, 84, 197, 34, 114, 255, 109, 148, 68, 216, 111, 32, 124, 159, 224, 208, 129, 140, 97, 226, 114, 185, 37, 103, 243, 83, 220, 55, 35, 71, 229, 130, 22, 221, 48, 165, 221, 51, 109, 53, 193, 214, 172, 189, 93, 177, 2 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100004,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "5B-C0-8C-85-51-69-EC-8F-EC-AA-B8-CD-DF-E7-67-EE-BE-04-47-15-8C-A7-5A-C5-86-B5-61-AE-49-0B-70-5D", new byte[] { 179, 160, 36, 100, 163, 88, 142, 32, 215, 19, 231, 15, 166, 95, 121, 80, 152, 64, 206, 233, 198, 186, 22, 124, 61, 220, 51, 188, 113, 70, 81, 76, 44, 66, 116, 42, 190, 157, 245, 239, 229, 25, 190, 245, 132, 173, 210, 235, 51, 77, 100, 145, 102, 107, 201, 155, 155, 26, 44, 151, 164, 204, 37, 10 } });

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0a9c8263-7f5e-4e25-bb85-7a4c0a1e3a5c"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 12, 6, 761, DateTimeKind.Utc).AddTicks(6209));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0bb3c011-9ba9-47e7-9ce0-3268f85e1ffc"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 12, 6, 761, DateTimeKind.Utc).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("18a64e64-3707-451c-b54d-51dbb9933aa0"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 12, 6, 761, DateTimeKind.Utc).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("1b234567-89ab-cdef-0123-456789abcdef"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 12, 6, 761, DateTimeKind.Utc).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("2b7c5a63-8e93-4d88-bc90-85c42d1574ae"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 12, 6, 761, DateTimeKind.Utc).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("34f2c84e-6c77-4c4a-b5f3-eef62d87b4be"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 12, 6, 761, DateTimeKind.Utc).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("3d8f49b2-ef8b-4b3e-8f5d-1f68d8f4f4b1"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 12, 6, 761, DateTimeKind.Utc).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("4d8d76aa-48e5-4c2b-95f1-5a77c73c0f11"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 12, 6, 761, DateTimeKind.Utc).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("59259348-41da-4bbc-b85c-48ee82f474ce"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 12, 6, 761, DateTimeKind.Utc).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5a6e8d59-0c3d-4e54-a105-50f44dcb9e4b"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 12, 6, 761, DateTimeKind.Utc).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5e4f2822-bb47-45b4-83c0-6c1de2b5f900"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 12, 6, 761, DateTimeKind.Utc).AddTicks(6232));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("72b24a8d-4e5b-43e5-aeae-ecf9dc1b52d9"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 12, 6, 761, DateTimeKind.Utc).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("7f1f7c59-f92e-4c3b-a3f4-9c2a4cd474cb"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 12, 6, 761, DateTimeKind.Utc).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8b5c0f77-e3f1-4972-9102-6c1dfbb5a601"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 12, 6, 761, DateTimeKind.Utc).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8d5c8e30-dede-4ef0-9158-f7692c41acb2"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 12, 6, 761, DateTimeKind.Utc).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9b7f3e43-50bc-41d5-8f43-b8e0e1f47732"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 12, 6, 761, DateTimeKind.Utc).AddTicks(6227));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e7b22d3-c5a5-429e-82dc-e5c573745e1d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 12, 6, 761, DateTimeKind.Utc).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("c7f1f4f5-74e3-4b4f-9c5a-3e2059d8b72d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 12, 6, 761, DateTimeKind.Utc).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("e43ff624-3f3c-4e8e-b5eb-11c0c3a244fa"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 12, 6, 761, DateTimeKind.Utc).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("f3b00c12-3b5e-4c8e-9bb0-7a5c7408cd07"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 12, 6, 761, DateTimeKind.Utc).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23"),
                column: "GamePicturePath",
                value: "https://fusiontech-0dxp.onrender.com/../images/Games/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
