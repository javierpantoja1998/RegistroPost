using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroYLoginPost.Models
{
    [Table("USUARIO")]
    public class Usuario
    {
        [Key]
        [Column("IDUSUARIO")]
        public int IdUsuario { get; set; }

        [Column("EMAIL")]
        public string Email { get; set; }
        [Column("PASSWORD")]
        public string Password { get; set; }
    }
}
