using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class PopularLanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "INSERT INTO Lanches(CategoriaId, Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque) " +
                    "VALUES (1, 'Cheese Salada', 'Pão, hambúrguer, ovo, presunto, queijo, alface e tomate', 'Delicioso pão de hambúrguer com ovo frito; presunto e queijo de primeira qualidade acompanhado de alface e tomate', 12.50, 'https://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg', 'https://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg', 0, 1)");

            migrationBuilder.Sql(
                "INSERT INTO Lanches(CategoriaId, Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque) " +
                    "VALUES (1, 'Misto Quente', 'Pão, presunto, mussarela e tomate', 'Delicioso pão francês quentinho na chapa com presunto e mussarela bem servidos com tomate preparado com carinho', 8.00, 'https://www.macoratti.net/Imagens/lanches/mistoquente4.jpg', 'https://www.macoratti.net/Imagens/lanches/mistoquente4.jpg', 0, 1)");

            migrationBuilder.Sql(
                "INSERT INTO Lanches(CategoriaId, Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque) " +
                    "VALUES (1, 'Cheese Burger', 'Pão, hambúrguer, presunto, mussarela e batata palha', 'Pão de hambúrguer especial com hambúrguer de nossa preparação e presunto e mussarela; acompanha batata palha', 11.00, 'https://www.macoratti.net/Imagens/lanches/cheeseburger1.jpg', 'https://www.macoratti.net/Imagens/lanches/cheeseburger1.jpg', 0, 1)");

            migrationBuilder.Sql(
                "INSERT INTO Lanches(CategoriaId, Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImagemUrl, ImagemThumbnailUrl, IsLanchePreferido, EmEstoque) " +
                    "VALUES (2, 'Lanche Natural Peito Peru', 'Pão Integral, queijo branco, peito de peru, cenoura, alface e iogurte', 'Pão integral natural com queijo branco, peito de peru e cenoura ralada com alface picado e iogurte natural', 15.00, 'https://www.macoratti.net/Imagens/lanches/lanchenatural.jpg', 'https://www.macoratti.net/Imagens/lanches/lanchenatural.jpg', 1, 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}