using Microsoft.EntityFrameworkCore.Migrations;

namespace PracHome.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentStandardRelations",
                columns: table => new
                {
                    StudentStandardRelationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StandardId = table.Column<int>(type: "int", nullable: false),
                    StudentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentStandardRelations", x => x.StudentStandardRelationId);
                });

            migrationBuilder.CreateTable(
                name: "TblStandards",
                columns: table => new
                {
                    StandardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StandardName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentStandardRelationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblStandards", x => x.StandardId);
                    table.ForeignKey(
                        name: "FK_TblStandards_StudentStandardRelations_StudentStandardRelationId",
                        column: x => x.StudentStandardRelationId,
                        principalTable: "StudentStandardRelations",
                        principalColumn: "StudentStandardRelationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblStudents",
                columns: table => new
                {
                    StudentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StandardId = table.Column<int>(type: "int", nullable: false),
                    StudentStandardRelationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblStudents", x => x.StudentID);
                    table.ForeignKey(
                        name: "FK_TblStudents_StudentStandardRelations_StudentStandardRelationId",
                        column: x => x.StudentStandardRelationId,
                        principalTable: "StudentStandardRelations",
                        principalColumn: "StudentStandardRelationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblStudents_TblStandards_StandardId",
                        column: x => x.StandardId,
                        principalTable: "TblStandards",
                        principalColumn: "StandardId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblStandards_StudentStandardRelationId",
                table: "TblStandards",
                column: "StudentStandardRelationId");

            migrationBuilder.CreateIndex(
                name: "IX_TblStudents_StandardId",
                table: "TblStudents",
                column: "StandardId");

            migrationBuilder.CreateIndex(
                name: "IX_TblStudents_StudentStandardRelationId",
                table: "TblStudents",
                column: "StudentStandardRelationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblStudents");

            migrationBuilder.DropTable(
                name: "TblStandards");

            migrationBuilder.DropTable(
                name: "StudentStandardRelations");
        }
    }
}
