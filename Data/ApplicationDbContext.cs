using CursoCliente3.Models;
using Microsoft.EntityFrameworkCore;

namespace CursoCliente3.Data
{
    public class ApplicationDbContext : DbContext
    {
       public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {

        }
        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Curso> Cursos { get; set; } 
    }
}