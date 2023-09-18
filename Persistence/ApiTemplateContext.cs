using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Persistence;
public class ApiTemplateContext : DbContext //Clase de abstraccion para facilitar interaccion
{
    public ApiTemplateContext(DbContextOptions<ApiTemplateContext> options) : base(options) { }
    public DbSet<Pais> Pais { get; set; }//DbSet uno para cada entidad a implementar
}
//
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);
    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
}
