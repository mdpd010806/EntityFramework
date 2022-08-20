using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework.Models
{
    class Tarea
    {
        [Key]
        public Guid tareaId { get; set; }
        [ForeignKey("categoriaId")]
        public Guid categoriaId {get; set;}
        [Required]
        [MaxLength(150)]
        public string titulo { get; set; }
        [Required]
        [MaxLength(200)]
        public string descripcion { get; set; }   
        public Prioridad prioridadTarea {get; set;}
        public DateTime fechaCreacion {get; set;}
        public virtual Categoria categoria {get; set;}
        [NotMapped]
        public string resumen {get; set;}
    }

    public enum Prioridad{
        Baja, Media, Alta
    }
}