using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CatalogoBolo.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bolos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    ImagemUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 200, nullable: true),
                    Preco = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Bolos",
                columns: new[] { "Id", "Descricao", "ImagemUrl", "Nome", "Preco" },
                values: new object[,]
                {
                    { 1, "Bolo1", "https://img.freepik.com/fotos-premium/bolo-de-milho-delicioso-na-mesa_434193-2483.jpg?w=1060", "Bolo de Banana", 10000m },
                    { 2, "Bolo2", "https://images.pexels.com/photos/960540/pexels-photo-960540.jpeg?auto=compress&cs=tinysrgb&w=600", "Bolo brigadeiro", 100500m },
                    { 3, "Bolo3", "https://img.freepik.com/fotos-gratis/bolo-de-frutas-de-sobremesa_144627-10487.jpg?w=1060&t=st=1721384999~exp=1721385599~hmac=e86fa13fd41adbc30fd24558ac3907eb89198d5d6916d7dbb8833ab52e183fdc", "Bolo de chocolate", 12750m },
                    { 4, "Bolo4", "https://img.freepik.com/fotos-gratis/femea-servindo-um-delicioso-bolo-de-cidra-com-esmalte-em-cima-de-uma-mesa-branca_181624-58169.jpg?w=360&t=st=1721385148~exp=1721385748~hmac=5fd040000ce347c207d1e0b38b908d8ed67f34bd9b732fb83aa88425022a6a53", "Bolo de laranja", 9500m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bolos");
        }
    }
}
