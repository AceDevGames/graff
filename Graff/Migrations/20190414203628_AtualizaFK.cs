using Microsoft.EntityFrameworkCore.Migrations;

namespace Graff.Migrations
{
    public partial class AtualizaFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LancesLeilao_Pessoa_Pessoaid",
                table: "LancesLeilao");

            migrationBuilder.DropForeignKey(
                name: "FK_Leilao_Produto_Produtoid",
                table: "Leilao");

            migrationBuilder.RenameColumn(
                name: "Produtoid",
                table: "Leilao",
                newName: "ProdutoId");

            migrationBuilder.RenameIndex(
                name: "IX_Leilao_Produtoid",
                table: "Leilao",
                newName: "IX_Leilao_ProdutoId");

            migrationBuilder.RenameColumn(
                name: "Pessoaid",
                table: "LancesLeilao",
                newName: "PessoaId");

            migrationBuilder.RenameIndex(
                name: "IX_LancesLeilao_Pessoaid",
                table: "LancesLeilao",
                newName: "IX_LancesLeilao_PessoaId");

            migrationBuilder.AlterColumn<int>(
                name: "ProdutoId",
                table: "Leilao",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PessoaId",
                table: "LancesLeilao",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_LancesLeilao_Pessoa_PessoaId",
                table: "LancesLeilao",
                column: "PessoaId",
                principalTable: "Pessoa",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Leilao_Produto_ProdutoId",
                table: "Leilao",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LancesLeilao_Pessoa_PessoaId",
                table: "LancesLeilao");

            migrationBuilder.DropForeignKey(
                name: "FK_Leilao_Produto_ProdutoId",
                table: "Leilao");

            migrationBuilder.RenameColumn(
                name: "ProdutoId",
                table: "Leilao",
                newName: "Produtoid");

            migrationBuilder.RenameIndex(
                name: "IX_Leilao_ProdutoId",
                table: "Leilao",
                newName: "IX_Leilao_Produtoid");

            migrationBuilder.RenameColumn(
                name: "PessoaId",
                table: "LancesLeilao",
                newName: "Pessoaid");

            migrationBuilder.RenameIndex(
                name: "IX_LancesLeilao_PessoaId",
                table: "LancesLeilao",
                newName: "IX_LancesLeilao_Pessoaid");

            migrationBuilder.AlterColumn<int>(
                name: "Produtoid",
                table: "Leilao",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Pessoaid",
                table: "LancesLeilao",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_LancesLeilao_Pessoa_Pessoaid",
                table: "LancesLeilao",
                column: "Pessoaid",
                principalTable: "Pessoa",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Leilao_Produto_Produtoid",
                table: "Leilao",
                column: "Produtoid",
                principalTable: "Produto",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
