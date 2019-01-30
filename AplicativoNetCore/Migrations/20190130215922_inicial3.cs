using Microsoft.EntityFrameworkCore.Migrations;

namespace AplicativoNetCore.Migrations
{
    public partial class inicial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_Pedido_PedidoId",
                table: "Pessoa");

            migrationBuilder.DropIndex(
                name: "IX_Pessoa_PedidoId",
                table: "Pessoa");

            migrationBuilder.DropColumn(
                name: "PedidoId",
                table: "Pessoa");

            migrationBuilder.AddColumn<int>(
                name: "PessoaId",
                table: "Pedido",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_PessoaId",
                table: "Pedido",
                column: "PessoaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Pessoa_PessoaId",
                table: "Pedido",
                column: "PessoaId",
                principalTable: "Pessoa",
                principalColumn: "PessoaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Pessoa_PessoaId",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_PessoaId",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "PessoaId",
                table: "Pedido");

            migrationBuilder.AddColumn<int>(
                name: "PedidoId",
                table: "Pessoa",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_PedidoId",
                table: "Pessoa",
                column: "PedidoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoa_Pedido_PedidoId",
                table: "Pessoa",
                column: "PedidoId",
                principalTable: "Pedido",
                principalColumn: "PedidoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
