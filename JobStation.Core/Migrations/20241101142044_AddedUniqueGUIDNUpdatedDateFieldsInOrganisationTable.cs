using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JobStation.Core.Migrations
{
    public partial class AddedUniqueGUIDNUpdatedDateFieldsInOrganisationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UniqueGuid",
                table: "OrganisationDetails",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "UpdatedOn",
                table: "OrganisationDetails",
                type: "datetimeoffset(7)",
                nullable: false,
                defaultValueSql: "getdate()");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UniqueGuid",
                table: "OrganisationDetails");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "OrganisationDetails");
        }
    }
}
