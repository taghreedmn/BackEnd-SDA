using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c4f5e3e1-2c4c-4f4e-a4d1-5e5e6139d703"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c9ebf2c7-5a7f-4b5d-bb7f-2f2c4d8e4a88"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("d3c4b5e8-1f3a-4c8c-897e-2d8cf3e7c4f6"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "82-8C-3E-0B-D3-B6-5E-9D-56-92-A2-81-FD-4C-0A-9E-24-7E-35-25-E1-A6-04-4A-96-87-BF-96-90-F6-26-10", new byte[] { 48, 199, 226, 189, 95, 93, 60, 152, 199, 67, 92, 81, 118, 155, 226, 251, 129, 119, 22, 202, 211, 246, 139, 97, 161, 45, 142, 100, 219, 206, 251, 23, 56, 67, 164, 26, 172, 130, 22, 6, 156, 18, 230, 152, 127, 204, 252, 239, 30, 246, 202, 172, 81, 223, 191, 150, 80, 170, 197, 170, 95, 230, 190, 98 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "F6-0C-8A-BB-7E-E1-F0-C5-9A-7B-C4-50-C7-2C-BA-19-BC-27-11-49-FD-B1-FA-6B-8B-CD-D8-C4-3A-85-FD-40", new byte[] { 21, 52, 238, 11, 192, 1, 137, 91, 71, 181, 210, 206, 249, 46, 145, 156, 213, 181, 204, 158, 204, 34, 243, 23, 16, 142, 181, 27, 186, 140, 133, 3, 35, 130, 104, 222, 36, 167, 210, 167, 134, 147, 61, 90, 51, 95, 248, 161, 0, 53, 100, 142, 154, 96, 88, 58, 229, 141, 11, 166, 104, 77, 124, 222 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "2A-86-58-54-3C-53-24-03-EC-6B-43-9C-E0-14-28-23-09-43-AF-79-2B-FF-37-7B-AB-9F-A7-B5-95-2B-D4-F8", new byte[] { 33, 31, 218, 122, 85, 225, 92, 91, 174, 92, 123, 131, 145, 77, 46, 42, 224, 226, 67, 128, 29, 108, 61, 173, 178, 166, 225, 178, 93, 252, 127, 117, 30, 44, 184, 247, 116, 146, 193, 71, 94, 255, 150, 89, 144, 36, 250, 81, 174, 66, 3, 253, 129, 103, 196, 193, 183, 205, 217, 139, 129, 191, 59, 78 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "A6-83-A2-63-56-3A-29-19-B4-35-4D-CB-F2-DC-F8-0B-F1-EC-43-46-AA-8F-2C-2E-A0-4E-1B-FB-4E-FF-C9-E7", new byte[] { 162, 66, 61, 8, 154, 146, 34, 246, 152, 195, 236, 214, 253, 190, 128, 97, 153, 195, 99, 41, 32, 233, 143, 206, 32, 238, 142, 65, 240, 236, 46, 27, 104, 230, 51, 197, 212, 33, 59, 197, 219, 173, 97, 60, 35, 199, 111, 89, 151, 134, 247, 128, 175, 54, 13, 139, 12, 189, 166, 8, 72, 7, 54, 237 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "BA-33-3F-34-86-76-18-67-9D-03-75-09-E8-91-E9-B1-B3-C9-DE-68-EE-60-DE-1D-B8-70-89-72-B3-41-31-0C", new byte[] { 56, 1, 189, 130, 127, 139, 148, 155, 137, 172, 13, 140, 67, 188, 142, 241, 227, 148, 131, 224, 100, 200, 178, 60, 94, 66, 37, 103, 158, 22, 205, 50, 52, 44, 224, 175, 214, 7, 18, 33, 235, 133, 122, 161, 49, 149, 94, 225, 112, 140, 72, 156, 220, 244, 143, 13, 100, 5, 63, 186, 203, 13, 72, 18 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "97-FA-67-B3-4D-F4-E2-D2-46-26-F9-A3-02-93-6E-9B-11-8D-D6-85-93-D9-8D-42-3A-8A-05-72-33-F5-58-D6", new byte[] { 222, 204, 9, 171, 51, 253, 179, 6, 158, 252, 63, 174, 166, 211, 231, 217, 23, 194, 83, 109, 32, 70, 98, 59, 149, 214, 15, 105, 218, 208, 124, 48, 123, 126, 106, 55, 114, 77, 29, 130, 250, 39, 97, 87, 85, 148, 221, 176, 148, 170, 201, 14, 151, 146, 5, 111, 16, 53, 168, 215, 247, 100, 231, 86 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "3E-87-EF-1D-93-12-6A-37-55-A6-BF-B0-2C-7C-D3-C3-95-33-7B-29-7C-E3-95-35-BE-D9-F5-16-57-96-5D-4A", new byte[] { 190, 207, 217, 183, 124, 1, 160, 123, 244, 136, 220, 156, 46, 1, 135, 212, 244, 210, 75, 115, 52, 157, 23, 43, 206, 5, 187, 146, 126, 68, 199, 84, 202, 37, 172, 50, 5, 40, 86, 250, 60, 242, 51, 73, 87, 128, 202, 101, 201, 89, 58, 140, 82, 97, 160, 130, 78, 32, 109, 79, 27, 53, 99, 134 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "19-72-B8-8C-4C-4D-D3-06-41-20-4F-91-16-76-3D-33-E5-F3-5A-77-63-B4-37-B8-F4-11-06-BB-1A-F3-AB-AC", new byte[] { 172, 94, 172, 239, 12, 89, 21, 99, 190, 155, 194, 46, 50, 49, 92, 145, 162, 33, 74, 51, 85, 245, 232, 119, 107, 22, 238, 100, 78, 198, 55, 253, 119, 205, 27, 170, 248, 102, 137, 44, 77, 88, 187, 254, 110, 55, 215, 224, 112, 38, 161, 21, 108, 155, 239, 214, 229, 58, 202, 165, 202, 23, 144, 5 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "C6-FB-D1-5E-52-80-DD-A5-0A-5B-F8-23-C7-2B-A2-1D-B2-BF-BE-B2-FB-0B-0C-A0-62-0B-0B-D9-B8-50-6D-3B", new byte[] { 134, 76, 243, 38, 126, 62, 37, 35, 121, 177, 120, 94, 62, 170, 132, 182, 15, 146, 247, 166, 201, 179, 158, 34, 195, 32, 4, 136, 20, 248, 153, 108, 162, 52, 9, 146, 145, 228, 152, 126, 177, 147, 132, 8, 9, 78, 217, 175, 176, 84, 132, 59, 57, 46, 207, 191, 146, 1, 84, 130, 199, 77, 89, 25 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100004,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "BD-B3-BE-37-90-A7-54-78-62-39-1F-19-49-58-74-B6-62-9B-6A-77-54-17-41-24-17-44-7E-3C-20-B7-73-3F", new byte[] { 121, 84, 79, 42, 52, 69, 211, 150, 139, 70, 39, 55, 41, 182, 117, 139, 14, 150, 233, 68, 51, 48, 231, 174, 78, 72, 79, 30, 27, 65, 187, 80, 36, 227, 206, 179, 83, 255, 133, 89, 244, 27, 12, 64, 107, 183, 110, 17, 211, 48, 143, 31, 169, 16, 15, 139, 181, 130, 236, 239, 162, 123, 153, 70 } });

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0a9c8263-7f5e-4e25-bb85-7a4c0a1e3a5c"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0bb3c011-9ba9-47e7-9ce0-3268f85e1ffc"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("18a64e64-3707-451c-b54d-51dbb9933aa0"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("1b234567-89ab-cdef-0123-456789abcdef"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("2b7c5a63-8e93-4d88-bc90-85c42d1574ae"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("34f2c84e-6c77-4c4a-b5f3-eef62d87b4be"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("3d8f49b2-ef8b-4b3e-8f5d-1f68d8f4f4b1"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("4d8d76aa-48e5-4c2b-95f1-5a77c73c0f11"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("59259348-41da-4bbc-b85c-48ee82f474ce"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5a6e8d59-0c3d-4e54-a105-50f44dcb9e4b"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5e4f2822-bb47-45b4-83c0-6c1de2b5f900"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("72b24a8d-4e5b-43e5-aeae-ecf9dc1b52d9"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("7f1f7c59-f92e-4c3b-a3f4-9c2a4cd474cb"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8b5c0f77-e3f1-4972-9102-6c1dfbb5a601"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8d5c8e30-dede-4ef0-9158-f7692c41acb2"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9b7f3e43-50bc-41d5-8f43-b8e0e1f47732"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e7b22d3-c5a5-429e-82dc-e5c573745e1d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("c7f1f4f5-74e3-4b4f-9c5a-3e2059d8b72d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("e43ff624-3f3c-4e8e-b5eb-11c0c3a244fa"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("f3b00c12-3b5e-4c8e-9bb0-7a5c7408cd07"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 19, 13, 57, 945, DateTimeKind.Utc).AddTicks(6921));

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
    }
}
