using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntregaModulo6.Models
{
    [Table("mensagem")]
    public class Mensagem
    {

        [Column("id")]
        public int Id { get; set; }

        [Column("nome")]
        [StringLength(80)]
        public string nome { get; set; } = string.Empty;

        [Column("email")]
        [StringLength(255)]
        public string email { get; set; } = string.Empty;

        [Column("telefone")]
        [StringLength(255)]
        public string telefone { get; set; } = string.Empty;

        [Column("msg")]
        [StringLength(500)]
        public string msg { get; set; } = string.Empty;
    }
}
