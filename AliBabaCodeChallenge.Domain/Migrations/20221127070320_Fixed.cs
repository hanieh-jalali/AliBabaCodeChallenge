using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AliBabaCodeChallenge.Domain.Migrations
{
    /// <inheritdoc />
    public partial class Fixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_contactsAddress_Contacts_ContactId1",
                table: "contactsAddress");

            migrationBuilder.DropIndex(
                name: "IX_contactsAddress_ContactId1",
                table: "contactsAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactPhoneNumberType",
                table: "ContactPhoneNumberType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactAddressType",
                table: "ContactAddressType");

            migrationBuilder.DropColumn(
                name: "PhonrTypeId",
                table: "contactsPhonenNumber");

            migrationBuilder.DropColumn(
                name: "AddressTypeId",
                table: "contactsAddress");

            migrationBuilder.DropColumn(
                name: "ContactId1",
                table: "contactsAddress");

            migrationBuilder.RenameTable(
                name: "ContactPhoneNumberType",
                newName: "contactsPhoneNumberType");

            migrationBuilder.RenameTable(
                name: "ContactAddressType",
                newName: "contactsAddressType");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Contacts",
                newName: "Name");

            migrationBuilder.AlterColumn<int>(
                name: "ContactId",
                table: "contactsPhonenNumber",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "ContactPhoneNumberTypeId",
                table: "contactsPhonenNumber",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<int>(
                name: "ContactId",
                table: "contactsAddress",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "ContactAddressTypeId",
                table: "contactsAddress",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Contacts",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "contactsPhoneNumberType",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "contactsAddressType",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AddPrimaryKey(
                name: "PK_contactsPhoneNumberType",
                table: "contactsPhoneNumberType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_contactsAddressType",
                table: "contactsAddressType",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_contactsPhonenNumber_ContactId",
                table: "contactsPhonenNumber",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_contactsPhonenNumber_ContactPhoneNumberTypeId",
                table: "contactsPhonenNumber",
                column: "ContactPhoneNumberTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_contactsAddress_ContactAddressTypeId",
                table: "contactsAddress",
                column: "ContactAddressTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_contactsAddress_ContactId",
                table: "contactsAddress",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_contactsAddress_Contacts_ContactId",
                table: "contactsAddress",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_contactsAddress_contactsAddressType_ContactAddressTypeId",
                table: "contactsAddress",
                column: "ContactAddressTypeId",
                principalTable: "contactsAddressType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_contactsPhonenNumber_Contacts_ContactId",
                table: "contactsPhonenNumber",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_contactsPhonenNumber_contactsPhoneNumberType_ContactPhoneNumberTypeId",
                table: "contactsPhonenNumber",
                column: "ContactPhoneNumberTypeId",
                principalTable: "contactsPhoneNumberType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_contactsAddress_Contacts_ContactId",
                table: "contactsAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_contactsAddress_contactsAddressType_ContactAddressTypeId",
                table: "contactsAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_contactsPhonenNumber_Contacts_ContactId",
                table: "contactsPhonenNumber");

            migrationBuilder.DropForeignKey(
                name: "FK_contactsPhonenNumber_contactsPhoneNumberType_ContactPhoneNumberTypeId",
                table: "contactsPhonenNumber");

            migrationBuilder.DropIndex(
                name: "IX_contactsPhonenNumber_ContactId",
                table: "contactsPhonenNumber");

            migrationBuilder.DropIndex(
                name: "IX_contactsPhonenNumber_ContactPhoneNumberTypeId",
                table: "contactsPhonenNumber");

            migrationBuilder.DropIndex(
                name: "IX_contactsAddress_ContactAddressTypeId",
                table: "contactsAddress");

            migrationBuilder.DropIndex(
                name: "IX_contactsAddress_ContactId",
                table: "contactsAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_contactsPhoneNumberType",
                table: "contactsPhoneNumberType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_contactsAddressType",
                table: "contactsAddressType");

            migrationBuilder.DropColumn(
                name: "ContactPhoneNumberTypeId",
                table: "contactsPhonenNumber");

            migrationBuilder.DropColumn(
                name: "ContactAddressTypeId",
                table: "contactsAddress");

            migrationBuilder.RenameTable(
                name: "contactsPhoneNumberType",
                newName: "ContactPhoneNumberType");

            migrationBuilder.RenameTable(
                name: "contactsAddressType",
                newName: "ContactAddressType");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Contacts",
                newName: "Title");

            migrationBuilder.AlterColumn<long>(
                name: "ContactId",
                table: "contactsPhonenNumber",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "PhonrTypeId",
                table: "contactsPhonenNumber",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<long>(
                name: "ContactId",
                table: "contactsAddress",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AddressTypeId",
                table: "contactsAddress",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ContactId1",
                table: "contactsAddress",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256)
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ContactPhoneNumberType",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ContactAddressType",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactPhoneNumberType",
                table: "ContactPhoneNumberType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactAddressType",
                table: "ContactAddressType",
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
    }
}
