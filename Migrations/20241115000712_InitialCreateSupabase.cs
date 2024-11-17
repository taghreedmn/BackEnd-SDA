using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateSupabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c4f5e3e1-2c4c-4f4e-a4d1-5e5e6139d703"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 0, 7, 12, 403, DateTimeKind.Utc).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c9ebf2c7-5a7f-4b5d-bb7f-2f2c4d8e4a88"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 0, 7, 12, 403, DateTimeKind.Utc).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("d3c4b5e8-1f3a-4c8c-897e-2d8cf3e7c4f6"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 0, 7, 12, 403, DateTimeKind.Utc).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 0, 7, 12, 403, DateTimeKind.Utc).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "15-21-28-70-9B-8F-19-B4-F8-FB-47-E2-0F-CC-49-33-17-A4-EE-08-FA-E0-01-07-F4-34-A1-EB-8A-64-B7-CD", new byte[] { 9, 26, 80, 169, 249, 252, 73, 236, 119, 17, 171, 239, 17, 152, 38, 168, 17, 127, 235, 253, 11, 28, 27, 0, 219, 81, 47, 9, 81, 32, 204, 70, 197, 54, 108, 43, 135, 29, 112, 92, 47, 92, 37, 20, 150, 155, 36, 201, 210, 230, 85, 73, 27, 35, 214, 160, 113, 57, 82, 61, 188, 142, 240, 224 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "FF-28-72-0F-CD-F4-94-44-1E-E3-C1-39-43-AC-A3-38-14-5C-AC-13-02-4F-8D-F5-08-1F-86-68-70-1C-61-C4", new byte[] { 18, 137, 75, 186, 41, 218, 139, 245, 116, 96, 1, 61, 145, 166, 197, 29, 236, 139, 216, 206, 164, 112, 92, 180, 180, 83, 5, 25, 149, 15, 39, 88, 65, 123, 196, 142, 118, 82, 129, 76, 153, 115, 222, 61, 133, 57, 255, 146, 137, 42, 174, 104, 208, 34, 192, 174, 129, 54, 196, 242, 127, 14, 85, 248 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "7F-DC-AF-66-19-A3-9B-C1-D5-A9-06-29-F2-E2-08-6F-30-D8-7C-01-5E-10-AB-D2-3C-F5-6A-D3-B4-FA-17-8B", new byte[] { 66, 98, 157, 180, 46, 196, 45, 109, 33, 244, 207, 224, 174, 55, 109, 0, 123, 224, 245, 101, 77, 19, 54, 22, 117, 156, 103, 82, 134, 34, 130, 161, 151, 220, 162, 119, 179, 144, 37, 180, 242, 80, 249, 132, 183, 43, 62, 151, 198, 148, 30, 254, 96, 62, 171, 152, 190, 25, 242, 34, 158, 253, 221, 98 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "E2-00-CB-75-7E-5C-FF-A3-C0-9E-8E-BE-12-B6-B8-B0-49-61-8B-C1-56-16-1E-44-77-AB-21-F3-DA-F6-A1-89", new byte[] { 23, 16, 95, 16, 80, 50, 8, 46, 122, 32, 105, 76, 46, 210, 86, 61, 230, 6, 26, 142, 57, 208, 210, 9, 121, 92, 237, 161, 134, 176, 27, 61, 50, 204, 116, 65, 228, 233, 70, 239, 237, 150, 202, 19, 221, 79, 205, 186, 73, 205, 9, 135, 39, 85, 190, 135, 3, 143, 250, 3, 67, 31, 184, 158 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "EB-9F-8D-F7-B5-A6-62-8B-98-F0-78-79-1F-49-01-32-9C-33-1B-B9-B8-A1-82-CB-5C-9A-A5-89-95-AE-3F-2D", new byte[] { 34, 113, 123, 29, 118, 32, 44, 131, 0, 154, 248, 140, 156, 247, 60, 141, 255, 96, 150, 17, 32, 6, 127, 47, 224, 232, 75, 75, 250, 153, 220, 67, 247, 208, 14, 218, 198, 250, 128, 220, 209, 4, 187, 142, 71, 24, 249, 234, 116, 202, 128, 231, 251, 19, 134, 204, 162, 248, 18, 243, 64, 160, 94, 234 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "E5-72-6F-9B-E9-17-C3-59-AC-4D-38-7A-77-44-2B-10-0F-27-5F-F4-09-DF-EE-CD-05-A8-E6-55-8B-4B-40-92", new byte[] { 198, 148, 131, 129, 107, 106, 233, 98, 177, 121, 251, 135, 94, 220, 122, 198, 35, 16, 177, 48, 187, 179, 95, 197, 216, 206, 186, 111, 47, 244, 94, 168, 247, 52, 152, 93, 241, 34, 98, 66, 93, 214, 226, 77, 32, 56, 238, 242, 202, 38, 30, 119, 120, 75, 20, 137, 213, 77, 254, 121, 42, 19, 22, 128 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "01-9A-E5-62-DD-E6-A0-3E-07-60-27-E0-39-3B-77-65-93-AE-44-AC-E7-12-50-B4-D1-7C-DF-9B-29-3A-C0-82", new byte[] { 59, 127, 193, 50, 244, 13, 162, 176, 68, 53, 51, 172, 255, 148, 122, 143, 123, 252, 221, 220, 19, 24, 64, 202, 208, 7, 9, 244, 210, 166, 247, 229, 102, 108, 180, 59, 36, 232, 171, 145, 154, 65, 140, 15, 210, 32, 69, 208, 225, 242, 219, 156, 28, 249, 149, 27, 93, 185, 52, 65, 188, 210, 5, 103 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "1A-F5-D2-A0-0D-35-D9-BB-7A-82-5E-E9-35-09-AA-4D-92-E1-0E-8B-27-9D-5B-69-3E-8D-9B-09-DC-64-DC-2E", new byte[] { 60, 250, 214, 245, 229, 9, 229, 243, 164, 63, 125, 247, 190, 189, 125, 133, 245, 163, 65, 114, 13, 76, 96, 193, 108, 127, 68, 38, 14, 196, 184, 19, 179, 224, 100, 98, 179, 86, 8, 228, 66, 182, 36, 88, 9, 34, 62, 68, 217, 195, 74, 96, 46, 102, 216, 15, 129, 6, 218, 82, 88, 164, 164, 41 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "8F-01-FA-1C-60-98-50-CB-B5-8E-18-33-8B-A9-0E-16-10-20-6C-8C-7A-AE-20-E8-A6-29-7E-01-C4-67-CE-10", new byte[] { 64, 228, 117, 6, 174, 81, 174, 18, 143, 253, 18, 253, 197, 161, 37, 254, 159, 168, 229, 153, 152, 154, 51, 103, 205, 179, 58, 75, 122, 121, 160, 25, 39, 127, 152, 157, 32, 42, 101, 237, 54, 104, 149, 47, 42, 253, 67, 90, 41, 98, 6, 134, 160, 71, 204, 252, 125, 231, 101, 140, 121, 58, 11, 156 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100004,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "56-5D-26-3E-BE-1D-8D-3E-48-90-AD-3A-36-2A-66-3B-D5-57-82-3A-BC-FD-2E-E1-F6-AA-BB-66-D3-C9-90-3E", new byte[] { 116, 137, 52, 90, 252, 213, 248, 190, 67, 90, 211, 137, 124, 3, 61, 95, 137, 24, 135, 235, 117, 87, 191, 7, 199, 52, 111, 172, 176, 33, 124, 34, 229, 153, 164, 88, 25, 202, 183, 225, 88, 14, 153, 44, 219, 1, 119, 68, 193, 242, 182, 60, 204, 60, 48, 83, 10, 217, 2, 221, 45, 62, 100, 125 } });

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0a9c8263-7f5e-4e25-bb85-7a4c0a1e3a5c"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 0, 7, 12, 403, DateTimeKind.Utc).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0bb3c011-9ba9-47e7-9ce0-3268f85e1ffc"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 0, 7, 12, 403, DateTimeKind.Utc).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("18a64e64-3707-451c-b54d-51dbb9933aa0"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 0, 7, 12, 403, DateTimeKind.Utc).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("1b234567-89ab-cdef-0123-456789abcdef"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 0, 7, 12, 403, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("2b7c5a63-8e93-4d88-bc90-85c42d1574ae"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 0, 7, 12, 403, DateTimeKind.Utc).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("34f2c84e-6c77-4c4a-b5f3-eef62d87b4be"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 0, 7, 12, 403, DateTimeKind.Utc).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("3d8f49b2-ef8b-4b3e-8f5d-1f68d8f4f4b1"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 0, 7, 12, 403, DateTimeKind.Utc).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("4d8d76aa-48e5-4c2b-95f1-5a77c73c0f11"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 0, 7, 12, 403, DateTimeKind.Utc).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("59259348-41da-4bbc-b85c-48ee82f474ce"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 0, 7, 12, 403, DateTimeKind.Utc).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5a6e8d59-0c3d-4e54-a105-50f44dcb9e4b"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 0, 7, 12, 403, DateTimeKind.Utc).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5e4f2822-bb47-45b4-83c0-6c1de2b5f900"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 0, 7, 12, 403, DateTimeKind.Utc).AddTicks(3723));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("72b24a8d-4e5b-43e5-aeae-ecf9dc1b52d9"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 0, 7, 12, 403, DateTimeKind.Utc).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("7f1f7c59-f92e-4c3b-a3f4-9c2a4cd474cb"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 0, 7, 12, 403, DateTimeKind.Utc).AddTicks(3686));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8b5c0f77-e3f1-4972-9102-6c1dfbb5a601"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 0, 7, 12, 403, DateTimeKind.Utc).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8d5c8e30-dede-4ef0-9158-f7692c41acb2"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 0, 7, 12, 403, DateTimeKind.Utc).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9b7f3e43-50bc-41d5-8f43-b8e0e1f47732"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 0, 7, 12, 403, DateTimeKind.Utc).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e7b22d3-c5a5-429e-82dc-e5c573745e1d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 0, 7, 12, 403, DateTimeKind.Utc).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("c7f1f4f5-74e3-4b4f-9c5a-3e2059d8b72d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 0, 7, 12, 403, DateTimeKind.Utc).AddTicks(3711));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("e43ff624-3f3c-4e8e-b5eb-11c0c3a244fa"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 0, 7, 12, 403, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("f3b00c12-3b5e-4c8e-9bb0-7a5c7408cd07"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 0, 7, 12, 403, DateTimeKind.Utc).AddTicks(3718));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c4f5e3e1-2c4c-4f4e-a4d1-5e5e6139d703"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 13, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(5245));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c9ebf2c7-5a7f-4b5d-bb7f-2f2c4d8e4a88"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 13, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("d3c4b5e8-1f3a-4c8c-897e-2d8cf3e7c4f6"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 13, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 13, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "0E-31-5C-CE-A0-D8-57-D8-4A-D2-11-FC-EB-78-55-84-3E-D8-9D-F6-A7-D3-89-87-05-01-13-40-AC-BE-2E-6C", new byte[] { 180, 28, 49, 63, 8, 88, 147, 233, 188, 50, 87, 164, 60, 228, 21, 3, 40, 92, 247, 213, 230, 245, 105, 166, 90, 0, 98, 81, 85, 54, 56, 172, 255, 101, 86, 162, 58, 145, 211, 87, 96, 86, 126, 222, 232, 196, 164, 228, 251, 215, 13, 216, 69, 162, 73, 79, 12, 72, 198, 222, 160, 33, 66, 113 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "23-56-56-BA-59-C9-E6-EF-57-1B-8A-EA-62-76-92-BB-66-DB-D0-B4-71-AA-5A-CA-ED-58-A6-57-95-31-46-51", new byte[] { 52, 1, 79, 241, 139, 40, 176, 146, 31, 123, 235, 254, 95, 86, 103, 246, 60, 19, 65, 58, 239, 147, 8, 144, 81, 80, 170, 226, 110, 205, 84, 228, 161, 23, 231, 35, 198, 18, 225, 156, 12, 242, 245, 251, 110, 244, 168, 72, 72, 118, 161, 237, 252, 32, 204, 109, 62, 94, 225, 222, 20, 199, 59, 80 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "AD-3E-A3-99-BF-43-51-F7-54-36-C9-1E-7F-2B-57-AC-FE-72-EE-28-4D-52-60-D7-D5-1A-E7-69-05-D9-B1-DB", new byte[] { 29, 4, 190, 66, 143, 160, 18, 114, 235, 196, 231, 6, 187, 153, 36, 92, 83, 194, 123, 7, 93, 30, 6, 242, 189, 58, 115, 146, 90, 251, 136, 50, 125, 254, 51, 93, 136, 166, 191, 64, 200, 7, 5, 42, 8, 213, 49, 72, 124, 207, 129, 211, 160, 25, 194, 203, 35, 122, 234, 188, 27, 242, 198, 128 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "EE-95-77-11-F9-1B-6C-0C-31-A2-EA-11-38-C9-4B-C3-A9-1A-1D-40-47-65-A3-85-8B-2C-9C-0A-44-2B-20-7A", new byte[] { 92, 121, 165, 107, 120, 205, 136, 195, 94, 146, 16, 159, 66, 164, 34, 179, 37, 213, 211, 60, 1, 179, 197, 180, 35, 207, 242, 123, 68, 100, 75, 20, 126, 15, 86, 104, 101, 91, 175, 72, 180, 70, 3, 38, 245, 161, 151, 178, 127, 173, 227, 87, 160, 80, 166, 179, 31, 39, 54, 166, 52, 191, 103, 165 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "18-72-02-CB-65-5F-7D-F6-DD-51-41-EC-EF-5F-20-C6-83-4C-87-C1-4D-D6-49-2F-BE-8D-9E-01-96-04-AE-C1", new byte[] { 151, 28, 124, 168, 204, 72, 237, 0, 140, 210, 112, 245, 86, 234, 229, 37, 138, 79, 30, 247, 194, 225, 52, 161, 38, 11, 219, 137, 59, 181, 25, 53, 101, 125, 127, 18, 216, 64, 156, 161, 241, 188, 102, 86, 22, 76, 239, 253, 133, 75, 74, 139, 27, 197, 241, 197, 109, 144, 87, 201, 118, 169, 185, 127 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "8A-7E-46-B6-C0-E0-AD-AC-37-6E-BD-98-90-54-D9-03-98-25-65-80-46-05-45-16-C5-76-79-A3-9C-8E-CD-00", new byte[] { 45, 185, 206, 190, 161, 200, 107, 50, 39, 17, 193, 136, 86, 10, 96, 24, 234, 93, 96, 196, 198, 112, 42, 108, 246, 74, 47, 27, 187, 37, 209, 21, 17, 219, 83, 81, 88, 194, 113, 228, 32, 62, 231, 38, 118, 79, 63, 141, 222, 52, 157, 96, 123, 155, 191, 100, 135, 112, 83, 195, 140, 14, 133, 221 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "CD-57-43-8D-F5-BA-69-AB-78-EC-6D-D8-95-CD-77-F9-3A-C1-DC-8A-62-39-3E-04-C1-CC-7D-E7-C1-50-CF-81", new byte[] { 239, 157, 242, 99, 244, 94, 8, 201, 31, 171, 228, 26, 21, 102, 51, 101, 205, 76, 161, 92, 215, 184, 232, 51, 154, 199, 85, 190, 20, 146, 186, 95, 158, 216, 42, 108, 73, 205, 237, 46, 248, 2, 165, 193, 197, 166, 58, 193, 217, 127, 103, 39, 171, 75, 213, 136, 71, 78, 239, 140, 78, 9, 175, 222 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "6D-C4-D6-D7-11-E9-52-CF-D8-5C-01-BF-75-83-61-D2-7A-10-B2-17-4D-23-92-3F-A6-26-BC-4C-84-4A-DF-A5", new byte[] { 221, 241, 218, 85, 83, 34, 195, 92, 103, 231, 169, 146, 111, 95, 113, 162, 179, 37, 190, 125, 144, 248, 255, 83, 112, 207, 67, 36, 74, 81, 109, 121, 225, 248, 86, 234, 182, 37, 57, 174, 101, 162, 118, 178, 231, 66, 196, 12, 185, 246, 244, 58, 186, 109, 180, 73, 128, 161, 56, 135, 151, 201, 188, 83 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "1D-C7-BB-C9-B9-C7-64-06-07-EA-98-86-E1-45-A4-27-94-71-DF-74-5C-DA-36-52-29-BB-1B-40-A5-AC-E8-F9", new byte[] { 100, 130, 192, 243, 153, 84, 151, 201, 227, 71, 93, 42, 192, 64, 254, 53, 217, 82, 245, 157, 117, 249, 184, 142, 90, 65, 72, 102, 168, 227, 204, 128, 210, 208, 19, 199, 151, 177, 203, 39, 170, 194, 87, 219, 50, 204, 200, 150, 188, 206, 140, 78, 31, 211, 48, 21, 154, 207, 242, 225, 47, 122, 25, 46 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100004,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "8F-2B-22-36-AC-72-FC-F5-ED-83-33-7E-42-9C-6E-2B-61-4B-D5-82-B7-A8-90-E7-D3-A1-36-BD-AB-0F-03-E1", new byte[] { 110, 81, 34, 31, 111, 218, 200, 187, 78, 214, 119, 142, 237, 102, 0, 227, 94, 22, 212, 237, 131, 93, 210, 135, 247, 154, 93, 163, 19, 22, 180, 26, 63, 139, 60, 102, 0, 123, 128, 188, 126, 247, 45, 75, 190, 42, 222, 92, 141, 246, 3, 226, 161, 35, 8, 34, 127, 186, 3, 57, 182, 141, 53, 224 } });

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0a9c8263-7f5e-4e25-bb85-7a4c0a1e3a5c"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 13, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0bb3c011-9ba9-47e7-9ce0-3268f85e1ffc"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 13, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("18a64e64-3707-451c-b54d-51dbb9933aa0"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 12, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("1b234567-89ab-cdef-0123-456789abcdef"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 13, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("2b7c5a63-8e93-4d88-bc90-85c42d1574ae"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 13, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("34f2c84e-6c77-4c4a-b5f3-eef62d87b4be"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 12, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("3d8f49b2-ef8b-4b3e-8f5d-1f68d8f4f4b1"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 13, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("4d8d76aa-48e5-4c2b-95f1-5a77c73c0f11"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 13, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4932));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("59259348-41da-4bbc-b85c-48ee82f474ce"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 12, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5a6e8d59-0c3d-4e54-a105-50f44dcb9e4b"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 13, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5e4f2822-bb47-45b4-83c0-6c1de2b5f900"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 12, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("72b24a8d-4e5b-43e5-aeae-ecf9dc1b52d9"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 12, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("7f1f7c59-f92e-4c3b-a3f4-9c2a4cd474cb"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 13, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8b5c0f77-e3f1-4972-9102-6c1dfbb5a601"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 12, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4961));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8d5c8e30-dede-4ef0-9158-f7692c41acb2"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 12, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9b7f3e43-50bc-41d5-8f43-b8e0e1f47732"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 12, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e7b22d3-c5a5-429e-82dc-e5c573745e1d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 13, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("c7f1f4f5-74e3-4b4f-9c5a-3e2059d8b72d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 12, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4952));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("e43ff624-3f3c-4e8e-b5eb-11c0c3a244fa"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 13, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("f3b00c12-3b5e-4c8e-9bb0-7a5c7408cd07"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 12, 21, 0, 43, 113, DateTimeKind.Utc).AddTicks(4956));
        }
    }
}
