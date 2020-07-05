using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LIbraryManagementSytem.Migrations
{
    public partial class BookCopiesID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BOOKCOPIES",
                table: "BOOKCOPIES");

            migrationBuilder.AddColumn<int>(
                name: "BookCopiesID",
                table: "BOOKCOPIES",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BOOKCOPIES",
                table: "BOOKCOPIES",
                column: "BookCopiesID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BOOKCOPIES",
                table: "BOOKCOPIES");

            migrationBuilder.DropColumn(
                name: "BookCopiesID",
                table: "BOOKCOPIES");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BOOKCOPIES",
                table: "BOOKCOPIES",
                column: "BookBarcode");
        }
    }
}
