using Microsoft.EntityFrameworkCore;

namespace CatalogoBolo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Bolo> Bolos { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {

            mb.Entity<Bolo>().HasData(new Bolo
            {
                Id = 1,
                Nome = "Bolo de Banana",
                Descricao = "Bolo1",
                ImagemUrl = "https://img.freepik.com/fotos-premium/bolo-de-milho-delicioso-na-mesa_434193-2483.jpg?w=1060",
                Preco = 10000
            }, new Bolo
            {
                Id = 2,
                Nome = "Bolo brigadeiro",
                Descricao = "Bolo2",
                ImagemUrl = "https://images.pexels.com/photos/960540/pexels-photo-960540.jpeg?auto=compress&cs=tinysrgb&w=600",
                Preco = 100500
            }, new Bolo
            {
                Id = 3,
                Nome = "Bolo de chocolate",
                Descricao = "Bolo3",
                ImagemUrl = "https://img.freepik.com/fotos-gratis/bolo-de-frutas-de-sobremesa_144627-10487.jpg?w=1060&t=st=1721384999~exp=1721385599~hmac=e86fa13fd41adbc30fd24558ac3907eb89198d5d6916d7dbb8833ab52e183fdc",
                Preco = 12750
            }, new Bolo
            {
                Id = 4,
                Nome = "Bolo de laranja",
                Descricao = "Bolo4",
                ImagemUrl = "https://img.freepik.com/fotos-gratis/femea-servindo-um-delicioso-bolo-de-cidra-com-esmalte-em-cima-de-uma-mesa-branca_181624-58169.jpg?w=360&t=st=1721385148~exp=1721385748~hmac=5fd040000ce347c207d1e0b38b908d8ed67f34bd9b732fb83aa88425022a6a53",
                Preco = 9500
            });
        }
    }
}
