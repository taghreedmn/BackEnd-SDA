using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class newChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c4f5e3e1-2c4c-4f4e-a4d1-5e5e6139d703"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 3, 15, 30, 956, DateTimeKind.Utc).AddTicks(937));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c9ebf2c7-5a7f-4b5d-bb7f-2f2c4d8e4a88"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 3, 15, 30, 956, DateTimeKind.Utc).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("d3c4b5e8-1f3a-4c8c-897e-2d8cf3e7c4f6"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 3, 15, 30, 956, DateTimeKind.Utc).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 3, 15, 30, 956, DateTimeKind.Utc).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "97-5B-04-47-C7-48-71-66-FB-DB-5C-97-16-E1-DA-B6-57-E9-B4-26-19-82-87-B6-2B-68-96-1D-26-9F-9C-56", new byte[] { 241, 229, 227, 121, 30, 59, 121, 64, 56, 63, 113, 40, 62, 184, 123, 178, 42, 106, 235, 137, 255, 75, 2, 251, 157, 115, 119, 211, 174, 158, 87, 105, 223, 1, 182, 227, 220, 170, 133, 65, 135, 41, 244, 182, 126, 214, 42, 125, 241, 241, 118, 200, 252, 63, 189, 225, 116, 190, 245, 148, 116, 122, 84, 159 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "88-26-C1-44-31-CF-D7-5A-2F-65-A6-C5-87-DC-E3-5C-6F-69-81-7C-95-E0-84-BC-8E-5A-12-BF-E0-08-06-AF", new byte[] { 216, 39, 86, 112, 208, 108, 112, 97, 195, 84, 199, 192, 101, 12, 179, 113, 40, 192, 123, 102, 56, 186, 155, 52, 233, 175, 55, 37, 22, 180, 139, 240, 177, 31, 185, 4, 236, 204, 111, 212, 22, 115, 20, 59, 28, 151, 223, 107, 199, 133, 113, 139, 8, 113, 151, 140, 9, 132, 120, 102, 224, 149, 57, 162 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "8F-36-CF-52-45-53-67-43-55-64-17-B9-72-2B-FC-93-AB-50-B4-19-0B-33-44-C2-A6-65-83-99-28-A5-7F-A4", new byte[] { 150, 23, 23, 86, 82, 8, 221, 75, 12, 173, 207, 42, 213, 38, 83, 81, 223, 158, 230, 48, 90, 222, 79, 48, 143, 198, 219, 245, 17, 15, 21, 149, 30, 209, 193, 249, 219, 160, 80, 135, 52, 1, 130, 212, 71, 196, 181, 164, 9, 144, 248, 229, 85, 59, 109, 54, 61, 161, 162, 51, 243, 78, 122, 28 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "E5-9B-81-A1-F9-55-F9-9B-ED-66-18-6E-5E-48-23-CD-6A-78-66-33-25-08-B3-75-08-18-23-97-69-6E-97-DB", new byte[] { 152, 36, 41, 212, 42, 127, 36, 76, 70, 243, 221, 170, 104, 73, 70, 76, 33, 2, 222, 142, 217, 31, 120, 209, 230, 85, 184, 196, 182, 110, 9, 191, 20, 159, 40, 59, 211, 3, 29, 121, 22, 153, 203, 26, 40, 94, 153, 137, 4, 141, 181, 156, 88, 160, 106, 61, 46, 84, 165, 199, 122, 118, 89, 216 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "1E-5C-7D-16-82-AF-0D-F0-BD-70-39-4A-8C-B8-40-2A-7E-6B-BB-AA-39-44-46-22-56-72-03-40-B5-DA-62-2B", new byte[] { 130, 239, 40, 134, 46, 57, 106, 46, 218, 200, 129, 101, 245, 131, 230, 97, 11, 229, 152, 10, 40, 200, 225, 19, 207, 71, 187, 132, 93, 188, 63, 17, 88, 100, 148, 82, 185, 198, 209, 158, 6, 67, 47, 15, 92, 122, 183, 55, 4, 243, 181, 206, 196, 215, 182, 247, 184, 8, 199, 35, 83, 144, 215, 107 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "3C-EE-35-39-A3-65-8C-EC-7B-DC-F3-44-52-8A-1E-8E-C1-7E-81-8D-E5-9D-9D-82-48-DD-2D-E8-E1-AC-77-40", new byte[] { 44, 16, 242, 99, 246, 158, 53, 61, 54, 181, 40, 50, 27, 179, 67, 96, 187, 107, 239, 237, 191, 175, 36, 31, 224, 46, 123, 241, 87, 108, 223, 253, 249, 3, 184, 214, 68, 166, 243, 215, 161, 244, 214, 192, 180, 195, 191, 65, 119, 225, 133, 119, 46, 0, 128, 191, 207, 72, 235, 64, 182, 197, 27, 23 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "8E-49-88-74-84-C4-F7-E4-C9-A0-E3-F3-BF-D2-90-BB-86-36-C4-EA-69-46-FE-D4-0F-F9-FA-15-40-01-35-9B", new byte[] { 149, 104, 142, 102, 123, 120, 0, 53, 31, 146, 208, 100, 164, 190, 153, 137, 103, 67, 50, 162, 88, 74, 175, 19, 208, 201, 208, 194, 67, 96, 79, 71, 70, 239, 212, 141, 114, 132, 221, 126, 161, 126, 184, 223, 179, 251, 239, 165, 92, 169, 154, 74, 73, 0, 149, 77, 22, 138, 198, 85, 78, 73, 101, 57 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "E4-E5-86-6F-3F-96-1E-1A-58-9C-EE-61-06-28-51-37-2A-E5-D9-BA-B1-6D-4C-04-8D-3B-E2-C7-8A-36-E5-C3", new byte[] { 1, 130, 94, 242, 165, 69, 144, 89, 92, 5, 6, 132, 52, 182, 192, 216, 98, 116, 38, 106, 104, 149, 236, 179, 191, 29, 92, 207, 241, 166, 13, 116, 15, 198, 62, 149, 78, 56, 204, 139, 14, 50, 210, 212, 244, 102, 55, 64, 212, 203, 168, 55, 77, 80, 99, 50, 62, 206, 73, 250, 58, 49, 78, 18 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "A4-2B-45-21-FF-97-69-CE-2E-40-35-B1-A8-CE-04-29-3E-ED-6A-95-33-05-CA-3D-30-87-2D-0B-2C-04-F0-59", new byte[] { 231, 212, 23, 41, 218, 122, 14, 114, 2, 33, 243, 147, 221, 148, 188, 194, 131, 197, 190, 200, 115, 178, 215, 198, 107, 176, 23, 7, 112, 90, 50, 192, 36, 79, 1, 24, 202, 198, 50, 154, 97, 48, 205, 85, 67, 144, 176, 180, 234, 14, 52, 29, 71, 168, 168, 173, 184, 25, 61, 104, 184, 73, 50, 156 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100004,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "BF-3F-0D-AD-EB-64-93-D1-D0-BF-AB-F0-5E-39-6C-D3-5C-33-65-D1-B6-1D-8A-A3-ED-81-02-DB-E8-1D-30-00", new byte[] { 255, 46, 63, 48, 79, 57, 212, 93, 249, 175, 20, 76, 40, 101, 181, 119, 8, 8, 29, 243, 190, 72, 169, 213, 124, 254, 109, 23, 0, 185, 253, 165, 120, 16, 80, 214, 21, 56, 54, 15, 122, 102, 61, 94, 234, 229, 79, 119, 125, 93, 24, 100, 158, 140, 11, 183, 132, 178, 126, 3, 215, 0, 203, 141 } });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: new Guid("12ba59b8-6c30-4864-9d48-0f95bd278b40"),
                column: "PublisherPicturePath",
                value: "https://fusiontech-h1ri.onrender.com/images/Publishers/12ba59b8-6c30-4864-9d48-0f95bd278b40/12ba59b8-6c30-4864-9d48-0f95bd278b40.jpg");

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: new Guid("df5d8791-98b3-445d-8120-07b33695da10"),
                column: "PublisherPicturePath",
                value: "https://fusiontech-h1ri.onrender.com/images/Publishers/df5d8791-98b3-445d-8120-07b33695da10/df5d8791-98b3-445d-8120-07b33695da10.png");

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: new Guid("f5ea9a66-8a49-4f1f-ae5d-09ce38a7c80d"),
                column: "PublisherPicturePath",
                value: "https://fusiontech-h1ri.onrender.com/images/Publishers/f5ea9a66-8a49-4f1f-ae5d-09ce38a7c80d/f5ea9a66-8a49-4f1f-ae5d-09ce38a7c80d.jpg");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("0b4ad2e6-b78c-47a8-bf70-fb667cb7a138"),
                column: "StudioPicturePath",
                value: "https://fusiontech-h1ri.onrender.com/images/Studios/0b4ad2e6-b78c-47a8-bf70-fb667cb7a138/0b4ad2e6-b78c-47a8-bf70-fb667cb7a138.png");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("5502bbf3-535e-4042-85b8-052b35594542"),
                column: "StudioPicturePath",
                value: "https://fusiontech-h1ri.onrender.com/images/Studios/5502bbf3-535e-4042-85b8-052b35594542/5502bbf3-535e-4042-85b8-052b35594542.jpg");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("646e4c3c-bfc2-41dc-9f49-14b7905516b8"),
                column: "StudioPicturePath",
                value: "https://fusiontech-h1ri.onrender.com/images/Studios/646e4c3c-bfc2-41dc-9f49-14b7905516b8/646e4c3c-bfc2-41dc-9f49-14b7905516b8.png");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("727cffb5-6ba3-4a56-a1eb-fe1962c8f044"),
                column: "StudioPicturePath",
                value: "https://fusiontech-h1ri.onrender.com/images/Studios/727cffb5-6ba3-4a56-a1eb-fe1962c8f044/727cffb5-6ba3-4a56-a1eb-fe1962c8f044.jpg");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("86b47e62-089e-4f3e-b9c4-f29ea6720fd0"),
                column: "StudioPicturePath",
                value: "https://fusiontech-h1ri.onrender.com/images/Studios/86b47e62-089e-4f3e-b9c4-f29ea6720fd0/86b47e62-089e-4f3e-b9c4-f29ea6720fd0.png");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("8720de28-1bf5-49ad-b272-ddfee747f22c"),
                column: "StudioPicturePath",
                value: "https://fusiontech-h1ri.onrender.com/images/Studios/8720de28-1bf5-49ad-b272-ddfee747f22c/8720de28-1bf5-49ad-b272-ddfee747f22c.jpg");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("9fc928ce-aa2a-4e7b-816d-b3468ea552ed"),
                column: "StudioPicturePath",
                value: "https://fusiontech-h1ri.onrender.com/images/Studios/9fc928ce-aa2a-4e7b-816d-b3468ea552ed/9fc928ce-aa2a-4e7b-816d-b3468ea552ed.jpg");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("bbd8f143-d7e1-41ef-9702-9bfb27567b80"),
                column: "StudioPicturePath",
                value: "https://fusiontech-h1ri.onrender.com/images/Studios/bbd8f143-d7e1-41ef-9702-9bfb27567b80/bbd8f143-d7e1-41ef-9702-9bfb27567b80.png");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("bfe21050-cd59-4feb-ab5e-459031e4b3f3"),
                column: "StudioPicturePath",
                value: "https://fusiontech-h1ri.onrender.com/images/Studios/bfe21050-cd59-4feb-ab5e-459031e4b3f3/bfe21050-cd59-4feb-ab5e-459031e4b3f3.png");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("cf04439e-6b5d-406f-b2e1-a5616a3aee8a"),
                column: "StudioPicturePath",
                value: "https://fusiontech-h1ri.onrender.com/images/Studios/cf04439e-6b5d-406f-b2e1-a5616a3aee8a/cf04439e-6b5d-406f-b2e1-a5616a3aee8a.png");

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0a9c8263-7f5e-4e25-bb85-7a4c0a1e3a5c"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 15, 30, 956, DateTimeKind.Utc).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0bb3c011-9ba9-47e7-9ce0-3268f85e1ffc"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 15, 30, 956, DateTimeKind.Utc).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("18a64e64-3707-451c-b54d-51dbb9933aa0"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 15, 30, 956, DateTimeKind.Utc).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("1b234567-89ab-cdef-0123-456789abcdef"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 15, 30, 956, DateTimeKind.Utc).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("2b7c5a63-8e93-4d88-bc90-85c42d1574ae"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 15, 30, 956, DateTimeKind.Utc).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("34f2c84e-6c77-4c4a-b5f3-eef62d87b4be"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 15, 30, 956, DateTimeKind.Utc).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("3d8f49b2-ef8b-4b3e-8f5d-1f68d8f4f4b1"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 15, 30, 956, DateTimeKind.Utc).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("4d8d76aa-48e5-4c2b-95f1-5a77c73c0f11"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 15, 30, 956, DateTimeKind.Utc).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("59259348-41da-4bbc-b85c-48ee82f474ce"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 15, 30, 956, DateTimeKind.Utc).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5a6e8d59-0c3d-4e54-a105-50f44dcb9e4b"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 15, 30, 956, DateTimeKind.Utc).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5e4f2822-bb47-45b4-83c0-6c1de2b5f900"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 15, 30, 956, DateTimeKind.Utc).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("72b24a8d-4e5b-43e5-aeae-ecf9dc1b52d9"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 15, 30, 956, DateTimeKind.Utc).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("7f1f7c59-f92e-4c3b-a3f4-9c2a4cd474cb"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 15, 30, 956, DateTimeKind.Utc).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8b5c0f77-e3f1-4972-9102-6c1dfbb5a601"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 15, 30, 956, DateTimeKind.Utc).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8d5c8e30-dede-4ef0-9158-f7692c41acb2"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 15, 30, 956, DateTimeKind.Utc).AddTicks(792));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9b7f3e43-50bc-41d5-8f43-b8e0e1f47732"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 15, 30, 956, DateTimeKind.Utc).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e7b22d3-c5a5-429e-82dc-e5c573745e1d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 15, 30, 956, DateTimeKind.Utc).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("c7f1f4f5-74e3-4b4f-9c5a-3e2059d8b72d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 15, 30, 956, DateTimeKind.Utc).AddTicks(795));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("e43ff624-3f3c-4e8e-b5eb-11c0c3a244fa"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 15, 30, 956, DateTimeKind.Utc).AddTicks(779));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("f3b00c12-3b5e-4c8e-9bb0-7a5c7408cd07"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 15, 30, 956, DateTimeKind.Utc).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23"),
                column: "GamePicturePath",
                value: "https://fusiontech-h1ri.onrender.com/images/Games/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("02b0bb70-4fc8-4c72-86a7-731f4332b9a5"),
                column: "GamePicturePath",
                value: "https://fusiontech-h1ri.onrender.com/images/Games/02b0bb70-4fc8-4c72-86a7-731f4332b9a5/02b0bb70-4fc8-4c72-86a7-731f4332b9a5.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("0ce33067-7091-4c51-a1c4-3a93751c748c"),
                column: "GamePicturePath",
                value: "https://fusiontech-h1ri.onrender.com/images/Games/0ce33067-7091-4c51-a1c4-3a93751c748c/0ce33067-7091-4c51-a1c4-3a93751c748c.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("338b764e-b0f1-4969-89c8-164ca308e226"),
                column: "GamePicturePath",
                value: "https://fusiontech-h1ri.onrender.com/images/Games/338b764e-b0f1-4969-89c8-164ca308e226/338b764e-b0f1-4969-89c8-164ca308e226.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("339b171d-1256-4569-a330-506e46bb06c6"),
                column: "GamePicturePath",
                value: "https://fusiontech-h1ri.onrender.com/images/Games/339b171d-1256-4569-a330-506e46bb06c6/339b171d-1256-4569-a330-506e46bb06c6.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("426a499a-41c1-4763-a615-fca426836e3f"),
                column: "GamePicturePath",
                value: "https://fusiontech-h1ri.onrender.com/images/Games/426a499a-41c1-4763-a615-fca426836e3f/426a499a-41c1-4763-a615-fca426836e3f.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("4cdb49aa-17a7-4029-a50a-e01f5aa5fd3c"),
                column: "GamePicturePath",
                value: "https://fusiontech-h1ri.onrender.com/images/Games/4cdb49aa-17a7-4029-a50a-e01f5aa5fd3c/4cdb49aa-17a7-4029-a50a-e01f5aa5fd3c.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("7248c5a6-49e0-4f88-be50-8d87a54c938f"),
                column: "GamePicturePath",
                value: "https://fusiontech-h1ri.onrender.com/images/Games/7248c5a6-49e0-4f88-be50-8d87a54c938f/7248c5a6-49e0-4f88-be50-8d87a54c938f.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("72daabe6-62ec-4657-8e27-3ef881adcdd0"),
                column: "GamePicturePath",
                value: "https://fusiontech-h1ri.onrender.com/images/Games/72daabe6-62ec-4657-8e27-3ef881adcdd0/72daabe6-62ec-4657-8e27-3ef881adcdd0.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("7fe582b8-0308-48d8-8173-800102aebcfb"),
                column: "GamePicturePath",
                value: "https://fusiontech-h1ri.onrender.com/images/Games/7fe582b8-0308-48d8-8173-800102aebcfb/7fe582b8-0308-48d8-8173-800102aebcfb.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("9215201e-133d-43e1-b9b8-7b73ac3327c5"),
                column: "GamePicturePath",
                value: "https://fusiontech-h1ri.onrender.com/images/Games/9215201e-133d-43e1-b9b8-7b73ac3327c5/9215201e-133d-43e1-b9b8-7b73ac3327c5.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("96ae6e7a-5c53-4ded-bf98-6a791f1ebdd3"),
                column: "GamePicturePath",
                value: "https://fusiontech-h1ri.onrender.com/images/Games/96ae6e7a-5c53-4ded-bf98-6a791f1ebdd3/96ae6e7a-5c53-4ded-bf98-6a791f1ebdd3.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("a0ed6f38-b3e3-4090-86f1-40c09cdaaecd"),
                column: "GamePicturePath",
                value: "https://fusiontech-h1ri.onrender.com/images/Games/a0ed6f38-b3e3-4090-86f1-40c09cdaaecd/a0ed6f38-b3e3-4090-86f1-40c09cdaaecd.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("c5618a1b-eef8-43ec-aa1b-25415fb5bc2f"),
                column: "GamePicturePath",
                value: "https://fusiontech-h1ri.onrender.com/images/Games/c5618a1b-eef8-43ec-aa1b-25415fb5bc2f/c5618a1b-eef8-43ec-aa1b-25415fb5bc2f.png");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("d6cd4ffd-62d1-41e6-b6b4-5a05babb8d45"),
                column: "GamePicturePath",
                value: "https://fusiontech-h1ri.onrender.com/images/Games/d6cd4ffd-62d1-41e6-b6b4-5a05babb8d45/d6cd4ffd-62d1-41e6-b6b4-5a05babb8d45.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("dce59101-3621-461e-bf10-61807163a946"),
                column: "GamePicturePath",
                value: "https://fusiontech-h1ri.onrender.com/images/Games/dce59101-3621-461e-bf10-61807163a946/dce59101-3621-461e-bf10-61807163a946.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("e09688b3-257e-413f-9ef4-0f4a9916a2c7"),
                column: "GamePicturePath",
                value: "https://fusiontech-h1ri.onrender.com/images/Games/e09688b3-257e-413f-9ef4-0f4a9916a2c7/e09688b3-257e-413f-9ef4-0f4a9916a2c7.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("e439131b-d595-48e3-8873-be55a1357748"),
                column: "GamePicturePath",
                value: "https://fusiontech-h1ri.onrender.com/images/Games/e439131b-d595-48e3-8873-be55a1357748/e439131b-d595-48e3-8873-be55a1357748.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("e5a9c78f-863e-428d-81a5-3b2d4ce62494"),
                column: "GamePicturePath",
                value: "https://fusiontech-h1ri.onrender.com/images/Games/e5a9c78f-863e-428d-81a5-3b2d4ce62494/e5a9c78f-863e-428d-81a5-3b2d4ce62494.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("ee4836d4-d131-47fe-b741-3c104f14df71"),
                column: "GamePicturePath",
                value: "https://fusiontech-h1ri.onrender.com/images/Games/ee4836d4-d131-47fe-b741-3c104f14df71/ee4836d4-d131-47fe-b741-3c104f14df71.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c4f5e3e1-2c4c-4f4e-a4d1-5e5e6139d703"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 3, 10, 10, 349, DateTimeKind.Utc).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c9ebf2c7-5a7f-4b5d-bb7f-2f2c4d8e4a88"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 3, 10, 10, 349, DateTimeKind.Utc).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("d3c4b5e8-1f3a-4c8c-897e-2d8cf3e7c4f6"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 3, 10, 10, 349, DateTimeKind.Utc).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 3, 10, 10, 349, DateTimeKind.Utc).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "32-77-D3-E1-C1-3E-0A-94-1C-31-AB-C5-9C-9E-10-31-DD-B9-35-AD-96-05-BF-C9-B5-00-61-F2-24-47-03-1F", new byte[] { 91, 31, 209, 199, 212, 4, 185, 18, 82, 67, 89, 54, 240, 3, 223, 28, 63, 18, 81, 149, 9, 62, 165, 46, 40, 156, 51, 51, 137, 99, 213, 212, 248, 81, 100, 65, 57, 153, 181, 110, 247, 131, 108, 122, 225, 83, 184, 166, 24, 11, 149, 77, 73, 88, 77, 39, 25, 102, 243, 226, 92, 236, 181, 92 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "73-0A-76-45-BD-48-2E-8D-F8-BF-74-24-72-D7-C9-6D-04-55-F9-B2-F7-73-81-89-A5-F2-C6-3A-C8-E3-3F-38", new byte[] { 120, 30, 230, 19, 228, 180, 70, 204, 30, 113, 206, 44, 196, 238, 250, 63, 14, 149, 247, 115, 19, 179, 39, 152, 228, 232, 117, 113, 197, 213, 77, 158, 122, 29, 246, 219, 46, 43, 75, 253, 48, 31, 225, 135, 225, 100, 3, 72, 113, 95, 9, 7, 149, 58, 223, 109, 64, 174, 26, 0, 102, 245, 104, 231 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "2C-3A-B4-D1-E6-45-F1-AF-6A-A7-D8-10-9A-11-08-34-DF-CF-B2-F4-CE-EA-AD-58-F2-74-84-0F-58-52-4A-4C", new byte[] { 150, 63, 64, 154, 91, 60, 42, 5, 95, 109, 226, 192, 129, 253, 97, 5, 162, 208, 49, 93, 19, 59, 74, 17, 53, 139, 52, 174, 182, 127, 84, 109, 119, 195, 144, 221, 167, 227, 81, 150, 100, 236, 125, 206, 138, 203, 156, 193, 204, 177, 144, 193, 17, 172, 51, 121, 1, 17, 223, 244, 255, 36, 168, 57 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "E1-29-1F-B0-27-E6-5F-D1-CD-5A-20-E6-D6-10-F1-E3-22-84-8B-62-B0-03-05-64-C2-15-ED-25-71-59-5F-BC", new byte[] { 37, 230, 241, 229, 210, 119, 162, 12, 33, 246, 211, 25, 157, 204, 243, 162, 147, 10, 160, 63, 138, 197, 60, 77, 135, 136, 148, 153, 20, 249, 117, 223, 223, 153, 81, 248, 20, 15, 56, 153, 98, 182, 243, 216, 239, 7, 130, 112, 126, 191, 229, 77, 163, 59, 56, 49, 111, 71, 144, 212, 164, 23, 193, 203 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "FB-FE-F6-4C-E4-B2-A1-1D-4F-83-06-22-C0-6C-67-56-62-91-EF-B7-70-93-5B-BE-71-DF-41-47-67-BF-F0-D7", new byte[] { 77, 196, 191, 150, 210, 172, 186, 141, 9, 198, 171, 63, 137, 9, 112, 226, 38, 136, 23, 163, 48, 13, 68, 183, 248, 125, 61, 25, 149, 27, 194, 200, 94, 147, 154, 225, 205, 107, 70, 246, 63, 177, 92, 197, 192, 246, 118, 188, 103, 77, 199, 19, 220, 191, 185, 53, 118, 233, 242, 71, 209, 125, 241, 32 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "94-1C-65-43-F1-A4-F9-2E-AC-A1-6E-F2-FA-52-49-A8-67-BC-01-0A-40-72-C0-92-0F-E8-26-61-59-E7-B8-74", new byte[] { 2, 63, 34, 29, 32, 86, 118, 211, 73, 51, 232, 57, 206, 250, 106, 71, 209, 13, 10, 9, 71, 156, 21, 15, 31, 85, 79, 71, 155, 44, 88, 94, 111, 83, 69, 208, 201, 164, 87, 234, 35, 182, 241, 2, 88, 152, 86, 34, 201, 205, 212, 178, 136, 8, 227, 94, 45, 107, 190, 28, 139, 210, 159, 197 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "23-5A-36-47-C3-F4-F9-4B-5A-11-89-6B-6C-4E-F5-BB-FC-16-C1-E7-67-D2-93-51-8B-85-57-F3-1B-67-4E-8A", new byte[] { 208, 226, 145, 150, 245, 34, 115, 248, 5, 72, 137, 168, 160, 107, 173, 74, 20, 69, 19, 8, 97, 243, 91, 160, 28, 150, 26, 135, 231, 14, 230, 128, 224, 243, 217, 77, 228, 85, 132, 118, 170, 246, 59, 145, 153, 59, 150, 175, 193, 129, 41, 117, 238, 196, 251, 242, 26, 96, 199, 121, 114, 109, 206, 1 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "FA-1A-40-05-85-D5-14-66-9F-61-4D-7F-6C-BD-42-F5-8A-BD-96-A5-11-3A-8C-79-E0-FD-7E-3B-78-9D-18-A9", new byte[] { 5, 241, 123, 200, 156, 202, 92, 154, 4, 179, 174, 128, 156, 61, 158, 54, 11, 44, 82, 127, 220, 28, 26, 255, 73, 167, 232, 129, 4, 115, 246, 182, 166, 136, 20, 245, 159, 66, 163, 1, 175, 162, 176, 40, 166, 53, 103, 117, 84, 201, 242, 183, 182, 182, 178, 27, 52, 95, 215, 208, 199, 220, 113, 246 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "BC-56-84-F8-D6-57-E4-62-05-5B-15-2F-C1-77-4D-E3-10-64-E3-C4-C6-65-C6-35-16-3D-70-79-5C-6D-5A-24", new byte[] { 67, 201, 211, 71, 1, 187, 153, 231, 235, 141, 2, 89, 176, 253, 239, 220, 220, 245, 190, 94, 220, 238, 242, 54, 193, 221, 250, 137, 18, 89, 65, 202, 224, 7, 238, 111, 173, 38, 61, 50, 253, 209, 43, 147, 241, 117, 62, 236, 255, 194, 65, 98, 62, 112, 249, 139, 235, 136, 99, 82, 23, 132, 101, 96 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100004,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "27-EA-71-3D-7D-35-47-19-E9-11-1B-B4-F4-12-76-7F-25-C3-DF-3E-86-8A-8B-2A-E7-7C-A9-A2-53-58-13-57", new byte[] { 73, 90, 127, 12, 66, 23, 29, 216, 182, 212, 186, 71, 67, 33, 136, 114, 79, 56, 64, 205, 177, 78, 240, 216, 15, 195, 240, 130, 56, 12, 49, 20, 109, 221, 205, 133, 229, 160, 233, 84, 137, 6, 223, 170, 191, 9, 191, 91, 242, 117, 99, 130, 31, 85, 254, 239, 6, 104, 197, 47, 231, 58, 128, 210 } });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: new Guid("12ba59b8-6c30-4864-9d48-0f95bd278b40"),
                column: "PublisherPicturePath",
                value: "https://fusiontech-q0v4.onrender.com/images/Publishers/12ba59b8-6c30-4864-9d48-0f95bd278b40/12ba59b8-6c30-4864-9d48-0f95bd278b40.jpg");

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: new Guid("df5d8791-98b3-445d-8120-07b33695da10"),
                column: "PublisherPicturePath",
                value: "https://fusiontech-q0v4.onrender.com/images/Publishers/df5d8791-98b3-445d-8120-07b33695da10/df5d8791-98b3-445d-8120-07b33695da10.png");

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: new Guid("f5ea9a66-8a49-4f1f-ae5d-09ce38a7c80d"),
                column: "PublisherPicturePath",
                value: "https://fusiontech-q0v4.onrender.com/images/Publishers/f5ea9a66-8a49-4f1f-ae5d-09ce38a7c80d/f5ea9a66-8a49-4f1f-ae5d-09ce38a7c80d.jpg");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("0b4ad2e6-b78c-47a8-bf70-fb667cb7a138"),
                column: "StudioPicturePath",
                value: "https://fusiontech-q0v4.onrender.com/images/Studios/0b4ad2e6-b78c-47a8-bf70-fb667cb7a138/0b4ad2e6-b78c-47a8-bf70-fb667cb7a138.png");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("5502bbf3-535e-4042-85b8-052b35594542"),
                column: "StudioPicturePath",
                value: "https://fusiontech-q0v4.onrender.com/images/Studios/5502bbf3-535e-4042-85b8-052b35594542/5502bbf3-535e-4042-85b8-052b35594542.jpg");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("646e4c3c-bfc2-41dc-9f49-14b7905516b8"),
                column: "StudioPicturePath",
                value: "https://fusiontech-q0v4.onrender.com/images/Studios/646e4c3c-bfc2-41dc-9f49-14b7905516b8/646e4c3c-bfc2-41dc-9f49-14b7905516b8.png");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("727cffb5-6ba3-4a56-a1eb-fe1962c8f044"),
                column: "StudioPicturePath",
                value: "https://fusiontech-q0v4.onrender.com/images/Studios/727cffb5-6ba3-4a56-a1eb-fe1962c8f044/727cffb5-6ba3-4a56-a1eb-fe1962c8f044.jpg");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("86b47e62-089e-4f3e-b9c4-f29ea6720fd0"),
                column: "StudioPicturePath",
                value: "https://fusiontech-q0v4.onrender.com/images/Studios/86b47e62-089e-4f3e-b9c4-f29ea6720fd0/86b47e62-089e-4f3e-b9c4-f29ea6720fd0.png");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("8720de28-1bf5-49ad-b272-ddfee747f22c"),
                column: "StudioPicturePath",
                value: "https://fusiontech-q0v4.onrender.com/images/Studios/8720de28-1bf5-49ad-b272-ddfee747f22c/8720de28-1bf5-49ad-b272-ddfee747f22c.jpg");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("9fc928ce-aa2a-4e7b-816d-b3468ea552ed"),
                column: "StudioPicturePath",
                value: "https://fusiontech-q0v4.onrender.com/images/Studios/9fc928ce-aa2a-4e7b-816d-b3468ea552ed/9fc928ce-aa2a-4e7b-816d-b3468ea552ed.jpg");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("bbd8f143-d7e1-41ef-9702-9bfb27567b80"),
                column: "StudioPicturePath",
                value: "https://fusiontech-q0v4.onrender.com/images/Studios/bbd8f143-d7e1-41ef-9702-9bfb27567b80/bbd8f143-d7e1-41ef-9702-9bfb27567b80.png");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("bfe21050-cd59-4feb-ab5e-459031e4b3f3"),
                column: "StudioPicturePath",
                value: "https://fusiontech-q0v4.onrender.com/images/Studios/bfe21050-cd59-4feb-ab5e-459031e4b3f3/bfe21050-cd59-4feb-ab5e-459031e4b3f3.png");

            migrationBuilder.UpdateData(
                table: "Studio",
                keyColumn: "GameStudioId",
                keyValue: new Guid("cf04439e-6b5d-406f-b2e1-a5616a3aee8a"),
                column: "StudioPicturePath",
                value: "https://fusiontech-q0v4.onrender.com/images/Studios/cf04439e-6b5d-406f-b2e1-a5616a3aee8a/cf04439e-6b5d-406f-b2e1-a5616a3aee8a.png");

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0a9c8263-7f5e-4e25-bb85-7a4c0a1e3a5c"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 10, 10, 349, DateTimeKind.Utc).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0bb3c011-9ba9-47e7-9ce0-3268f85e1ffc"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 10, 10, 349, DateTimeKind.Utc).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("18a64e64-3707-451c-b54d-51dbb9933aa0"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 10, 10, 349, DateTimeKind.Utc).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("1b234567-89ab-cdef-0123-456789abcdef"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 10, 10, 349, DateTimeKind.Utc).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("2b7c5a63-8e93-4d88-bc90-85c42d1574ae"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 10, 10, 349, DateTimeKind.Utc).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("34f2c84e-6c77-4c4a-b5f3-eef62d87b4be"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 10, 10, 349, DateTimeKind.Utc).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("3d8f49b2-ef8b-4b3e-8f5d-1f68d8f4f4b1"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 10, 10, 349, DateTimeKind.Utc).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("4d8d76aa-48e5-4c2b-95f1-5a77c73c0f11"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 10, 10, 349, DateTimeKind.Utc).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("59259348-41da-4bbc-b85c-48ee82f474ce"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 10, 10, 349, DateTimeKind.Utc).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5a6e8d59-0c3d-4e54-a105-50f44dcb9e4b"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 10, 10, 349, DateTimeKind.Utc).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5e4f2822-bb47-45b4-83c0-6c1de2b5f900"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 10, 10, 349, DateTimeKind.Utc).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("72b24a8d-4e5b-43e5-aeae-ecf9dc1b52d9"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 10, 10, 349, DateTimeKind.Utc).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("7f1f7c59-f92e-4c3b-a3f4-9c2a4cd474cb"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 10, 10, 349, DateTimeKind.Utc).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8b5c0f77-e3f1-4972-9102-6c1dfbb5a601"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 10, 10, 349, DateTimeKind.Utc).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8d5c8e30-dede-4ef0-9158-f7692c41acb2"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 10, 10, 349, DateTimeKind.Utc).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9b7f3e43-50bc-41d5-8f43-b8e0e1f47732"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 10, 10, 349, DateTimeKind.Utc).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e7b22d3-c5a5-429e-82dc-e5c573745e1d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 10, 10, 349, DateTimeKind.Utc).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("c7f1f4f5-74e3-4b4f-9c5a-3e2059d8b72d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 10, 10, 349, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("e43ff624-3f3c-4e8e-b5eb-11c0c3a244fa"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 10, 10, 349, DateTimeKind.Utc).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("f3b00c12-3b5e-4c8e-9bb0-7a5c7408cd07"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 10, 10, 349, DateTimeKind.Utc).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23"),
                column: "GamePicturePath",
                value: "https://fusiontech-q0v4.onrender.com/images/Games/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("02b0bb70-4fc8-4c72-86a7-731f4332b9a5"),
                column: "GamePicturePath",
                value: "https://fusiontech-q0v4.onrender.com/images/Games/02b0bb70-4fc8-4c72-86a7-731f4332b9a5/02b0bb70-4fc8-4c72-86a7-731f4332b9a5.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("0ce33067-7091-4c51-a1c4-3a93751c748c"),
                column: "GamePicturePath",
                value: "https://fusiontech-q0v4.onrender.com/images/Games/0ce33067-7091-4c51-a1c4-3a93751c748c/0ce33067-7091-4c51-a1c4-3a93751c748c.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("338b764e-b0f1-4969-89c8-164ca308e226"),
                column: "GamePicturePath",
                value: "https://fusiontech-q0v4.onrender.com/images/Games/338b764e-b0f1-4969-89c8-164ca308e226/338b764e-b0f1-4969-89c8-164ca308e226.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("339b171d-1256-4569-a330-506e46bb06c6"),
                column: "GamePicturePath",
                value: "https://fusiontech-q0v4.onrender.com/images/Games/339b171d-1256-4569-a330-506e46bb06c6/339b171d-1256-4569-a330-506e46bb06c6.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("426a499a-41c1-4763-a615-fca426836e3f"),
                column: "GamePicturePath",
                value: "https://fusiontech-q0v4.onrender.com/images/Games/426a499a-41c1-4763-a615-fca426836e3f/426a499a-41c1-4763-a615-fca426836e3f.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("4cdb49aa-17a7-4029-a50a-e01f5aa5fd3c"),
                column: "GamePicturePath",
                value: "https://fusiontech-q0v4.onrender.com/images/Games/4cdb49aa-17a7-4029-a50a-e01f5aa5fd3c/4cdb49aa-17a7-4029-a50a-e01f5aa5fd3c.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("7248c5a6-49e0-4f88-be50-8d87a54c938f"),
                column: "GamePicturePath",
                value: "https://fusiontech-q0v4.onrender.com/images/Games/7248c5a6-49e0-4f88-be50-8d87a54c938f/7248c5a6-49e0-4f88-be50-8d87a54c938f.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("72daabe6-62ec-4657-8e27-3ef881adcdd0"),
                column: "GamePicturePath",
                value: "https://fusiontech-q0v4.onrender.com/images/Games/72daabe6-62ec-4657-8e27-3ef881adcdd0/72daabe6-62ec-4657-8e27-3ef881adcdd0.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("7fe582b8-0308-48d8-8173-800102aebcfb"),
                column: "GamePicturePath",
                value: "https://fusiontech-q0v4.onrender.com/images/Games/7fe582b8-0308-48d8-8173-800102aebcfb/7fe582b8-0308-48d8-8173-800102aebcfb.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("9215201e-133d-43e1-b9b8-7b73ac3327c5"),
                column: "GamePicturePath",
                value: "https://fusiontech-q0v4.onrender.com/images/Games/9215201e-133d-43e1-b9b8-7b73ac3327c5/9215201e-133d-43e1-b9b8-7b73ac3327c5.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("96ae6e7a-5c53-4ded-bf98-6a791f1ebdd3"),
                column: "GamePicturePath",
                value: "https://fusiontech-q0v4.onrender.com/images/Games/96ae6e7a-5c53-4ded-bf98-6a791f1ebdd3/96ae6e7a-5c53-4ded-bf98-6a791f1ebdd3.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("a0ed6f38-b3e3-4090-86f1-40c09cdaaecd"),
                column: "GamePicturePath",
                value: "https://fusiontech-q0v4.onrender.com/images/Games/a0ed6f38-b3e3-4090-86f1-40c09cdaaecd/a0ed6f38-b3e3-4090-86f1-40c09cdaaecd.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("c5618a1b-eef8-43ec-aa1b-25415fb5bc2f"),
                column: "GamePicturePath",
                value: "https://fusiontech-q0v4.onrender.com/images/Games/c5618a1b-eef8-43ec-aa1b-25415fb5bc2f/c5618a1b-eef8-43ec-aa1b-25415fb5bc2f.png");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("d6cd4ffd-62d1-41e6-b6b4-5a05babb8d45"),
                column: "GamePicturePath",
                value: "https://fusiontech-q0v4.onrender.com/images/Games/d6cd4ffd-62d1-41e6-b6b4-5a05babb8d45/d6cd4ffd-62d1-41e6-b6b4-5a05babb8d45.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("dce59101-3621-461e-bf10-61807163a946"),
                column: "GamePicturePath",
                value: "https://fusiontech-q0v4.onrender.com/images/Games/dce59101-3621-461e-bf10-61807163a946/dce59101-3621-461e-bf10-61807163a946.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("e09688b3-257e-413f-9ef4-0f4a9916a2c7"),
                column: "GamePicturePath",
                value: "https://fusiontech-q0v4.onrender.com/images/Games/e09688b3-257e-413f-9ef4-0f4a9916a2c7/e09688b3-257e-413f-9ef4-0f4a9916a2c7.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("e439131b-d595-48e3-8873-be55a1357748"),
                column: "GamePicturePath",
                value: "https://fusiontech-q0v4.onrender.com/images/Games/e439131b-d595-48e3-8873-be55a1357748/e439131b-d595-48e3-8873-be55a1357748.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("e5a9c78f-863e-428d-81a5-3b2d4ce62494"),
                column: "GamePicturePath",
                value: "https://fusiontech-q0v4.onrender.com/images/Games/e5a9c78f-863e-428d-81a5-3b2d4ce62494/e5a9c78f-863e-428d-81a5-3b2d4ce62494.jpg");

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("ee4836d4-d131-47fe-b741-3c104f14df71"),
                column: "GamePicturePath",
                value: "https://fusiontech-q0v4.onrender.com/images/Games/ee4836d4-d131-47fe-b741-3c104f14df71/ee4836d4-d131-47fe-b741-3c104f14df71.jpg");
        }
    }
}
