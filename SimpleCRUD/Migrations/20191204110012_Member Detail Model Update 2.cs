using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleCRUD.Migrations
{
    public partial class MemberDetailModelUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MemberDetail_1",
                table: "MemberDetail_1");

            migrationBuilder.RenameTable(
                name: "MemberDetail_1",
                newName: "MemberDetail");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MemberDetail",
                table: "MemberDetail",
                column: "MyProperty");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MemberDetail",
                table: "MemberDetail");

            migrationBuilder.RenameTable(
                name: "MemberDetail",
                newName: "MemberDetail_1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MemberDetail_1",
                table: "MemberDetail_1",
                column: "MyProperty");
        }
    }
}
