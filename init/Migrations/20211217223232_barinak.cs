using Microsoft.EntityFrameworkCore.Migrations;

namespace init.Migrations
{
    public partial class barinak : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aid",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    amount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aid", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "animals",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    katagori = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    yas = table.Column<int>(type: "int", nullable: false),
                    isim = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_animals", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Apikeys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApiKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apikeys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    USERID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USERNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PASSWORD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMAIL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    COUNTRY = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ROLEID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.USERID);
                });

            migrationBuilder.InsertData(
                table: "Aid",
                columns: new[] { "id", "amount" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Apikeys",
                columns: new[] { "Id", "ApiKey" },
                values: new object[] { 1, 5561 });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "USERID", "COUNTRY", "EMAIL", "PASSWORD", "ROLEID", "USERNAME" },
                values: new object[,]
                {
                    { 1, "Turkey", "haci.cingoz@ogr.sakarya.edu.tr", "123", 1, "g181210086@sakarya.edu.tr" },
                    { 2, "Turkey", "mustafa.kurban@ogr.sakarya.edu.tr", "123", 1, "g191210056@sakarya.edu.tr" }
                });

            migrationBuilder.InsertData(
                table: "animals",
                columns: new[] { "id", "isim", "katagori", "yas" },
                values: new object[,]
                {
                    { 1, "Tarçın", "Köpek", 4 },
                    { 2, "Duman", "Kedi", 2 },
                    { 3, "Benekli", "Kaplumbağa", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aid");

            migrationBuilder.DropTable(
                name: "animals");

            migrationBuilder.DropTable(
                name: "Apikeys");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
