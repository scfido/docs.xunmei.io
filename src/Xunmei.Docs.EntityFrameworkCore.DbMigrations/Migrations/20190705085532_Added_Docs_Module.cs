using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Xunmei.Docs.Migrations
{
    public partial class Added_Docs_Module : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DocsProjects",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ExtraProperties = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    ShortName = table.Column<string>(maxLength: 32, nullable: false),
                    Format = table.Column<string>(nullable: true),
                    DefaultDocumentName = table.Column<string>(maxLength: 128, nullable: false),
                    NavigationDocumentName = table.Column<string>(maxLength: 128, nullable: false),
                    MinimumVersion = table.Column<string>(nullable: true),
                    DocumentStoreType = table.Column<string>(nullable: true),
                    MainWebsiteUrl = table.Column<string>(nullable: true),
                    LatestVersionBranchName = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocsProjects", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DocsProjects");
        }
    }
}
