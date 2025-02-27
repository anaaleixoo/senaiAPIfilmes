using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_filmes_senai1.Domains
{

    [Table("Filme")]
    public class Filme
    {
        [Key]

        public Guid IdFilme { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O titulo do filme e obrigatorio!")]

        public string? Titulo { get; set; }

        public Guid IdGenero { get; set; }

        [ForeignKey("IdGenero")]

        public Genero? genero { get; set; }
        public object Título { get; internal set; }
    }
}
