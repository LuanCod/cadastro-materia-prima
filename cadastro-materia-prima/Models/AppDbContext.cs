using Microsoft.EntityFrameworkCore;

namespace cadastro_materia_prima.Models
{
    public class AppDbContext : DbContext

    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options) { }

        public DbSet<Materia> Materias { get; set; }




    }
}
