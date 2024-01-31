using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1_Assignment.Migrations
{
    /// <inheritdoc />
    public partial class taskmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "taskLists",
                columns: table => new
                {
                    taskid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    taskname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    taskdescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    taskstatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_taskLists", x => x.taskid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "taskLists");
        }
    }
}
