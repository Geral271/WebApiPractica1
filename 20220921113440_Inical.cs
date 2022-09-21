using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiPractica1.Migrations
{
    public partial class Inical : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vuelo",
                columns: table => new
                {
                    IdVuelo = table.Column<int>(type: "int", nullable: false),
                    numeroVuelo =table.Column<int>(type "int", nullable:false).Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<string>(type: "Datatime", nullable: false),
                    Hora = table.Column<string>(type: "time", nullable: false),
                    Origen = table.Column<string>(type: "nvarchar(40)", nullable: false),
                    Destino = table.Column<string>(type: "nvarchar(40)", nullable: false),
                    PlazaTotal = table.Column<int>(type: "int", nullable: false),
                    PlazaTurista = table.Column<int>(type: "int", nullable: false)

                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vuelo", x => x.numeroVuelo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vuelo");
        }
    }
}
