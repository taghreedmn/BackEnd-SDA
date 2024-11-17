using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class updateLink : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c4f5e3e1-2c4c-4f4e-a4d1-5e5e6139d703"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("c9ebf2c7-5a7f-4b5d-bb7f-2f2c4d8e4a88"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("d3c4b5e8-1f3a-4c8c-897e-2d8cf3e7c4f6"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: new Guid("f47ac10b-58cc-4372-a567-0e02b2c3d479"),
                column: "OrderDate",
                value: new DateTime(2024, 11, 15, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "45-0C-0F-C1-22-6F-59-71-3C-A4-B7-F6-38-FD-08-E6-00-C2-03-0D-A6-17-60-F9-61-53-10-6B-5E-C2-35-7C", new byte[] { 5, 90, 86, 96, 122, 169, 173, 20, 126, 255, 73, 26, 17, 227, 211, 58, 19, 214, 69, 124, 82, 174, 16, 23, 190, 51, 216, 27, 193, 118, 115, 222, 199, 192, 45, 156, 28, 205, 162, 194, 243, 218, 53, 154, 2, 189, 196, 53, 85, 59, 14, 62, 159, 67, 235, 99, 225, 172, 128, 234, 122, 149, 16, 252 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 2,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "EB-BD-C3-49-A1-EC-7A-27-66-1D-0D-8A-08-33-0B-88-85-F0-CE-82-B0-D0-EA-2D-73-3A-01-6D-8C-D5-E0-08", new byte[] { 94, 175, 190, 158, 43, 33, 164, 36, 96, 14, 62, 139, 110, 11, 83, 175, 175, 177, 235, 30, 181, 172, 183, 226, 12, 234, 53, 188, 117, 55, 158, 49, 232, 157, 244, 137, 161, 131, 147, 237, 46, 148, 122, 145, 160, 182, 228, 189, 167, 60, 100, 28, 225, 191, 66, 141, 205, 55, 82, 79, 226, 43, 80, 61 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 3,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "81-12-3A-47-AD-19-1D-4A-19-DF-76-A1-2E-5B-C6-27-46-1E-40-79-3B-C7-23-5E-38-23-99-A7-2F-23-2F-18", new byte[] { 141, 157, 55, 75, 158, 59, 141, 240, 227, 200, 165, 0, 4, 150, 217, 55, 117, 239, 177, 186, 123, 216, 136, 12, 100, 165, 7, 229, 31, 179, 188, 141, 168, 106, 34, 30, 223, 102, 230, 218, 43, 247, 23, 227, 6, 40, 139, 248, 53, 11, 32, 72, 115, 111, 232, 188, 20, 124, 125, 231, 98, 34, 227, 130 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "50-5B-13-B6-B5-18-CD-18-C9-8F-39-A0-50-C2-81-52-0F-C0-F8-B2-D4-7D-7A-3C-0C-00-DD-5E-EC-D8-B4-38", new byte[] { 203, 127, 165, 12, 235, 57, 140, 166, 238, 158, 163, 203, 112, 87, 14, 131, 39, 6, 73, 246, 172, 146, 2, 138, 110, 51, 236, 207, 4, 44, 211, 174, 40, 57, 209, 189, 225, 245, 153, 245, 30, 183, 12, 195, 134, 75, 224, 138, 180, 165, 34, 112, 22, 220, 109, 96, 65, 38, 52, 38, 185, 75, 74, 242 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "68-6C-78-5D-45-48-01-CC-3E-CA-E7-AB-10-75-1D-F5-24-32-E4-58-A9-06-7D-13-4A-44-14-15-EB-9F-1D-E3", new byte[] { 35, 56, 230, 189, 18, 27, 195, 6, 113, 158, 111, 92, 52, 117, 65, 185, 129, 14, 121, 112, 226, 219, 161, 37, 125, 58, 113, 193, 13, 134, 68, 26, 114, 96, 117, 162, 129, 40, 60, 190, 10, 138, 164, 105, 201, 204, 20, 198, 111, 159, 225, 76, 11, 145, 231, 210, 233, 122, 35, 194, 227, 80, 12, 183 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 1003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "D7-A2-8B-E9-60-F0-16-2D-D0-B4-D2-C4-28-CC-14-B2-C4-DF-8E-34-0A-38-1A-FB-9F-29-1E-F5-78-B4-FC-3D", new byte[] { 146, 60, 112, 40, 17, 229, 189, 56, 14, 243, 42, 88, 49, 220, 251, 169, 185, 83, 190, 220, 51, 235, 130, 164, 187, 184, 198, 21, 209, 88, 59, 171, 179, 227, 98, 164, 55, 161, 167, 33, 56, 30, 78, 215, 128, 180, 70, 92, 52, 210, 206, 29, 87, 184, 31, 167, 167, 24, 31, 194, 238, 109, 202, 236 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100001,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "A4-5B-E3-E0-3D-35-BF-BA-65-76-D4-68-B4-8A-39-DA-D1-E4-4E-4B-DF-CF-D2-53-C1-7F-0D-E1-42-BB-65-38", new byte[] { 127, 206, 167, 154, 136, 48, 102, 202, 252, 23, 223, 119, 84, 120, 34, 234, 151, 33, 34, 4, 251, 107, 226, 92, 76, 160, 195, 173, 60, 255, 75, 69, 143, 212, 13, 47, 212, 140, 186, 161, 115, 226, 118, 143, 62, 93, 208, 220, 3, 11, 95, 198, 162, 8, 222, 240, 63, 102, 178, 109, 207, 34, 249, 91 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100002,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "61-C5-C9-65-AD-BC-48-97-B6-46-09-5D-20-82-75-93-8C-C7-D5-8D-9C-21-B9-94-7F-57-0B-B6-A4-41-35-25", new byte[] { 97, 93, 133, 74, 67, 43, 242, 81, 234, 155, 90, 149, 163, 157, 124, 143, 90, 195, 80, 154, 104, 143, 0, 111, 227, 83, 43, 189, 40, 242, 4, 163, 232, 8, 88, 69, 147, 60, 241, 64, 50, 188, 206, 71, 18, 62, 149, 9, 125, 82, 238, 117, 104, 70, 19, 37, 89, 149, 31, 47, 12, 201, 255, 235 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100003,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "7E-76-C3-AF-63-28-EA-10-FA-58-97-CE-A8-DD-4A-9F-47-EB-52-64-A7-BE-44-43-65-62-3D-BB-90-95-22-A5", new byte[] { 71, 184, 1, 189, 20, 149, 116, 236, 244, 30, 222, 57, 22, 90, 133, 220, 162, 170, 133, 213, 109, 116, 145, 149, 131, 174, 215, 230, 50, 3, 154, 90, 160, 64, 160, 24, 136, 137, 160, 107, 210, 134, 48, 200, 71, 123, 214, 72, 53, 52, 115, 59, 185, 169, 83, 37, 118, 80, 198, 180, 203, 62, 91, 40 } });

            migrationBuilder.UpdateData(
                table: "Persons",
                keyColumn: "PersonId",
                keyValue: 100004,
                columns: new[] { "PersonPassword", "salt" },
                values: new object[] { "85-6F-33-C6-80-6E-D5-0E-15-40-86-7D-7D-77-D2-80-FA-19-71-5E-CA-AD-6D-39-39-8C-24-35-4C-0C-E3-F3", new byte[] { 129, 109, 98, 102, 229, 50, 68, 131, 170, 240, 15, 7, 9, 13, 228, 37, 6, 15, 100, 251, 53, 93, 82, 97, 207, 53, 151, 52, 184, 80, 77, 142, 127, 136, 185, 115, 184, 23, 121, 25, 17, 64, 211, 33, 108, 185, 61, 162, 139, 6, 18, 28, 129, 187, 243, 29, 69, 20, 15, 36, 243, 13, 162, 180 } });

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
                value: new DateTime(2024, 11, 15, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("0bb3c011-9ba9-47e7-9ce0-3268f85e1ffc"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("18a64e64-3707-451c-b54d-51dbb9933aa0"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("1b234567-89ab-cdef-0123-456789abcdef"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("2b7c5a63-8e93-4d88-bc90-85c42d1574ae"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("34f2c84e-6c77-4c4a-b5f3-eef62d87b4be"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("3d8f49b2-ef8b-4b3e-8f5d-1f68d8f4f4b1"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("4d8d76aa-48e5-4c2b-95f1-5a77c73c0f11"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("59259348-41da-4bbc-b85c-48ee82f474ce"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5a6e8d59-0c3d-4e54-a105-50f44dcb9e4b"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("5e4f2822-bb47-45b4-83c0-6c1de2b5f900"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("72b24a8d-4e5b-43e5-aeae-ecf9dc1b52d9"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("7f1f7c59-f92e-4c3b-a3f4-9c2a4cd474cb"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8b5c0f77-e3f1-4972-9102-6c1dfbb5a601"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("8d5c8e30-dede-4ef0-9158-f7692c41acb2"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9b7f3e43-50bc-41d5-8f43-b8e0e1f47732"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("9e7b22d3-c5a5-429e-82dc-e5c573745e1d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("c7f1f4f5-74e3-4b4f-9c5a-3e2059d8b72d"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("e43ff624-3f3c-4e8e-b5eb-11c0c3a244fa"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 15, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "Supply",
                keyColumn: "SupplyId",
                keyValue: new Guid("f3b00c12-3b5e-4c8e-9bb0-7a5c7408cd07"),
                column: "SupplierDate",
                value: new DateTime(2024, 11, 14, 3, 31, 25, 815, DateTimeKind.Utc).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "VideoGameInfo",
                keyColumn: "VideoGameInfoId",
                keyValue: new Guid("007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23"),
                column: "GamePicturePath",
                value: "https://fusiontech-0dxp.onrender.com/images/Games/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23/007e6acf-7ff4-45d6-aa22-dfbf4c4d3b23.jpg");

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
    }
}
