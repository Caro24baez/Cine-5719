using System;
using System.Collections.Generic;
using System.Text;
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


    }
}
