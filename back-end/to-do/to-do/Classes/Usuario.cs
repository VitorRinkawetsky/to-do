using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace to_do.Classes
{
    [Table("usuario")]
    public class Usuario
    {
        [Key]
        [Column("usuario")]
        public string usuario { get; set; }
        [Column("senha")]
        public string senha { get; set; }

        public Usuario(string usuario, string senha)
        {
            this.usuario = usuario;
            this.senha = senha;
        }
    }
}
