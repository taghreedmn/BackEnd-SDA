using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class Workk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c4f5e3e1-2c4c-4f4e-a4d1-5e5e6139d703"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c9ebf2c7-5a7f-4b5d-bb7f-2f2c4d8e4a88"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("d3c4b5e8-1f3a-4c8c-897e-2d8cf3e7c4f6"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "09-4F-27-42-2F-88-8B-9B-98-19-D2-34-C1-9C-5D-14-C3-BD-D8-40-B3-B0-DA-54-04-6C-C6-97-27-67-0A-56", new byte[] { 131, 79, 154, 0, 192, 124, 192, 118, 2, 202, 69, 173, 252, 125, 122, 193, 27, 201, 104, 162, 141, 154, 136, 27, 190, 180, 153, 212, 193, 133, 146, 210, 211, 205, 136, 21, 218, 123, 58, 56, 204, 194, 245, 145, 125, 208, 83, 235, 201, 225, 196, 131, 67, 229, 98, 139, 238, 148, 93, 239, 48, 128, 251, 96 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "23-EB-8B-2A-B0-C7-47-0D-6B-1C-B4-C4-C7-70-19-94-72-67-49-D9-93-38-DB-9E-8C-71-56-14-FC-F8-0E-11", new byte[] { 229, 191, 231, 126, 13, 252, 74, 134, 166, 249, 241, 216, 232, 255, 110, 200, 218, 213, 6, 126, 214, 39, 36, 32, 198, 123, 121, 33, 55, 178, 56, 217, 103, 19, 221, 165, 205, 207, 82, 99, 25, 25, 70, 167, 70, 142, 31, 196, 45, 210, 30, 0, 15, 171, 110, 58, 16, 102, 159, 70, 184, 126, 27, 8 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "87-FA-A0-89-0E-C5-E5-B5-8F-06-39-E3-98-9E-41-CB-C6-0E-71-53-41-BB-45-21-FD-8A-A3-3B-BD-73-DE-7C", new byte[] { 154, 245, 24, 54, 177, 218, 27, 254, 82, 213, 183, 23, 121, 14, 142, 180, 32, 191, 230, 52, 162, 254, 248, 200, 122, 20, 62, 253, 201, 108, 25, 164, 78, 12, 41, 113, 27, 163, 138, 88, 221, 172, 213, 248, 86, 205, 186, 151, 109, 231, 197, 243, 238, 121, 253, 94, 172, 226, 128, 221, 146, 207, 253, 230 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "2B-47-9B-94-F3-5E-D1-1D-94-6A-04-56-A1-E3-68-40-F1-59-CC-A4-8F-43-6D-DA-9C-23-9F-A2-75-8A-D7-F4", new byte[] { 170, 41, 237, 100, 124, 87, 22, 28, 202, 215, 242, 214, 188, 205, 221, 17, 73, 7, 13, 246, 141, 234, 102, 50, 203, 17, 206, 34, 230, 46, 52, 149, 18, 22, 214, 214, 244, 102, 252, 104, 217, 89, 227, 110, 50, 126, 26, 158, 188, 78, 124, 158, 47, 165, 48, 229, 9, 183, 201, 47, 206, 160, 251, 62 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "E9-F2-01-D5-38-5B-F8-49-36-66-2E-D0-0D-C3-37-AF-F8-14-78-39-CE-F7-92-22-B5-40-E9-E8-22-DC-EB-CC", new byte[] { 41, 204, 39, 207, 57, 170, 104, 91, 55, 201, 46, 150, 217, 18, 222, 29, 123, 92, 28, 29, 125, 113, 139, 52, 159, 60, 99, 238, 240, 95, 131, 43, 182, 109, 140, 19, 74, 17, 121, 253, 19, 173, 213, 194, 214, 139, 128, 131, 252, 242, 92, 60, 164, 14, 253, 90, 23, 164, 4, 156, 216, 10, 150, 229 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "1A-D9-B8-69-E5-A8-FA-24-E7-29-7B-A8-EE-F5-34-90-48-F4-42-AF-F7-7B-8A-CF-53-57-8E-86-7D-D6-76-98", new byte[] { 40, 91, 245, 59, 74, 227, 230, 180, 60, 250, 18, 99, 7, 53, 227, 141, 111, 220, 177, 144, 31, 133, 209, 167, 134, 165, 139, 204, 9, 124, 86, 50, 104, 89, 205, 159, 123, 239, 190, 216, 172, 230, 43, 137, 215, 0, 176, 122, 167, 171, 21, 95, 144, 29, 219, 251, 221, 70, 246, 161, 197, 251, 204, 20 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "D6-2C-BB-D9-83-F5-52-90-24-47-DB-FE-37-4D-F5-E5-71-3C-DA-9F-31-2B-2C-0B-5F-A7-98-96-64-30-CF-60", new byte[] { 4, 137, 220, 38, 115, 229, 148, 68, 25, 204, 140, 183, 18, 0, 186, 235, 202, 154, 145, 181, 62, 123, 217, 60, 71, 112, 56, 166, 226, 57, 187, 90, 82, 91, 167, 122, 252, 187, 104, 195, 56, 248, 134, 239, 252, 76, 169, 63, 231, 77, 245, 226, 251, 130, 253, 152, 44, 140, 155, 31, 96, 43, 203, 226 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "19-7F-D5-96-02-F0-C3-79-66-91-6B-05-CE-26-85-4C-CA-B2-F1-6C-D9-CF-D3-D6-43-F9-09-00-C5-F0-80-6E", new byte[] { 7, 108, 217, 214, 167, 23, 217, 130, 12, 229, 61, 250, 247, 93, 87, 56, 131, 59, 245, 103, 162, 43, 75, 194, 115, 5, 19, 92, 108, 116, 92, 112, 131, 64, 155, 183, 46, 221, 43, 4, 148, 35, 115, 128, 43, 131, 1, 30, 171, 154, 180, 121, 72, 105, 47, 248, 198, 43, 179, 160, 108, 209, 95, 75 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "01-58-86-97-45-42-41-F4-03-92-97-7A-80-AC-33-52-F0-11-13-5B-FA-A6-0F-73-47-F5-D4-98-D8-43-01-9E", new byte[] { 125, 195, 47, 175, 104, 204, 233, 0, 178, 145, 89, 184, 98, 249, 216, 214, 251, 192, 174, 116, 233, 170, 60, 52, 44, 112, 165, 28, 86, 242, 70, 123, 232, 235, 164, 206, 224, 75, 0, 113, 26, 220, 138, 181, 100, 173, 255, 242, 208, 172, 255, 156, 177, 137, 162, 241, 212, 140, 3, 177, 87, 140, 254, 162 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100004,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "62-C0-4F-93-E6-63-0C-D1-7E-93-7A-C7-FE-36-A8-84-5A-CA-FD-AF-BE-C9-7C-1E-B5-2B-F0-6B-A5-DC-70-B7", new byte[] { 236, 179, 43, 236, 47, 53, 243, 200, 22, 33, 65, 17, 135, 195, 5, 183, 230, 213, 70, 41, 145, 188, 255, 106, 207, 152, 73, 142, 46, 79, 109, 206, 66, 238, 191, 119, 172, 104, 93, 158, 92, 234, 187, 163, 70, 107, 181, 185, 34, 122, 132, 109, 1, 232, 185, 80, 108, 134, 253, 141, 14, 90, 177, 36 } });

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
                value: new DateTime(2024, 11, 15, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0bb3c011-9ba9-47e7-9ce0-3268f85e1ffc"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("18a64e64-3707-451c-b54d-51dbb9933aa0"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("1b234567-89ab-cdef-0123-456789abcdef"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("2b7c5a63-8e93-4d88-bc90-85c42d1574ae"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("34f2c84e-6c77-4c4a-b5f3-eef62d87b4be"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("3d8f49b2-ef8b-4b3e-8f5d-1f68d8f4f4b1"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("4d8d76aa-48e5-4c2b-95f1-5a77c73c0f11"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("59259348-41da-4bbc-b85c-48ee82f474ce"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5a6e8d59-0c3d-4e54-a105-50f44dcb9e4b"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5e4f2822-bb47-45b4-83c0-6c1de2b5f900"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("72b24a8d-4e5b-43e5-aeae-ecf9dc1b52d9"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("7f1f7c59-f92e-4c3b-a3f4-9c2a4cd474cb"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8b5c0f77-e3f1-4972-9102-6c1dfbb5a601"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8d5c8e30-dede-4ef0-9158-f7692c41acb2"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9b7f3e43-50bc-41d5-8f43-b8e0e1f47732"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e7b22d3-c5a5-429e-82dc-e5c573745e1d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("c7f1f4f5-74e3-4b4f-9c5a-3e2059d8b72d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("e43ff624-3f3c-4e8e-b5eb-11c0c3a244fa"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("f3b00c12-3b5e-4c8e-9bb0-7a5c7408cd07"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 30, 1, 282, DateTimeKind.Utc).AddTicks(5200));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c4f5e3e1-2c4c-4f4e-a4d1-5e5e6139d703"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c9ebf2c7-5a7f-4b5d-bb7f-2f2c4d8e4a88"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("d3c4b5e8-1f3a-4c8c-897e-2d8cf3e7c4f6"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "8B-40-52-F2-4B-0A-B4-88-63-99-AC-28-55-53-3E-5F-C4-84-9D-E0-8B-F7-52-70-05-73-48-31-F2-41-5F-0A", new byte[] { 47, 31, 165, 109, 249, 112, 69, 44, 59, 213, 37, 46, 211, 59, 57, 253, 8, 140, 38, 47, 212, 241, 81, 66, 148, 148, 2, 114, 18, 248, 105, 182, 193, 82, 219, 52, 60, 32, 201, 6, 79, 127, 247, 48, 13, 2, 173, 97, 24, 50, 40, 44, 28, 104, 205, 154, 255, 55, 187, 220, 26, 74, 234, 100 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "A6-EE-02-98-7D-C5-D8-D0-EB-2B-FE-43-C6-9B-BD-FC-1F-C5-5E-CB-5B-E4-29-68-52-98-2F-BD-38-02-47-A3", new byte[] { 92, 89, 230, 209, 0, 207, 16, 163, 212, 83, 40, 82, 21, 32, 179, 91, 252, 185, 134, 229, 229, 224, 86, 38, 48, 158, 157, 3, 123, 24, 108, 208, 212, 143, 7, 27, 188, 49, 170, 48, 79, 63, 214, 166, 86, 218, 185, 175, 35, 226, 208, 197, 2, 205, 78, 42, 133, 16, 235, 245, 8, 224, 207, 37 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "59-3C-A0-C7-E0-F2-64-22-C3-40-49-07-6A-45-32-D3-33-E6-6A-1C-5C-42-4F-C3-79-27-92-F4-6B-95-16-65", new byte[] { 174, 67, 143, 140, 210, 177, 132, 231, 90, 88, 107, 33, 149, 14, 31, 151, 19, 145, 167, 148, 10, 152, 201, 165, 146, 43, 220, 194, 87, 52, 136, 36, 11, 8, 206, 144, 19, 216, 115, 177, 236, 198, 173, 85, 115, 39, 251, 171, 8, 69, 187, 254, 11, 53, 64, 247, 221, 245, 3, 4, 183, 4, 159, 238 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "87-7E-99-49-5C-6D-89-C7-25-6D-47-4D-D3-5E-52-A8-EE-B2-15-70-F4-4F-F6-3F-5E-0F-78-0F-F4-B3-0B-BC", new byte[] { 188, 179, 223, 230, 41, 218, 56, 178, 27, 246, 61, 121, 97, 43, 193, 121, 10, 81, 0, 223, 204, 65, 254, 25, 176, 48, 66, 31, 179, 59, 77, 104, 85, 55, 188, 56, 28, 121, 23, 209, 88, 62, 172, 30, 84, 178, 189, 34, 175, 135, 184, 252, 0, 112, 7, 238, 12, 135, 156, 127, 78, 10, 74, 69 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "4E-43-EF-E1-BE-EB-FE-CE-80-89-B7-64-10-24-E7-EB-C7-2B-33-C5-68-62-B6-2A-80-A5-B3-F8-1E-63-A6-94", new byte[] { 168, 168, 49, 80, 46, 84, 158, 186, 210, 11, 15, 35, 35, 72, 6, 11, 129, 237, 193, 230, 166, 138, 7, 207, 230, 159, 249, 30, 6, 254, 191, 252, 33, 112, 52, 170, 59, 153, 214, 206, 218, 207, 4, 220, 68, 29, 112, 236, 85, 233, 64, 70, 234, 122, 76, 170, 171, 125, 141, 2, 92, 195, 22, 63 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "EF-90-D1-39-7A-9C-EC-B7-05-95-B1-19-DC-CA-5F-04-24-15-75-E9-B1-53-00-4F-62-4C-C6-4D-2D-55-3A-4A", new byte[] { 149, 15, 238, 252, 222, 154, 22, 39, 190, 132, 2, 13, 72, 202, 141, 60, 185, 130, 26, 198, 164, 153, 105, 6, 16, 24, 74, 99, 50, 191, 75, 212, 186, 230, 122, 225, 20, 164, 24, 54, 44, 156, 124, 247, 31, 193, 140, 232, 51, 1, 43, 148, 222, 96, 75, 34, 220, 147, 136, 21, 115, 52, 56, 109 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "65-65-4B-D4-76-D0-79-1A-8F-FC-4E-4D-74-20-33-8C-5D-AA-A8-8A-A2-C3-05-EE-F8-66-AF-8F-0F-DB-F2-D7", new byte[] { 240, 112, 213, 65, 107, 174, 85, 200, 151, 238, 122, 100, 31, 47, 46, 109, 171, 57, 70, 164, 76, 255, 116, 118, 34, 254, 36, 35, 218, 225, 23, 231, 236, 133, 133, 219, 115, 81, 36, 203, 30, 133, 196, 200, 43, 226, 112, 52, 128, 4, 22, 74, 156, 132, 186, 143, 164, 198, 19, 97, 51, 120, 85, 215 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "01-E5-B7-7D-76-B0-ED-61-6E-C2-1B-07-7F-68-E4-A1-40-19-68-74-43-D8-4B-FC-74-9A-28-66-36-B6-10-E9", new byte[] { 154, 219, 233, 90, 138, 231, 67, 214, 100, 87, 223, 160, 66, 45, 40, 222, 224, 149, 152, 135, 253, 146, 128, 233, 11, 219, 74, 185, 227, 6, 160, 10, 46, 130, 69, 200, 65, 248, 2, 235, 86, 165, 111, 190, 37, 42, 106, 243, 56, 87, 252, 154, 196, 139, 167, 41, 31, 236, 59, 75, 121, 187, 120, 50 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "1D-CF-D8-D2-99-66-22-18-0C-B6-9C-EF-EF-62-30-B7-A7-D4-91-D2-B2-D7-70-A3-C2-76-F8-7B-91-53-BE-29", new byte[] { 198, 158, 6, 71, 217, 100, 228, 114, 109, 255, 161, 125, 156, 158, 179, 235, 169, 13, 78, 146, 110, 109, 248, 177, 46, 148, 99, 114, 34, 148, 99, 201, 39, 249, 58, 100, 215, 120, 135, 143, 143, 88, 104, 28, 133, 171, 240, 59, 183, 121, 242, 236, 127, 191, 134, 141, 137, 54, 137, 219, 92, 206, 9, 222 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100004,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "46-BA-3B-2D-9C-74-28-96-8E-A2-A0-91-FC-97-C0-8A-0F-92-8D-CF-85-EA-74-73-90-77-22-08-E3-41-08-31", new byte[] { 159, 220, 17, 82, 166, 119, 138, 164, 101, 180, 248, 27, 182, 255, 168, 39, 122, 3, 198, 145, 3, 101, 112, 240, 153, 176, 106, 50, 108, 68, 4, 78, 25, 207, 190, 148, 100, 253, 109, 128, 23, 241, 182, 180, 234, 175, 149, 142, 245, 151, 230, 116, 115, 209, 219, 92, 243, 199, 188, 90, 209, 53, 170, 177 } });

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
                value: new DateTime(2024, 11, 15, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9812));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0bb3c011-9ba9-47e7-9ce0-3268f85e1ffc"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("18a64e64-3707-451c-b54d-51dbb9933aa0"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("1b234567-89ab-cdef-0123-456789abcdef"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("2b7c5a63-8e93-4d88-bc90-85c42d1574ae"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("34f2c84e-6c77-4c4a-b5f3-eef62d87b4be"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("3d8f49b2-ef8b-4b3e-8f5d-1f68d8f4f4b1"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("4d8d76aa-48e5-4c2b-95f1-5a77c73c0f11"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("59259348-41da-4bbc-b85c-48ee82f474ce"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5a6e8d59-0c3d-4e54-a105-50f44dcb9e4b"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5e4f2822-bb47-45b4-83c0-6c1de2b5f900"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("72b24a8d-4e5b-43e5-aeae-ecf9dc1b52d9"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("7f1f7c59-f92e-4c3b-a3f4-9c2a4cd474cb"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8b5c0f77-e3f1-4972-9102-6c1dfbb5a601"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8d5c8e30-dede-4ef0-9158-f7692c41acb2"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9b7f3e43-50bc-41d5-8f43-b8e0e1f47732"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e7b22d3-c5a5-429e-82dc-e5c573745e1d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("c7f1f4f5-74e3-4b4f-9c5a-3e2059d8b72d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9831));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("e43ff624-3f3c-4e8e-b5eb-11c0c3a244fa"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("f3b00c12-3b5e-4c8e-9bb0-7a5c7408cd07"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 21, 27, 38, 141, DateTimeKind.Utc).AddTicks(9835));

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
    }
}
