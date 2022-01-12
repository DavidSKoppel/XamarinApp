using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoListClassLibrary.Migrations
{
    public partial class changes03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "checked",
                table: "ShoppingListItems",
                type: "bit",
                fixedLength: true,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nchar(10)",
                oldFixedLength: true,
                oldMaxLength: 10);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "checked",
                table: "ShoppingListItems",
                type: "nchar(10)",
                fixedLength: true,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldFixedLength: true);
        }
    }
}
