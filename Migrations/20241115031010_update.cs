using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
