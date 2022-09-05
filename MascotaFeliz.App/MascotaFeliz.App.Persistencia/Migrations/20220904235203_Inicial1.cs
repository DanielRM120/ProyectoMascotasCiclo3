using Microsoft.EntityFrameworkCore.Migrations;

namespace MascotaFeliz.App.Persistencia.Migrations
{
    public partial class Inicial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FrequienciaRespiratoria",
                table: "VisitasDomiciliarias",
                newName: "FrecuenciaRespiratoria");

            migrationBuilder.RenameColumn(
                name: "FrequienciaCardiaca",
                table: "VisitasDomiciliarias",
                newName: "FrecuenciaCardiaca");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FrecuenciaRespiratoria",
                table: "VisitasDomiciliarias",
                newName: "FrequienciaRespiratoria");

            migrationBuilder.RenameColumn(
                name: "FrecuenciaCardiaca",
                table: "VisitasDomiciliarias",
                newName: "FrequienciaCardiaca");
        }
    }
}
