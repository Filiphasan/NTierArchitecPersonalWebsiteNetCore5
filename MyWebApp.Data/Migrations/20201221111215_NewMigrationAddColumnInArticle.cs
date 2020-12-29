using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebApp.Data.Migrations
{
    public partial class NewMigrationAddColumnInArticle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShortContent",
                table: "Articles",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "CreatedTime", "Date", "ModifiedTime", "ShortContent" },
                values: new object[] { new DateTime(2020, 12, 21, 14, 12, 14, 504, DateTimeKind.Local).AddTicks(6212), new DateTime(2020, 12, 21, 14, 12, 14, 504, DateTimeKind.Local).AddTicks(3820), new DateTime(2020, 12, 21, 14, 12, 14, 504, DateTimeKind.Local).AddTicks(6218), "" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShortContent",
                table: "Articles");

            migrationBuilder.UpdateData(
                table: "AboutMe",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 20, 20, 33, 42, 726, DateTimeKind.Local).AddTicks(5222), new DateTime(2020, 12, 20, 20, 33, 42, 726, DateTimeKind.Local).AddTicks(6192) });

            migrationBuilder.UpdateData(
                table: "Admin",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 20, 20, 33, 42, 731, DateTimeKind.Local).AddTicks(711), new DateTime(2020, 12, 20, 20, 33, 42, 731, DateTimeKind.Local).AddTicks(722) });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Date", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 20, 20, 33, 42, 742, DateTimeKind.Local).AddTicks(7927), new DateTime(2020, 12, 20, 20, 33, 42, 742, DateTimeKind.Local).AddTicks(2578), new DateTime(2020, 12, 20, 20, 33, 42, 742, DateTimeKind.Local).AddTicks(7935) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 20, 20, 33, 42, 745, DateTimeKind.Local).AddTicks(8186), new DateTime(2020, 12, 20, 20, 33, 42, 745, DateTimeKind.Local).AddTicks(8192) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 20, 20, 33, 42, 748, DateTimeKind.Local).AddTicks(5349), new DateTime(2020, 12, 20, 20, 33, 42, 748, DateTimeKind.Local).AddTicks(5355) });

            migrationBuilder.UpdateData(
                table: "ContactInfo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 20, 20, 33, 42, 750, DateTimeKind.Local).AddTicks(8664), new DateTime(2020, 12, 20, 20, 33, 42, 750, DateTimeKind.Local).AddTicks(8669) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 20, 20, 33, 42, 754, DateTimeKind.Local).AddTicks(6407), new DateTime(2020, 12, 20, 20, 33, 42, 754, DateTimeKind.Local).AddTicks(6413) });

            migrationBuilder.UpdateData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 20, 20, 33, 42, 754, DateTimeKind.Local).AddTicks(6497), new DateTime(2020, 12, 20, 20, 33, 42, 754, DateTimeKind.Local).AddTicks(6499) });

            migrationBuilder.UpdateData(
                table: "Experiences",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 20, 20, 33, 42, 759, DateTimeKind.Local).AddTicks(3733), new DateTime(2020, 12, 20, 20, 33, 42, 759, DateTimeKind.Local).AddTicks(3739) });

            migrationBuilder.UpdateData(
                table: "HomePageSliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 20, 20, 33, 42, 761, DateTimeKind.Local).AddTicks(9568), new DateTime(2020, 12, 20, 20, 33, 42, 761, DateTimeKind.Local).AddTicks(9573) });

            migrationBuilder.UpdateData(
                table: "HomePageSliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 20, 20, 33, 42, 761, DateTimeKind.Local).AddTicks(9626), new DateTime(2020, 12, 20, 20, 33, 42, 761, DateTimeKind.Local).AddTicks(9628) });

            migrationBuilder.UpdateData(
                table: "Interesteds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 20, 20, 33, 42, 763, DateTimeKind.Local).AddTicks(8129), new DateTime(2020, 12, 20, 20, 33, 42, 763, DateTimeKind.Local).AddTicks(8134) });

            migrationBuilder.UpdateData(
                table: "Interesteds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 20, 20, 33, 42, 763, DateTimeKind.Local).AddTicks(8169), new DateTime(2020, 12, 20, 20, 33, 42, 763, DateTimeKind.Local).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "Interesteds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 20, 20, 33, 42, 763, DateTimeKind.Local).AddTicks(8176), new DateTime(2020, 12, 20, 20, 33, 42, 763, DateTimeKind.Local).AddTicks(8177) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 20, 20, 33, 42, 766, DateTimeKind.Local).AddTicks(3214), new DateTime(2020, 12, 20, 20, 33, 42, 766, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "SiteIdentity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 20, 20, 33, 42, 768, DateTimeKind.Local).AddTicks(9788), new DateTime(2020, 12, 20, 20, 33, 42, 768, DateTimeKind.Local).AddTicks(9794) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 20, 20, 33, 42, 771, DateTimeKind.Local).AddTicks(634), new DateTime(2020, 12, 20, 20, 33, 42, 771, DateTimeKind.Local).AddTicks(639) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 20, 20, 33, 42, 771, DateTimeKind.Local).AddTicks(700), new DateTime(2020, 12, 20, 20, 33, 42, 771, DateTimeKind.Local).AddTicks(702) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 20, 20, 33, 42, 771, DateTimeKind.Local).AddTicks(707), new DateTime(2020, 12, 20, 20, 33, 42, 771, DateTimeKind.Local).AddTicks(708) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 20, 20, 33, 42, 771, DateTimeKind.Local).AddTicks(712), new DateTime(2020, 12, 20, 20, 33, 42, 771, DateTimeKind.Local).AddTicks(714) });

            migrationBuilder.UpdateData(
                table: "Skills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 20, 20, 33, 42, 771, DateTimeKind.Local).AddTicks(718), new DateTime(2020, 12, 20, 20, 33, 42, 771, DateTimeKind.Local).AddTicks(719) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 20, 20, 33, 42, 775, DateTimeKind.Local).AddTicks(5301), new DateTime(2020, 12, 20, 20, 33, 42, 775, DateTimeKind.Local).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 20, 20, 33, 42, 775, DateTimeKind.Local).AddTicks(5360), new DateTime(2020, 12, 20, 20, 33, 42, 775, DateTimeKind.Local).AddTicks(5361) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 20, 20, 33, 42, 775, DateTimeKind.Local).AddTicks(5366), new DateTime(2020, 12, 20, 20, 33, 42, 775, DateTimeKind.Local).AddTicks(5368) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 20, 20, 33, 42, 775, DateTimeKind.Local).AddTicks(5372), new DateTime(2020, 12, 20, 20, 33, 42, 775, DateTimeKind.Local).AddTicks(5374) });

            migrationBuilder.UpdateData(
                table: "SocialMediaAccounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 20, 20, 33, 42, 775, DateTimeKind.Local).AddTicks(5379), new DateTime(2020, 12, 20, 20, 33, 42, 775, DateTimeKind.Local).AddTicks(5380) });

            migrationBuilder.UpdateData(
                table: "Summary",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "ModifiedTime" },
                values: new object[] { new DateTime(2020, 12, 20, 20, 33, 42, 777, DateTimeKind.Local).AddTicks(4718), new DateTime(2020, 12, 20, 20, 33, 42, 777, DateTimeKind.Local).AddTicks(4724) });
        }
    }
}
