using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AliBabaCodeChallenge.Domain.Migrations
{
    /// <inheritdoc />
    public partial class AddRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactPhoneNumber",
                table: "ContactPhoneNumber");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactAddress",
                table: "ContactAddress");

            migrationBuilder.RenameTable(
                name: "ContactPhoneNumber",
                newName: "contactsPhonenNumber");

            migrationBuilder.RenameTable(
                name: "ContactAddress",
                newName: "contactsAddress");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "contactsPhonenNumber",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "contactsAddress",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AddColumn<int>(
                name: "ContactId1",
                table: "contactsAddress",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_contactsPhonenNumber",
                table: "contactsPhonenNumber",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_contactsAddress",
                table: "contactsAddress",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_contactsAddress_ContactId1",
                table: "contactsAddress",
                column: "ContactId1");

            migrationBuilder.AddForeignKey(
                name: "FK_contactsAddress_Contacts_ContactId1",
                table: "contactsAddress",
                column: "ContactId1",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_contactsAddress_Contacts_ContactId1",
                table: "contactsAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_contactsPhonenNumber",
                table: "contactsPhonenNumber");

            migrationBuilder.DropPrimaryKey(
                name: "PK_contactsAddress",
                table: "contactsAddress");

            migrationBuilder.DropIndex(
                name: "IX_contactsAddress_ContactId1",
                table: "contactsAddress");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "contactsPhonenNumber");

            migrationBuilder.DropColumn(
                name: "ContactId1",
                table: "contactsAddress");

            migrationBuilder.RenameTable(
                name: "contactsPhonenNumber",
                newName: "ContactPhoneNumber");

            migrationBuilder.RenameTable(
                name: "contactsAddress",
                newName: "ContactAddress");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "ContactAddress",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactPhoneNumber",
                table: "ContactPhoneNumber",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactAddress",
                table: "ContactAddress",
                column: "Id");
        }
    }
}
