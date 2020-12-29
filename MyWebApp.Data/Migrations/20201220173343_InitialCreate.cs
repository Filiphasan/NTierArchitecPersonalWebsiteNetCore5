using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebApp.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutMe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    MyJob = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    MyJobFA = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MyCVPath = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutMe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SecurituQuestion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SQAnswerHash = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CategoryFA = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ShortAdress = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LongAdress = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    School = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Avarage = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Workplace = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomePageSliders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    LongDescription = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePageSliders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Interesteds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interesteds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SiteIdentity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Keywords = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    LogoFA = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    LogoText = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteIdentity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PercentageValue = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialMediaAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountFA = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    AccountUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMediaAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Summary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Summary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Content = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    Thumbnail = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ViewsCount = table.Column<int>(type: "int", nullable: false),
                    CommentCount = table.Column<int>(type: "int", nullable: false),
                    SeoTags = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    SeoDescription = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedByName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AboutMe",
                columns: new[] { "Id", "BirthDate", "CreatedByName", "CreatedTime", "FirstName", "ImagePath", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedTime", "MyCVPath", "MyJob", "MyJobFA", "Note" },
                values: new object[] { 1, new DateTime(1998, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 726, DateTimeKind.Local).AddTicks(5222), "Hasan", "", true, false, "Erdal", "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 726, DateTimeKind.Local).AddTicks(6192), "", "Full-stack Web Developer", "<i class=\"fas fa - laptop - code\"></i>", "InitialCreate" });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "Id", "CreatedByName", "CreatedTime", "Email", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedTime", "Note", "PasswordHash", "SQAnswerHash", "SecurituQuestion" },
                values: new object[] { 1, "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 731, DateTimeKind.Local).AddTicks(711), "hasaerda@hotmail.com", true, false, "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 731, DateTimeKind.Local).AddTicks(722), "InitialCreate", "6449f8c4593cfb33c2404abdbc0c51e8", "fb01c2637b1583bd8e911f6ff47017c7", "Anne kızlık soyadı (küçük harflerle)?" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryFA", "CreatedByName", "CreatedTime", "Description", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedTime", "Name", "Note" },
                values: new object[] { 1, "<i class=\"fas fa - code\"></i>", "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 745, DateTimeKind.Local).AddTicks(8186), "Yazılım ile ilgili güncel bilgiler içerir.", true, false, "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 745, DateTimeKind.Local).AddTicks(8192), "Yazılım", "InitialCreate" });

            migrationBuilder.InsertData(
                table: "ContactInfo",
                columns: new[] { "Id", "CreatedByName", "CreatedTime", "Email", "IsActive", "IsDeleted", "LongAdress", "ModifiedByName", "ModifiedTime", "Note", "PhoneNumber", "ShortAdress" },
                values: new object[] { 1, "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 750, DateTimeKind.Local).AddTicks(8664), "hasaerda@hotmail.com", true, false, "Yukarıbayır Mh. Hüseyin Aşkın Sk. No:44 Kat-1", "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 750, DateTimeKind.Local).AddTicks(8669), "InitialCreate", "+905370352059", "Şahinbey/Gaziantep" });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Avarage", "CreatedByName", "CreatedTime", "Description", "Duration", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedTime", "Note", "School", "Title" },
                values: new object[,]
                {
                    { 1, "2.65 GANO", "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 754, DateTimeKind.Local).AddTicks(6407), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Exercitationem recusandae quibusdam expedita, vitae veniam aut", "Eylül 2016--Devam Ediyor", true, false, "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 754, DateTimeKind.Local).AddTicks(6413), "InitialCreate", "Uludağ Üniversitesi-Elektrik Elektronik Müh", "Lisans Derecesi" },
                    { 2, "81.63 ORT", "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 754, DateTimeKind.Local).AddTicks(6497), "Lorem ipsum dolor sit amet consectetur adipisicing elit. Exercitationem recusandae quibusdam expedita, vitae veniam aut", "Eylül 2012--Temmuz 2016", true, false, "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 754, DateTimeKind.Local).AddTicks(6499), "InitialCreate", "Türkan Halit Aykılıç Fen Lisesi-Fen Bilimleri", "Lise Mezun" }
                });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "CreatedByName", "CreatedTime", "Description", "Duration", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedTime", "Note", "Title", "Workplace" },
                values: new object[] { 1, "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 759, DateTimeKind.Local).AddTicks(3733), "Haziran 2020'den beridir, arkadaşlar ve çevrwm için web sitesi yapıyorum. Birkaç tanesini yayına aldım.", "Haziran 2020--Devam Ediyor", true, false, "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 759, DateTimeKind.Local).AddTicks(3739), "InitialCreate", "Freelance Web Developer", "Freelance" });

            migrationBuilder.InsertData(
                table: "HomePageSliders",
                columns: new[] { "Id", "CreatedByName", "CreatedTime", "IsActive", "IsDeleted", "LongDescription", "ModifiedByName", "ModifiedTime", "Note", "ShortDescription", "Title" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 761, DateTimeKind.Local).AddTicks(9568), true, false, "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur. Yaygın inancın tersine, Lorem Ipsum rastgele sözcüklerden oluşmaz. Kökleri M.Ö. 45 tarihinden bu yana klasik Latin edebiyatına kadar uzanan 2000 yıllık bir geçmişi vardır. Virginia'daki Hampden-Sydney College'dan Latince profesörü Richard McClintock, bir Lorem Ipsum pasajında geçen ve anlaşılması en güç sözcüklerden biri olan 'consectetur' sözcüğünün klasik edebiyattaki örneklerini incelediğinde kesin bir kaynağa ulaşmıştır. Lorm Ipsum, Çiçero tarafından M.Ö. 45 tarihinde kaleme alınan \"de Finibus Bonorum et Malorum\" (İyi ve Kötünün Uç Sınırları) eserinin 1.10.32 ve 1.10.33 sayılı bölümlerinden gelmektedir. Bu kitap, ahlak kuramı üzerine bir tezdir ve Rönesans döneminde çok popüler olmuştur. Lorem Ipsum pasajının ilk satırı olan \"Lorem ipsum dolor sit amet\" 1.10.32 sayılı bölümdeki bir satırdan gelmektedir.", "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 761, DateTimeKind.Local).AddTicks(9573), "InitialCreate", "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır.", ".NET DEVELOPER" },
                    { 2, "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 761, DateTimeKind.Local).AddTicks(9626), true, false, "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur. Yaygın inancın tersine, Lorem Ipsum rastgele sözcüklerden oluşmaz. Kökleri M.Ö. 45 tarihinden bu yana klasik Latin edebiyatına kadar uzanan 2000 yıllık bir geçmişi vardır. Virginia'daki Hampden-Sydney College'dan Latince profesörü Richard McClintock, bir Lorem Ipsum pasajında geçen ve anlaşılması en güç sözcüklerden biri olan 'consectetur' sözcüğünün klasik edebiyattaki örneklerini incelediğinde kesin bir kaynağa ulaşmıştır. Lorm Ipsum, Çiçero tarafından M.Ö. 45 tarihinde kaleme alınan \"de Finibus Bonorum et Malorum\" (İyi ve Kötünün Uç Sınırları) eserinin 1.10.32 ve 1.10.33 sayılı bölümlerinden gelmektedir. Bu kitap, ahlak kuramı üzerine bir tezdir ve Rönesans döneminde çok popüler olmuştur. Lorem Ipsum pasajının ilk satırı olan \"Lorem ipsum dolor sit amet\" 1.10.32 sayılı bölümdeki bir satırdan gelmektedir.", "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 761, DateTimeKind.Local).AddTicks(9628), "InitialCreate", "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır.", "WEB DEVELOPER" }
                });

            migrationBuilder.InsertData(
                table: "Interesteds",
                columns: new[] { "Id", "CreatedByName", "CreatedTime", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedTime", "Note", "Text" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 763, DateTimeKind.Local).AddTicks(8129), true, false, "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 763, DateTimeKind.Local).AddTicks(8134), "InitialCreate", "Bilgisayar Donanımları, Bileşenleri ve Yazılımları" },
                    { 2, "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 763, DateTimeKind.Local).AddTicks(8169), true, false, "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 763, DateTimeKind.Local).AddTicks(8171), "InitialCreate", "Vizyon Filmlerini takip etmek ve izlemek, Film incelemelerini okumak, Parodileri izlemek" },
                    { 3, "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 763, DateTimeKind.Local).AddTicks(8176), true, false, "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 763, DateTimeKind.Local).AddTicks(8177), "InitialCreate", "Animeler ve Mangalar" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "CreatedByName", "CreatedTime", "Email", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedTime", "Note", "Subject", "Text" },
                values: new object[] { 1, "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 766, DateTimeKind.Local).AddTicks(3214), "deneme@mail.com", "Mehmet", true, false, "Şevket", "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 766, DateTimeKind.Local).AddTicks(3220), "InitialCreate", "deneme", "Bu bir deneme mesajıdır. Dikkate almayınız!" });

            migrationBuilder.InsertData(
                table: "SiteIdentity",
                columns: new[] { "Id", "CreatedByName", "CreatedTime", "Description", "IsActive", "IsDeleted", "Keywords", "LogoFA", "LogoText", "ModifiedByName", "ModifiedTime", "Note", "Title" },
                values: new object[] { 1, "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 768, DateTimeKind.Local).AddTicks(9788), "Ben Hasan Erdal. Yazılım geliştiricisiyim. C#, python ve web bilgim var.", true, false, "Hasan Erdal, Hasan, Erdal, Software, Developer, Engineer", "<i class=\"fab fa - hire - a - helper\"></i>", "HASAN ERDAL", "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 768, DateTimeKind.Local).AddTicks(9794), "InitialCreate", "Hasan Erdal" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CreatedByName", "CreatedTime", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedTime", "Note", "PercentageValue", "Title" },
                values: new object[,]
                {
                    { 1, "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 771, DateTimeKind.Local).AddTicks(634), true, false, "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 771, DateTimeKind.Local).AddTicks(639), "InitialCreate", 70, "C#" },
                    { 2, "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 771, DateTimeKind.Local).AddTicks(700), true, false, "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 771, DateTimeKind.Local).AddTicks(702), "InitialCreate", 60, "ASP.NET MVC" },
                    { 3, "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 771, DateTimeKind.Local).AddTicks(707), true, false, "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 771, DateTimeKind.Local).AddTicks(708), "InitialCreate", 60, "ENTITY FRAMEWORK & LINQ" },
                    { 4, "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 771, DateTimeKind.Local).AddTicks(712), true, false, "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 771, DateTimeKind.Local).AddTicks(714), "InitialCreate", 65, "HTML & CSS" },
                    { 5, "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 771, DateTimeKind.Local).AddTicks(718), true, false, "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 771, DateTimeKind.Local).AddTicks(719), "InitialCreate", 50, "DEVEXPRESS FRAMEWORK" }
                });

            migrationBuilder.InsertData(
                table: "SocialMediaAccounts",
                columns: new[] { "Id", "AccountFA", "AccountUrl", "CreatedByName", "CreatedTime", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedTime", "Note" },
                values: new object[,]
                {
                    { 1, "<i class=\"fab fa - facebook - square\"></i>", "https://www.facebook.com/xxfiliphasanxx", "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 775, DateTimeKind.Local).AddTicks(5301), true, false, "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 775, DateTimeKind.Local).AddTicks(5310), "InitialCreate" },
                    { 2, "<i class=\"fab fa - twitter - square\"></i>", "https://twitter.com/hasaerda", "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 775, DateTimeKind.Local).AddTicks(5360), true, false, "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 775, DateTimeKind.Local).AddTicks(5361), "InitialCreate" },
                    { 3, "<i class=\"fab fa - linkedin\"></i>", "https://www.linkedin.com/in/hasan-erdal-2b57a3136/", "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 775, DateTimeKind.Local).AddTicks(5366), true, false, "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 775, DateTimeKind.Local).AddTicks(5368), "InitialCreate" },
                    { 4, "<i class=\"fab fa - github - square\"></i>", "https://github.com/Filiphasan", "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 775, DateTimeKind.Local).AddTicks(5372), true, false, "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 775, DateTimeKind.Local).AddTicks(5374), "InitialCreate" },
                    { 5, "<i class=\"fab fa - youtube\"></i>", "https://www.youtube.com/channel/UCKgQs4J8PEFS97iOGop_X4w", "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 775, DateTimeKind.Local).AddTicks(5379), true, false, "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 775, DateTimeKind.Local).AddTicks(5380), "InitialCreate" }
                });

            migrationBuilder.InsertData(
                table: "Summary",
                columns: new[] { "Id", "Content", "CreatedByName", "CreatedTime", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedTime", "Note" },
                values: new object[] { 1, "Merhaba siteme hoşgeldiniz. Ben Elektrik Elektronik Mühendisliği okuyan aynı zamanda yazılıma gönül vermiş birisiyim. C# ve .NET alanlarında yoğun bir şekilde kendimi geliştiriyorum. Python ve JavaScript dillerinde ise yavaş ve planlı şekilde gelişimime devam ediyorum. Gelişime açık ve hızlı öğrenen birisi olduğumu düşünüyorum. Geleceğimi yazılım üzerine şekillendireceğime eminim. Bu yolda elimden gelenin en iyisini değil, her şeyi yapacağım. Yazılım üzerine birçok hayalim, uzun ve kısa vadeli planlarım var. Açıkçası yazılımın hayatımın her alanına yeterli ölçüde etki etmesini istiyorum. Bilgisayar eskiden beridir tutkum olan bir alan. Bilgisayardan bir şeyler yazarak bunun somut sonuçlarını görmek beni mutlu ediyor.", "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 777, DateTimeKind.Local).AddTicks(4718), true, false, "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 777, DateTimeKind.Local).AddTicks(4724), "InitialCreate" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "CommentCount", "Content", "CreatedByName", "CreatedTime", "Date", "IsActive", "IsDeleted", "ModifiedByName", "ModifiedTime", "Note", "SeoDescription", "SeoTags", "Thumbnail", "Title", "ViewsCount" },
                values: new object[] { 1, 1, 0, "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.", "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 742, DateTimeKind.Local).AddTicks(7927), new DateTime(2020, 12, 20, 20, 33, 42, 742, DateTimeKind.Local).AddTicks(2578), true, false, "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 742, DateTimeKind.Local).AddTicks(7935), "InitialCreate", "C# 9.0 ve .Net 5.0 Yenilikleri", "C#, C#9, .NET5", "", "C# 9.0 ve .Net 5.0 Yenilikleri", 0 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "ArticleId", "CreatedByName", "CreatedTime", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedByName", "ModifiedTime", "Note", "Text" },
                values: new object[] { 1, 1, "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 748, DateTimeKind.Local).AddTicks(5349), "Hasan", true, false, "Erdal", "InitialCreate", new DateTime(2020, 12, 20, 20, 33, 42, 748, DateTimeKind.Local).AddTicks(5355), "C# Blog Gönderisi", "Bu bir deneme yorumudur. Lütfen dikkate almayınız!" });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ArticleId",
                table: "Comments",
                column: "ArticleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutMe");

            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "ContactInfo");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "HomePageSliders");

            migrationBuilder.DropTable(
                name: "Interesteds");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "SiteIdentity");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "SocialMediaAccounts");

            migrationBuilder.DropTable(
                name: "Summary");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
