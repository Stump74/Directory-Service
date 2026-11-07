using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DirectoryService.Infrastructure.Postgres.Migrations
{
    /// <inheritdoc />
    public partial class Reviewfixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_departments_departments_ParentId",
                table: "departments");

            migrationBuilder.DropColumn(
                name: "IsPrimary",
                table: "department_locations");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "positions",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "positions",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "locations",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "locations",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Slug",
                table: "departments",
                newName: "slug");

            migrationBuilder.RenameColumn(
                name: "Path",
                table: "departments",
                newName: "path");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "departments",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "departments",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "departments",
                newName: "parent_id");

            migrationBuilder.RenameIndex(
                name: "IX_departments_ParentId",
                table: "departments",
                newName: "IX_departments_parent_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "department_positions",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "PositionId",
                table: "department_positions",
                newName: "position_id");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "department_positions",
                newName: "department_id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "department_locations",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "department_locations",
                newName: "location_id");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "department_locations",
                newName: "department_id");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "positions",
                type: "character varying(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "street",
                table: "locations",
                type: "character varying(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "house",
                table: "locations",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "country",
                table: "locations",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "city",
                table: "locations",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "locations",
                type: "character varying(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "slug",
                table: "departments",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "path",
                table: "departments",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "departments",
                type: "character varying(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            var dpColumns = new[] { "department_id", "position_id" };

            migrationBuilder.CreateIndex(
                name: "IX_department_positions_department_id_position_id",
                table: "department_positions",
                columns: dpColumns,
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_department_positions_position_id",
                table: "department_positions",
                column: "position_id");

            var columns = new[] { "department_id", "location_id" };

            migrationBuilder.CreateIndex(
                name: "IX_department_locations_department_id_location_id",
                table: "department_locations",
                columns: columns,
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_department_locations_location_id",
                table: "department_locations",
                column: "location_id");

            migrationBuilder.AddForeignKey(
                name: "FK_department_locations_departments_department_id",
                table: "department_locations",
                column: "department_id",
                principalTable: "departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_department_locations_locations_location_id",
                table: "department_locations",
                column: "location_id",
                principalTable: "locations",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_department_positions_departments_department_id",
                table: "department_positions",
                column: "department_id",
                principalTable: "departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_department_positions_positions_position_id",
                table: "department_positions",
                column: "position_id",
                principalTable: "positions",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_departments_departments_parent_id",
                table: "departments",
                column: "parent_id",
                principalTable: "departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_department_locations_departments_department_id",
                table: "department_locations");

            migrationBuilder.DropForeignKey(
                name: "FK_department_locations_locations_location_id",
                table: "department_locations");

            migrationBuilder.DropForeignKey(
                name: "FK_department_positions_departments_department_id",
                table: "department_positions");

            migrationBuilder.DropForeignKey(
                name: "FK_department_positions_positions_position_id",
                table: "department_positions");

            migrationBuilder.DropForeignKey(
                name: "FK_departments_departments_parent_id",
                table: "departments");

            migrationBuilder.DropIndex(
                name: "IX_department_positions_department_id_position_id",
                table: "department_positions");

            migrationBuilder.DropIndex(
                name: "IX_department_positions_position_id",
                table: "department_positions");

            migrationBuilder.DropIndex(
                name: "IX_department_locations_department_id_location_id",
                table: "department_locations");

            migrationBuilder.DropIndex(
                name: "IX_department_locations_location_id",
                table: "department_locations");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "positions",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "positions",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "locations",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "locations",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "slug",
                table: "departments",
                newName: "Slug");

            migrationBuilder.RenameColumn(
                name: "path",
                table: "departments",
                newName: "Path");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "departments",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "departments",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "parent_id",
                table: "departments",
                newName: "ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_departments_parent_id",
                table: "departments",
                newName: "IX_departments_ParentId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "department_positions",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "position_id",
                table: "department_positions",
                newName: "PositionId");

            migrationBuilder.RenameColumn(
                name: "department_id",
                table: "department_positions",
                newName: "DepartmentId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "department_locations",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "location_id",
                table: "department_locations",
                newName: "LocationId");

            migrationBuilder.RenameColumn(
                name: "department_id",
                table: "department_locations",
                newName: "DepartmentId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "positions",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "street",
                table: "locations",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "locations",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "house",
                table: "locations",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "country",
                table: "locations",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "city",
                table: "locations",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "departments",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Path",
                table: "departments",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "departments",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(500)",
                oldMaxLength: 500);

            migrationBuilder.AddColumn<bool>(
                name: "IsPrimary",
                table: "department_locations",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_departments_departments_ParentId",
                table: "departments",
                column: "ParentId",
                principalTable: "departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
