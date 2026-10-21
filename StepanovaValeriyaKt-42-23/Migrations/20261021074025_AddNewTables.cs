using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace StepanovaValeriyaKt_42_23.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "b_deleted",
                table: "cd_group",
                newName: "IsDeleted");

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "cd_group",
                type: "boolean",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bool",
                oldComment: "Флаг логического удаления");

            migrationBuilder.AddColumn<int>(
                name: "c_group_course",
                table: "cd_group",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                comment: "Курс");

            migrationBuilder.AddColumn<int>(
                name: "f_specialnost_id",
                table: "cd_group",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                comment: "Идентификатор специальности");

            migrationBuilder.CreateTable(
                name: "cd_discipline",
                columns: table => new
                {
                    discipline_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    c_discipline_name = table.Column<string>(type: "text", nullable: false),
                    c_discipline_is_deleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cd_discipline", x => x.discipline_id);
                });

            migrationBuilder.CreateTable(
                name: "cd_specialnost",
                columns: table => new
                {
                    specialnost_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    c_specialnost_title = table.Column<string>(type: "text", nullable: false),
                    c_specialnost_code = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cd_specialnost", x => x.specialnost_id);
                });

            migrationBuilder.CreateTable(
                name: "cd_grade",
                columns: table => new
                {
                    grade_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    c_grade_value = table.Column<int>(type: "integer", nullable: false),
                    f_student_id = table.Column<int>(type: "integer", nullable: false),
                    f_discipline_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cd_grade", x => x.grade_id);
                    table.ForeignKey(
                        name: "FK_cd_grade_cd_discipline_f_discipline_id",
                        column: x => x.f_discipline_id,
                        principalTable: "cd_discipline",
                        principalColumn: "discipline_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cd_grade_cd_student_f_student_id",
                        column: x => x.f_student_id,
                        principalTable: "cd_student",
                        principalColumn: "student_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cd_group_f_specialnost_id",
                table: "cd_group",
                column: "f_specialnost_id");

            migrationBuilder.CreateIndex(
                name: "IX_cd_grade_f_discipline_id",
                table: "cd_grade",
                column: "f_discipline_id");

            migrationBuilder.CreateIndex(
                name: "IX_cd_grade_f_student_id",
                table: "cd_grade",
                column: "f_student_id");

            migrationBuilder.AddForeignKey(
                name: "fk_f_specialnost_id",
                table: "cd_group",
                column: "f_specialnost_id",
                principalTable: "cd_specialnost",
                principalColumn: "specialnost_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_f_specialnost_id",
                table: "cd_group");

            migrationBuilder.DropTable(
                name: "cd_grade");

            migrationBuilder.DropTable(
                name: "cd_specialnost");

            migrationBuilder.DropTable(
                name: "cd_discipline");

            migrationBuilder.DropIndex(
                name: "IX_cd_group_f_specialnost_id",
                table: "cd_group");

            migrationBuilder.DropColumn(
                name: "c_group_course",
                table: "cd_group");

            migrationBuilder.DropColumn(
                name: "f_specialnost_id",
                table: "cd_group");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "cd_group",
                newName: "b_deleted");

            migrationBuilder.AlterColumn<bool>(
                name: "b_deleted",
                table: "cd_group",
                type: "bool",
                nullable: false,
                comment: "Флаг логического удаления",
                oldClrType: typeof(bool),
                oldType: "boolean");
        }
    }
}
