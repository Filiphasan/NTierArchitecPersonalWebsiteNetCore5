using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebApp.Data.Migrations
{
    public partial class newmigrationlast : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Thumbnail",
                table: "Articles",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.UpdateData(
                table: "AboutMe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 284, DateTimeKind.Local).AddTicks(2516), new DateTime(2020, 12, 26, 17, 1, 27, 284, DateTimeKind.Local).AddTicks(3539) });

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 288, DateTimeKind.Local).AddTicks(5827), new DateTime(2020, 12, 26, 17, 1, 27, 288, DateTimeKind.Local).AddTicks(5841) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 298, DateTimeKind.Local).AddTicks(2380), new DateTime(2020, 12, 26, 17, 1, 27, 298, DateTimeKind.Local).AddTicks(2386) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 300, DateTimeKind.Local).AddTicks(3462), new DateTime(2020, 12, 26, 17, 1, 27, 300, DateTimeKind.Local).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 303, DateTimeKind.Local).AddTicks(6866), new DateTime(2020, 12, 26, 17, 1, 27, 303, DateTimeKind.Local).AddTicks(6871) });

            migrationBuilder.UpdateData(
                table: "ContactInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 305, DateTimeKind.Local).AddTicks(9704), new DateTime(2020, 12, 26, 17, 1, 27, 305, DateTimeKind.Local).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 308, DateTimeKind.Local).AddTicks(5384), new DateTime(2020, 12, 26, 17, 1, 27, 308, DateTimeKind.Local).AddTicks(5389) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 308, DateTimeKind.Local).AddTicks(5479), new DateTime(2020, 12, 26, 17, 1, 27, 308, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 310, DateTimeKind.Local).AddTicks(8536), new DateTime(2020, 12, 26, 17, 1, 27, 310, DateTimeKind.Local).AddTicks(8542) });

            migrationBuilder.UpdateData(
                table: "HomePageSliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 313, DateTimeKind.Local).AddTicks(6150), new DateTime(2020, 12, 26, 17, 1, 27, 313, DateTimeKind.Local).AddTicks(6156) });

            migrationBuilder.UpdateData(
                table: "HomePageSliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 313, DateTimeKind.Local).AddTicks(6209), new DateTime(2020, 12, 26, 17, 1, 27, 313, DateTimeKind.Local).AddTicks(6211) });

            migrationBuilder.UpdateData(
                table: "Interesteds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 315, DateTimeKind.Local).AddTicks(4357), new DateTime(2020, 12, 26, 17, 1, 27, 315, DateTimeKind.Local).AddTicks(4362) });

            migrationBuilder.UpdateData(
                table: "Interesteds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 315, DateTimeKind.Local).AddTicks(4390), new DateTime(2020, 12, 26, 17, 1, 27, 315, DateTimeKind.Local).AddTicks(4391) });

            migrationBuilder.UpdateData(
                table: "Interesteds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 315, DateTimeKind.Local).AddTicks(4396), new DateTime(2020, 12, 26, 17, 1, 27, 315, DateTimeKind.Local).AddTicks(4397) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 318, DateTimeKind.Local).AddTicks(1224), new DateTime(2020, 12, 26, 17, 1, 27, 318, DateTimeKind.Local).AddTicks(1231) });

            migrationBuilder.UpdateData(
                table: "SiteIdentity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 320, DateTimeKind.Local).AddTicks(5718), new DateTime(2020, 12, 26, 17, 1, 27, 320, DateTimeKind.Local).AddTicks(5723) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 322, DateTimeKind.Local).AddTicks(6974), new DateTime(2020, 12, 26, 17, 1, 27, 322, DateTimeKind.Local).AddTicks(6979) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 322, DateTimeKind.Local).AddTicks(7041), new DateTime(2020, 12, 26, 17, 1, 27, 322, DateTimeKind.Local).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 322, DateTimeKind.Local).AddTicks(7048), new DateTime(2020, 12, 26, 17, 1, 27, 322, DateTimeKind.Local).AddTicks(7049) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 322, DateTimeKind.Local).AddTicks(7054), new DateTime(2020, 12, 26, 17, 1, 27, 322, DateTimeKind.Local).AddTicks(7055) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 322, DateTimeKind.Local).AddTicks(7059), new DateTime(2020, 12, 26, 17, 1, 27, 322, DateTimeKind.Local).AddTicks(7060) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 324, DateTimeKind.Local).AddTicks(8225), new DateTime(2020, 12, 26, 17, 1, 27, 324, DateTimeKind.Local).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 324, DateTimeKind.Local).AddTicks(8268), new DateTime(2020, 12, 26, 17, 1, 27, 324, DateTimeKind.Local).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 324, DateTimeKind.Local).AddTicks(8274), new DateTime(2020, 12, 26, 17, 1, 27, 324, DateTimeKind.Local).AddTicks(8275) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 324, DateTimeKind.Local).AddTicks(8279), new DateTime(2020, 12, 26, 17, 1, 27, 324, DateTimeKind.Local).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 324, DateTimeKind.Local).AddTicks(8285), new DateTime(2020, 12, 26, 17, 1, 27, 324, DateTimeKind.Local).AddTicks(8286) });

            migrationBuilder.UpdateData(
                table: "Summary",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 17, 1, 27, 326, DateTimeKind.Local).AddTicks(5109), new DateTime(2020, 12, 26, 17, 1, 27, 326, DateTimeKind.Local).AddTicks(5114) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Thumbnail",
                table: "Articles",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AboutMe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 13, 18, 41, 848, DateTimeKind.Local).AddTicks(1722), new DateTime(2020, 12, 26, 13, 18, 41, 848, DateTimeKind.Local).AddTicks(2667) });

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 13, 18, 41, 853, DateTimeKind.Local).AddTicks(2908), new DateTime(2020, 12, 26, 13, 18, 41, 853, DateTimeKind.Local).AddTicks(2918) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 13, 18, 41, 861, DateTimeKind.Local).AddTicks(5173), new DateTime(2020, 12, 26, 13, 18, 41, 861, DateTimeKind.Local).AddTicks(5178) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 13, 18, 41, 863, DateTimeKind.Local).AddTicks(3887), new DateTime(2020, 12, 26, 13, 18, 41, 863, DateTimeKind.Local).AddTicks(3893) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 13, 18, 41, 866, DateTimeKind.Local).AddTicks(1430), new DateTime(2020, 12, 26, 13, 18, 41, 866, DateTimeKind.Local).AddTicks(1436) });

            migrationBuilder.UpdateData(
                table: "ContactInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 13, 18, 41, 869, DateTimeKind.Local).AddTicks(776), new DateTime(2020, 12, 26, 13, 18, 41, 869, DateTimeKind.Local).AddTicks(782) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 13, 18, 41, 871, DateTimeKind.Local).AddTicks(6064), new DateTime(2020, 12, 26, 13, 18, 41, 871, DateTimeKind.Local).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 13, 18, 41, 871, DateTimeKind.Local).AddTicks(6147), new DateTime(2020, 12, 26, 13, 18, 41, 871, DateTimeKind.Local).AddTicks(6148) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 13, 18, 41, 873, DateTimeKind.Local).AddTicks(8381), new DateTime(2020, 12, 26, 13, 18, 41, 873, DateTimeKind.Local).AddTicks(8387) });

            migrationBuilder.UpdateData(
                table: "HomePageSliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 13, 18, 41, 875, DateTimeKind.Local).AddTicks(9639), new DateTime(2020, 12, 26, 13, 18, 41, 875, DateTimeKind.Local).AddTicks(9644) });

            migrationBuilder.UpdateData(
                table: "HomePageSliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 13, 18, 41, 875, DateTimeKind.Local).AddTicks(9688), new DateTime(2020, 12, 26, 13, 18, 41, 875, DateTimeKind.Local).AddTicks(9689) });

            migrationBuilder.UpdateData(
                table: "Interesteds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 13, 18, 41, 877, DateTimeKind.Local).AddTicks(7290), new DateTime(2020, 12, 26, 13, 18, 41, 877, DateTimeKind.Local).AddTicks(7295) });

            migrationBuilder.UpdateData(
                table: "Interesteds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 13, 18, 41, 877, DateTimeKind.Local).AddTicks(7326), new DateTime(2020, 12, 26, 13, 18, 41, 877, DateTimeKind.Local).AddTicks(7328) });

            migrationBuilder.UpdateData(
                table: "Interesteds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 13, 18, 41, 877, DateTimeKind.Local).AddTicks(7333), new DateTime(2020, 12, 26, 13, 18, 41, 877, DateTimeKind.Local).AddTicks(7334) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 13, 18, 41, 880, DateTimeKind.Local).AddTicks(5259), new DateTime(2020, 12, 26, 13, 18, 41, 880, DateTimeKind.Local).AddTicks(5266) });

            migrationBuilder.UpdateData(
                table: "SiteIdentity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 13, 18, 41, 882, DateTimeKind.Local).AddTicks(8439), new DateTime(2020, 12, 26, 13, 18, 41, 882, DateTimeKind.Local).AddTicks(8445) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 13, 18, 41, 885, DateTimeKind.Local).AddTicks(8412), new DateTime(2020, 12, 26, 13, 18, 41, 885, DateTimeKind.Local).AddTicks(8418) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 13, 18, 41, 885, DateTimeKind.Local).AddTicks(8477), new DateTime(2020, 12, 26, 13, 18, 41, 885, DateTimeKind.Local).AddTicks(8479) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 13, 18, 41, 885, DateTimeKind.Local).AddTicks(8483), new DateTime(2020, 12, 26, 13, 18, 41, 885, DateTimeKind.Local).AddTicks(8485) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 13, 18, 41, 885, DateTimeKind.Local).AddTicks(8488), new DateTime(2020, 12, 26, 13, 18, 41, 885, DateTimeKind.Local).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 13, 18, 41, 885, DateTimeKind.Local).AddTicks(8493), new DateTime(2020, 12, 26, 13, 18, 41, 885, DateTimeKind.Local).AddTicks(8495) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 13, 18, 41, 887, DateTimeKind.Local).AddTicks(8887), new DateTime(2020, 12, 26, 13, 18, 41, 887, DateTimeKind.Local).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 13, 18, 41, 887, DateTimeKind.Local).AddTicks(8928), new DateTime(2020, 12, 26, 13, 18, 41, 887, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 13, 18, 41, 887, DateTimeKind.Local).AddTicks(8934), new DateTime(2020, 12, 26, 13, 18, 41, 887, DateTimeKind.Local).AddTicks(8935) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 13, 18, 41, 887, DateTimeKind.Local).AddTicks(8939), new DateTime(2020, 12, 26, 13, 18, 41, 887, DateTimeKind.Local).AddTicks(8941) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 13, 18, 41, 887, DateTimeKind.Local).AddTicks(8945), new DateTime(2020, 12, 26, 13, 18, 41, 887, DateTimeKind.Local).AddTicks(8946) });

            migrationBuilder.UpdateData(
                table: "Summary",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 26, 13, 18, 41, 889, DateTimeKind.Local).AddTicks(6171), new DateTime(2020, 12, 26, 13, 18, 41, 889, DateTimeKind.Local).AddTicks(6177) });
        }
    }
}
