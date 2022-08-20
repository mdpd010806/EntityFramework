using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    public class TareasContext: DbContext
    {
        DbSet<Tarea> tareas {get; set;}
        DbSet<Categoria> categorias {get; set;}

        public TareasContext(DbContextOptions<TareasContext> options) : base(options) { }
    }
}