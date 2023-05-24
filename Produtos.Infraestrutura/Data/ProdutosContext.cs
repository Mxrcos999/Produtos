using Microsoft.EntityFrameworkCore;

namespace Produtos.Infraestrutura.Data;

public class ProdutosContext : DbContext
{
    public ProdutosContext(DbContextOptions options) : base(options) {}
}
