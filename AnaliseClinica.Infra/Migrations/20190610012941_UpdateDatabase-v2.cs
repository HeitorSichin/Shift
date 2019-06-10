using Microsoft.EntityFrameworkCore.Migrations;

namespace AnaliseClinica.Infra.Migrations
{
    public partial class UpdateDatabasev2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdemServicoExame_ExamePreco_ExamePrecoId",
                table: "OrdemServicoExame");

            migrationBuilder.DropIndex(
                name: "IX_OrdemServicoExame_ExamePrecoId",
                table: "OrdemServicoExame");

            migrationBuilder.DropColumn(
                name: "ExamePrecoId",
                table: "OrdemServicoExame");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExamePrecoId",
                table: "OrdemServicoExame",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrdemServicoExame_ExamePrecoId",
                table: "OrdemServicoExame",
                column: "ExamePrecoId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdemServicoExame_ExamePreco_ExamePrecoId",
                table: "OrdemServicoExame",
                column: "ExamePrecoId",
                principalTable: "ExamePreco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
