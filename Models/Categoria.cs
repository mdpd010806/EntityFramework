using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Models
{
    class Categoria
    {
        [Key]
        public Guid categoriaId {get; set;}
        [Required]
        [MaxLength(100)]
        public string nombre { get; set; }
        [Required]
        [MaxLength(200)]
        public string descripcion { get; set; }
        public virtual ICollection<Tarea> tareas {get; set;}
    }
}