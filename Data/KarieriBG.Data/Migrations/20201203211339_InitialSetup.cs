using Microsoft.EntityFrameworkCore.Migrations;

namespace KarieriBG.Data.Migrations
{
    public partial class InitialSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PositionCities_Positions_PositionId1",
                table: "PositionCities");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Departments_DepartmentId1",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_PositionTypes_Positions_PositionId1",
                table: "PositionTypes");

            migrationBuilder.DropIndex(
                name: "IX_PositionTypes_PositionId1",
                table: "PositionTypes");

            migrationBuilder.DropIndex(
                name: "IX_Positions_DepartmentId1",
                table: "Positions");

            migrationBuilder.DropIndex(
                name: "IX_PositionCities_PositionId1",
                table: "PositionCities");

            migrationBuilder.DropColumn(
                name: "PositionId1",
                table: "PositionTypes");

            migrationBuilder.DropColumn(
                name: "DepartmentId1",
                table: "Positions");

            migrationBuilder.DropColumn(
                name: "PositionId1",
                table: "PositionCities");

            migrationBuilder.AlterColumn<string>(
                name: "PositionId",
                table: "PositionTypes",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "PositionId",
                table: "PositionCities",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Departments",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_PositionTypes_PositionId",
                table: "PositionTypes",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_DepartmentId",
                table: "Positions",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_PositionCities_PositionId",
                table: "PositionCities",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_PositionCities_Positions_PositionId",
                table: "PositionCities",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Departments_DepartmentId",
                table: "Positions",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PositionTypes_Positions_PositionId",
                table: "PositionTypes",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PositionCities_Positions_PositionId",
                table: "PositionCities");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Departments_DepartmentId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_PositionTypes_Positions_PositionId",
                table: "PositionTypes");

            migrationBuilder.DropIndex(
                name: "IX_PositionTypes_PositionId",
                table: "PositionTypes");

            migrationBuilder.DropIndex(
                name: "IX_Positions_DepartmentId",
                table: "Positions");

            migrationBuilder.DropIndex(
                name: "IX_PositionCities_PositionId",
                table: "PositionCities");

            migrationBuilder.AlterColumn<int>(
                name: "PositionId",
                table: "PositionTypes",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PositionId1",
                table: "PositionTypes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DepartmentId1",
                table: "Positions",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PositionId",
                table: "PositionCities",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PositionId1",
                table: "PositionCities",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Departments",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_PositionTypes_PositionId1",
                table: "PositionTypes",
                column: "PositionId1");

            migrationBuilder.CreateIndex(
                name: "IX_Positions_DepartmentId1",
                table: "Positions",
                column: "DepartmentId1");

            migrationBuilder.CreateIndex(
                name: "IX_PositionCities_PositionId1",
                table: "PositionCities",
                column: "PositionId1");

            migrationBuilder.AddForeignKey(
                name: "FK_PositionCities_Positions_PositionId1",
                table: "PositionCities",
                column: "PositionId1",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Departments_DepartmentId1",
                table: "Positions",
                column: "DepartmentId1",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PositionTypes_Positions_PositionId1",
                table: "PositionTypes",
                column: "PositionId1",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
