using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SistemaWebMisRecetas.Validators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaWebMisRecetas.Models
{
    public class Receta
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [CategoriaOkAtributte]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [Column(TypeName = "varchar(250)")]
        [StringLength(250)]
        [DataType(DataType.MultilineText)]
        public string Ingredientes { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [Column(TypeName = "varchar(250)")]
        [StringLength(250)]
        [DataType(DataType.MultilineText)]
        public string Instrucciones { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string NombreAutor { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string ApellidoAutor { get; set; }


        
        [Required(ErrorMessage ="Campo Obligatorio")]
        [IsEdadOkAtributte]
        public int EdadAutor { get; set; }


        [Required (ErrorMessage = "Campo Obligatorio")]
        [IsEmailAtributte]
        public string CorreoAutor { get; set; }

    }
}
