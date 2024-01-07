using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntregaModulo6.Models
{
    [Table("pacote")]
    public class Pacote
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        [StringLength(80)]
        public string nome { get; set; } = string.Empty;

        [Column("duracao")]
        [Required]
        [StringLength(80)]
        public string duracao { get; set; } = string.Empty;

        [Column("preco")]
        [StringLength(80)]
        public float preco { get; set; } 

    }
}
