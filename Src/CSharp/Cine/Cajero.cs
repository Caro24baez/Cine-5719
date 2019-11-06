using System;
using System.Collections.Generic;
using System.Text;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cine
{
    [Table ("Cajero")]
    class Cajero
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column("idCajero")]
        public int Id { get; set; }
        [ForeignKey("idEntrada"), Required]
        public Entrada Entrada { get; set; }
        [Column("nombre"), StringLength(45), Required]
        public string Nombre { get; set; }
        [Column("apellido"), StringLength(45), Required]
        public string Apellido { get; set; }
        [Column("email"), StringLength(45), Required]
        public string Email { get; set; }
        [Column("contraseña"), StringLength(45), Required]
        public string Contraseña { get; set; }
=======
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Cine
{

    [Table("Cajero")]
    public class Cajero
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column("idCajero")]
        public short IdCajero { get; set; }

        [ForeignKey("idEntrada"), Required]
        public Entrada entrada { get; set; }

        [Column("nombre"), StringLength(45), Required]
        public string nombre { get; set; }

        [Column("apellido"), StringLength(45), Required]
        public string apellido { get; set; }

        [Column("contraseña"), StringLength(45), Required]
        public string contrasenia { get; set; }

        [Column("email"), StringLength(45), Required]
        public string email { get; set; }

>>>>>>> 1444c6b51d182105f40d4ba5baa84e68d5440b8c

    }
}
