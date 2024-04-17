using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class addRoomType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RoomType",
                columns: table => new
                {
                    RoomTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Area = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Bed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    linkimg1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    linkimg2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    linkimg3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    linkimg4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    linkimg5 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomType", x => x.RoomTypeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoomType");
        }
    }
}
