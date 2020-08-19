using Microsoft.EntityFrameworkCore.Migrations;

namespace webcorenewproject.Migrations
{
    public partial class newdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Address", "Age", "Name" },
                values: new object[] { 1, "381, Khuda Ali sher Chandigarh", 38, "Amit Chauhan" });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Address", "Age", "Name" },
                values: new object[] { 2, "381, Khauda Ali Sher Chandigarh", 31, "Aarti Chauhan" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
