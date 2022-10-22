namespace WebApiDaTerra.data;
using Microsoft.EntityFrameworkCore;
using WebApiDaTerra.models;


public class DaTerraDbContext:DbContext
{
    public DbSet<Produto> Produtos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("DataSource=app.db;Cache=Shared");
}