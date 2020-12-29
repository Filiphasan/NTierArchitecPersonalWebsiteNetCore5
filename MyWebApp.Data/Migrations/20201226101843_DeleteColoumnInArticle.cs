using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebApp.Data.Migrations
{
    public partial class DeleteColoumnInArticle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CommentCount",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Articles");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CommentCount",
                table: "Articles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Articles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AboutMe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 21, 14, 12, 14, 491, DateTimeKind.Local).AddTicks(4300), new DateTime(2020, 12, 21, 14, 12, 14, 491, DateTimeKind.Local).AddTicks(7338) });

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 21, 14, 12, 14, 495, DateTimeKind.Local).AddTicks(5522), new DateTime(2020, 12, 21, 14, 12, 14, 495, DateTimeKind.Local).AddTicks(5533) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Date", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 21, 14, 12, 14, 504, DateTimeKind.Local).AddTicks(6212), new DateTime(2020, 12, 21, 14, 12, 14, 504, DateTimeKind.Local).AddTicks(3820), new DateTime(2020, 12, 21, 14, 12, 14, 504, DateTimeKind.Local).AddTicks(6218) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 21, 14, 12, 14, 506, DateTimeKind.Local).AddTicks(5615), new DateTime(2020, 12, 21, 14, 12, 14, 506, DateTimeKind.Local).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 21, 14, 12, 14, 509, DateTimeKind.Local).AddTicks(6350), new DateTime(2020, 12, 21, 14, 12, 14, 509, DateTimeKind.Local).AddTicks(6355) });

            migrationBuilder.UpdateData(
                table: "ContactInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 21, 14, 12, 14, 511, DateTimeKind.Local).AddTicks(8494), new DateTime(2020, 12, 21, 14, 12, 14, 511, DateTimeKind.Local).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 21, 14, 12, 14, 514, DateTimeKind.Local).AddTicks(1994), new DateTime(2020, 12, 21, 14, 12, 14, 514, DateTimeKind.Local).AddTicks(1999) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 21, 14, 12, 14, 514, DateTimeKind.Local).AddTicks(2072), new DateTime(2020, 12, 21, 14, 12, 14, 514, DateTimeKind.Local).AddTicks(2074) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 21, 14, 12, 14, 516, DateTimeKind.Local).AddTicks(3466), new DateTime(2020, 12, 21, 14, 12, 14, 516, DateTimeKind.Local).AddTicks(3626) });

            migrationBuilder.UpdateData(
                table: "HomePageSliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 21, 14, 12, 14, 518, DateTimeKind.Local).AddTicks(5547), new DateTime(2020, 12, 21, 14, 12, 14, 518, DateTimeKind.Local).AddTicks(5553) });

            migrationBuilder.UpdateData(
                table: "HomePageSliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 21, 14, 12, 14, 518, DateTimeKind.Local).AddTicks(5600), new DateTime(2020, 12, 21, 14, 12, 14, 518, DateTimeKind.Local).AddTicks(5602) });

            migrationBuilder.UpdateData(
                table: "Interesteds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 21, 14, 12, 14, 520, DateTimeKind.Local).AddTicks(2604), new DateTime(2020, 12, 21, 14, 12, 14, 520, DateTimeKind.Local).AddTicks(2609) });

            migrationBuilder.UpdateData(
                table: "Interesteds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 21, 14, 12, 14, 520, DateTimeKind.Local).AddTicks(2638), new DateTime(2020, 12, 21, 14, 12, 14, 520, DateTimeKind.Local).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "Interesteds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 21, 14, 12, 14, 520, DateTimeKind.Local).AddTicks(2644), new DateTime(2020, 12, 21, 14, 12, 14, 520, DateTimeKind.Local).AddTicks(2645) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 21, 14, 12, 14, 522, DateTimeKind.Local).AddTicks(4941), new DateTime(2020, 12, 21, 14, 12, 14, 522, DateTimeKind.Local).AddTicks(4946) });

            migrationBuilder.UpdateData(
                table: "SiteIdentity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 21, 14, 12, 14, 525, DateTimeKind.Local).AddTicks(4759), new DateTime(2020, 12, 21, 14, 12, 14, 525, DateTimeKind.Local).AddTicks(4766) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 21, 14, 12, 14, 527, DateTimeKind.Local).AddTicks(4693), new DateTime(2020, 12, 21, 14, 12, 14, 527, DateTimeKind.Local).AddTicks(4698) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 21, 14, 12, 14, 527, DateTimeKind.Local).AddTicks(4748), new DateTime(2020, 12, 21, 14, 12, 14, 527, DateTimeKind.Local).AddTicks(4750) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 21, 14, 12, 14, 527, DateTimeKind.Local).AddTicks(4754), new DateTime(2020, 12, 21, 14, 12, 14, 527, DateTimeKind.Local).AddTicks(4755) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 21, 14, 12, 14, 527, DateTimeKind.Local).AddTicks(4759), new DateTime(2020, 12, 21, 14, 12, 14, 527, DateTimeKind.Local).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 21, 14, 12, 14, 527, DateTimeKind.Local).AddTicks(4765), new DateTime(2020, 12, 21, 14, 12, 14, 527, DateTimeKind.Local).AddTicks(4766) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 21, 14, 12, 14, 529, DateTimeKind.Local).AddTicks(5259), new DateTime(2020, 12, 21, 14, 12, 14, 529, DateTimeKind.Local).AddTicks(5264) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 21, 14, 12, 14, 529, DateTimeKind.Local).AddTicks(5300), new DateTime(2020, 12, 21, 14, 12, 14, 529, DateTimeKind.Local).AddTicks(5301) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 21, 14, 12, 14, 529, DateTimeKind.Local).AddTicks(5306), new DateTime(2020, 12, 21, 14, 12, 14, 529, DateTimeKind.Local).AddTicks(5307) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 21, 14, 12, 14, 529, DateTimeKind.Local).AddTicks(5311), new DateTime(2020, 12, 21, 14, 12, 14, 529, DateTimeKind.Local).AddTicks(5312) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 21, 14, 12, 14, 529, DateTimeKind.Local).AddTicks(5317), new DateTime(2020, 12, 21, 14, 12, 14, 529, DateTimeKind.Local).AddTicks(5318) });

            migrationBuilder.UpdateData(
                table: "Summary",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 21, 14, 12, 14, 531, DateTimeKind.Local).AddTicks(1714), new DateTime(2020, 12, 21, 14, 12, 14, 531, DateTimeKind.Local).AddTicks(1719) });
        }
    }
}
