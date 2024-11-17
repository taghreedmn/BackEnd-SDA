using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class local : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c4f5e3e1-2c4c-4f4e-a4d1-5e5e6139d703"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c9ebf2c7-5a7f-4b5d-bb7f-2f2c4d8e4a88"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("d3c4b5e8-1f3a-4c8c-897e-2d8cf3e7c4f6"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "C0-98-36-8D-2E-AF-71-30-F9-05-BB-60-2C-73-01-7F-4E-45-73-59-5B-A1-7D-F7-11-0A-9B-03-87-FC-C9-98", new byte[] { 102, 174, 31, 251, 137, 114, 47, 46, 33, 56, 87, 88, 17, 231, 246, 114, 214, 63, 255, 37, 172, 76, 139, 40, 255, 109, 249, 126, 39, 64, 106, 209, 234, 92, 123, 76, 189, 195, 33, 6, 139, 127, 86, 226, 147, 177, 31, 253, 235, 20, 81, 88, 197, 72, 189, 16, 130, 203, 179, 75, 174, 70, 18, 48 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "5E-7D-90-60-BB-09-10-2F-47-22-6A-65-90-1C-8B-C9-79-16-04-D2-7B-79-BD-8D-F6-1A-A8-9C-29-2D-FF-65", new byte[] { 61, 77, 191, 139, 107, 186, 62, 17, 88, 6, 132, 94, 75, 34, 213, 179, 69, 40, 219, 168, 252, 115, 11, 133, 186, 139, 27, 183, 249, 145, 221, 175, 109, 250, 49, 74, 53, 161, 98, 135, 185, 66, 108, 48, 152, 205, 238, 166, 29, 48, 95, 114, 127, 140, 15, 16, 151, 141, 209, 238, 14, 64, 182, 158 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "44-81-DE-E4-F7-AE-4C-D4-FC-EE-CD-F9-A5-ED-A9-9C-16-F4-BF-6A-73-87-E9-DA-A4-87-F0-73-7E-47-9D-A2", new byte[] { 67, 8, 116, 39, 48, 10, 220, 79, 20, 136, 179, 48, 241, 255, 252, 15, 250, 130, 195, 252, 27, 255, 76, 5, 144, 188, 49, 128, 205, 74, 7, 5, 153, 123, 133, 116, 108, 69, 41, 49, 247, 163, 213, 210, 221, 43, 214, 189, 252, 81, 220, 83, 148, 159, 140, 46, 141, 196, 215, 253, 43, 135, 120, 60 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "12-EC-FB-7C-91-8F-C8-90-FF-6C-05-6B-87-27-51-1C-48-AF-26-60-9F-46-0E-41-11-C5-E2-9A-01-09-82-D0", new byte[] { 29, 242, 120, 58, 141, 50, 124, 237, 84, 189, 37, 199, 98, 153, 144, 219, 248, 195, 239, 139, 22, 240, 223, 151, 203, 73, 48, 76, 144, 96, 183, 122, 71, 103, 157, 84, 113, 15, 236, 47, 58, 218, 152, 87, 181, 178, 205, 240, 207, 70, 216, 149, 133, 108, 82, 126, 149, 228, 66, 188, 51, 240, 86, 177 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "AB-5C-7D-63-9A-3D-B4-DD-9A-DF-66-2F-95-CA-9A-67-A5-E3-DF-F9-A7-C4-31-D3-3C-AA-DC-D8-F5-50-5A-57", new byte[] { 117, 227, 177, 56, 160, 120, 63, 107, 14, 117, 74, 199, 163, 28, 170, 147, 70, 78, 192, 108, 41, 175, 164, 216, 181, 44, 118, 108, 154, 15, 80, 5, 96, 111, 221, 64, 226, 135, 95, 98, 213, 220, 182, 175, 29, 110, 157, 43, 227, 228, 217, 153, 62, 15, 1, 94, 76, 207, 241, 139, 164, 111, 114, 148 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "11-14-57-32-C3-6B-CD-F3-7C-55-C1-1D-BF-B6-1D-05-E6-29-88-C5-CA-A8-4C-44-2B-86-9A-C4-02-A8-B6-DD", new byte[] { 248, 225, 84, 189, 248, 10, 169, 170, 136, 84, 44, 29, 128, 16, 96, 135, 104, 200, 63, 14, 182, 199, 91, 181, 97, 37, 173, 173, 95, 140, 212, 111, 170, 2, 219, 140, 53, 50, 111, 153, 91, 223, 181, 27, 116, 140, 8, 95, 116, 229, 190, 222, 180, 177, 163, 20, 67, 98, 249, 229, 112, 203, 242, 59 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "37-BD-52-04-DD-B5-9B-D9-7C-74-EA-FE-24-52-71-41-5F-2C-CE-06-3B-30-06-4E-AA-0D-B6-F8-96-C6-B5-32", new byte[] { 34, 118, 153, 95, 253, 90, 87, 67, 208, 220, 82, 201, 192, 32, 160, 160, 219, 142, 75, 87, 147, 63, 133, 212, 41, 213, 145, 39, 135, 84, 127, 223, 50, 151, 189, 222, 106, 254, 100, 59, 220, 40, 73, 100, 129, 96, 132, 119, 128, 114, 23, 75, 38, 120, 77, 59, 103, 2, 217, 227, 39, 22, 209, 110 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "85-5C-7F-12-B1-C8-08-C4-D5-8A-CB-A2-68-90-B0-8D-E9-72-E5-5D-19-1C-D3-5D-67-18-6B-5A-EA-88-58-B2", new byte[] { 162, 82, 144, 174, 50, 131, 213, 42, 93, 83, 195, 76, 55, 88, 54, 226, 52, 38, 15, 83, 68, 146, 162, 235, 117, 72, 3, 148, 121, 229, 73, 254, 188, 100, 34, 218, 0, 17, 3, 217, 81, 26, 23, 0, 76, 207, 225, 224, 168, 163, 229, 24, 46, 188, 229, 243, 163, 27, 183, 39, 164, 104, 6, 222 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "D0-7E-8C-C7-FA-22-C3-11-B2-26-48-B8-EE-6C-1E-E1-85-80-F2-82-AB-56-9A-D6-09-57-B5-E9-3D-4D-F4-62", new byte[] { 4, 153, 89, 120, 170, 197, 201, 21, 124, 174, 174, 102, 202, 181, 179, 0, 27, 239, 69, 74, 57, 2, 42, 94, 176, 10, 232, 193, 177, 181, 252, 153, 193, 194, 173, 97, 111, 218, 70, 226, 16, 117, 110, 232, 88, 157, 160, 34, 73, 121, 3, 121, 2, 64, 143, 252, 163, 189, 185, 141, 136, 73, 246, 185 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100004,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "75-35-D8-A2-6F-11-A2-39-EA-DA-88-7A-38-06-9E-A1-2F-2F-09-75-C0-2E-2C-B8-B5-98-E7-17-AC-47-42-B0", new byte[] { 77, 189, 142, 84, 38, 38, 153, 68, 86, 61, 57, 11, 108, 167, 205, 171, 168, 4, 192, 213, 104, 207, 45, 29, 219, 40, 195, 205, 90, 2, 109, 70, 11, 128, 51, 26, 242, 185, 210, 233, 93, 158, 233, 205, 111, 96, 141, 2, 199, 123, 62, 213, 127, 185, 179, 73, 76, 96, 219, 188, 104, 164, 242, 100 } });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: new Guid("12ba59b8-6c30-4864-9d48-0f95bd278b40"),
                column: "PublisherPicturePath",
                value: "http://localhost:5125/images/Publishers/12ba59b8-6c30-4864-9d48-0f95bd278b40/12ba59b8-6c30-4864-9d48-0f95bd278b40.jpg");

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: new Guid("df5d8791-98b3-445d-8120-07b33695da10"),
                column: "PublisherPicturePath",
                value: "http://localhost:5125/images/Publishers/df5d8791-98b3-445d-8120-07b33695da10/df5d8791-98b3-445d-8120-07b33695da10.png");

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: new Guid("f5ea9a66-8a49-4f1f-ae5d-09ce38a7c80d"),
                column: "PublisherPicturePath",
                value: "http://localhost:5125/images/Publishers/f5ea9a66-8a49-4f1f-ae5d-09ce38a7c80d/f5ea9a66-8a49-4f1f-ae5d-09ce38a7c80d.jpg");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("0b4ad2e6-b78c-47a8-bf70-fb667cb7a138"),
                column: "StudioPicturePath",
                value: "http://localhost:5125/images/Studios/0b4ad2e6-b78c-47a8-bf70-fb667cb7a138/0b4ad2e6-b78c-47a8-bf70-fb667cb7a138.png");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("5502bbf3-535e-4042-85b8-052b35594542"),
                column: "StudioPicturePath",
                value: "http://localhost:5125/images/Studios/5502bbf3-535e-4042-85b8-052b35594542/5502bbf3-535e-4042-85b8-052b35594542.jpg");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("646e4c3c-bfc2-41dc-9f49-14b7905516b8"),
                column: "StudioPicturePath",
                value: "http://localhost:5125/images/Studios/646e4c3c-bfc2-41dc-9f49-14b7905516b8/646e4c3c-bfc2-41dc-9f49-14b7905516b8.png");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("727cffb5-6ba3-4a56-a1eb-fe1962c8f044"),
                column: "StudioPicturePath",
                value: "http://localhost:5125/images/Studios/727cffb5-6ba3-4a56-a1eb-fe1962c8f044/727cffb5-6ba3-4a56-a1eb-fe1962c8f044.jpg");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("86b47e62-089e-4f3e-b9c4-f29ea6720fd0"),
                column: "StudioPicturePath",
                value: "http://localhost:5125/images/Studios/86b47e62-089e-4f3e-b9c4-f29ea6720fd0/86b47e62-089e-4f3e-b9c4-f29ea6720fd0.png");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("8720de28-1bf5-49ad-b272-ddfee747f22c"),
                column: "StudioPicturePath",
                value: "http://localhost:5125/images/Studios/8720de28-1bf5-49ad-b272-ddfee747f22c/8720de28-1bf5-49ad-b272-ddfee747f22c.jpg");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("9fc928ce-aa2a-4e7b-816d-b3468ea552ed"),
                column: "StudioPicturePath",
                value: "http://localhost:5125/images/Studios/9fc928ce-aa2a-4e7b-816d-b3468ea552ed/9fc928ce-aa2a-4e7b-816d-b3468ea552ed.jpg");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("bbd8f143-d7e1-41ef-9702-9bfb27567b80"),
                column: "StudioPicturePath",
                value: "http://localhost:5125/images/Studios/bbd8f143-d7e1-41ef-9702-9bfb27567b80/bbd8f143-d7e1-41ef-9702-9bfb27567b80.png");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("bfe21050-cd59-4feb-ab5e-459031e4b3f3"),
                column: "StudioPicturePath",
                value: "http://localhost:5125/images/Studios/bfe21050-cd59-4feb-ab5e-459031e4b3f3/bfe21050-cd59-4feb-ab5e-459031e4b3f3.png");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("cf04439e-6b5d-406f-b2e1-a5616a3aee8a"),
                column: "StudioPicturePath",
                value: "http://localhost:5125/images/Studios/cf04439e-6b5d-406f-b2e1-a5616a3aee8a/cf04439e-6b5d-406f-b2e1-a5616a3aee8a.png");

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0a9c8263-7f5e-4e25-bb85-7a4c0a1e3a5c"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0bb3c011-9ba9-47e7-9ce0-3268f85e1ffc"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("18a64e64-3707-451c-b54d-51dbb9933aa0"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("1b234567-89ab-cdef-0123-456789abcdef"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("2b7c5a63-8e93-4d88-bc90-85c42d1574ae"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("34f2c84e-6c77-4c4a-b5f3-eef62d87b4be"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("3d8f49b2-ef8b-4b3e-8f5d-1f68d8f4f4b1"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("4d8d76aa-48e5-4c2b-95f1-5a77c73c0f11"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("59259348-41da-4bbc-b85c-48ee82f474ce"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5a6e8d59-0c3d-4e54-a105-50f44dcb9e4b"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5e4f2822-bb47-45b4-83c0-6c1de2b5f900"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("72b24a8d-4e5b-43e5-aeae-ecf9dc1b52d9"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("7f1f7c59-f92e-4c3b-a3f4-9c2a4cd474cb"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8b5c0f77-e3f1-4972-9102-6c1dfbb5a601"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8d5c8e30-dede-4ef0-9158-f7692c41acb2"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9b7f3e43-50bc-41d5-8f43-b8e0e1f47732"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e7b22d3-c5a5-429e-82dc-e5c573745e1d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("c7f1f4f5-74e3-4b4f-9c5a-3e2059d8b72d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("e43ff624-3f3c-4e8e-b5eb-11c0c3a244fa"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("f3b00c12-3b5e-4c8e-9bb0-7a5c7408cd07"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 16, 37, 35, 326, DateTimeKind.Utc).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23"),
                column: "GamePicturePath",
                value: "http://localhost:5125/images/Games/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("02b0bb70-4fc8-4c72-86a7-731f4332b9a5"),
                column: "GamePicturePath",
                value: "http://localhost:5125/images/Games/02b0bb70-4fc8-4c72-86a7-731f4332b9a5/02b0bb70-4fc8-4c72-86a7-731f4332b9a5.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("0ce33067-7091-4c51-a1c4-3a93751c748c"),
                column: "GamePicturePath",
                value: "http://localhost:5125/images/Games/0ce33067-7091-4c51-a1c4-3a93751c748c/0ce33067-7091-4c51-a1c4-3a93751c748c.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("338b764e-b0f1-4969-89c8-164ca308e226"),
                column: "GamePicturePath",
                value: "http://localhost:5125/images/Games/338b764e-b0f1-4969-89c8-164ca308e226/338b764e-b0f1-4969-89c8-164ca308e226.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("339b171d-1256-4569-a330-506e46bb06c6"),
                column: "GamePicturePath",
                value: "http://localhost:5125/images/Games/339b171d-1256-4569-a330-506e46bb06c6/339b171d-1256-4569-a330-506e46bb06c6.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("426a499a-41c1-4763-a615-fca426836e3f"),
                column: "GamePicturePath",
                value: "http://localhost:5125/images/Games/426a499a-41c1-4763-a615-fca426836e3f/426a499a-41c1-4763-a615-fca426836e3f.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("4cdb49aa-17a7-4029-a50a-e01f5aa5fd3c"),
                column: "GamePicturePath",
                value: "http://localhost:5125/images/Games/4cdb49aa-17a7-4029-a50a-e01f5aa5fd3c/4cdb49aa-17a7-4029-a50a-e01f5aa5fd3c.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("7248c5a6-49e0-4f88-be50-8d87a54c938f"),
                column: "GamePicturePath",
                value: "http://localhost:5125/images/Games/7248c5a6-49e0-4f88-be50-8d87a54c938f/7248c5a6-49e0-4f88-be50-8d87a54c938f.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("72daabe6-62ec-4657-8e27-3ef881adcdd0"),
                column: "GamePicturePath",
                value: "http://localhost:5125/images/Games/72daabe6-62ec-4657-8e27-3ef881adcdd0/72daabe6-62ec-4657-8e27-3ef881adcdd0.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("7fe582b8-0308-48d8-8173-800102aebcfb"),
                column: "GamePicturePath",
                value: "http://localhost:5125/images/Games/7fe582b8-0308-48d8-8173-800102aebcfb/7fe582b8-0308-48d8-8173-800102aebcfb.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("9215201e-133d-43e1-b9b8-7b73ac3327c5"),
                column: "GamePicturePath",
                value: "http://localhost:5125/images/Games/9215201e-133d-43e1-b9b8-7b73ac3327c5/9215201e-133d-43e1-b9b8-7b73ac3327c5.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("96ae6e7a-5c53-4ded-bf98-6a791f1ebdd3"),
                column: "GamePicturePath",
                value: "http://localhost:5125/images/Games/96ae6e7a-5c53-4ded-bf98-6a791f1ebdd3/96ae6e7a-5c53-4ded-bf98-6a791f1ebdd3.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("a0ed6f38-b3e3-4090-86f1-40c09cdaaecd"),
                column: "GamePicturePath",
                value: "http://localhost:5125/images/Games/a0ed6f38-b3e3-4090-86f1-40c09cdaaecd/a0ed6f38-b3e3-4090-86f1-40c09cdaaecd.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("c5618a1b-eef8-43ec-aa1b-25415fb5bc2f"),
                column: "GamePicturePath",
                value: "http://localhost:5125/images/Games/c5618a1b-eef8-43ec-aa1b-25415fb5bc2f/c5618a1b-eef8-43ec-aa1b-25415fb5bc2f.png");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("d6cd4ffd-62d1-41e6-b6b4-5a05babb8d45"),
                column: "GamePicturePath",
                value: "http://localhost:5125/images/Games/d6cd4ffd-62d1-41e6-b6b4-5a05babb8d45/d6cd4ffd-62d1-41e6-b6b4-5a05babb8d45.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("dce59101-3621-461e-bf10-61807163a946"),
                column: "GamePicturePath",
                value: "http://localhost:5125/images/Games/dce59101-3621-461e-bf10-61807163a946/dce59101-3621-461e-bf10-61807163a946.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("e09688b3-257e-413f-9ef4-0f4a9916a2c7"),
                column: "GamePicturePath",
                value: "http://localhost:5125/images/Games/e09688b3-257e-413f-9ef4-0f4a9916a2c7/e09688b3-257e-413f-9ef4-0f4a9916a2c7.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("e439131b-d595-48e3-8873-be55a1357748"),
                column: "GamePicturePath",
                value: "http://localhost:5125/images/Games/e439131b-d595-48e3-8873-be55a1357748/e439131b-d595-48e3-8873-be55a1357748.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("e5a9c78f-863e-428d-81a5-3b2d4ce62494"),
                column: "GamePicturePath",
                value: "http://localhost:5125/images/Games/e5a9c78f-863e-428d-81a5-3b2d4ce62494/e5a9c78f-863e-428d-81a5-3b2d4ce62494.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("ee4836d4-d131-47fe-b741-3c104f14df71"),
                column: "GamePicturePath",
                value: "http://localhost:5125/images/Games/ee4836d4-d131-47fe-b741-3c104f14df71/ee4836d4-d131-47fe-b741-3c104f14df71.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: new Guid("12ba59b8-6c30-4864-9d48-0f95bd278b40"),
                column: "PublisherPicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Publishers/12ba59b8-6c30-4864-9d48-0f95bd278b40/12ba59b8-6c30-4864-9d48-0f95bd278b40.jpg");

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: new Guid("df5d8791-98b3-445d-8120-07b33695da10"),
                column: "PublisherPicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Publishers/df5d8791-98b3-445d-8120-07b33695da10/df5d8791-98b3-445d-8120-07b33695da10.png");

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: new Guid("f5ea9a66-8a49-4f1f-ae5d-09ce38a7c80d"),
                column: "PublisherPicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Publishers/f5ea9a66-8a49-4f1f-ae5d-09ce38a7c80d/f5ea9a66-8a49-4f1f-ae5d-09ce38a7c80d.jpg");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("0b4ad2e6-b78c-47a8-bf70-fb667cb7a138"),
                column: "StudioPicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Studios/0b4ad2e6-b78c-47a8-bf70-fb667cb7a138/0b4ad2e6-b78c-47a8-bf70-fb667cb7a138.png");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("5502bbf3-535e-4042-85b8-052b35594542"),
                column: "StudioPicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Studios/5502bbf3-535e-4042-85b8-052b35594542/5502bbf3-535e-4042-85b8-052b35594542.jpg");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("646e4c3c-bfc2-41dc-9f49-14b7905516b8"),
                column: "StudioPicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Studios/646e4c3c-bfc2-41dc-9f49-14b7905516b8/646e4c3c-bfc2-41dc-9f49-14b7905516b8.png");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("727cffb5-6ba3-4a56-a1eb-fe1962c8f044"),
                column: "StudioPicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Studios/727cffb5-6ba3-4a56-a1eb-fe1962c8f044/727cffb5-6ba3-4a56-a1eb-fe1962c8f044.jpg");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("86b47e62-089e-4f3e-b9c4-f29ea6720fd0"),
                column: "StudioPicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Studios/86b47e62-089e-4f3e-b9c4-f29ea6720fd0/86b47e62-089e-4f3e-b9c4-f29ea6720fd0.png");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("8720de28-1bf5-49ad-b272-ddfee747f22c"),
                column: "StudioPicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Studios/8720de28-1bf5-49ad-b272-ddfee747f22c/8720de28-1bf5-49ad-b272-ddfee747f22c.jpg");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("9fc928ce-aa2a-4e7b-816d-b3468ea552ed"),
                column: "StudioPicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Studios/9fc928ce-aa2a-4e7b-816d-b3468ea552ed/9fc928ce-aa2a-4e7b-816d-b3468ea552ed.jpg");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("bbd8f143-d7e1-41ef-9702-9bfb27567b80"),
                column: "StudioPicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Studios/bbd8f143-d7e1-41ef-9702-9bfb27567b80/bbd8f143-d7e1-41ef-9702-9bfb27567b80.png");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("bfe21050-cd59-4feb-ab5e-459031e4b3f3"),
                column: "StudioPicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Studios/bfe21050-cd59-4feb-ab5e-459031e4b3f3/bfe21050-cd59-4feb-ab5e-459031e4b3f3.png");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("cf04439e-6b5d-406f-b2e1-a5616a3aee8a"),
                column: "StudioPicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Studios/cf04439e-6b5d-406f-b2e1-a5616a3aee8a/cf04439e-6b5d-406f-b2e1-a5616a3aee8a.png");

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

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("02b0bb70-4fc8-4c72-86a7-731f4332b9a5"),
                column: "GamePicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Games/02b0bb70-4fc8-4c72-86a7-731f4332b9a5/02b0bb70-4fc8-4c72-86a7-731f4332b9a5.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("0ce33067-7091-4c51-a1c4-3a93751c748c"),
                column: "GamePicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Games/0ce33067-7091-4c51-a1c4-3a93751c748c/0ce33067-7091-4c51-a1c4-3a93751c748c.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("338b764e-b0f1-4969-89c8-164ca308e226"),
                column: "GamePicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Games/338b764e-b0f1-4969-89c8-164ca308e226/338b764e-b0f1-4969-89c8-164ca308e226.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("339b171d-1256-4569-a330-506e46bb06c6"),
                column: "GamePicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Games/339b171d-1256-4569-a330-506e46bb06c6/339b171d-1256-4569-a330-506e46bb06c6.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("426a499a-41c1-4763-a615-fca426836e3f"),
                column: "GamePicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Games/426a499a-41c1-4763-a615-fca426836e3f/426a499a-41c1-4763-a615-fca426836e3f.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("4cdb49aa-17a7-4029-a50a-e01f5aa5fd3c"),
                column: "GamePicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Games/4cdb49aa-17a7-4029-a50a-e01f5aa5fd3c/4cdb49aa-17a7-4029-a50a-e01f5aa5fd3c.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("7248c5a6-49e0-4f88-be50-8d87a54c938f"),
                column: "GamePicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Games/7248c5a6-49e0-4f88-be50-8d87a54c938f/7248c5a6-49e0-4f88-be50-8d87a54c938f.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("72daabe6-62ec-4657-8e27-3ef881adcdd0"),
                column: "GamePicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Games/72daabe6-62ec-4657-8e27-3ef881adcdd0/72daabe6-62ec-4657-8e27-3ef881adcdd0.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("7fe582b8-0308-48d8-8173-800102aebcfb"),
                column: "GamePicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Games/7fe582b8-0308-48d8-8173-800102aebcfb/7fe582b8-0308-48d8-8173-800102aebcfb.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("9215201e-133d-43e1-b9b8-7b73ac3327c5"),
                column: "GamePicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Games/9215201e-133d-43e1-b9b8-7b73ac3327c5/9215201e-133d-43e1-b9b8-7b73ac3327c5.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("96ae6e7a-5c53-4ded-bf98-6a791f1ebdd3"),
                column: "GamePicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Games/96ae6e7a-5c53-4ded-bf98-6a791f1ebdd3/96ae6e7a-5c53-4ded-bf98-6a791f1ebdd3.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("a0ed6f38-b3e3-4090-86f1-40c09cdaaecd"),
                column: "GamePicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Games/a0ed6f38-b3e3-4090-86f1-40c09cdaaecd/a0ed6f38-b3e3-4090-86f1-40c09cdaaecd.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("c5618a1b-eef8-43ec-aa1b-25415fb5bc2f"),
                column: "GamePicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Games/c5618a1b-eef8-43ec-aa1b-25415fb5bc2f/c5618a1b-eef8-43ec-aa1b-25415fb5bc2f.png");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("d6cd4ffd-62d1-41e6-b6b4-5a05babb8d45"),
                column: "GamePicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Games/d6cd4ffd-62d1-41e6-b6b4-5a05babb8d45/d6cd4ffd-62d1-41e6-b6b4-5a05babb8d45.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("dce59101-3621-461e-bf10-61807163a946"),
                column: "GamePicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Games/dce59101-3621-461e-bf10-61807163a946/dce59101-3621-461e-bf10-61807163a946.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("e09688b3-257e-413f-9ef4-0f4a9916a2c7"),
                column: "GamePicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Games/e09688b3-257e-413f-9ef4-0f4a9916a2c7/e09688b3-257e-413f-9ef4-0f4a9916a2c7.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("e439131b-d595-48e3-8873-be55a1357748"),
                column: "GamePicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Games/e439131b-d595-48e3-8873-be55a1357748/e439131b-d595-48e3-8873-be55a1357748.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("e5a9c78f-863e-428d-81a5-3b2d4ce62494"),
                column: "GamePicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Games/e5a9c78f-863e-428d-81a5-3b2d4ce62494/e5a9c78f-863e-428d-81a5-3b2d4ce62494.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("ee4836d4-d131-47fe-b741-3c104f14df71"),
                column: "GamePicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Games/ee4836d4-d131-47fe-b741-3c104f14df71/ee4836d4-d131-47fe-b741-3c104f14df71.jpg");
        }
    }
}
