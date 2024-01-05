using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntregaModulo6.Models
{
    [Table ("cliente")]
    public class Cliente
    {
        [Column ("id")]
        public int Id { get; set; }

        [Column("nome")]
        [StringLength(80)]
        public string nome { get; set; } = string.Empty;

        [Column("cpf")]
        [Required]
        [StringLength(14)]
        public string cpf { get; set; }

        [Column("dataNascimento")]
        [StringLength(32)]
        public string dataNascimento { get; set; } = string.Empty;

        [Column("email")]
        [Required]
        [StringLength(255)]
        public string email { get; set; }

        [Column("senha")]
        [StringLength(255)]
        public string senha { get; set; } = string.Empty;

        [Column("endereco")]
        [StringLength(255)]
        public string endereco { get; set; } = string.Empty;


    }
}
