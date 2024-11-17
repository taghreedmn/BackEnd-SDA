using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
